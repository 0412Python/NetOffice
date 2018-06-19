﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.MSComctlLibApi;

namespace NetOffice.MSComctlLibApi.Behind
{
	/// <summary>
	/// DispatchInterface INodes 
	/// SupportByVersion MSComctlLib, 6
	/// </summary>	[SupportByVersion("MSComctlLib", 6)]
	[EntityType(EntityType.IsDispatchInterface), BaseType, Enumerator(Enumerator.Reference, EnumeratorInvoke.Method), HasIndexProperty(IndexInvoke.Property, "Item")]
	public class INodes : COMObject, NetOffice.MSComctlLibApi.INodes
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
                    _type = typeof(INodes);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public INodes() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
		public virtual Int16 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt16PropertyGet(this, "Count");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Count", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual NetOffice.MSComctlLibApi.INode get_ControlDefault(object index)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSComctlLibApi.INode>(this, "ControlDefault", typeof(NetOffice.MSComctlLibApi.INode), index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual void set_ControlDefault(object index, NetOffice.MSComctlLibApi.INode value)
		{
			InvokerService.InvokeInternal.ExecutePropertySet(this, "ControlDefault", index, value);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Alias for get_ControlDefault
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6), Redirect("get_ControlDefault")]
		public virtual NetOffice.MSComctlLibApi.INode ControlDefault(object index)
		{
			return get_ControlDefault(index);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		[BaseResult]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.MSComctlLibApi.INode this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.MSComctlLibApi.INode>(this, "Item", index);
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "Item", value, index);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="relative">optional object relative</param>
		/// <param name="relationship">optional object relationship</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="image">optional object image</param>
		/// <param name="selectedImage">optional object selectedImage</param>
		[SupportByVersion("MSComctlLib", 6)]
		[BaseResult]
		public virtual NetOffice.MSComctlLibApi.INode Add(object relative, object relationship, object key, object text, object image, object selectedImage)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add", new object[]{ relative, relationship, key, text, image, selectedImage });
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		[CustomMethod]
		[BaseResult]
		[SupportByVersion("MSComctlLib", 6)]
		public virtual NetOffice.MSComctlLibApi.INode Add()
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add");
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="relative">optional object relative</param>
		[CustomMethod]
		[BaseResult]
		[SupportByVersion("MSComctlLib", 6)]
		public virtual NetOffice.MSComctlLibApi.INode Add(object relative)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add", relative);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="relative">optional object relative</param>
		/// <param name="relationship">optional object relationship</param>
		[CustomMethod]
		[BaseResult]
		[SupportByVersion("MSComctlLib", 6)]
		public virtual NetOffice.MSComctlLibApi.INode Add(object relative, object relationship)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add", relative, relationship);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="relative">optional object relative</param>
		/// <param name="relationship">optional object relationship</param>
		/// <param name="key">optional object key</param>
		[CustomMethod]
		[BaseResult]
		[SupportByVersion("MSComctlLib", 6)]
		public virtual NetOffice.MSComctlLibApi.INode Add(object relative, object relationship, object key)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add", relative, relationship, key);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="relative">optional object relative</param>
		/// <param name="relationship">optional object relationship</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		[CustomMethod]
		[BaseResult]
		[SupportByVersion("MSComctlLib", 6)]
		public virtual NetOffice.MSComctlLibApi.INode Add(object relative, object relationship, object key, object text)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add", relative, relationship, key, text);
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="relative">optional object relative</param>
		/// <param name="relationship">optional object relationship</param>
		/// <param name="key">optional object key</param>
		/// <param name="text">optional object text</param>
		/// <param name="image">optional object image</param>
		[CustomMethod]
		[BaseResult]
		[SupportByVersion("MSComctlLib", 6)]
		public virtual NetOffice.MSComctlLibApi.INode Add(object relative, object relationship, object key, object text, object image)
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSComctlLibApi.INode>(this, "Add", new object[]{ relative, relationship, key, text, image });
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		[SupportByVersion("MSComctlLib", 6)]
		public virtual void Clear()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Clear");
		}

		/// <summary>
		/// SupportByVersion MSComctlLib 6
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSComctlLib", 6)]
		public virtual void Remove(object index)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Remove", index);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.MSComctlLibApi.INode>

        ICOMObject IEnumerableProvider<NetOffice.MSComctlLibApi.INode>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsMethod(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.MSComctlLibApi.INode>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.MSComctlLibApi.INode>

        /// <summary>
        /// SupportByVersion MSComctlLib, 6
        /// </summary>
        [SupportByVersion("MSComctlLib", 6)]
        public virtual IEnumerator<NetOffice.MSComctlLibApi.INode> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.MSComctlLibApi.INode item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion MSComctlLib, 6
        /// </summary>
        [SupportByVersion("MSComctlLib", 6)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsMethod(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

