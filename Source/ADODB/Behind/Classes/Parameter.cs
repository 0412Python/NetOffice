﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ADODBApi;

namespace NetOffice.ADODBApi.Behind
{
    /// <summary>
    /// CoClass Parameter 
    /// SupportByVersion ADODB, 2.1,2.5
    /// </summary>
    [SupportByVersion("ADODB", 2.1, 2.5)]
    [EntityType(EntityType.IsCoClass)]
    public class Parameter : _Parameter, NetOffice.ADODBApi.Parameter
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

        /// <summary>
        /// Type Cache
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Parameter);
                return _type;
            }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>		
        public Parameter() : base()
        {

        }

        #endregion

        #pragma warning restore
    }
}
