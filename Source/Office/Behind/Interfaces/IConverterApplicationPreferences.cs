﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// Interface IConverterApplicationPreferences 
    /// SupportByVersion Office, 14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862807.aspx </remarks>
    [SupportByVersion("Office", 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IConverterApplicationPreferences : COMObject, NetOffice.OfficeApi.IConverterApplicationPreferences
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
                    _type = typeof(IConverterApplicationPreferences);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IConverterApplicationPreferences() : base()
		{

		}

		#endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864148.aspx </remarks>
        /// <param name="plcid">Int32 plcid</param>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 HrGetLcid(out Int32 plcid)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
            plcid = 0;
            object[] paramsArray = Invoker.ValidateParamsArray(plcid);
            object returnItem = Invoker.MethodReturn(this, "HrGetLcid", paramsArray, modifiers);
            plcid = (Int32)paramsArray[0];
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860588.aspx </remarks>
        /// <param name="phwnd">Int32 phwnd</param>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 HrGetHwnd(out Int32 phwnd)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
            phwnd = 0;
            object[] paramsArray = Invoker.ValidateParamsArray(phwnd);
            object returnItem = Invoker.MethodReturn(this, "HrGetHwnd", paramsArray, modifiers);
            phwnd = (Int32)paramsArray[0];
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864579.aspx </remarks>
        /// <param name="pbstrApplication">string pbstrApplication</param>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 HrGetApplication(out string pbstrApplication)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
            pbstrApplication = string.Empty;
            object[] paramsArray = Invoker.ValidateParamsArray(pbstrApplication);
            object returnItem = Invoker.MethodReturn(this, "HrGetApplication", paramsArray, modifiers);
            pbstrApplication = paramsArray[0] as string;
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862557.aspx </remarks>
        /// <param name="pFormat">Int32 pFormat</param>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 HrCheckFormat(out Int32 pFormat)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
            pFormat = 0;
            object[] paramsArray = Invoker.ValidateParamsArray(pFormat);
            object returnItem = Invoker.MethodReturn(this, "HrCheckFormat", paramsArray, modifiers);
            pFormat = (Int32)paramsArray[0];
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        #endregion

        #pragma warning restore
    }
}
