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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learner{

/// <summary>This container reflects key enrolment data for the current or current main (home) school or establishment linked to a learner.  An agent may operate more efficiently if the data represented here is sufficient.  If the agent requires more data or needs to retrieve enrolment data from all enroled schools then it may still need to request some or all LearnerSchoolEnrolment objects for the learner.  This information should always be specified when there is an active enrolment.  It must also accurately reflect the data in the represented LearnerSchoolEnrolment object and generate change events for this object when change events are detected for LearnerSchoolEnrolment.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class CurrentSchoolEnrolment : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a CurrentSchoolEnrolment
	/// </summary>
	public CurrentSchoolEnrolment() : base ( LearnerDTD.CURRENTSCHOOLENROLMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learnerSchoolEnrolmentRefId">The ID (GUID) of the LearnerSchoolEnrolment record associated with this learner that is also designated as the current or current main enrolment.</param>
	///<param name="laId">The DfES assigned number for the LA in which the learner is currently enroled with respect to their current or current main (home) school. CBDS: 100013, 100032, 100162, 900009</param>
	///<param name="establishmentId">The DfES assigned number for the school or establishment in which the learner is currently enroled with respect to their current or current main (home) school. CBDS: 100004, 100163, 900010</param>
	///<param name="ncYearGroup">The current or most recent National Curriculum Year Group of the learner in the LA. </param>
	///
	public CurrentSchoolEnrolment( string learnerSchoolEnrolmentRefId, string laId, string establishmentId, NCYearGroup ncYearGroup ) : base( LearnerDTD.CURRENTSCHOOLENROLMENT )
	{
		this.LearnerSchoolEnrolmentRefId = learnerSchoolEnrolmentRefId;
		this.LAId = laId;
		this.EstablishmentId = establishmentId;
		this.NCYearGroup = ncYearGroup;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CurrentSchoolEnrolment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearnerDTD.CURRENTSCHOOLENROLMENT_LEARNERSCHOOLENROLMENTREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>LearnerSchoolEnrolmentRefId</c> attribute.
	/// </summary>
	/// <value> The <c>LearnerSchoolEnrolmentRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the LearnerSchoolEnrolment record associated with this learner that is also designated as the current or current main enrolment."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LearnerSchoolEnrolmentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.CURRENTSCHOOLENROLMENT_LEARNERSCHOOLENROLMENTREFID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.CURRENTSCHOOLENROLMENT_LEARNERSCHOOLENROLMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LAId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LAId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The DfES assigned number for the LA in which the learner is currently enroled with respect to their current or current main (home) school. CBDS: 100013, 100032, 100162, 900009"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LAId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.CURRENTSCHOOLENROLMENT_LAID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.CURRENTSCHOOLENROLMENT_LAID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EstablishmentId&gt;</c> element.
	/// </summary>
	/// <value> The <c>EstablishmentId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The DfES assigned number for the school or establishment in which the learner is currently enroled with respect to their current or current main (home) school. CBDS: 100004, 100163, 900010"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string EstablishmentId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.CURRENTSCHOOLENROLMENT_ESTABLISHMENTID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.CURRENTSCHOOLENROLMENT_ESTABLISHMENTID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;NCYearGroup&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;NCYearGroup&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setNCYearGroup</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>NCYearGroup</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetNCYearGroup( NCYear Value ) {
		RemoveChild( LearnerDTD.CURRENTSCHOOLENROLMENT_NCYEARGROUP);
		AddChild( LearnerDTD.CURRENTSCHOOLENROLMENT_NCYEARGROUP, new NCYearGroup( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NCYearGroup&gt;</c> element.
	/// </summary>
	/// <value> A NCYearGroup </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The current or most recent National Curriculum Year Group of the learner in the LA. "</para>
	/// <para>To remove the <c>NCYearGroup</c>, set <c>NCYearGroup</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public NCYearGroup NCYearGroup
	{
		get
		{
			return (NCYearGroup)GetChild( LearnerDTD.CURRENTSCHOOLENROLMENT_NCYEARGROUP);
		}
		set
		{
			RemoveChild( LearnerDTD.CURRENTSCHOOLENROLMENT_NCYEARGROUP);
			if( value != null)
			{
				AddChild( LearnerDTD.CURRENTSCHOOLENROLMENT_NCYEARGROUP, value );
			}
		}
	}

}}