﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ADODBApi;

namespace NetOffice.ADODBApi.Behind
{
	/// <summary>
	/// DispatchInterface _DynaCollection 
	/// SupportByVersion ADODB, 2.1,2.5
	/// </summary>
	[SupportByVersion("ADODB", 2.1,2.5)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
 	public class _DynaCollection : _Collection, NetOffice.ADODBApi._DynaCollection
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
                    _type = typeof(_DynaCollection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _DynaCollection() : base()
		{

		}

		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="_object">object object</param>
		[SupportByVersion("ADODB", 2.1,2.5)]
		public virtual void Append(object _object)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Append", _object);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.1, 2.5
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("ADODB", 2.1,2.5)]
		public virtual void Delete(object index)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Delete", index);
		}

		#endregion

		#pragma warning restore
	}
}

