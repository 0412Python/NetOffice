﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IValidation 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class IValidation : COMObject, NetOffice.ExcelApi.IValidation
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
                    _type = typeof(IValidation);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IValidation() : base()
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
		public virtual Int32 AlertStyle
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "AlertStyle");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool IgnoreBlank
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "IgnoreBlank");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "IgnoreBlank", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 IMEMode
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "IMEMode");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "IMEMode", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool InCellDropdown
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "InCellDropdown");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "InCellDropdown", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string ErrorMessage
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "ErrorMessage");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ErrorMessage", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string ErrorTitle
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "ErrorTitle");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ErrorTitle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string InputMessage
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "InputMessage");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "InputMessage", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string InputTitle
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "InputTitle");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "InputTitle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string Formula1
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Formula1");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual string Formula2
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Formula2");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Operator
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Operator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool ShowError
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "ShowError");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ShowError", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool ShowInput
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "ShowInput");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ShowInput", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Type
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Type");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual bool Value
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "Value");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlDVType type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		/// <param name="_operator">optional object operator</param>
		/// <param name="formula1">optional object formula1</param>
		/// <param name="formula2">optional object formula2</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Add(NetOffice.ExcelApi.Enums.XlDVType type, object alertStyle, object _operator, object formula1, object formula2)
		{
			return Factory.ExecuteInt32MethodGet(this, "Add", new object[]{ type, alertStyle, _operator, formula1, formula2 });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlDVType type</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Add(NetOffice.ExcelApi.Enums.XlDVType type)
		{
			return Factory.ExecuteInt32MethodGet(this, "Add", type);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlDVType type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Add(NetOffice.ExcelApi.Enums.XlDVType type, object alertStyle)
		{
			return Factory.ExecuteInt32MethodGet(this, "Add", type, alertStyle);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlDVType type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		/// <param name="_operator">optional object operator</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Add(NetOffice.ExcelApi.Enums.XlDVType type, object alertStyle, object _operator)
		{
			return Factory.ExecuteInt32MethodGet(this, "Add", type, alertStyle, _operator);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlDVType type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		/// <param name="_operator">optional object operator</param>
		/// <param name="formula1">optional object formula1</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Add(NetOffice.ExcelApi.Enums.XlDVType type, object alertStyle, object _operator, object formula1)
		{
			return Factory.ExecuteInt32MethodGet(this, "Add", type, alertStyle, _operator, formula1);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Delete()
		{
			return Factory.ExecuteInt32MethodGet(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">optional object type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		/// <param name="_operator">optional object operator</param>
		/// <param name="formula1">optional object formula1</param>
		/// <param name="formula2">optional object formula2</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Modify(object type, object alertStyle, object _operator, object formula1, object formula2)
		{
			return Factory.ExecuteInt32MethodGet(this, "Modify", new object[]{ type, alertStyle, _operator, formula1, formula2 });
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Modify()
		{
			return Factory.ExecuteInt32MethodGet(this, "Modify");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">optional object type</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Modify(object type)
		{
			return Factory.ExecuteInt32MethodGet(this, "Modify", type);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">optional object type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Modify(object type, object alertStyle)
		{
			return Factory.ExecuteInt32MethodGet(this, "Modify", type, alertStyle);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">optional object type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		/// <param name="_operator">optional object operator</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Modify(object type, object alertStyle, object _operator)
		{
			return Factory.ExecuteInt32MethodGet(this, "Modify", type, alertStyle, _operator);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="type">optional object type</param>
		/// <param name="alertStyle">optional object alertStyle</param>
		/// <param name="_operator">optional object operator</param>
		/// <param name="formula1">optional object formula1</param>
		[CustomMethod]
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public virtual Int32 Modify(object type, object alertStyle, object _operator, object formula1)
		{
			return Factory.ExecuteInt32MethodGet(this, "Modify", type, alertStyle, _operator, formula1);
		}

		#endregion

		#pragma warning restore
	}
}


