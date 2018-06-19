﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface ReflectionFormat 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863140.aspx </remarks>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class ReflectionFormat : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.ReflectionFormat
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
                    _type = typeof(ReflectionFormat);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ReflectionFormat() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861491.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoReflectionType Type
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoReflectionType>(this, "Type");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "Type", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861198.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single Transparency
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "Transparency");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Transparency", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862407.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single Size
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "Size");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Size", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864080.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single Offset
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "Offset");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Offset", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865483.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single Blur
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "Blur");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Blur", value);
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}
