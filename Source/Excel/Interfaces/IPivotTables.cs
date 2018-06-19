﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.ExcelApi
{
	/// <summary>
	/// Interface IPivotTables 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Method, "Item")]
	public interface IPivotTables : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.PivotTable>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		NetOffice.ExcelApi.Application Application { get; }

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16), ProxyResult]
		object Parent { get; }

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		Int32 Count { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.ExcelApi.PivotTable this[object index] { get; }

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="pivotCache">NetOffice.ExcelApi.PivotCache pivotCache</param>
		/// <param name="tableDestination">object tableDestination</param>
		/// <param name="tableName">optional object tableName</param>
		/// <param name="readData">optional object readData</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		NetOffice.ExcelApi.PivotTable Add(NetOffice.ExcelApi.PivotCache pivotCache, object tableDestination, object tableName, object readData);

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="pivotCache">NetOffice.ExcelApi.PivotCache pivotCache</param>
		/// <param name="tableDestination">object tableDestination</param>
		/// <param name="tableName">optional object tableName</param>
		/// <param name="readData">optional object readData</param>
		/// <param name="defaultVersion">optional object defaultVersion</param>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		NetOffice.ExcelApi.PivotTable Add(NetOffice.ExcelApi.PivotCache pivotCache, object tableDestination, object tableName, object readData, object defaultVersion);

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="pivotCache">NetOffice.ExcelApi.PivotCache pivotCache</param>
		/// <param name="tableDestination">object tableDestination</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		NetOffice.ExcelApi.PivotTable Add(NetOffice.ExcelApi.PivotCache pivotCache, object tableDestination);

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="pivotCache">NetOffice.ExcelApi.PivotCache pivotCache</param>
		/// <param name="tableDestination">object tableDestination</param>
		/// <param name="tableName">optional object tableName</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		NetOffice.ExcelApi.PivotTable Add(NetOffice.ExcelApi.PivotCache pivotCache, object tableDestination, object tableName);

		#endregion
	}
}
