﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface SmartDocument 
    /// SupportByVersion Office, 11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863963.aspx </remarks>
    [SupportByVersion("Office", 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class SmartDocument : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.SmartDocument
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
                    _type = typeof(SmartDocument);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public SmartDocument() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864983.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string SolutionID
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SolutionID");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SolutionID", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865469.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string SolutionURL
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SolutionURL");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SolutionURL", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865250.aspx </remarks>
        /// <param name="considerAllSchemas">optional bool ConsiderAllSchemas = false</param>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void PickSolution(object considerAllSchemas)
        {
            Factory.ExecuteMethod(this, "PickSolution", considerAllSchemas);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865250.aspx </remarks>
        [CustomMethod]
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void PickSolution()
        {
            Factory.ExecuteMethod(this, "PickSolution");
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864173.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void RefreshPane()
        {
            Factory.ExecuteMethod(this, "RefreshPane");
        }

        #endregion

        #pragma warning restore
    }
}
