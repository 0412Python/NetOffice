﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// Interface IElementBehaviorFactory 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsInterface)]
 	public class IElementBehaviorFactory : COMObject, NetOffice.MSHTMLApi.IElementBehaviorFactory
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
                    _type = typeof(IElementBehaviorFactory);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IElementBehaviorFactory() : base()
		{

		}

		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="bstrBehavior">string bstrBehavior</param>
		/// <param name="bstrBehaviorUrl">string bstrBehaviorUrl</param>
		/// <param name="pSite">NetOffice.MSHTMLApi.IElementBehaviorSite pSite</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IElementBehavior FindBehavior(string bstrBehavior, string bstrBehaviorUrl, NetOffice.MSHTMLApi.IElementBehaviorSite pSite)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IElementBehavior>(this, "FindBehavior", typeof(NetOffice.MSHTMLApi.IElementBehavior), bstrBehavior, bstrBehaviorUrl, pSite);
		}

		#endregion

		#pragma warning restore
	}
}


