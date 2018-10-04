﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ADODBApi;

namespace NetOffice.ADODBApi.Behind
{
	/// <summary>
	/// DispatchInterface Fields_Deprecated 
	/// SupportByVersion ADODB, 2.5
	/// </summary>
	public class Fields_Deprecated : Fields20_Deprecated, NetOffice.ADODBApi.Fields_Deprecated
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
                    _type = typeof(Fields_Deprecated);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Fields_Deprecated() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("ADODB", 2.5)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.ADODBApi.Field_Deprecated this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ADODBApi.Field_Deprecated>(this, "Item", typeof(NetOffice.ADODBApi.Field_Deprecated), index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Refresh()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Refresh");
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="type">NetOffice.ADODBApi.Enums.DataTypeEnum type</param>
		/// <param name="definedSize">optional Int32 DefinedSize = 0</param>
		/// <param name="attrib">optional NetOffice.ADODBApi.Enums.FieldAttributeEnum Attrib = -1</param>
		/// <param name="fieldValue">optional object fieldValue</param>
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, object definedSize, object attrib, object fieldValue)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Append", new object[]{ name, type, definedSize, attrib, fieldValue });
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="type">NetOffice.ADODBApi.Enums.DataTypeEnum type</param>
		[CustomMethod]
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Append", name, type);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="type">NetOffice.ADODBApi.Enums.DataTypeEnum type</param>
		/// <param name="definedSize">optional Int32 DefinedSize = 0</param>
		[CustomMethod]
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, object definedSize)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Append", name, type, definedSize);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="type">NetOffice.ADODBApi.Enums.DataTypeEnum type</param>
		/// <param name="definedSize">optional Int32 DefinedSize = 0</param>
		/// <param name="attrib">optional NetOffice.ADODBApi.Enums.FieldAttributeEnum Attrib = -1</param>
		[CustomMethod]
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Append(string name, NetOffice.ADODBApi.Enums.DataTypeEnum type, object definedSize, object attrib)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Append", name, type, definedSize, attrib);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Update()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Update");
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		/// <param name="resyncValues">optional NetOffice.ADODBApi.Enums.ResyncEnum ResyncValues = 2</param>
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Resync(object resyncValues)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Resync", resyncValues);
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		[CustomMethod]
		[SupportByVersion("ADODB", 2.5)]
		public virtual void Resync()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Resync");
		}

		/// <summary>
		/// SupportByVersion ADODB 2.5
		/// </summary>
		[SupportByVersion("ADODB", 2.5)]
		public virtual void CancelUpdate()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "CancelUpdate");
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ADODBApi.Field_Deprecated>

        ICOMObject IEnumerableProvider<NetOffice.ADODBApi.Field_Deprecated>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsMethod(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ADODBApi.Field_Deprecated>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, true);
        }

        #endregion

        #region IEnumerable<NetOffice.ADODBApi.Field_Deprecated>

        /// <summary>
        /// SupportByVersion ADODB, 2.5
        /// </summary>
        [SupportByVersion("ADODB", 2.5)]
        public virtual IEnumerator<NetOffice.ADODBApi.Field_Deprecated> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ADODBApi.Field_Deprecated item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion ADODB, 2.5
        /// </summary>
        [SupportByVersion("ADODB", 2.5)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

