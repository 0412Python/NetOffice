﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OWC10Api.Behind
{
    /// <summary>
    /// CoClass ChartSpace 
    /// SupportByVersion OWC10, 1
    /// </summary>
    [SupportByVersion("OWC10", 1)]
    [EntityType(EntityType.IsCoClass)]
    [ComEventContract(typeof(NetOffice.OWC10Api.EventContracts.IChartEvents))]
    public class ChartSpace : ChChartSpace, NetOffice.OWC10Api.ChartSpace
    {
        #pragma warning disable

        #region Fields

        private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
        private string _activeSinkId;
        private static Type _type;
        private NetOffice.OWC10Api.Behind.EventContracts.IChartEvents_SinkHelper _iChartEvents_SinkHelper;

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
                    _type = typeof(ChartSpace);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>		
        public ChartSpace() : base()
        {

        }

        #endregion

        #region Events

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_DataSetChangeEventHandler _DataSetChangeEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_DataSetChangeEventHandler DataSetChangeEvent
        {
            add
            {
                CreateEventBridge();
                _DataSetChangeEvent += value;
            }
            remove
            {
                _DataSetChangeEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_DblClickEventHandler _DblClickEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_DblClickEventHandler DblClickEvent
        {
            add
            {
                CreateEventBridge();
                _DblClickEvent += value;
            }
            remove
            {
                _DblClickEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_ClickEventHandler _ClickEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_ClickEventHandler ClickEvent
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

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_KeyDownEventHandler _KeyDownEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_KeyDownEventHandler KeyDownEvent
        {
            add
            {
                CreateEventBridge();
                _KeyDownEvent += value;
            }
            remove
            {
                _KeyDownEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_KeyUpEventHandler _KeyUpEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_KeyUpEventHandler KeyUpEvent
        {
            add
            {
                CreateEventBridge();
                _KeyUpEvent += value;
            }
            remove
            {
                _KeyUpEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_KeyPressEventHandler _KeyPressEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_KeyPressEventHandler KeyPressEvent
        {
            add
            {
                CreateEventBridge();
                _KeyPressEvent += value;
            }
            remove
            {
                _KeyPressEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_BeforeKeyDownEventHandler _BeforeKeyDownEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_BeforeKeyDownEventHandler BeforeKeyDownEvent
        {
            add
            {
                CreateEventBridge();
                _BeforeKeyDownEvent += value;
            }
            remove
            {
                _BeforeKeyDownEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_BeforeKeyUpEventHandler _BeforeKeyUpEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_BeforeKeyUpEventHandler BeforeKeyUpEvent
        {
            add
            {
                CreateEventBridge();
                _BeforeKeyUpEvent += value;
            }
            remove
            {
                _BeforeKeyUpEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_BeforeKeyPressEventHandler _BeforeKeyPressEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_BeforeKeyPressEventHandler BeforeKeyPressEvent
        {
            add
            {
                CreateEventBridge();
                _BeforeKeyPressEvent += value;
            }
            remove
            {
                _BeforeKeyPressEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_MouseDownEventHandler _MouseDownEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_MouseDownEventHandler MouseDownEvent
        {
            add
            {
                CreateEventBridge();
                _MouseDownEvent += value;
            }
            remove
            {
                _MouseDownEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_MouseMoveEventHandler _MouseMoveEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_MouseMoveEventHandler MouseMoveEvent
        {
            add
            {
                CreateEventBridge();
                _MouseMoveEvent += value;
            }
            remove
            {
                _MouseMoveEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_MouseUpEventHandler _MouseUpEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_MouseUpEventHandler MouseUpEvent
        {
            add
            {
                CreateEventBridge();
                _MouseUpEvent += value;
            }
            remove
            {
                _MouseUpEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_MouseWheelEventHandler _MouseWheelEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_MouseWheelEventHandler MouseWheelEvent
        {
            add
            {
                CreateEventBridge();
                _MouseWheelEvent += value;
            }
            remove
            {
                _MouseWheelEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_SelectionChangeEventHandler _SelectionChangeEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_SelectionChangeEventHandler SelectionChangeEvent
        {
            add
            {
                CreateEventBridge();
                _SelectionChangeEvent += value;
            }
            remove
            {
                _SelectionChangeEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_BeforeScreenTipEventHandler _BeforeScreenTipEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_BeforeScreenTipEventHandler BeforeScreenTipEvent
        {
            add
            {
                CreateEventBridge();
                _BeforeScreenTipEvent += value;
            }
            remove
            {
                _BeforeScreenTipEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_CommandEnabledEventHandler _CommandEnabledEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_CommandEnabledEventHandler CommandEnabledEvent
        {
            add
            {
                CreateEventBridge();
                _CommandEnabledEvent += value;
            }
            remove
            {
                _CommandEnabledEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_CommandCheckedEventHandler _CommandCheckedEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_CommandCheckedEventHandler CommandCheckedEvent
        {
            add
            {
                CreateEventBridge();
                _CommandCheckedEvent += value;
            }
            remove
            {
                _CommandCheckedEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_CommandTipTextEventHandler _CommandTipTextEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_CommandTipTextEventHandler CommandTipTextEvent
        {
            add
            {
                CreateEventBridge();
                _CommandTipTextEvent += value;
            }
            remove
            {
                _CommandTipTextEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_CommandBeforeExecuteEventHandler _CommandBeforeExecuteEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_CommandBeforeExecuteEventHandler CommandBeforeExecuteEvent
        {
            add
            {
                CreateEventBridge();
                _CommandBeforeExecuteEvent += value;
            }
            remove
            {
                _CommandBeforeExecuteEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_CommandExecuteEventHandler _CommandExecuteEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_CommandExecuteEventHandler CommandExecuteEvent
        {
            add
            {
                CreateEventBridge();
                _CommandExecuteEvent += value;
            }
            remove
            {
                _CommandExecuteEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_BeforeContextMenuEventHandler _BeforeContextMenuEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_BeforeContextMenuEventHandler BeforeContextMenuEvent
        {
            add
            {
                CreateEventBridge();
                _BeforeContextMenuEvent += value;
            }
            remove
            {
                _BeforeContextMenuEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_BeforeRenderEventHandler _BeforeRenderEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_BeforeRenderEventHandler BeforeRenderEvent
        {
            add
            {
                CreateEventBridge();
                _BeforeRenderEvent += value;
            }
            remove
            {
                _BeforeRenderEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_AfterRenderEventHandler _AfterRenderEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_AfterRenderEventHandler AfterRenderEvent
        {
            add
            {
                CreateEventBridge();
                _AfterRenderEvent += value;
            }
            remove
            {
                _AfterRenderEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_AfterFinalRenderEventHandler _AfterFinalRenderEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_AfterFinalRenderEventHandler AfterFinalRenderEvent
        {
            add
            {
                CreateEventBridge();
                _AfterFinalRenderEvent += value;
            }
            remove
            {
                _AfterFinalRenderEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_AfterLayoutEventHandler _AfterLayoutEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_AfterLayoutEventHandler AfterLayoutEvent
        {
            add
            {
                CreateEventBridge();
                _AfterLayoutEvent += value;
            }
            remove
            {
                _AfterLayoutEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion OWC10, 1
        /// </summary>
        private event ChartSpace_ViewChangeEventHandler _ViewChangeEvent;

        /// <summary>
        /// SupportByVersion OWC10 1
        /// </summary>
        [SupportByVersion("OWC10", 1)]
        public virtual event ChartSpace_ViewChangeEventHandler ViewChangeEvent
        {
            add
            {
                CreateEventBridge();
                _ViewChangeEvent += value;
            }
            remove
            {
                _ViewChangeEvent -= value;
            }
        }

        #endregion

        #region IEventBinding

        /// <summary>
        /// Creates active sink helper
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual void CreateEventBridge()
        {
            if (false == Factory.Settings.EnableEvents)
                return;

            if (null != _connectPoint)
                return;

            if (null == _activeSinkId)
                _activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, NetOffice.OWC10Api.Behind.EventContracts.IChartEvents_SinkHelper.Id);


            if (NetOffice.OWC10Api.Behind.EventContracts.IChartEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
            {
                _iChartEvents_SinkHelper = new NetOffice.OWC10Api.Behind.EventContracts.IChartEvents_SinkHelper(this, _connectPoint);
                return;
            }
        }

        /// <summary>
        /// The instance use currently an event listener 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool EventBridgeInitialized
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
        public virtual bool HasEventRecipients()
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual int GetCountOfEventRecipients(string eventName)
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
        public virtual int RaiseCustomEvent(string eventName, ref object[] paramsArray)
        {
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
        }

        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual void DisposeEventBridge()
        {
            if (null != _iChartEvents_SinkHelper)
            {
                _iChartEvents_SinkHelper.Dispose();
                _iChartEvents_SinkHelper = null;
            }

            _connectPoint = null;
        }

        #endregion

        #pragma warning restore
    }
}
