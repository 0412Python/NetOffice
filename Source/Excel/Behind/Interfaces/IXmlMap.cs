﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IXmlMap 
	/// SupportByVersion Excel, 11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 11,12,14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class IXmlMap : COMObject, NetOffice.ExcelApi.IXmlMap
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
                    _type = typeof(IXmlMap);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IXmlMap() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual string _Default
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "_Default");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual string Name
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool IsExportable
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IsExportable");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool ShowImportExportValidationErrors
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowImportExportValidationErrors");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowImportExportValidationErrors", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool SaveDataSourceDefinition
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SaveDataSourceDefinition");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SaveDataSourceDefinition", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool AdjustColumnWidth
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AdjustColumnWidth");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AdjustColumnWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool PreserveColumnFilter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "PreserveColumnFilter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "PreserveColumnFilter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool PreserveNumberFormatting
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "PreserveNumberFormatting");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "PreserveNumberFormatting", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual bool AppendOnImport
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AppendOnImport");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AppendOnImport", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual string RootElementName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "RootElementName");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.XmlNamespace RootElementNamespace
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.XmlNamespace>(this, "RootElementNamespace", typeof(NetOffice.ExcelApi.XmlNamespace));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.XmlSchemas Schemas
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.XmlSchemas>(this, "Schemas", typeof(NetOffice.ExcelApi.XmlSchemas));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.XmlDataBinding DataBinding
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.XmlDataBinding>(this, "DataBinding", typeof(NetOffice.ExcelApi.XmlDataBinding));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "WorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual Int32 Delete()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="url">string url</param>
		/// <param name="overwrite">optional object overwrite</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlImportResult Import(string url, object overwrite)
		{
			return InvokerService.InvokeInternal.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "Import", url, overwrite);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="url">string url</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlImportResult Import(string url)
		{
			return InvokerService.InvokeInternal.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "Import", url);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="xmlData">string xmlData</param>
		/// <param name="overwrite">optional object overwrite</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlImportResult ImportXml(string xmlData, object overwrite)
		{
			return InvokerService.InvokeInternal.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "ImportXml", xmlData, overwrite);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="xmlData">string xmlData</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlImportResult ImportXml(string xmlData)
		{
			return InvokerService.InvokeInternal.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "ImportXml", xmlData);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="url">string url</param>
		/// <param name="overwrite">optional object overwrite</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlExportResult Export(string url, object overwrite)
		{
			return InvokerService.InvokeInternal.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlExportResult>(this, "Export", url, overwrite);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="url">string url</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlExportResult Export(string url)
		{
			return InvokerService.InvokeInternal.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlExportResult>(this, "Export", url);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="data">string data</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlXmlExportResult ExportXml(out string data)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			data = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(data);
			object returnItem = Invoker.MethodReturn(this, "ExportXml", paramsArray, modifiers);
			data = paramsArray[0] as string;
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlExportResult)intReturnItem;
		}

		#endregion

		#pragma warning restore
	}
}


