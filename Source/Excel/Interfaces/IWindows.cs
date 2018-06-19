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
	/// Interface IWindows 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public interface IWindows : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.Window>
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

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.ExcelApi.Window this[object index] { get; }

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		bool SyncScrollingSideBySide { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		/// <param name="activeWorkbook">optional object activeWorkbook</param>
		/// <param name="syncHorizontal">optional object syncHorizontal</param>
		/// <param name="syncVertical">optional object syncVertical</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		object Arrange(object arrangeStyle, object activeWorkbook, object syncHorizontal, object syncVertical);

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		object Arrange();

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		object Arrange(object arrangeStyle);

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		/// <param name="activeWorkbook">optional object activeWorkbook</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		object Arrange(object arrangeStyle, object activeWorkbook);

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		/// <param name="activeWorkbook">optional object activeWorkbook</param>
		/// <param name="syncHorizontal">optional object syncHorizontal</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		object Arrange(object arrangeStyle, object activeWorkbook, object syncHorizontal);

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="windowName">object windowName</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		bool CompareSideBySideWith(object windowName);

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		bool BreakSideBySide();

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		Int32 ResetPositionsSideBySide();

		#endregion
	}
}
