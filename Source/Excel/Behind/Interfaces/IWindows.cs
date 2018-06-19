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
	/// Interface IWindows 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class IWindows : COMObject, NetOffice.ExcelApi.IWindows
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
                    _type = typeof(IWindows);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IWindows() : base()
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

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.ExcelApi.Window this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Window>(this, "_Default", typeof(NetOffice.ExcelApi.Window), index);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool SyncScrollingSideBySide
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SyncScrollingSideBySide");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SyncScrollingSideBySide", value);
			}
		}

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
		public virtual object Arrange(object arrangeStyle, object activeWorkbook, object syncHorizontal, object syncVertical)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Arrange", arrangeStyle, activeWorkbook, syncHorizontal, syncVertical);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object Arrange()
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Arrange");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object Arrange(object arrangeStyle)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Arrange", arrangeStyle);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		/// <param name="activeWorkbook">optional object activeWorkbook</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object Arrange(object arrangeStyle, object activeWorkbook)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Arrange", arrangeStyle, activeWorkbook);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="arrangeStyle">optional NetOffice.ExcelApi.Enums.XlArrangeStyle ArrangeStyle = 1</param>
		/// <param name="activeWorkbook">optional object activeWorkbook</param>
		/// <param name="syncHorizontal">optional object syncHorizontal</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object Arrange(object arrangeStyle, object activeWorkbook, object syncHorizontal)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Arrange", arrangeStyle, activeWorkbook, syncHorizontal);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="windowName">object windowName</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool CompareSideBySideWith(object windowName)
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "CompareSideBySideWith", windowName);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool BreakSideBySide()
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "BreakSideBySide");
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual Int32 ResetPositionsSideBySide()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "ResetPositionsSideBySide");
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.Window>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.Window>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.Window>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.Window>

        /// <summary>
        /// SupportByVersion Excel, 9,10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual IEnumerator<NetOffice.ExcelApi.Window> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.Window item in innerEnumerator)
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
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

