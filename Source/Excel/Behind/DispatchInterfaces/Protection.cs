﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface Protection 
	/// SupportByVersion Excel, 10,11,12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839872.aspx </remarks>
	[SupportByVersion("Excel", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class Protection : COMObject, NetOffice.ExcelApi.Protection
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
                    _type = typeof(Protection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Protection() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822646.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowFormattingCells
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowFormattingCells");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194806.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowFormattingColumns
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowFormattingColumns");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838830.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowFormattingRows
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowFormattingRows");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835264.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowInsertingColumns
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowInsertingColumns");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197743.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowInsertingRows
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowInsertingRows");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840705.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowInsertingHyperlinks
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowInsertingHyperlinks");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821624.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowDeletingColumns
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowDeletingColumns");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839800.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowDeletingRows
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowDeletingRows");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839266.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowSorting
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowSorting");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839866.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowFiltering
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowFiltering");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197311.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual bool AllowUsingPivotTables
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AllowUsingPivotTables");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834945.aspx </remarks>
		[SupportByVersion("Excel", 10,11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.AllowEditRanges AllowEditRanges
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.AllowEditRanges>(this, "AllowEditRanges", typeof(NetOffice.ExcelApi.AllowEditRanges));
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


