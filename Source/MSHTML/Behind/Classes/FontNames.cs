﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSHTMLApi.Behind
{
    /// <summary>
    /// CoClass FontNames 
    /// SupportByVersion MSHTML, 4
    /// </summary>
    [SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsCoClass)]
 	public class FontNames : IFontNames, NetOffice.MSHTMLApi.FontNames
    {
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;

        #endregion

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

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(FontNames);
                return _type;
            }
        }
        
        #endregion
        		
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public FontNames() : base()
		{

		}

		#endregion

		#region Static CoClass Methods
		#endregion

		#region Events

		#endregion
       

		#pragma warning restore
	}
}

