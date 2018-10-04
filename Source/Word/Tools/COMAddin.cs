﻿using System;
using NetRuntimeSystem = System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Attributes;
using NetOffice.Tools;
using NetOffice.OfficeApi.Tools;
using Office = NetOffice.OfficeApi;
using Word = NetOffice.WordApi;
using NetOffice.OfficeApi.Enums;
using NetOffice.OfficeApi.Native;
using stdole;

namespace NetOffice.WordApi.Tools
{
    /// <summary>
    /// NetOffice MS-Word COM Addin
    /// </summary>
    public abstract class COMAddin : OfficeCOMAddin, IOfficeCOMAddin, Office.Native.IDocumentInspector
    {
        #region Fields

        /// <summary>
        /// MS-Word Registry Path
        /// </summary>
        private static readonly string _addinOfficeRegistryKey  = "Software\\Microsoft\\Office\\Word\\Addins\\";

        /// <summary>
        /// Instance factory to avoid trouble with addins in same appdomain
        /// </summary>
        private Core _factory;

        #endregion

        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public COMAddin()
        {
            _factory = RaiseCreateFactory();
            if (null == _factory)
                _factory = Core.Default;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Common Tasks Helper. The property is available after the host application has called OnConnection for the instance
        /// </summary>
        public Contribution.CommonUtils Utils { get; private set; }

        /// <summary>
        /// Host Application Instance
        /// </summary>
        public new Word.Application Application
        {
            get
            {
                return base.Application as Word.Application;
            }
        }

        /// <summary>
        /// Cached Register Error Method Delegate
        /// </summary>
        private static MethodInfo RegisterErrorMethod { get; set; }

        #endregion

        #region COMAddinBase

        /// <summary>
        /// Generic Host Application Instance
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override ICOMObject AppInstance
        {
            get { return Application; }
        }

        /// <summary>
        /// The used factory core
        /// </summary>
        public override Core Factory
        {
            get
            {
                return _factory;
            }
        }

        #endregion

        #region IDTExtensibility2 Overrides

        /// <summary>
        /// Occurs whenever an add-in is loaded into MS-Office
        /// </summary>
        /// <param name="application">A reference to an instance of the office application</param>
        /// <param name="connectMode">An ext_ConnectMode enumeration value that indicates the way the add-in was loaded into MS-Office</param>
        /// <param name="addInInst">An AddIn reference to the add-in's own instance. This is stored for later use, such as determining the parent collection for the add-in</param>
        /// <param name="custom">An empty array that you can use to pass host-specific data for use in the add-in</param>
        protected override void HandleOnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
        {
            if (null != custom && custom.Length > 0)
            {
                object firstCustomItem = custom.GetValue(1);
                string tryString = null != firstCustomItem ? firstCustomItem.ToString() : String.Empty;
                NetRuntimeSystem.Int32.TryParse(tryString, out _automationCode);
            }

            base.Application = Factory.CreateKnownObjectFromComProxy<Word.Application>(null, application, typeof(Word.Application));
            Utils = OnCreateUtils();
            TryCreateCustomObject(addInInst);
            RaiseOnConnection(this.Application, connectMode, addInInst, ref custom);
        }

        /// <summary>
        /// Occurs whenever an add-in is unloaded from MS Office
        /// </summary>
        /// <param name="removeMode">An ext_DisconnectMode enumeration value that informs an add-in why it was unloaded.</param>
        /// <param name="custom">An empty array that you can use to pass host-specific data for use after the add-in unloads</param>
        protected override void HandleOnDisconnection(ext_DisconnectMode removeMode, ref Array custom)
        {
            try
            {
                RaiseOnDisconnection(removeMode, ref custom);
                Utils.Dispose();
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                Factory.Console.WriteException(exception);
            }

            foreach (ITaskPane item in TaskPaneInstances)
            {
                try
                {
                    item.OnDisconnection();
                }
                catch (NetRuntimeSystem.Exception exception)
                {
                    Factory.Console.WriteException(exception);
                }
            }

            foreach (var item in TaskPanes)
            {
                try
                {
                    if (null != item.Pane && !item.Pane.IsDisposed)
                        item.Pane.Dispose();
                }
                catch (NetRuntimeSystem.Exception exception)
                {
                    Factory.Console.WriteException(exception);
                }
            }

            try
            {
                if (null != TaskPaneFactory && false == TaskPaneFactory.IsDisposed)
                    TaskPaneFactory.Dispose();
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                Factory.Console.WriteException(exception);
            }

            try
            {
                if (null != RibbonUI)
                {
                    RibbonUI.Dispose();
                    RibbonUI = null;
                }
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                Factory.Console.WriteException(exception);
            }

            try
            {
                if (!Application.IsDisposed)
                    Application.Dispose();
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                Factory.Console.WriteException(exception);
            }
        }

        /// <summary>
        ///  Occurs whenever an add-in, which is set to load when MS Office starts, loads.
        /// </summary>
        /// <param name="custom">An empty array that you can use to pass host-specific data for use when the add-in loads</param>
        protected override void HandleOnStartupComplete(ref Array custom)
        {
            LoadingTimeElapsed = (DateTime.Now - _creationTime);
            Roots = OnCreateRoots();
            RaiseOnStartupComplete(ref custom);
        }

        /// <summary>
        /// Occurs whenever an add-in is loaded or unloaded from MS Office
        /// </summary>
        /// <param name="custom">An empty array that you can use to pass host-specific data for use in the add-in</param>
        protected override void HandleOnAddInsUpdate(ref Array custom)
        {
            RaiseOnAddInsUpdate(ref custom);
        }

        /// <summary>
        /// Occurs whenever MS Office shuts down while an add-in is running
        /// </summary>
        /// <param name="custom">An empty array that you can use to pass host-specific data for use in the add-in</param>
        protected override void HandleOnBeginShutdown(ref Array custom)
        {
            RaiseOnBeginShutdown(ref custom);

        }

        #endregion

        #region IDocumentInspector

        private ToolsDocumentInspector CurrentInspector { get; set; }

        void IDocumentInspector.GetInfo(out string Name, out string Desc)
        {
            CurrentInspector = TryCreateDocumentInspector(out Name, out Desc);
        }

        void IDocumentInspector.Inspect(object Doc, out MsoDocInspectorStatus Status, out string Result, out string Action)
        {
            Word.Document document = null;
            try
            {
                if (null != CurrentInspector)
                {
                    document = COMObject.Create<Word.Document>(Factory, Doc);
                    CurrentInspector.Inspect(document, out Status, out Result, out Action);
                    return;
                }
                else
                {
                    Status = MsoDocInspectorStatus.msoDocInspectorStatusError;
                    Result = null;
                    Action = null;
                }
            }
            catch
            {
                Status = MsoDocInspectorStatus.msoDocInspectorStatusError;
                Result = null;
                Action = null;
                throw;
            }
            finally
            {
                TryDisposeDocumentInspectorDocument(document, Doc);
            }
        }

        void IDocumentInspector.Fix(object Doc, Int32 Hwnd, out MsoDocInspectorStatus Status, out string Result)
        {
            Word.Document document = null;
            try
            {
                if (null != CurrentInspector)
                {
                    document = COMObject.Create<Word.Document>(Factory, Doc);
                    CurrentInspector.Fix(document, Hwnd, out Status, out Result);
                    return;
                }
                else
                {
                    Status = MsoDocInspectorStatus.msoDocInspectorStatusError;
                    Result = null;
                }
            }
            catch
            {
                Status = MsoDocInspectorStatus.msoDocInspectorStatusError;
                Result = null;
                throw;
            }
            finally
            {
                TryDisposeDocumentInspectorDocument(document, Doc);
            }
        }

        /// <summary>
        /// Creates a new instance of a Documument Inspector service
        /// </summary>
        /// <returns>instance of ToolsDocumentInspector</returns>
        protected virtual ToolsDocumentInspector OnCreateDocumentInspector()
        {
            return null;
        }

        private ToolsDocumentInspector TryCreateDocumentInspector(out string name, out string description)
        {
            try
            {
                ToolsDocumentInspector inspector = OnCreateDocumentInspector();
                if (null != inspector)
                {
                    inspector.InitializeInspector(this);
                    if (null != inspector)
                    {
                        CurrentInspector = inspector;
                        name = inspector.Name;
                        description = inspector.Description;
                    }
                    else
                    {
                        CurrentInspector = null;
                        name = "<#Error>";
                        description = String.Empty;
                    }
                    return inspector;
                }
                else
                {
                    name = "<#Error>";
                    description = String.Empty;
                    return null;
                }

            }
            catch
            {
                name = "<#Error>";
                description = String.Empty;
                return null;
            }
        }

        private static bool TryDisposeDocumentInspectorDocument(Word.Document document, object comProxy)
        {
            try
            {
                if (null != document && false == document.IsDisposed)
                {
                    document.Dispose();
                }
                else if (null == document)
                {
                    if (null != comProxy)
                        Marshal.ReleaseComObject(comProxy);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Virtual Methods

        /// <summary>
        /// Create the used utils. The method was called in OnConnection
        /// </summary>
        /// <returns>new ToolsUtils instance</returns>
        protected internal virtual Contribution.CommonUtils OnCreateUtils()
        {
            return new Contribution.CommonUtils(this, Type, 3 == _automationCode ? true : false, this.Type.Assembly);
        }

        /// <summary>
        /// Create the used factory. The method was called as first in the base ctor
        /// </summary>
        /// <returns>new Settings instance</returns>
        protected virtual Core CreateFactory()
        {
            Core core = new Core();
            ForceInitializeAttribute attribute = AttributeReflector.GetForceInitializeAttribute(Type);
            if (null != attribute)
            {
                core.Settings.EnableMoreDebugOutput = attribute.EnableMoreDebugOutput;
                core.CheckInitialize();
            }
            return core;
        }

        /// <summary>
        /// Create the necessary factory and was called in the first line in base ctor
        /// </summary>
        /// <returns></returns>
        private Core RaiseCreateFactory()
        {
            try
            {
                return CreateFactory();
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.CreateFactory, exception);
                return null;
            }
        }

        #endregion

        #region COM Register Functions

        /// <summary>
        /// Called from regasm while register
        /// </summary>
        /// <param name="type">Type information for the class</param>
        [ComRegisterFunction, Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public static void RegisterFunction(Type type)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;
            COMAddinRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, InstallScope.System, OfficeRegisterKeyState.NeedToCreate);
            RegisterHandleDocumentInspector(type);
        }

        /// <summary>
        /// Called from regasm while ungregister
        /// </summary>
        /// <param name="type">Type information for the class</param>
        [ComUnregisterFunction, Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public static void UnregisterFunction(Type type)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;
            COMAddinUnRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, InstallScope.System, OfficeUnRegisterKeyState.NeedToDelete);
            UnregisterHandleDocumentInspector(type);
        }

        /// <summary>
        /// Called from RegAddin while register
        /// </summary>
        /// <param name="type">Type information for the class</param>
        /// <param name="scope">NetOffice.Tools.InstallScope enum value</param>
        /// <param name="keyState">NetOffice.Tools.OfficeRegisterKeyState enum value</param>
        [ComRegisterCall]
        private static void OptimizedRegisterFunction(Type type, int scope, int keyState)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;

            InstallScope currentScope = (InstallScope)scope;
            OfficeRegisterKeyState currentKeyState = (OfficeRegisterKeyState)keyState;

            COMAddinRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, currentScope, currentKeyState);
            RegisterHandleDocumentInspector(type);
        }

        /// <summary>
        /// Called from RegAddin while unregister
        /// </summary>
        /// <param name="type">Type information for the class</param>
        /// <param name="scope">NetOffice.Tools.InstallScope enum value</param>
        /// <param name="keyState">NetOffice.Tools.OfficeUnRegisterKeyState enum value</param>
        [ComUnregisterCall]
        private static void OptimizedUnregisterFunction(Type type, int scope, int keyState)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;

            InstallScope currentScope = (InstallScope)scope;
            OfficeUnRegisterKeyState currentKeyState = (OfficeUnRegisterKeyState)keyState;

            COMAddinUnRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, currentScope, currentKeyState);
            UnregisterHandleDocumentInspector(type);
        }

        /// <summary>
        /// Called from RegAddin while export registry informations
        /// </summary>
        /// <param name="type">Type information for the class</param>
        /// <param name="scope">NetOffice.Tools.InstallScope enum value</param>
        /// <param name="keyState">NetOffice.Tools.OfficeRegisterKeyState enum value</param>
        /// <returns>Registry keys/values to be add in the registry export or null</returns>
        [ComRegExportCall]
        private static RegExport RegExportFunction(Type type, int scope, int keyState)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            InstallScope currentScope = (InstallScope)scope;
            OfficeRegisterKeyState currentKeyState = (OfficeRegisterKeyState)keyState;

            return RegExportHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, currentScope, currentKeyState);
        }

        private static void RegisterHandleDocumentInspector(Type type)
        {
            try
            {
                DocumentInspectorAttribute[] attributes = DocumentInspectorAttribute.GetAttributes(type);
                if (attributes.Length > 0)
                {
                    GuidAttribute typeid = AttributeReflector.GetGuidAttribute(type);
                    foreach (var attribute in attributes)
                    {
                        foreach (var version in attribute.ProcessedApplicationVersion)
                        {
                            DocumentInspectorAttribute.CreateKey("Word", attribute.Name, version, attribute.Selected, typeid.Value);
                        }
                    }
                }
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                NetOffice.DebugConsole.Default.WriteException(exception);
                if(!RegisterErrorHandler.RaiseStaticErrorHandlerMethod(type, RegisterErrorMethodKind.Register, exception))
                    throw;
            }
        }

        private static void UnregisterHandleDocumentInspector(Type type)
        {
            try
            {
                DocumentInspectorAttribute[] attributes = DocumentInspectorAttribute.GetAttributes(type);
                if (attributes.Length > 0)
                {
                    RegistryLocationAttribute location = AttributeReflector.GetRegistryLocationAttribute(type);
                    GuidAttribute typeid = AttributeReflector.GetGuidAttribute(type);
                    foreach (var attribute in attributes)
                    {
                        foreach (var version in attribute.ProcessedApplicationVersion)
                        {
                            DocumentInspectorAttribute.TryDeleteKey("Word", attribute.Name, version);
                        }
                    }
                }
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                NetOffice.DebugConsole.Default.WriteException(exception);
                if(!RegisterErrorHandler.RaiseStaticErrorHandlerMethod(type, RegisterErrorMethodKind.UnRegister, exception))
                    throw;
            }
        }

        #endregion
    }
}