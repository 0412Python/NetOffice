﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.OfficeApi
{
    /// <summary>
    /// DispatchInterface Shapes 
    /// SupportByVersion Office, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Method, "Item")]
	[TypeId("000C031E-0000-0000-C000-000000000046")]
    public interface Shapes : _IMsoDispObj, IEnumerableProvider<NetOffice.OfficeApi.Shape>
    {
        #region Properties

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        object Parent { get; }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        Int32 Count { get; }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape Background { get; }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape Default { get; }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        NetOffice.OfficeApi.Shape this[object index] { get; }

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoCalloutType type</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddCallout(NetOffice.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoConnectorType type</param>
        /// <param name="beginX">Single beginX</param>
        /// <param name="beginY">Single beginY</param>
        /// <param name="endX">Single endX</param>
        /// <param name="endY">Single endY</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddConnector(NetOffice.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="safeArrayOfPoints">object safeArrayOfPoints</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddCurve(object safeArrayOfPoints);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation orientation</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddLabel(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="beginX">Single beginX</param>
        /// <param name="beginY">Single beginY</param>
        /// <param name="endX">Single endX</param>
        /// <param name="endY">Single endY</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
        /// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">optional Single Width = -1</param>
        /// <param name="height">optional Single Height = -1</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width, object height);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
        /// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        [CustomMethod]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
        /// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">optional Single Width = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="safeArrayOfPoints">object safeArrayOfPoints</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddPolyline(object safeArrayOfPoints);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoAutoShapeType type</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddShape(NetOffice.OfficeApi.Enums.MsoAutoShapeType type, Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="presetTextEffect">NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect</param>
        /// <param name="text">string text</param>
        /// <param name="fontName">string fontName</param>
        /// <param name="fontSize">Single fontSize</param>
        /// <param name="fontBold">NetOffice.OfficeApi.Enums.MsoTriState fontBold</param>
        /// <param name="fontItalic">NetOffice.OfficeApi.Enums.MsoTriState fontItalic</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddTextEffect(NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, NetOffice.OfficeApi.Enums.MsoTriState fontBold, NetOffice.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation orientation</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddTextbox(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.FreeformBuilder BuildFreeform(NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.ShapeRange Range(object index);

        /// <summary>
        /// SupportByVersion Office 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 9, 10, 11, 12, 14, 15, 16)]
        void SelectAll();

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoDiagramType type</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddDiagram(NetOffice.OfficeApi.Enums.MsoDiagramType type, Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddCanvas(Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        /// <param name="height">optional Single Height = -1</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddChart(object type, object left, object top, object width, object height);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddChart();

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddChart(object type);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddChart(object type, object left);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddChart(object type, object left, object top);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddChart(object type, object left, object top, object width);

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="numRows">Int32 numRows</param>
        /// <param name="numColumns">Int32 numColumns</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("Office", 12, 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddTable(Int32 numRows, Int32 numColumns, Single left, Single top, Single width, Single height);

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <param name="layout">NetOffice.OfficeApi.SmartArtLayout layout</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        /// <param name="height">optional Single Height = -1</param>
        [SupportByVersion("Office", 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left, object top, object width, object height);

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <param name="layout">NetOffice.OfficeApi.SmartArtLayout layout</param>
        [CustomMethod]
        [SupportByVersion("Office", 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout);

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <param name="layout">NetOffice.OfficeApi.SmartArtLayout layout</param>
        /// <param name="left">optional Single Left = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left);

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <param name="layout">NetOffice.OfficeApi.SmartArtLayout layout</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left, object top);

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <param name="layout">NetOffice.OfficeApi.SmartArtLayout layout</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 14, 15, 16)]
        NetOffice.OfficeApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left, object top, object width);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        /// <param name="height">optional Single Height = -1</param>
        /// <param name="newLayout">optional bool NewLayout = true</param>
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style, object type, object left, object top, object width, object height, object newLayout);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2();

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style, object type);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style, object type, object left);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style, object type, object left, object top);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style, object type, object left, object top, object width);

        /// <summary>
        /// SupportByVersion Office 15,16
        /// </summary>
        /// <param name="style">optional Int32 Style = -1</param>
        /// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
        /// <param name="left">optional Single Left = -1</param>
        /// <param name="top">optional Single Top = -1</param>
        /// <param name="width">optional Single Width = -1</param>
        /// <param name="height">optional Single Height = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 15, 16)]
        NetOffice.OfficeApi.Shape AddChart2(object style, object type, object left, object top, object width, object height);

        #endregion
    }
}
