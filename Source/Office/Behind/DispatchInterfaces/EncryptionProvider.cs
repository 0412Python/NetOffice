﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface EncryptionProvider 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863389.aspx </remarks>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class EncryptionProvider : COMObject, NetOffice.OfficeApi.EncryptionProvider
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
                    _type = typeof(EncryptionProvider);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public EncryptionProvider() : base()
		{

		}

		#endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864896.aspx </remarks>
        /// <param name="encprovdet">NetOffice.OfficeApi.Enums.EncryptionProviderDetail encprovdet</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public object GetProviderDetail(NetOffice.OfficeApi.Enums.EncryptionProviderDetail encprovdet)
        {
            return Factory.ExecuteVariantMethodGet(this, "GetProviderDetail", encprovdet);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864027.aspx </remarks>
        /// <param name="parentWindow">object parentWindow</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public Int32 NewSession(object parentWindow)
        {
            return Factory.ExecuteInt32MethodGet(this, "NewSession", parentWindow);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864627.aspx </remarks>
        /// <param name="parentWindow">object parentWindow</param>
        /// <param name="encryptionData">object encryptionData</param>
        /// <param name="permissionsMask">UIntPtr permissionsMask</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public Int32 Authenticate(object parentWindow, object encryptionData, out UIntPtr permissionsMask)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false, false, true);
            permissionsMask = UIntPtr.Zero;
            object[] paramsArray = Invoker.ValidateParamsArray(parentWindow, encryptionData, permissionsMask);
            object returnItem = Invoker.MethodReturn(this, "Authenticate", paramsArray, modifiers);
            permissionsMask = (UIntPtr)paramsArray[2];
            return NetRuntimeSystem.Convert.ToInt32(returnItem);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864902.aspx </remarks>
        /// <param name="sessionHandle">Int32 sessionHandle</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public Int32 CloneSession(Int32 sessionHandle)
        {
            return Factory.ExecuteInt32MethodGet(this, "CloneSession", sessionHandle);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864652.aspx </remarks>
        /// <param name="sessionHandle">Int32 sessionHandle</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void EndSession(Int32 sessionHandle)
        {
            Factory.ExecuteMethod(this, "EndSession", sessionHandle);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862766.aspx </remarks>
        /// <param name="sessionHandle">Int32 sessionHandle</param>
        /// <param name="encryptionData">object encryptionData</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public Int32 Save(Int32 sessionHandle, object encryptionData)
        {
            return Factory.ExecuteInt32MethodGet(this, "Save", sessionHandle, encryptionData);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861839.aspx </remarks>
        /// <param name="sessionHandle">Int32 sessionHandle</param>
        /// <param name="streamName">string streamName</param>
        /// <param name="unencryptedStream">object unencryptedStream</param>
        /// <param name="encryptedStream">object encryptedStream</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void EncryptStream(Int32 sessionHandle, string streamName, object unencryptedStream, object encryptedStream)
        {
            Factory.ExecuteMethod(this, "EncryptStream", sessionHandle, streamName, unencryptedStream, encryptedStream);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864940.aspx </remarks>
        /// <param name="sessionHandle">Int32 sessionHandle</param>
        /// <param name="streamName">string streamName</param>
        /// <param name="encryptedStream">object encryptedStream</param>
        /// <param name="unencryptedStream">object unencryptedStream</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void DecryptStream(Int32 sessionHandle, string streamName, object encryptedStream, object unencryptedStream)
        {
            Factory.ExecuteMethod(this, "DecryptStream", sessionHandle, streamName, encryptedStream, unencryptedStream);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863378.aspx </remarks>
        /// <param name="sessionHandle">Int32 sessionHandle</param>
        /// <param name="parentWindow">object parentWindow</param>
        /// <param name="readOnly">bool readOnly</param>
        /// <param name="remove">bool remove</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void ShowSettings(Int32 sessionHandle, object parentWindow, bool readOnly, out bool remove)
        {
            ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false, false, false, true);
            remove = false;
            object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle, parentWindow, readOnly, remove);
            Invoker.Method(this, "ShowSettings", paramsArray, modifiers);
            remove = (bool)paramsArray[3];
        }

        #endregion

        #pragma warning restore
    }
}
