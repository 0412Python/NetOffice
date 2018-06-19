﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// DispatchInterface IHTMLLinkElement3 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
 	public class IHTMLLinkElement3 : IHTMLLinkElement2, NetOffice.MSHTMLApi.IHTMLLinkElement3
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
                    _type = typeof(IHTMLLinkElement3);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IHTMLLinkElement3() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string charset
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "charset");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "charset", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string hreflang
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "hreflang");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "hreflang", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}

