﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.OutlookApi;

namespace NetOffice.OutlookApi.Behind
{
	/// <summary>
	/// DispatchInterface Conflicts 
	/// SupportByVersion Outlook, 11,12,14,15,16
	/// </summary>	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff868978.aspx </remarks>
	[SupportByVersion("Outlook", 11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Custom), HasIndexProperty(IndexInvoke.Method, "Item")]
	public class Conflicts : COMObject, NetOffice.OutlookApi.Conflicts
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
                    _type = typeof(Conflicts);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Conflicts() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864189.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		[BaseResult]
		public virtual NetOffice.OutlookApi._Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.OutlookApi._Application>(this, "Application");
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863280.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		public virtual NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OutlookApi.Enums.OlObjectClass>(this, "Class");
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864782.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		[BaseResult]
		public virtual NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.OutlookApi._NameSpace>(this, "Session");
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff866455.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864473.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		#endregion

		
        #region Methods

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.OutlookApi.Conflict this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.OutlookApi.Conflict>(this, "Item", typeof(NetOffice.OutlookApi.Conflict), index);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff869881.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		public virtual NetOffice.OutlookApi.Conflict GetFirst()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.OutlookApi.Conflict>(this, "GetFirst", typeof(NetOffice.OutlookApi.Conflict));
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863031.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		public virtual NetOffice.OutlookApi.Conflict GetLast()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.OutlookApi.Conflict>(this, "GetLast", typeof(NetOffice.OutlookApi.Conflict));
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862998.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		public virtual NetOffice.OutlookApi.Conflict GetNext()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.OutlookApi.Conflict>(this, "GetNext", typeof(NetOffice.OutlookApi.Conflict));
		}

		/// <summary>
		/// SupportByVersion Outlook 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862418.aspx </remarks>
		[SupportByVersion("Outlook", 11,12,14,15,16)]
		public virtual NetOffice.OutlookApi.Conflict GetPrevious()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.OutlookApi.Conflict>(this, "GetPrevious", typeof(NetOffice.OutlookApi.Conflict));
		}

        #endregion
        
        #region IEnumerableProvider<NetOffice.OutlookApi.Conflict>

        ICOMObject IEnumerableProvider<NetOffice.OutlookApi.Conflict>.GetComObjectEnumerator(ICOMObject parent)
        {
            return this;
        }

        IEnumerable IEnumerableProvider<NetOffice.OutlookApi.Conflict>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OutlookApi.Conflict item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable<NetOffice.OutlookApi.Conflict>

        /// <summary>
        /// SupportByVersion Outlook, 11,12,14,15,16
        /// This is a custom enumerator from NetOffice
        /// </summary>
        [SupportByVersion("Outlook", 11, 12, 14, 15, 16)]
        [CustomEnumerator]
        public virtual IEnumerator<NetOffice.OutlookApi.Conflict> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OutlookApi.Conflict item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Outlook, 11,12,14,15,16
        /// This is a custom enumerator from NetOffice
        /// </summary>
        [SupportByVersion("Outlook", 11, 12, 14, 15, 16)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i + 1];

            foreach (object item in enumeratorObjects)
                yield return item;
        }

        #endregion

        #pragma warning restore
    }
}

