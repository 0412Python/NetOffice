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
    /// Interface IAllowEditRanges 
    /// SupportByVersion Excel, 10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	[TypeId("0002446A-0001-0000-C000-000000000046")]
    public interface IAllowEditRanges : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.AllowEditRange>
    {
        #region Properties

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        Int32 Count { get; }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        NetOffice.ExcelApi.AllowEditRange this[object index] { get; }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="title">string title</param>
        /// <param name="range">NetOffice.ExcelApi.Range range</param>
        /// <param name="password">optional object password</param>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.AllowEditRange Add(string title, NetOffice.ExcelApi.Range range, object password);

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="title">string title</param>
        /// <param name="range">NetOffice.ExcelApi.Range range</param>
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        NetOffice.ExcelApi.AllowEditRange Add(string title, NetOffice.ExcelApi.Range range);

        #endregion
    }
}
