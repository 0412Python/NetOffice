﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface DocumentLibraryVersions 
    /// SupportByVersion Office, 11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860259.aspx </remarks>
    public class DocumentLibraryVersions : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.DocumentLibraryVersions
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
                    _type = typeof(DocumentLibraryVersions);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public DocumentLibraryVersions() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="lIndex">Int32 lIndex</param>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        public virtual NetOffice.OfficeApi.DocumentLibraryVersion this[Int32 lIndex]
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.DocumentLibraryVersion>(this, "Item", typeof(NetOffice.OfficeApi.DocumentLibraryVersion), lIndex);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862237.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual Int32 Count
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863759.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863074.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual bool IsVersioningEnabled
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IsVersioningEnabled");
            }
        }

        #endregion

        #region Methods

        #endregion

        #region IEnumerableProvider<NetOffice.OfficeApi.DocumentLibraryVersion>

        ICOMObject IEnumerableProvider<NetOffice.OfficeApi.DocumentLibraryVersion>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.OfficeApi.DocumentLibraryVersion>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.OfficeApi.DocumentLibraryVersion>

        /// <summary>
        /// SupportByVersion Office, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.OfficeApi.DocumentLibraryVersion> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.DocumentLibraryVersion item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Office, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
        }

        #endregion

        #pragma warning restore
    }
}
