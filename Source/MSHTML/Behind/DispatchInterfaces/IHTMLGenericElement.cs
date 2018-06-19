﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// DispatchInterface IHTMLGenericElement 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class IHTMLGenericElement : COMObject, NetOffice.MSHTMLApi.IHTMLGenericElement
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
                    _type = typeof(IHTMLGenericElement);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IHTMLGenericElement() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual object recordset
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "recordset");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dataMember">string dataMember</param>
		/// <param name="hierarchy">optional object hierarchy</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual object namedRecordset(string dataMember, object hierarchy)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "namedRecordset", dataMember, hierarchy);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dataMember">string dataMember</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object namedRecordset(string dataMember)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "namedRecordset", dataMember);
		}

		#endregion

		#pragma warning restore
	}
}

