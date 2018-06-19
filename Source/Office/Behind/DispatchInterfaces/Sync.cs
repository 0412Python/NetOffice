﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface Sync 
    /// SupportByVersion Office, 11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860602.aspx </remarks>
    [SupportByVersion("Office", 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class Sync : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.Sync
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
                    _type = typeof(Sync);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Sync() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865564.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoSyncStatusType Status
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoSyncStatusType>(this, "Status");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865364.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string WorkspaceLastChangedBy
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "WorkspaceLastChangedBy");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864917.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual object LastSyncTime
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "LastSyncTime");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862150.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoSyncErrorType ErrorType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoSyncErrorType>(this, "ErrorType");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860559.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863651.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void GetUpdate()
        {
            Factory.ExecuteMethod(this, "GetUpdate");
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860754.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void PutUpdate()
        {
            Factory.ExecuteMethod(this, "PutUpdate");
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860783.aspx </remarks>
        /// <param name="syncVersionType">NetOffice.OfficeApi.Enums.MsoSyncVersionType syncVersionType</param>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void OpenVersion(NetOffice.OfficeApi.Enums.MsoSyncVersionType syncVersionType)
        {
            Factory.ExecuteMethod(this, "OpenVersion", syncVersionType);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864675.aspx </remarks>
        /// <param name="syncConflictResolution">NetOffice.OfficeApi.Enums.MsoSyncConflictResolutionType syncConflictResolution</param>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void ResolveConflict(NetOffice.OfficeApi.Enums.MsoSyncConflictResolutionType syncConflictResolution)
        {
            Factory.ExecuteMethod(this, "ResolveConflict", syncConflictResolution);
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861422.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void Unsuspend()
        {
            Factory.ExecuteMethod(this, "Unsuspend");
        }

        #endregion

        #pragma warning restore
    }
}
