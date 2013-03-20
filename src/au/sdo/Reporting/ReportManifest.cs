// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.au.Common;
using OpenADK.Library.Infra;

namespace OpenADK.Library.au.Reporting{

/// <summary>A ReportManifest</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class ReportManifest : SifDataObject
{
	/// <summary>
	/// Creates an instance of a ReportManifest
	/// </summary>
	public ReportManifest() : base( Adk.SifVersion, ReportingDTD.REPORTMANIFEST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The unique identifier for this report manifest.</param>
	///<param name="reportAuthorityInfoRefId">ID (GUID) of the authority providing this manifest.</param>
	///<param name="sifVersion">Specifies which SIF Implementation Specification version should be used when returning the report data; wildcards are allowed.  When a wildcard is specified,        the responding agent SHOULD attempt to return the report data in the version specified by SIF_Message/@Version,        if that version matches the wildcard version.  If not, the responding agent can return the data in any version it chooses that matches the wildcard version.</param>
	///<param name="sifMaxBufferSize">Specifies the maximum size of a packet to be returned to the report authority.</param>
	///<param name="reportName">The authority's accepted name for the report.</param>
	///<param name="reportDefinitionSource">Indicates where the report definition can be found.        If Type is Embedded or Base64Binary, this element's value contains the report definition.  If Type is        URL, this element's value is the location of the external definition.  A Type value of SIF_Query        indicates that the SIF_QueryGroup element contains the definition.</param>
	///
	public ReportManifest( string refId, string reportAuthorityInfoRefId, string sifVersion, int? sifMaxBufferSize, string reportName, ReportDefinitionSource reportDefinitionSource ) : base( Adk.SifVersion, ReportingDTD.REPORTMANIFEST )
	{
		this.RefId = refId;
		this.ReportAuthorityInfoRefId = reportAuthorityInfoRefId;
		this.SIF_Version = sifVersion;
		this.SIF_MaxBufferSize = sifMaxBufferSize;
		this.ReportName = reportName;
		this.ReportDefinitionSource = reportDefinitionSource;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ReportManifest( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ReportingDTD.REPORTMANIFEST_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The unique identifier for this report manifest."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTMANIFEST_REFID ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTMANIFEST_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ReportAuthorityInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>ReportAuthorityInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "ID (GUID) of the authority providing this manifest."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string ReportAuthorityInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTMANIFEST_REPORTAUTHORITYINFOREFID ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTMANIFEST_REPORTAUTHORITYINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Version&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Version</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies which SIF Implementation Specification version should be used when returning the report data; wildcards are allowed.  When a wildcard is specified,        the responding agent SHOULD attempt to return the report data in the version specified by SIF_Message/@Version,        if that version matches the wildcard version.  If not, the responding agent can return the data in any version it chooses that matches the wildcard version."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SIF_Version
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTMANIFEST_SIF_VERSION ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTMANIFEST_SIF_VERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_MaxBufferSize&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_MaxBufferSize</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies the maximum size of a packet to be returned to the report authority."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SIF_MaxBufferSize
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( ReportingDTD.REPORTMANIFEST_SIF_MAXBUFFERSIZE ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTMANIFEST_SIF_MAXBUFFERSIZE, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ReceivingAuthority&gt;</c> element.</summary>
	/// <param name="SifRefObject">The name of the object referenced.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ReceivingAuthority&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setReceivingAuthority</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReceivingAuthority</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetReceivingAuthority( ReceivingAuthoritySIF_RefObject SifRefObject, string Value ) {
		RemoveChild( ReportingDTD.REPORTMANIFEST_RECEIVINGAUTHORITY);
		AddChild( ReportingDTD.REPORTMANIFEST_RECEIVINGAUTHORITY, new ReceivingAuthority( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReceivingAuthority&gt;</c> element.
	/// </summary>
	/// <value> A ReceivingAuthority </value>
	/// <remarks>
	/// <para>To remove the <c>ReceivingAuthority</c>, set <c>ReceivingAuthority</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ReceivingAuthority ReceivingAuthority
	{
		get
		{
			return (ReceivingAuthority)GetChild( ReportingDTD.REPORTMANIFEST_RECEIVINGAUTHORITY);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTMANIFEST_RECEIVINGAUTHORITY);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTMANIFEST_RECEIVINGAUTHORITY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportName&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReportName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The authority's accepted name for the report."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string ReportName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTMANIFEST_REPORTNAME ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTMANIFEST_REPORTNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The description for the report."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTMANIFEST_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTMANIFEST_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportingPeriod&gt;</c> element.
	/// </summary>
	/// <value> A ReportingPeriod </value>
	/// <remarks>
	/// <para>To remove the <c>ReportingPeriod</c>, set <c>ReportingPeriod</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ReportingPeriod ReportingPeriod
	{
		get
		{
			return (ReportingPeriod)GetChild( ReportingDTD.REPORTMANIFEST_REPORTINGPERIOD);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTMANIFEST_REPORTINGPERIOD);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTMANIFEST_REPORTINGPERIOD, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ReportDefinitionSource&gt;</c> element.</summary>
	/// <param name="Type">This attribute indicates the source of the report definition.</param>
	/// <param name="QueryLanguage">The vendor-defined query language used in the report definition (e.g. SQL, ExampleObject,        Description, com.vendor.format, etc.).  If the Type attribute is SIF_Query, then QueryLanguage should also be SIF_Query.        If the Type attribute is SIF_ExtendedQuery, then QueryLanguage should also be SIF_ExtendedQuery.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ReportDefinitionSource&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setReportDefinitionSource</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReportDefinitionSource</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetReportDefinitionSource( ReportDefinitionSourceType Type, string QueryLanguage, string Value ) {
		RemoveChild( ReportingDTD.REPORTMANIFEST_REPORTDEFINITIONSOURCE);
		AddChild( ReportingDTD.REPORTMANIFEST_REPORTDEFINITIONSOURCE, new ReportDefinitionSource( Type, QueryLanguage, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportDefinitionSource&gt;</c> element.
	/// </summary>
	/// <value> A ReportDefinitionSource </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Indicates where the report definition can be found.        If Type is Embedded or Base64Binary, this element's value contains the report definition.  If Type is        URL, this element's value is the location of the external definition.  A Type value of SIF_Query        indicates that the SIF_QueryGroup element contains the definition."</para>
	/// <para>To remove the <c>ReportDefinitionSource</c>, set <c>ReportDefinitionSource</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ReportDefinitionSource ReportDefinitionSource
	{
		get
		{
			return (ReportDefinitionSource)GetChild( ReportingDTD.REPORTMANIFEST_REPORTDEFINITIONSOURCE);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTMANIFEST_REPORTDEFINITIONSOURCE);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTMANIFEST_REPORTDEFINITIONSOURCE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ReportFormatList&gt;</c> element.</summary>
	/// <param name="ReportFormat">A third-party format that describes the visual representation of the report data.</param>
	///<remarks>
	/// <para>This form of <c>setReportFormatList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReportFormatList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetReportFormatList( ReportFormat ReportFormat ) {
		RemoveChild( ReportingDTD.REPORTMANIFEST_REPORTFORMATLIST);
		AddChild( ReportingDTD.REPORTMANIFEST_REPORTFORMATLIST, new ReportFormatList( ReportFormat ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportFormatList&gt;</c> element.
	/// </summary>
	/// <value> A ReportFormatList </value>
	/// <remarks>
	/// <para>To remove the <c>ReportFormatList</c>, set <c>ReportFormatList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ReportFormatList ReportFormatList
	{
		get
		{
			return (ReportFormatList)GetChild( ReportingDTD.REPORTMANIFEST_REPORTFORMATLIST);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTMANIFEST_REPORTFORMATLIST);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTMANIFEST_REPORTFORMATLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_QueryGroup&gt;</c> element.</summary>
	/// <param name="SifQuery">A SIF_Query</param>
	///<remarks>
	/// <para>This form of <c>setSIF_QueryGroup</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_QueryGroup</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSIF_QueryGroup( SIF_Query SifQuery ) {
		RemoveChild( ReportingDTD.REPORTMANIFEST_SIF_QUERYGROUP);
		AddChild( ReportingDTD.REPORTMANIFEST_SIF_QUERYGROUP, new SIF_QueryGroup( SifQuery ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_QueryGroup&gt;</c> element.
	/// </summary>
	/// <value> A SIF_QueryGroup </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_QueryGroup</c>, set <c>SIF_QueryGroup</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_QueryGroup SIF_QueryGroup
	{
		get
		{
			return (SIF_QueryGroup)GetChild( ReportingDTD.REPORTMANIFEST_SIF_QUERYGROUP);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTMANIFEST_SIF_QUERYGROUP);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTMANIFEST_SIF_QUERYGROUP, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_ExtendedQuery&gt;</c> element.</summary>
	/// <param name="SifSelect">A SIF_Select</param>
	/// <param name="SifFrom">A SIF_From</param>
	///<remarks>
	/// <para>This form of <c>setSIF_ExtendedQuery</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_ExtendedQuery</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSIF_ExtendedQuery( SIF_Select SifSelect, SIF_From SifFrom ) {
		RemoveChild( ReportingDTD.REPORTMANIFEST_SIF_EXTENDEDQUERY);
		AddChild( ReportingDTD.REPORTMANIFEST_SIF_EXTENDEDQUERY, new SIF_ExtendedQuery( SifSelect, SifFrom ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedQuery&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ExtendedQuery </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Query criteria for extracting the report information if ReportDefinitionSource/@Type          is SIF_ExtendedQuery."</para>
	/// <para>To remove the <c>SIF_ExtendedQuery</c>, set <c>SIF_ExtendedQuery</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_ExtendedQuery SIF_ExtendedQuery
	{
		get
		{
			return (SIF_ExtendedQuery)GetChild( ReportingDTD.REPORTMANIFEST_SIF_EXTENDEDQUERY);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTMANIFEST_SIF_EXTENDEDQUERY);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTMANIFEST_SIF_EXTENDEDQUERY, value );
			}
		}
	}

}}
