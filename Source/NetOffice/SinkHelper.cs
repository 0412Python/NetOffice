﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice.Exceptions;

namespace NetOffice
{
    /// <summary>
    /// Sink Helper Base Class for an Event Interface Sink helper class
    /// </summary>
    public abstract class SinkHelper : IDisposable
    {
        #region Fields

        private ICOMObject _eventClass;
        private IEventBinding _eventBinding;
        private IConnectionPoint _connectionPoint;
        private int _connectionCookie;

        #endregion

        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        /// <param name="eventClass">target CoClass instance</param>
        /// <exception cref="ArgumentNullException">Occurs when eventClass argument is null</exception>
        /// <exception cref="InvalidCastException">Occurs when eventClass argument doesnt implement the <see cref="IEventBinding"/> interface</exception>
        public SinkHelper(ICOMObject eventClass)
        {
            if (null == eventClass)
                throw new ArgumentNullException("eventClass");
            _eventClass = eventClass;
            _eventBinding = (IEventBinding)eventClass;
        }

        #endregion

        #region Properties
        
        /// <summary>
        /// CoClass Instance
        /// </summary>
        protected internal ICOMObject EventClass
        {
            get
            {
                return _eventClass;
            }
        }

        /// <summary>
        /// CoClass Instance EventBinding
        /// </summary>
        protected internal IEventBinding EventBinding
        {
            get
            {
                return _eventBinding;
            }
        }

        /// <summary>
        /// CoClass Factore Core
        /// </summary>
        protected internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create event binding
        /// </summary>
        /// <param name="connectPoint">target connection point</param>
        /// <exception cref="NetOfficeCOMException">Unexpected error</exception>
        public void SetupEventBinding(IConnectionPoint connectPoint)
        {
            try
            {
                if (true == Settings.Default.EnableEvents)
                {
                    _connectionPoint = connectPoint;
                    _connectionPoint.Advise(this, out _connectionCookie);
                    Factory.InternalObjectEvents.AddEventBridge(this);
                }
            }
            catch (Exception throwedException)
            {
                _eventClass.Console.WriteException(throwedException);
                throw new NetOfficeCOMException("An error occured while setup event binding.", throwedException);
            }
        }

        /// <summary>
        /// Release event binding
        /// </summary>
        /// <exception cref="NetOfficeCOMException">Unexpected error</exception>
        public void RemoveEventBinding()
        {
            RemoveEventBinding(true);
        }

        /// <summary>
        /// Validate to proceed event
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns>true if event is ready, otherwise false</returns>
        public bool Validate(string eventName)
        {
            if ((true == _eventClass.IsCurrentlyDisposing)
                || (false == _eventBinding.HasEventRecipients(eventName)))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Release event binding
        /// </summary>
        /// <exception cref="NetOfficeCOMException">Unexpected error</exception>
        internal void RemoveEventBinding(bool removeFromList)
        {
            if (_connectionCookie != 0)
            {
                try
                {
                    _connectionPoint.Unadvise(_connectionCookie);
                    Marshal.ReleaseComObject(_connectionPoint);
                }
                catch (System.Runtime.InteropServices.COMException throwedException)
                {
                    _eventClass.Console.WriteException(throwedException);
                    ; // RPC server is disconnected or dead
                }
                catch (Exception throwedException)
                {
                    _eventClass.Console.WriteException(throwedException);
                    throw new NetOfficeCOMException("An error occured while release event binding.", throwedException);
                }

                _connectionPoint = null;
                _connectionCookie = 0;

                if (removeFromList)
                    Factory.InternalObjectEvents.RemoveEventBridge(this);
            }
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get supported connection point from comProxy
        /// </summary>
        /// <param name="comInstance"></param>
        /// <param name="point"></param>
        /// <param name="sinkIds"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Occurs when comInstance argument is null</exception>
        /// <exception cref="COMException">Occurs when underlying proxy doesnt support the target event interface</exception>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static string GetConnectionPoint(ICOMObject comInstance, ref IConnectionPoint point, params string[] sinkIds)
        {
            if (null == comInstance)
                throw new ArgumentNullException("comInstance");

            if (null == sinkIds)
                return null;

            IConnectionPointContainer connectionPointContainer = comInstance.UnderlyingObject as IConnectionPointContainer;
            if (null == connectionPointContainer)
            {
                if (comInstance.Settings.EnableEventDebugOutput)
                    comInstance.Console.WriteLine("Unable to cast IConnectionPointContainer.");
                return null;
            }

            if (comInstance.Settings.EnableEventDebugOutput)
                comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call FindConnectionPoint");

            string id = FindConnectionPoint(comInstance, connectionPointContainer, ref point, sinkIds);

            if (comInstance.Settings.EnableEventDebugOutput)
                comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call FindConnectionPoint passed");

            if (null == id)
            {
                if (comInstance.Settings.EnableEventDebugOutput)
                    comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call EnumConnectionPoint");
                id = EnumConnectionPoint(comInstance, connectionPointContainer, ref point, sinkIds);
                if (comInstance.Settings.EnableEventDebugOutput)
                    comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call EnumConnectionPoint passed");
            }

            if (null != id)
                return id;
            else
                throw new COMException("Specified instance doesnt implement the target event interface.");
        }

        /// <summary>
        /// Get supported connection point from comProxy in reverse order to GetConnectionPoint
        /// </summary>
        /// <param name="comInstance"></param>
        /// <param name="point"></param>
        /// <param name="sinkIds"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Occurs when comInstance argument is null</exception>
        /// <exception cref="COMException">Occurs when underlying proxy doesnt support the target event interface</exception>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static string GetConnectionPoint2(ICOMObject comInstance, ref IConnectionPoint point, params string[] sinkIds)
        {
            if (null == comInstance)
                throw new ArgumentNullException("comInstance");

            if (null == sinkIds)
                return null;

            IConnectionPointContainer connectionPointContainer = comInstance.UnderlyingObject as IConnectionPointContainer;
            if (null == connectionPointContainer)
            {
                if (comInstance.Settings.EnableEventDebugOutput)
                    comInstance.Console.WriteLine("Unable to cast IConnectionPointContainer.");
                return null;
            }

            if (comInstance.Settings.EnableEventDebugOutput)
                comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call EnumConnectionPoint");

            string id = EnumConnectionPoint(comInstance, connectionPointContainer, ref point, sinkIds);

            if (comInstance.Settings.EnableEventDebugOutput)
                comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call EnumConnectionPoint passed");

            if (null == id)
            {
                if (comInstance.Settings.EnableEventDebugOutput)
                    comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call FindConnectionPoint");
                id = FindConnectionPoint(comInstance, connectionPointContainer, ref point, sinkIds);
                if (comInstance.Settings.EnableEventDebugOutput)
                    comInstance.Console.WriteLine(comInstance.InstanceType.FullName + " -> Call FindConnectionPoint passed");
            }

            if (null != id)
                return id;
            else
                throw new COMException("Specified instance doesnt implement the target event interface.");
        }

        /// <summary>
        /// Try to find connection point by FindConnectionPoint
        /// </summary>
        private static string FindConnectionPoint(ICOMObject comInstance, IConnectionPointContainer connectionPointContainer, ref IConnectionPoint point, params string[] sinkIds)
        {
            try
            {
                for (int i = sinkIds.Length; i > 0; i--)
                {
                    Guid refGuid = new Guid(sinkIds[i - 1]);
                    IConnectionPoint refPoint = null;
                    connectionPointContainer.FindConnectionPoint(ref refGuid, out refPoint);
                    if (null != refPoint)
                    {
                        point = refPoint;
                        return sinkIds[i - 1];
                    }
                }

                return null;
            }
            catch (Exception throwedException)
            {
                comInstance.Console.WriteException(throwedException);
                return null;
            }
        }

        /// <summary>
        /// try to find connection point by EnumConnectionPoints
        /// </summary>
        private static string EnumConnectionPoint(ICOMObject comInstance, IConnectionPointContainer connectionPointContainer, ref IConnectionPoint point, params string[] sinkIds)
        {
            IConnectionPoint[] points = new IConnectionPoint[1];
            IEnumConnectionPoints enumPoints = null;
            try
            {
                connectionPointContainer.EnumConnectionPoints(out enumPoints);
                while (enumPoints.Next(1, points, IntPtr.Zero) == 0) // S_OK = 0 , S_FALSE = 1
                {
                    if (null == points[0])
                        break;

                    Guid interfaceGuid;
                    points[0].GetConnectionInterface(out interfaceGuid);

                    for (int i = sinkIds.Length; i > 0; i--)
                    {
                        string id = interfaceGuid.ToString().Replace("{", "").Replace("}", "");
                        if (true == sinkIds[i - 1].Equals(id, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Marshal.ReleaseComObject(enumPoints);
                            enumPoints = null;
                            point = points[0];
                            return id;
                        }
                    }
                }
                return null;
            }
            catch (Exception throwedException)
            {
                comInstance.Console.WriteException(throwedException);
                return null;
            }
            finally
            {
                if (null != enumPoints)
                    Marshal.ReleaseComObject(enumPoints);
            }
        }
      
        /// <summary>
        /// Perform cast to System.String and suspress any exception(s)
        /// </summary>
        /// <param name="value">value to cast</param>
        /// <returns>cast value or false if exception occurs</returns>
        protected static string ToString(object value)
        {
            try
            {
                return Convert.ToString(value);
            }
            catch
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// Perform cast to System.Boolean and suspress any exception(s)
        /// </summary>
        /// <param name="value">value to cast</param>
        /// <returns>cast value or false if exception occurs</returns>
        protected static bool ToBoolean(object value)
        {
            try
            {
                return (bool)value;
            }
            catch
            {
                return default(bool);
            }
        }

        /// <summary>
        /// Perform cast to System.Int16 and suspress any exception(s)
        /// </summary>
        /// <param name="value">value to cast</param>
        /// <returns>cast value or 0 if exception occurs</returns>
        protected static Int16 ToInt16(object value)
        {
            try
            {
                return (Int16)value;
            }
            catch
            {
                return default(Int16);
            }
        }

        /// <summary>
        /// Perform cast to System.Int32 and suspress any exception(s)
        /// </summary>
        /// <param name="value">value to cast</param>
        /// <returns>cast value or 0 if exception occurs</returns>
        protected static Int32 ToInt32(object value)
        {
            try
            {
                return (Int32)value;
            }
            catch
            {
                return default(Int32);
            }
        }

        /// <summary>
        /// Perform cast to System.Double and suspress any exception(s)
        /// </summary>
        /// <param name="value">value to cast</param>
        /// <returns>cast value or 0 if exception occurs</returns>
        protected static double ToDouble(object value)
        {
            try
            {
                return (double)value;
            }
            catch
            {
                return default(double);
            }
        }

        /// <summary>
        /// Perform cast to System.Single and suspress any exception(s)
        /// </summary>
        /// <param name="value">value to cast</param>
        /// <returns>cast value or 0 if exception occurs</returns>
        protected static Single ToSingle(object value)
        {
            try
            {
                return (Single)value;
            }
            catch
            {
                return default(Single);
            }
        }

        /// <summary>
        /// Perform cast to System.Enum and suspress any exception(s)
        /// </summary>
        /// <typeparam name="T">type of System.Enum</typeparam>
        /// <param name="value">value to cast</param>
        /// <returns>ast value or default(T) if exception occurs</returns>
        protected static T ToEnum<T>(object value) where T : struct
        {
            try
            {
                return (T)value;
            }
            catch
            {
                return default(T);
            }
        }

        #endregion

        #region IDisposable

        /// <summary>
        /// Removes event binding
        /// </summary>
        public virtual void Dispose()
        {
            RemoveEventBinding();
        }

        #endregion
    }
}
