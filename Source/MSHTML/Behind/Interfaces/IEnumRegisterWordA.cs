﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// Interface IEnumRegisterWordA 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsInterface)]
 	public class IEnumRegisterWordA : COMObject, NetOffice.MSHTMLApi.IEnumRegisterWordA
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
                    _type = typeof(IEnumRegisterWordA);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IEnumRegisterWordA() : base()
		{

		}

        #endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion MSHTML 4
        /// </summary>
        /// <param name="ppEnum">NetOffice.MSHTMLApi.IEnumRegisterWordA ppEnum</param>
        [SupportByVersion("MSHTML", 4)]
        public virtual Int32 Clone(out NetOffice.MSHTMLApi.IEnumRegisterWordA ppEnum)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
            ppEnum = null;
            object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
            object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray, modifiers);
            if (paramsArray[0] is MarshalByRefObject)
                ppEnum = Factory.CreateKnownObjectFromComProxy<NetOffice.MSHTMLApi.IEnumRegisterWordA>(this, paramsArray[0], typeof(NetOffice.MSHTMLApi.IEnumRegisterWordA));
            else
                ppEnum = null;
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="ulCount">Int32 ulCount</param>
		/// <param name="rgRegisterWord">__MIDL___MIDL_itf_mshtml_0001_0042_0001 rgRegisterWord</param>
		/// <param name="pcFetched">Int32 pcFetched</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 Next(Int32 ulCount, out __MIDL___MIDL_itf_mshtml_0001_0042_0001 rgRegisterWord, out Int32 pcFetched)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			rgRegisterWord = new NetOffice.MSHTMLApi.__MIDL___MIDL_itf_mshtml_0001_0042_0001();
			pcFetched = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(ulCount, rgRegisterWord, pcFetched);
			object returnItem = Invoker.MethodReturn(this, "Next", paramsArray, modifiers);
			rgRegisterWord = (__MIDL___MIDL_itf_mshtml_0001_0042_0001)paramsArray[1];
			pcFetched = (Int32)paramsArray[2];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 reset()
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "reset");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="ulCount">Int32 ulCount</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 Skip(Int32 ulCount)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Skip", ulCount);
		}

		#endregion

		#pragma warning restore
	}
}

