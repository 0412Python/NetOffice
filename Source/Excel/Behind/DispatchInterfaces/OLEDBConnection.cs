﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface OLEDBConnection 
	/// SupportByVersion Excel, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840829.aspx </remarks>
	[SupportByVersion("Excel", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class OLEDBConnection : COMObject, NetOffice.ExcelApi.OLEDBConnection
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
                    _type = typeof(OLEDBConnection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public OLEDBConnection() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841170.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837153.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195661.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835908.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		public virtual object ADOConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "ADOConnection");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838635.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool BackgroundQuery
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "BackgroundQuery");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BackgroundQuery", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195827.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual object CommandText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CommandText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "CommandText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196260.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCmdType CommandType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCmdType>(this, "CommandType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "CommandType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193049.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
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
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193348.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool EnableRefresh
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "EnableRefresh");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnableRefresh", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837076.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual object LocalConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "LocalConnection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "LocalConnection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839237.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool MaintainConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "MaintainConnection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "MaintainConnection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821284.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual DateTime RefreshDate
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteDateTimePropertyGet(this, "RefreshDate");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194985.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool Refreshing
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Refreshing");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193523.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool RefreshOnFileOpen
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RefreshOnFileOpen");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshOnFileOpen", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195135.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 RefreshPeriod
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "RefreshPeriod");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshPeriod", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197722.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlRobustConnect RobustConnect
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlRobustConnect>(this, "RobustConnect");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "RobustConnect", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839728.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool SavePassword
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SavePassword");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SavePassword", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822628.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual string SourceConnectionFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceConnectionFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceConnectionFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839944.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual string SourceDataFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceDataFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceDataFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822663.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool OLAP
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "OLAP");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838035.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool UseLocalConnection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "UseLocalConnection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UseLocalConnection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195939.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual Int32 MaxDrillthroughRecords
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "MaxDrillthroughRecords");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "MaxDrillthroughRecords", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196421.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool IsConnected
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IsConnected");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835586.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCredentialsMethod ServerCredentialsMethod
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCredentialsMethod>(this, "ServerCredentialsMethod");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "ServerCredentialsMethod", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834716.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual string ServerSSOApplicationID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ServerSSOApplicationID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ServerSSOApplicationID", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840011.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool AlwaysUseConnectionFile
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AlwaysUseConnectionFile");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AlwaysUseConnectionFile", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194502.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool ServerFillColor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ServerFillColor");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ServerFillColor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821322.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool ServerFontStyle
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ServerFontStyle");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ServerFontStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839791.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool ServerNumberFormat
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ServerNumberFormat");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ServerNumberFormat", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840163.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool ServerTextColor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ServerTextColor");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ServerTextColor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff820726.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool RetrieveInOfficeUILang
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RetrieveInOfficeUILang");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RetrieveInOfficeUILang", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836792.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual NetOffice.ExcelApi.CalculatedMembers CalculatedMembers
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.CalculatedMembers>(this, "CalculatedMembers", typeof(NetOffice.ExcelApi.CalculatedMembers));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822379.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual Int32 LocaleID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "LocaleID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "LocaleID", value);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195519.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void CancelRefresh()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "CancelRefresh");
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841267.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void MakeConnection()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "MakeConnection");
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838765.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void Refresh()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Refresh");
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839809.aspx </remarks>
		/// <param name="oDCFileName">string oDCFileName</param>
		/// <param name="description">optional object description</param>
		/// <param name="keywords">optional object keywords</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void SaveAsODC(string oDCFileName, object description, object keywords)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SaveAsODC", oDCFileName, description, keywords);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839809.aspx </remarks>
		/// <param name="oDCFileName">string oDCFileName</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void SaveAsODC(string oDCFileName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SaveAsODC", oDCFileName);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839809.aspx </remarks>
		/// <param name="oDCFileName">string oDCFileName</param>
		/// <param name="description">optional object description</param>
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual void SaveAsODC(string oDCFileName, object description)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SaveAsODC", oDCFileName, description);
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836197.aspx </remarks>
		[SupportByVersion("Excel", 14,15,16)]
		public virtual void Reconnect()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Reconnect");
		}

		#endregion

		#pragma warning restore
	}
}


