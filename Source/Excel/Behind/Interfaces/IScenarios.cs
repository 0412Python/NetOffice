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
	/// Interface IScenarios 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	public class IScenarios : COMObject, NetOffice.ExcelApi.IScenarios
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Instance Type        /// </summary>
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
                    _type = typeof(IScenarios);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IScenarios() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
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
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="changingCells">object changingCells</param>
		/// <param name="values">optional object values</param>
		/// <param name="comment">optional object comment</param>
		/// <param name="locked">optional object locked</param>
		/// <param name="hidden">optional object hidden</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Scenario Add(string name, object changingCells, object values, object comment, object locked, object hidden)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Scenario>(this, "Add", typeof(NetOffice.ExcelApi.Scenario), new object[]{ name, changingCells, values, comment, locked, hidden });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="changingCells">object changingCells</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Scenario Add(string name, object changingCells)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Scenario>(this, "Add", typeof(NetOffice.ExcelApi.Scenario), name, changingCells);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="changingCells">object changingCells</param>
		/// <param name="values">optional object values</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Scenario Add(string name, object changingCells, object values)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Scenario>(this, "Add", typeof(NetOffice.ExcelApi.Scenario), name, changingCells, values);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="changingCells">object changingCells</param>
		/// <param name="values">optional object values</param>
		/// <param name="comment">optional object comment</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Scenario Add(string name, object changingCells, object values, object comment)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Scenario>(this, "Add", typeof(NetOffice.ExcelApi.Scenario), name, changingCells, values, comment);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="changingCells">object changingCells</param>
		/// <param name="values">optional object values</param>
		/// <param name="comment">optional object comment</param>
		/// <param name="locked">optional object locked</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Scenario Add(string name, object changingCells, object values, object comment, object locked)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Scenario>(this, "Add", typeof(NetOffice.ExcelApi.Scenario), new object[]{ name, changingCells, values, comment, locked });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="reportType">optional NetOffice.ExcelApi.Enums.XlSummaryReportType ReportType = 1</param>
		/// <param name="resultCells">optional object resultCells</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object CreateSummary(object reportType, object resultCells)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "CreateSummary", reportType, resultCells);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object CreateSummary()
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "CreateSummary");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="reportType">optional NetOffice.ExcelApi.Enums.XlSummaryReportType ReportType = 1</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object CreateSummary(object reportType)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "CreateSummary", reportType);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.ExcelApi.Scenario this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.Scenario>(this, "Item", typeof(NetOffice.ExcelApi.Scenario), index);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="source">object source</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object Merge(object source)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Merge", source);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.Scenario>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.Scenario>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsMethod(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.Scenario>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.Scenario>

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.ExcelApi.Scenario> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.Scenario item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

