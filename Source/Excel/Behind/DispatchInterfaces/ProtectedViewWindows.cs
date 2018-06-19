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
	/// DispatchInterface ProtectedViewWindows 
	/// SupportByVersion Excel, 14,15,16
	/// </summary>	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838667.aspx </remarks>
	[SupportByVersion("Excel", 14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class ProtectedViewWindows : COMObject, NetOffice.ExcelApi.ProtectedViewWindows
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
                    _type = typeof(ProtectedViewWindows);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ProtectedViewWindows() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196081.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840808.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195468.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195061.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.ExcelApi.ProtectedViewWindow this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ProtectedViewWindow>(this, "_Default", typeof(NetOffice.ExcelApi.ProtectedViewWindow), index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		/// <param name="filename">string filename</param>
		/// <param name="password">optional object password</param>
		/// <param name="addToMru">optional object addToMru</param>
		/// <param name="repairMode">optional object repairMode</param>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename, object password, object addToMru, object repairMode)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ProtectedViewWindow>(this, "Open", typeof(NetOffice.ExcelApi.ProtectedViewWindow), filename, password, addToMru, repairMode);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		/// <param name="filename">string filename</param>
		[CustomMethod]
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ProtectedViewWindow>(this, "Open", typeof(NetOffice.ExcelApi.ProtectedViewWindow), filename);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		/// <param name="filename">string filename</param>
		/// <param name="password">optional object password</param>
		[CustomMethod]
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename, object password)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ProtectedViewWindow>(this, "Open", typeof(NetOffice.ExcelApi.ProtectedViewWindow), filename, password);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838390.aspx </remarks>
		/// <param name="filename">string filename</param>
		/// <param name="password">optional object password</param>
		/// <param name="addToMru">optional object addToMru</param>
		[CustomMethod]
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.ProtectedViewWindow Open(string filename, object password, object addToMru)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ProtectedViewWindow>(this, "Open", typeof(NetOffice.ExcelApi.ProtectedViewWindow), filename, password, addToMru);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.ProtectedViewWindow>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.ProtectedViewWindow>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.ProtectedViewWindow>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.ProtectedViewWindow>

        /// <summary>
        /// SupportByVersion Excel, 14,15,16
        /// </summary>
        [SupportByVersion("Excel", 14, 15, 16)]
        public IEnumerator<NetOffice.ExcelApi.ProtectedViewWindow> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.ProtectedViewWindow item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 14,15,16
        /// </summary>
        [SupportByVersion("Excel", 14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

