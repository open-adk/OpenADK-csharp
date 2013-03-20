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
using OpenADK.Library.us.Common;
using OpenADK.Library.Infra;

namespace OpenADK.Library.us.Reporting{

/// <summary>Identifies the manifest for the report and characteristics of the submission. This element is a conditional element. This element is included or the ReportData element is included but never both at the same time within an instance of this object. See examples of the usage of the object below.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ReportInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ReportInfo
	/// </summary>
	public ReportInfo() : base ( ReportingDTD.REPORTINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="reportManifestRefId">The report manifest corresponding to this report.</param>
	///<param name="calculationDate">The date on which the report was calculated.</param>
	///<param name="submissionNumber">A number that identifies the submission; beginning at 1 and incremented each time a submission is done for a particular report; used to indicate resubmission(s).</param>
	///<param name="submissionReason">Reason for the report submission.</param>
	///
	public ReportInfo( string reportManifestRefId, DateTime? calculationDate, int? submissionNumber, SubmissionReason submissionReason ) : base( ReportingDTD.REPORTINFO )
	{
		this.ReportManifestRefId = reportManifestRefId;
		this.CalculationDate = calculationDate;
		this.SubmissionNumber = submissionNumber;
		this.SetSubmissionReason( submissionReason );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ReportInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ReportingDTD.REPORTINFO_REPORTMANIFESTREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>ReportManifestRefId</c> attribute.
	/// </summary>
	/// <value> The <c>ReportManifestRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The report manifest corresponding to this report."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string ReportManifestRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTINFO_REPORTMANIFESTREFID ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTINFO_REPORTMANIFESTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CalculationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>CalculationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date on which the report was calculated."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? CalculationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( ReportingDTD.REPORTINFO_CALCULATIONDATE ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTINFO_CALCULATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubmissionNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>SubmissionNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A number that identifies the submission; beginning at 1 and incremented each time a submission is done for a particular report; used to indicate resubmission(s)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public int? SubmissionNumber
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( ReportingDTD.REPORTINFO_SUBMISSIONNUMBER ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTINFO_SUBMISSIONNUMBER, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubmissionReason&gt;</c> element.
	/// </summary>
	/// <value> The <c>SubmissionReason</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reason for the report submission."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string SubmissionReason
	{
		get
		{ 
			return GetFieldValue( ReportingDTD.REPORTINFO_SUBMISSIONREASON );
		}
		set
		{
			SetField( ReportingDTD.REPORTINFO_SUBMISSIONREASON, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;SubmissionReason&gt;</c> element.
	/// </summary>
	/// <param name="val">A SubmissionReason object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reason for the report submission."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetSubmissionReason( SubmissionReason val )
	{
		SetField( ReportingDTD.REPORTINFO_SUBMISSIONREASON, val );
	}

	///<summary>Sets the value of the <c>&lt;ReportSubmitterInfo&gt;</c> element.</summary>
	/// <param name="SubmitterName">Name of the report submitter.This is a descriptive string that names the entity submitting the SIF_ReportObject to the report authority.  It could be the name of an agency, a district, a school, the SIF_SourceId of the submitting agent, or any other string that a report authority could use to identify the submitter of a report.  This element may be present regardless of the presence of the SifRefIdType and SifRefId elements.  When those elements are used, it is recommended that collector agents reproduce the name of the LEA or school here.</param>
	///<remarks>
	/// <para>This form of <c>setReportSubmitterInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ReportSubmitterInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetReportSubmitterInfo( string SubmitterName ) {
		RemoveChild( ReportingDTD.REPORTINFO_REPORTSUBMITTERINFO);
		AddChild( ReportingDTD.REPORTINFO_REPORTSUBMITTERINFO, new ReportSubmitterInfo( SubmitterName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportSubmitterInfo&gt;</c> element.
	/// </summary>
	/// <value> A ReportSubmitterInfo </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Identifies the submitter of the report.This element is conditional depending on the context in which the SIF_ReportObject is used.  It must be present in the ReportInfo element when a SIF_ReportObject is sent to a report authority in a SIF_Event message.  However, its presence is optional in SIF_ReportObject packets delivered to report authorities in SIF_Response messages."</para>
	/// <para>To remove the <c>ReportSubmitterInfo</c>, set <c>ReportSubmitterInfo</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public ReportSubmitterInfo ReportSubmitterInfo
	{
		get
		{
			return (ReportSubmitterInfo)GetChild( ReportingDTD.REPORTINFO_REPORTSUBMITTERINFO);
		}
		set
		{
			RemoveChild( ReportingDTD.REPORTINFO_REPORTSUBMITTERINFO);
			if( value != null)
			{
				AddChild( ReportingDTD.REPORTINFO_REPORTSUBMITTERINFO, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ReportingDTD.REPORTINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( ReportingDTD.REPORTINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

}}
