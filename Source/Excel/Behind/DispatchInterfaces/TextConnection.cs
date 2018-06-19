﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface TextConnection 
	/// SupportByVersion Excel, 15, 16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228015.aspx </remarks>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class TextConnection : COMObject, NetOffice.ExcelApi.TextConnection
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
                    _type = typeof(TextConnection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public TextConnection() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231033.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229623.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230690.aspx </remarks>
		[SupportByVersion("Excel", 15, 16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj232073.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object Connection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Connection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Connection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231385.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileHeaderRow
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileHeaderRow");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileHeaderRow", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj232041.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object TextFileColumnDataTypes
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "TextFileColumnDataTypes");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "TextFileColumnDataTypes", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj229203.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileCommaDelimiter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileCommaDelimiter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileCommaDelimiter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231987.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileConsecutiveDelimiter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileConsecutiveDelimiter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileConsecutiveDelimiter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231768.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual string TextFileDecimalSeparator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextFileDecimalSeparator");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileDecimalSeparator", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228271.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object TextFileFixedColumnWidths
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "TextFileFixedColumnWidths");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "TextFileFixedColumnWidths", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227943.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual string TextFileOtherDelimiter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextFileOtherDelimiter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileOtherDelimiter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227899.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlTextParsingType TextFileParseType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextParsingType>(this, "TextFileParseType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFileParseType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228433.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlPlatform TextFilePlatform
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPlatform>(this, "TextFilePlatform");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFilePlatform", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227545.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFilePromptOnRefresh
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFilePromptOnRefresh");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFilePromptOnRefresh", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227524.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileSemicolonDelimiter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileSemicolonDelimiter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileSemicolonDelimiter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230951.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileSpaceDelimiter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileSpaceDelimiter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileSpaceDelimiter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231782.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual Int32 TextFileStartRow
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "TextFileStartRow");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileStartRow", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227355.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileTabDelimiter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileTabDelimiter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileTabDelimiter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228275.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlTextQualifier TextFileTextQualifier
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextQualifier>(this, "TextFileTextQualifier");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFileTextQualifier", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj227507.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual string TextFileThousandsSeparator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextFileThousandsSeparator");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileThousandsSeparator", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230624.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual bool TextFileTrailingMinusNumbers
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileTrailingMinusNumbers");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileTrailingMinusNumbers", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231092.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlTextVisualLayoutType TextFileVisualLayout
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextVisualLayoutType>(this, "TextFileVisualLayout");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFileVisualLayout", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


