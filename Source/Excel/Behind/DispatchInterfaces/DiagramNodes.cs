﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface DiagramNodes 
	/// SupportByVersion Excel, 10,11,12,14,15,16
	/// </summary>	[SupportByVersion("Excel", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Method, "Item")]
    [Duplicate("NetOffice.OfficeApi.DiagramNodes")]
    public class DiagramNodes : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.ExcelApi.DiagramNodes
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
                    _type = typeof(DiagramNodes);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public DiagramNodes() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.ExcelApi.DiagramNode this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.DiagramNode>(this, "Item", typeof(NetOffice.ExcelApi.DiagramNode), index);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public void SelectAll()
		{
			 Factory.ExecuteMethod(this, "SelectAll");
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.DiagramNode>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.DiagramNode>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.DiagramNode>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.DiagramNode>

        /// <summary>
        /// SupportByVersion Excel, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public IEnumerator<NetOffice.ExcelApi.DiagramNode> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.DiagramNode item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 10,11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

