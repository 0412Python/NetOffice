﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// CoClass CommandBarButton
    /// SupportByVersion Office, 9,10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865221.aspx </remarks>
    [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsCoClass)]
    [ComEventContract(typeof(NetOffice.OfficeApi.EventContracts._CommandBarButtonEvents))]
    internal class CommandBarButton : NetOffice.OfficeApi.Behind._CommandBarButton, NetOffice.OfficeApi.CommandBarButton
    {
        #pragma warning disable

        #region Fields

        private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
        private string _activeSinkId;
        private static Type _type;
        private NetOffice.OfficeApi.Behind.EventContracts._CommandBarButtonEvents_SinkHelper __CommandBarButtonEvents_SinkHelper;

        #endregion

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

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(CommandBarButton);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>
        public CommandBarButton() : base()
        {

        }

        #endregion

        #region Static CoClass Methods
        #endregion

        #region Events

        /// <summary>
        /// SupportByVersion Office, 9,10,11,12,14,15,16
        /// </summary>
        private event CommandBarButton_ClickEventHandler _ClickEvent;

        /// <summary>
        /// SupportByVersion Office 9 10 11 12 14 15,16
        /// </summary>
        ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864867.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public event CommandBarButton_ClickEventHandler ClickEvent
        {
            add
            {
                CreateEventBridge();
                _ClickEvent += value;
            }
            remove
            {
                _ClickEvent -= value;
            }
        }

        #endregion

        #region IEventBinding

        /// <summary>
        /// Creates active sink helper
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void CreateEventBridge()
        {
            if (false == Factory.Settings.EnableEvents)
                return;

            if (null != _connectPoint)
                return;

            if (null == _activeSinkId)
                _activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, NetOffice.OfficeApi.Behind.EventContracts._CommandBarButtonEvents_SinkHelper.Id);


            if (NetOffice.OfficeApi.Behind.EventContracts._CommandBarButtonEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
            {
                __CommandBarButtonEvents_SinkHelper = new NetOffice.OfficeApi.Behind.EventContracts._CommandBarButtonEvents_SinkHelper(this, _connectPoint);
                return;
            }
        }

        /// <summary>
        /// The instance use currently an event listener
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get
            {
                return (null != _connectPoint);
            }
        }
        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
        {
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
        }

        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
            if (null != __CommandBarButtonEvents_SinkHelper)
            {
                __CommandBarButtonEvents_SinkHelper.Dispose();
                __CommandBarButtonEvents_SinkHelper = null;
            }

            _connectPoint = null;
        }

        #endregion

        #pragma warning restore
    }
}
