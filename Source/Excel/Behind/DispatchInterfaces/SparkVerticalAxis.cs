﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface SparkVerticalAxis 
	/// SupportByVersion Excel, 14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195497.aspx </remarks>
	[SupportByVersion("Excel", 14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class SparkVerticalAxis : COMObject, NetOffice.ExcelApi.SparkVerticalAxis
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
                    _type = typeof(SparkVerticalAxis);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public SparkVerticalAxis() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841141.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
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
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836156.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
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
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837439.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840224.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlSparkScale MinScaleType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlSparkScale>(this, "MinScaleType");
			}
			set
			{
				Factory.ExecuteEnumPropertySet(this, "MinScaleType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194837.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual object CustomMinScaleValue
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "CustomMinScaleValue");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "CustomMinScaleValue", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194274.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlSparkScale MaxScaleType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlSparkScale>(this, "MaxScaleType");
			}
			set
			{
				Factory.ExecuteEnumPropertySet(this, "MaxScaleType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821960.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual object CustomMaxScaleValue
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "CustomMaxScaleValue");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "CustomMaxScaleValue", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


