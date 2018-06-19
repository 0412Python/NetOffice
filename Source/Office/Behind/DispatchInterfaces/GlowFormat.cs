﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface GlowFormat 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864010.aspx </remarks>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class GlowFormat : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.GlowFormat
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
                    _type = typeof(GlowFormat);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public GlowFormat() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861153.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single Radius
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "Radius");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Radius", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863453.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ColorFormat Color
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ColorFormat>(this, "Color", typeof(NetOffice.OfficeApi.ColorFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862431.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single Transparency
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "Transparency");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Transparency", value);
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}
