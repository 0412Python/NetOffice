﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface IModelChanges 
    /// SupportByVersion Excel, 15, 16
    /// </summary>
    [SupportByVersion("Excel", 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IModelChanges : COMObject, NetOffice.ExcelApi.IModelChanges
    {
        #pragma warning disable

        #region Type Information

        /// <summary>        /// Instance Type
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
                    _type = typeof(IModelChanges);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IModelChanges() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelTableNames TablesAdded
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelTableNames>(this, "TablesAdded", typeof(NetOffice.ExcelApi.ModelTableNames));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelTableNames TablesDeleted
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelTableNames>(this, "TablesDeleted", typeof(NetOffice.ExcelApi.ModelTableNames));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelTableNames TablesModified
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelTableNames>(this, "TablesModified", typeof(NetOffice.ExcelApi.ModelTableNames));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelTableNameChanges TableNamesChanged
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelTableNameChanges>(this, "TableNamesChanged", typeof(NetOffice.ExcelApi.ModelTableNameChanges));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual bool RelationshipChange
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "RelationshipChange");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelColumnNames ColumnsAdded
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelColumnNames>(this, "ColumnsAdded", typeof(NetOffice.ExcelApi.ModelColumnNames));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelColumnNames ColumnsDeleted
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelColumnNames>(this, "ColumnsDeleted", typeof(NetOffice.ExcelApi.ModelColumnNames));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelColumnChanges ColumnsChanged
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelColumnChanges>(this, "ColumnsChanged", typeof(NetOffice.ExcelApi.ModelColumnChanges));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.ModelMeasureNames MeasuresAdded
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ModelMeasureNames>(this, "MeasuresAdded", typeof(NetOffice.ExcelApi.ModelMeasureNames));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual bool UnknownChange
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "UnknownChange");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlModelChangeSource Source
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlModelChangeSource>(this, "Source");
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}

