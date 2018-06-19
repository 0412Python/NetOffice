﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.PowerPointApi;

namespace NetOffice.PowerPointApi.Behind
{
	/// <summary>
	/// DispatchInterface PPDropDown 
	/// SupportByVersion PowerPoint, 9
	/// </summary>
	[SupportByVersion("PowerPoint", 9)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class PPDropDown : PPControl, NetOffice.PowerPointApi.PPDropDown
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
                    _type = typeof(PPDropDown);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public PPDropDown() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPStrings Strings
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.PPStrings>(this, "Strings", typeof(NetOffice.PowerPointApi.PPStrings));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		public Int32 FocusItem
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "FocusItem");			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "FocusItem", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByVersion("PowerPoint", 9)]
		public string OnSelectionChange
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "OnSelectionChange");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "OnSelectionChange", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


