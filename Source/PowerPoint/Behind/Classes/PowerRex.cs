﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.PowerPointApi.Behind
{
    /// <summary>
    /// CoClass PowerRex
    /// SupportByVersion PowerPoint, 10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("PowerPoint", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsCoClass)]
    public class PowerRex : _PowerRex, NetOffice.PowerPointApi.PowerRex
    {
        #pragma warning disable

        #region Fields

        private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
        private string _activeSinkId;
        private static Type _type;

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

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(PowerRex);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>
        public PowerRex() : base()
        {

        }

        #endregion

        #pragma warning restore
    }
}
