﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// Interface CategoryCollection 
    /// SupportByVersion Office, 15, 16
    /// </summary>
    [SupportByVersion("Office", 15, 16)]
    [EntityType(EntityType.IsInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Custom), HasIndexProperty(IndexInvoke.Property, "_Default")]
    public class CategoryCollection : COMObject, NetOffice.OfficeApi.CategoryCollection
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
                    _type = typeof(CategoryCollection);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public CategoryCollection() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        public Int32 Count
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Count");
            }
        }

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 15, 16), ProxyResult]
        public object Application
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Application");
            }
        }

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        public Int32 Creator
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Office", 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        public NetOffice.OfficeApi.IMsoCategory this[object index]
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoCategory>(this, "_Default", typeof(NetOffice.OfficeApi.IMsoCategory), index);
            }
        }

        #endregion

        #region Methods

        #endregion

        #region IEnumerableProvider<NetOffice.OfficeApi.IMsoCategory>

        ICOMObject IEnumerableProvider<NetOffice.OfficeApi.IMsoCategory>.GetComObjectEnumerator(ICOMObject parent)
        {
            return this;
        }

        IEnumerable IEnumerableProvider<NetOffice.OfficeApi.IMsoCategory>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.IMsoCategory item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable<NetOffice.OfficeApi.IMsoCategory> Member

        /// <summary>
        /// SupportByVersion Office, 15, 16
        /// This is a custom enumerator from NetOffice
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        [CustomEnumerator]
        public IEnumerator<NetOffice.OfficeApi.IMsoCategory> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.IMsoCategory item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// SupportByVersion Office, 15, 16
        /// This is a custom enumerator from NetOffice
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i + 1];

            foreach (object item in enumeratorObjects)
                yield return item;
        }

        #endregion

        #pragma warning restore
    }
}
