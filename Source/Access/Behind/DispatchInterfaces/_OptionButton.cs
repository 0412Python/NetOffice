﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.AccessApi;

namespace NetOffice.AccessApi.Behind
{
	/// <summary>
	/// DispatchInterface _OptionButton 
	/// SupportByVersion Access, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Access", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
 	public class _OptionButton : NetOffice.OfficeApi.Behind.IAccessible, NetOffice.AccessApi._OptionButton
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
                    _type = typeof(_OptionButton);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _OptionButton() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197332.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual NetOffice.AccessApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Application>(this, "Application", typeof(NetOffice.AccessApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194405.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836239.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual object OldValue
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "OldValue");
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197621.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual NetOffice.AccessApi.Properties Properties
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Properties>(this, "Properties", typeof(NetOffice.AccessApi.Properties));
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193965.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual NetOffice.AccessApi.Children Controls
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.AccessApi.Children>(this, "Controls", typeof(NetOffice.AccessApi.Children));
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196172.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual object Value
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Value");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Value", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197700.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string EventProcPrefix
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "EventProcPrefix");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EventProcPrefix", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string _Name
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "_Name");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "_Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845278.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte ControlType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "ControlType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ControlType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191808.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int32 OptionValue
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "OptionValue");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OptionValue", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821001.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string ControlSource
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ControlSource");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ControlSource", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197038.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string DefaultValue
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "DefaultValue");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DefaultValue", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845357.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string ValidationRule
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ValidationRule");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ValidationRule", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193477.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string ValidationText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ValidationText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ValidationText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834796.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string StatusBarText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "StatusBarText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "StatusBarText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836714.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool Visible
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Visible");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Visible", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835362.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte DisplayWhen
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "DisplayWhen");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DisplayWhen", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837306.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool Enabled
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Enabled");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Enabled", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835329.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool Locked
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Locked");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Locked", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836623.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool TripleState
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TripleState");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TripleState", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822429.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool TabStop
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TabStop");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TabStop", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821432.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 TabIndex
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "TabIndex");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TabIndex", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823063.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool HideDuplicates
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "HideDuplicates");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HideDuplicates", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822707.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 Left
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Left");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Left", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845907.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 Top
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Top");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Top", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822091.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 Width
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Width");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Width", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834795.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 Height
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Height");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Height", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192438.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte SpecialEffect
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "SpecialEffect");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SpecialEffect", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193162.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte BorderStyle
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "BorderStyle");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196086.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte OldBorderStyle
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "OldBorderStyle");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OldBorderStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834467.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte BorderWidth
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "BorderWidth");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual byte BorderLineStyle
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "BorderLineStyle");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderLineStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837229.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int32 BorderColor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "BorderColor");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderColor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195856.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string ShortcutMenuBar
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ShortcutMenuBar");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShortcutMenuBar", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193481.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string ControlTipText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ControlTipText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ControlTipText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845055.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int32 HelpContextId
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "HelpContextId");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HelpContextId", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837169.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 ColumnWidth
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "ColumnWidth");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ColumnWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194615.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 ColumnOrder
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "ColumnOrder");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ColumnOrder", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197726.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool ColumnHidden
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ColumnHidden");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ColumnHidden", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192264.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool AutoLabel
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AutoLabel");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AutoLabel", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823108.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool AddColon
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AddColon");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AddColon", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192929.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 LabelX
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "LabelX");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "LabelX", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835962.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 LabelY
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "LabelY");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "LabelY", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192842.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual byte LabelAlign
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "LabelAlign");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "LabelAlign", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845174.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual Int16 Section
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Section");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Section", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string ControlName
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ControlName");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ControlName", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845458.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string Tag
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Tag");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Tag", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836080.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual bool IsVisible
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IsVisible");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "IsVisible", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836343.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual bool InSelection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "InSelection");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "InSelection", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197069.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string BeforeUpdate
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "BeforeUpdate");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BeforeUpdate", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff844782.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string AfterUpdate
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "AfterUpdate");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AfterUpdate", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835933.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnEnter
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnEnter");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnEnter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821399.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnExit
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnExit");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnExit", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff844851.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnGotFocus
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnGotFocus");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnGotFocus", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835705.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnLostFocus
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnLostFocus");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnLostFocus", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195881.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnClick
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnClick");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnClick", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193182.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnDblClick
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnDblClick");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnDblClick", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff844933.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnMouseDown
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnMouseDown");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnMouseDown", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193486.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnMouseMove
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnMouseMove");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnMouseMove", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197330.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnMouseUp
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnMouseUp");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnMouseUp", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194948.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnKeyDown
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnKeyDown");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnKeyDown", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197965.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnKeyUp
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnKeyUp");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnKeyUp", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195430.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual string OnKeyPress
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnKeyPress");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnKeyPress", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193953.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual byte ReadingOrder
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "ReadingOrder");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ReadingOrder", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197105.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
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
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string BeforeUpdateMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "BeforeUpdateMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BeforeUpdateMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string AfterUpdateMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "AfterUpdateMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AfterUpdateMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnEnterMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnEnterMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnEnterMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnExitMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnExitMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnExitMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnGotFocusMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnGotFocusMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnGotFocusMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnLostFocusMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnLostFocusMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnLostFocusMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnClickMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnClickMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnClickMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnDblClickMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnDblClickMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnDblClickMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnMouseDownMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnMouseDownMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnMouseDownMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnMouseMoveMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnMouseMoveMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnMouseMoveMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnMouseUpMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnMouseUpMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnMouseUpMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnKeyDownMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnKeyDownMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnKeyDownMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnKeyUpMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnKeyUpMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnKeyUpMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Access", 12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual string OnKeyPressMacro
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnKeyPressMacro");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnKeyPressMacro", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192640.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual NetOffice.AccessApi.Enums.AcLayoutType Layout
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.AccessApi.Enums.AcLayoutType>(this, "Layout");
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194654.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual Int16 LeftPadding
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "LeftPadding");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "LeftPadding", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191898.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual Int16 TopPadding
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "TopPadding");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TopPadding", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836001.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual Int16 RightPadding
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "RightPadding");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RightPadding", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193240.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual Int16 BottomPadding
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "BottomPadding");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BottomPadding", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff844961.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineStyleLeft
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineStyleLeft");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineStyleLeft", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835374.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineStyleTop
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineStyleTop");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineStyleTop", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197997.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineStyleRight
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineStyleRight");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineStyleRight", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196737.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineStyleBottom
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineStyleBottom");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineStyleBottom", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192242.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineWidthLeft
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineWidthLeft");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineWidthLeft", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845703.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineWidthTop
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineWidthTop");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineWidthTop", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191827.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineWidthRight
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineWidthRight");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineWidthRight", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821786.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual byte GridlineWidthBottom
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBytePropertyGet(this, "GridlineWidthBottom");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineWidthBottom", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191803.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual Int32 GridlineColor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "GridlineColor");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineColor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845583.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual NetOffice.AccessApi.Enums.AcHorizontalAnchor HorizontalAnchor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.AccessApi.Enums.AcHorizontalAnchor>(this, "HorizontalAnchor");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "HorizontalAnchor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845852.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual NetOffice.AccessApi.Enums.AcVerticalAnchor VerticalAnchor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.AccessApi.Enums.AcVerticalAnchor>(this, "VerticalAnchor");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "VerticalAnchor", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835371.aspx </remarks>
		[SupportByVersion("Access", 12,14,15,16)]
		public virtual Int32 LayoutID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "LayoutID");
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845648.aspx </remarks>
		[SupportByVersion("Access", 14,15,16)]
		public virtual Int32 BorderThemeColorIndex
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "BorderThemeColorIndex");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderThemeColorIndex", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197398.aspx </remarks>
		[SupportByVersion("Access", 14,15,16)]
		public virtual Single BorderTint
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "BorderTint");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderTint", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821788.aspx </remarks>
		[SupportByVersion("Access", 14,15,16)]
		public virtual Single BorderShade
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "BorderShade");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BorderShade", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194330.aspx </remarks>
		[SupportByVersion("Access", 14,15,16)]
		public virtual Int32 GridlineThemeColorIndex
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "GridlineThemeColorIndex");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineThemeColorIndex", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196752.aspx </remarks>
		[SupportByVersion("Access", 14,15,16)]
		public virtual Single GridlineTint
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "GridlineTint");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineTint", value);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194410.aspx </remarks>
		[SupportByVersion("Access", 14,15,16)]
		public virtual Single GridlineShade
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteSinglePropertyGet(this, "GridlineShade");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "GridlineShade", value);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195456.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual void SizeToFit()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SizeToFit");
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821714.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual void Requery()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Requery");
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual void Goto()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Goto");
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834351.aspx </remarks>
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual void SetFocus()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "SetFocus");
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="bstrExpr">string bstrExpr</param>
		/// <param name="ppsa">optional object[] ppsa</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual object _Evaluate(string bstrExpr, object[] ppsa)
		{
            object[] paramsArray = Invoker.ValidateParamsArray(bstrExpr, (object)ppsa);
            object returnItem = Invoker.MethodReturn(this, "_Evaluate", paramsArray);
            if ((null != returnItem) && (returnItem is MarshalByRefObject))
            {
                ICOMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem, true);
                return newObject;
            }
            else
            {
                return returnItem;
            }
        }

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="bstrExpr">string bstrExpr</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Access", 9,10,11,12,14,15,16)]
		public virtual object _Evaluate(string bstrExpr)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "_Evaluate", bstrExpr);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834397.aspx </remarks>
		/// <param name="left">object left</param>
		/// <param name="top">optional object top</param>
		/// <param name="width">optional object width</param>
		/// <param name="height">optional object height</param>
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public virtual void Move(object left, object top, object width, object height)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Move", left, top, width, height);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834397.aspx </remarks>
		/// <param name="left">object left</param>
		[CustomMethod]
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public virtual void Move(object left)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Move", left);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834397.aspx </remarks>
		/// <param name="left">object left</param>
		/// <param name="top">optional object top</param>
		[CustomMethod]
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public virtual void Move(object left, object top)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Move", left, top);
		}

		/// <summary>
		/// SupportByVersion Access 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834397.aspx </remarks>
		/// <param name="left">object left</param>
		/// <param name="top">optional object top</param>
		/// <param name="width">optional object width</param>
		[CustomMethod]
		[SupportByVersion("Access", 10,11,12,14,15,16)]
		public virtual void Move(object left, object top, object width)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Move", left, top, width);
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("Access", 11,12,14,15,16)]
		public virtual bool IsMemberSafe(Int32 dispid)
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "IsMemberSafe", dispid);
		}

		#endregion

		#pragma warning restore
	}
}


