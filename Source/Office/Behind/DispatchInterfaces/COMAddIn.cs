﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface COMAddIn 
    /// SupportByVersion Office, 9,10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864948.aspx </remarks>
    [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class COMAddIn : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.COMAddIn
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
                    _type = typeof(COMAddIn);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public COMAddIn() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865348.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Description
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Description");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Description", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865259.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string ProgId
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "ProgId");
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860614.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Guid
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Guid");
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863828.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Connect
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Connect");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Connect", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860745.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Object
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Object");
            }
            set
            {
                Factory.ExecuteReferencePropertySet(this, "Object", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864953.aspx </remarks>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}
