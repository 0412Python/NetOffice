﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.PowerPointApi;

namespace NetOffice.PowerPointApi.Behind
{
	/// <summary>
	/// DispatchInterface FullSeriesCollection 
	/// SupportByVersion PowerPoint, 15, 16
	/// </summary>	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227661.aspx </remarks>
	[SupportByVersion("PowerPoint", 15, 16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Method, "_Default")]
	public class FullSeriesCollection : COMObject, NetOffice.PowerPointApi.FullSeriesCollection
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
                    _type = typeof(FullSeriesCollection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public FullSeriesCollection() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj684164.aspx </remarks>
		[SupportByVersion("PowerPoint", 15, 16), ProxyResult]
		public object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227663.aspx </remarks>
		[SupportByVersion("PowerPoint", 15, 16)]
		public Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj717740.aspx </remarks>
		[SupportByVersion("PowerPoint", 15, 16)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Application>(this, "Application", typeof(NetOffice.PowerPointApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj684239.aspx </remarks>
		[SupportByVersion("PowerPoint", 15, 16)]
		public Int32 Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 15,16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("PowerPoint", 15, 16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.PowerPointApi.Series this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.Series>(this, "_Default", typeof(NetOffice.PowerPointApi.Series), index);
			}
		}

        #endregion

        #region IEnumerableProvider<NetOffice.PowerPointApi.Series>

        ICOMObject IEnumerableProvider<NetOffice.PowerPointApi.Series>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsMethod(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.PowerPointApi.Series>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.PowerPointApi.Series>

        /// <summary>
        /// SupportByVersion PowerPoint, 15, 16
        /// </summary>
        [SupportByVersion("PowerPoint", 15, 16)]
        public IEnumerator<NetOffice.PowerPointApi.Series> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.PowerPointApi.Series item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion PowerPoint, 15, 16
        /// </summary>
        [SupportByVersion("PowerPoint", 15, 16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

