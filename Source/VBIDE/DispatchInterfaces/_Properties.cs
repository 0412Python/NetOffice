﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.VBIDEApi
{
    /// <summary>
    /// DispatchInterface _Properties
    /// SupportByVersion VBIDE, 12,14,5.3
    /// </summary>
    [SupportByVersion("VBIDE", 12, 14, 5.3)]
    [EntityType(EntityType.IsDispatchInterface), BaseType, Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Method, "Item")]
    public interface _Properties : ICOMObject, IEnumerableProvider<NetOffice.VBIDEApi.Property>
    {
        #region Properties

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        [BaseResult]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        NetOffice.VBIDEApi.Application Application { get; }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3), ProxyResult]
        object Parent { get; }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        Int32 Count { get; }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        NetOffice.VBIDEApi.VBE VBE { get; }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        NetOffice.VBIDEApi.Property this[object index] { get; }

        #endregion
    }
}
