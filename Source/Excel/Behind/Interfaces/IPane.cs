﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IPane 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class IPane : COMObject, NetOffice.ExcelApi.IPane
	{
		#pragma warning disable

		#region Type Information

        /// <summary>        /// Instance Type
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
                    _type = typeof(IPane);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IPane() : base()
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
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
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
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
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
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Index
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Index");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 ScrollColumn
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "ScrollColumn");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScrollColumn", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 ScrollRow
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "ScrollRow");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ScrollRow", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Range VisibleRange
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "VisibleRange", typeof(NetOffice.ExcelApi.Range));
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool Activate()
		{
			return Factory.ExecuteBoolMethodGet(this, "Activate");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		/// <param name="up">optional object up</param>
		/// <param name="toRight">optional object toRight</param>
		/// <param name="toLeft">optional object toLeft</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object LargeScroll(object down, object up, object toRight, object toLeft)
		{
			return Factory.ExecuteVariantMethodGet(this, "LargeScroll", down, up, toRight, toLeft);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object LargeScroll()
		{
			return Factory.ExecuteVariantMethodGet(this, "LargeScroll");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object LargeScroll(object down)
		{
			return Factory.ExecuteVariantMethodGet(this, "LargeScroll", down);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		/// <param name="up">optional object up</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object LargeScroll(object down, object up)
		{
			return Factory.ExecuteVariantMethodGet(this, "LargeScroll", down, up);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		/// <param name="up">optional object up</param>
		/// <param name="toRight">optional object toRight</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object LargeScroll(object down, object up, object toRight)
		{
			return Factory.ExecuteVariantMethodGet(this, "LargeScroll", down, up, toRight);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		/// <param name="up">optional object up</param>
		/// <param name="toRight">optional object toRight</param>
		/// <param name="toLeft">optional object toLeft</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object SmallScroll(object down, object up, object toRight, object toLeft)
		{
			return Factory.ExecuteVariantMethodGet(this, "SmallScroll", down, up, toRight, toLeft);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object SmallScroll()
		{
			return Factory.ExecuteVariantMethodGet(this, "SmallScroll");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object SmallScroll(object down)
		{
			return Factory.ExecuteVariantMethodGet(this, "SmallScroll", down);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		/// <param name="up">optional object up</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object SmallScroll(object down, object up)
		{
			return Factory.ExecuteVariantMethodGet(this, "SmallScroll", down, up);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="down">optional object down</param>
		/// <param name="up">optional object up</param>
		/// <param name="toRight">optional object toRight</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual object SmallScroll(object down, object up, object toRight)
		{
			return Factory.ExecuteVariantMethodGet(this, "SmallScroll", down, up, toRight);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="left">Int32 left</param>
		/// <param name="top">Int32 top</param>
		/// <param name="width">Int32 width</param>
		/// <param name="height">Int32 height</param>
		/// <param name="start">optional object start</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 ScrollIntoView(Int32 left, Int32 top, Int32 width, Int32 height, object start)
		{
			return Factory.ExecuteInt32MethodGet(this, "ScrollIntoView", new object[]{ left, top, width, height, start });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="left">Int32 left</param>
		/// <param name="top">Int32 top</param>
		/// <param name="width">Int32 width</param>
		/// <param name="height">Int32 height</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 ScrollIntoView(Int32 left, Int32 top, Int32 width, Int32 height)
		{
			return Factory.ExecuteInt32MethodGet(this, "ScrollIntoView", left, top, width, height);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="points">Int32 points</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 PointsToScreenPixelsX(Int32 points)
		{
			return Factory.ExecuteInt32MethodGet(this, "PointsToScreenPixelsX", points);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="points">Int32 points</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 PointsToScreenPixelsY(Int32 points)
		{
			return Factory.ExecuteInt32MethodGet(this, "PointsToScreenPixelsY", points);
		}

		#endregion

		#pragma warning restore
	}
}


