﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface _CommandBarActiveX 
    /// SupportByVersion Office, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class _CommandBarActiveX : NetOffice.OfficeApi.Behind.CommandBarControl, NetOffice.OfficeApi._CommandBarActiveX
    {
        #pragma warning disable

        #region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_CommandBarActiveX);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _CommandBarActiveX() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string ControlCLSID
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ControlCLSID");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ControlCLSID", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <param name="bstrIid">string bstrIid</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object get_QueryControlInterface(string bstrIid)
        {
            return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "QueryControlInterface", bstrIid);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_QueryControlInterface
        /// Unknown COM Proxy
        /// </summary>
        /// <param name="bstrIid">string bstrIid</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult, Redirect("get_QueryControlInterface")]
        public virtual object QueryControlInterface(string bstrIid)
        {
            return get_QueryControlInterface(bstrIid);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object InitWith
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "InitWith");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "InitWith", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object InstanceIdPtr
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "InstanceIdPtr");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="flagsSelect">Int32 flagsSelect</param>
        /// <param name="varChild">optional object varChild</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void accSelect(Int32 flagsSelect, object varChild)
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "accSelect", flagsSelect, varChild);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="flagsSelect">Int32 flagsSelect</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void accSelect(Int32 flagsSelect)
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "accSelect", flagsSelect);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="pxLeft">Int32 pxLeft</param>
        /// <param name="pyTop">Int32 pyTop</param>
        /// <param name="pcxWidth">Int32 pcxWidth</param>
        /// <param name="pcyHeight">Int32 pcyHeight</param>
        /// <param name="varChild">optional object varChild</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void accLocation(out Int32 pxLeft, out Int32 pyTop, out Int32 pcxWidth, out Int32 pcyHeight, object varChild)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true, true, true, true, false);
            pxLeft = 0;
            pyTop = 0;
            pcxWidth = 0;
            pcyHeight = 0;
            object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight, varChild);
            Invoker.Method(this, "accLocation", paramsArray, modifiers);
            pxLeft = (Int32)paramsArray[0];
            pyTop = (Int32)paramsArray[1];
            pcxWidth = (Int32)paramsArray[2];
            pcyHeight = (Int32)paramsArray[3];
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="pxLeft">Int32 pxLeft</param>
        /// <param name="pyTop">Int32 pyTop</param>
        /// <param name="pcxWidth">Int32 pcxWidth</param>
        /// <param name="pcyHeight">Int32 pcyHeight</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void accLocation(out Int32 pxLeft, out Int32 pyTop, out Int32 pcxWidth, out Int32 pcyHeight)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true, true, true, true);
            pxLeft = 0;
            pyTop = 0;
            pcxWidth = 0;
            pcyHeight = 0;
            object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight);
            Invoker.Method(this, "accLocation", paramsArray, modifiers);
            pxLeft = (Int32)paramsArray[0];
            pyTop = (Int32)paramsArray[1];
            pcxWidth = (Int32)paramsArray[2];
            pcyHeight = (Int32)paramsArray[3];
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="navDir">Int32 navDir</param>
        /// <param name="varStart">optional object varStart</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object accNavigate(Int32 navDir, object varStart)
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "accNavigate", navDir, varStart);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="navDir">Int32 navDir</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object accNavigate(Int32 navDir)
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "accNavigate", navDir);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="xLeft">Int32 xLeft</param>
        /// <param name="yTop">Int32 yTop</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object accHitTest(Int32 xLeft, Int32 yTop)
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "accHitTest", xLeft, yTop);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="varChild">optional object varChild</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void accDoDefaultAction(object varChild)
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "accDoDefaultAction", varChild);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void accDoDefaultAction()
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "accDoDefaultAction");
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="pUnk">object pUnk</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void SetInnerObjectFactory(object pUnk)
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "SetInnerObjectFactory", pUnk);
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual void EnsureControl()
        {
            InvokerService.InvokeInternal.ExecuteMethod(this, "EnsureControl");
        }

        #endregion

        #pragma warning restore
    }
}
