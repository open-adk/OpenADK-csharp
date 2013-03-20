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

namespace OpenADK.Library.us.Assessment{

/// <summary>A ScoreReporting</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ScoreReporting : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ScoreReporting
	/// </summary>
	public ScoreReporting() : base ( AssessmentDTD.SCOREREPORTING ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="scoreMetric">The metric or scale used to report the scores.</param>
	///
	public ScoreReporting( AssessmentReportingMethod scoreMetric ) : base( AssessmentDTD.SCOREREPORTING )
	{
		this.SetScoreMetric( scoreMetric );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScoreReporting( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SCOREREPORTING_SCOREMETRIC }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>ScoreMetric</c> attribute.
	/// </summary>
	/// <value> The <c>ScoreMetric</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The metric or scale used to report the scores."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreMetric
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.SCOREREPORTING_SCOREMETRIC );
		}
		set
		{
			SetField( AssessmentDTD.SCOREREPORTING_SCOREMETRIC, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>ScoreMetric</c> attribute.
	/// </summary>
	/// <param name="val">A AssessmentReportingMethod object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The metric or scale used to report the scores."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScoreMetric( AssessmentReportingMethod val )
	{
		SetField( AssessmentDTD.SCOREREPORTING_SCOREMETRIC, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Minimum&gt;</c> element.
	/// </summary>
	/// <value> The <c>Minimum</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lowest possible score value."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Minimum
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SCOREREPORTING_MINIMUM ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SCOREREPORTING_MINIMUM, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Maximum&gt;</c> element.
	/// </summary>
	/// <value> The <c>Maximum</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Highest possible score value"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Maximum
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SCOREREPORTING_MAXIMUM ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SCOREREPORTING_MAXIMUM, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreTableRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoreTableRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This identifies the specific score table used by this subtest to generate the score if applicable. Note that the score metric in this object should match the �to score metric� in the score table."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreTableRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SCOREREPORTING_SCORETABLEREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SCOREREPORTING_SCORETABLEREFID, new SifString( value ), value );
		}
	}

}}
