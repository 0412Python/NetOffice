﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface PivotFilter 
	/// SupportByVersion Excel, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822821.aspx </remarks>
	[SupportByVersion("Excel", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class PivotFilter : COMObject, NetOffice.ExcelApi.PivotFilter
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
                    _type = typeof(PivotFilter);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public PivotFilter() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822802.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838039.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836832.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821914.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 Order
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Order");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Order", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193663.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlPivotFilterType FilterType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPivotFilterType>(this, "FilterType");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194300.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual string Name
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Name");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838165.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual string Description
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Description");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837083.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool Active
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Active");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822831.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotField PivotField
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.PivotField>(this, "PivotField", typeof(NetOffice.ExcelApi.PivotField));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196303.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotField DataField
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.PivotField>(this, "DataField", typeof(NetOffice.ExcelApi.PivotField));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194018.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.CubeField DataCubeField
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.CubeField>(this, "DataCubeField", typeof(NetOffice.ExcelApi.CubeField));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196136.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual object Value1
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "Value1");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197247.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual object Value2
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "Value2");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822856.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.PivotField MemberPropertyField
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.PivotField>(this, "MemberPropertyField", typeof(NetOffice.ExcelApi.PivotField));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836189.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool IsMemberPropertyFilter
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "IsMemberPropertyFilter");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229114.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool WholeDayFilter
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "WholeDayFilter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "WholeDayFilter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlTimeMoving MovingPeriod
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTimeMoving>(this, "MovingPeriod");
			}
			set
			{
				Factory.ExecuteEnumPropertySet(this, "MovingPeriod", value);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197130.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void Delete()
		{
			 Factory.ExecuteMethod(this, "Delete");
		}

		#endregion

		#pragma warning restore
	}
}


