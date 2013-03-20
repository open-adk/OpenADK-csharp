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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A Course</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Course : SifElement
{
	/// <summary>
	/// Creates an instance of a Course
	/// </summary>
	public Course() : base ( EtranscriptsDTD.COURSE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="markingPeriod">A MarkingPeriod</param>
	///<param name="markingPeriods">A MarkingPeriods</param>
	///
	public Course( MarkingPeriod markingPeriod, MarkingPeriod markingPeriods ) : base( EtranscriptsDTD.COURSE )
	{
		this.MarkingPeriod = markingPeriod;
		this.MarkingPeriods =  new MarkingPeriods( markingPeriods );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Course( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { EtranscriptsDTD.COURSE_MARKINGPERIOD, EtranscriptsDTD.COURSE_MARKINGPERIODS }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolAttendedRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolAttendedRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Reference to the school where the course is being taken (see SchoolAttended); may be omitted if the school is the same as the school of record."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolAttendedRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( EtranscriptsDTD.COURSE_SCHOOLATTENDEDREFID ) ;
		}
		set
		{
			SetFieldValue( EtranscriptsDTD.COURSE_SCHOOLATTENDEDREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolCourseInfoData&gt;</c> element.
	/// </summary>
	/// <value> A SchoolCourseInfoData </value>
	/// <remarks>
	/// <para>To remove the <c>SchoolCourseInfoData</c>, set <c>SchoolCourseInfoData</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SchoolCourseInfoData SchoolCourseInfoData
	{
		get
		{
			return (SchoolCourseInfoData)GetChild( EtranscriptsDTD.COURSE_SCHOOLCOURSEINFODATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_SCHOOLCOURSEINFODATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_SCHOOLCOURSEINFODATA, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;StartDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setStartDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>StartDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetStartDate( string Value ) {
		RemoveChild( EtranscriptsDTD.COURSE_STARTDATE);
		AddChild( EtranscriptsDTD.COURSE_STARTDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Date course section started."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>StartDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType StartDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.COURSE_STARTDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_STARTDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_STARTDATE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;EndDate&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PartialDateType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setEndDate</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>EndDate</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetEndDate( string Value ) {
		RemoveChild( EtranscriptsDTD.COURSE_ENDDATE);
		AddChild( EtranscriptsDTD.COURSE_ENDDATE, new PartialDateType( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> A PartialDateType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Date course section ended, or will end."</para>
	/// <para>To remove the <c>PartialDateType</c>, set <c>EndDate</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PartialDateType EndDate
	{
		get
		{
			return (PartialDateType)GetChild( EtranscriptsDTD.COURSE_ENDDATE);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_ENDDATE);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_ENDDATE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;MarkingPeriod&gt;</c> element.</summary>
	/// <param name="GradeLevelWhenTaken">Student's grade level at time of course.</param>
	/// <param name="CourseCreditsAttempted">Number of course credits attempted.</param>
	/// <param name="CourseCreditsEarned">Number of course credits earned.</param>
	///<remarks>
	/// <para>This form of <c>setMarkingPeriod</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MarkingPeriod</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetMarkingPeriod( GradeLevel GradeLevelWhenTaken, decimal? CourseCreditsAttempted, decimal? CourseCreditsEarned ) {
		RemoveChild( EtranscriptsDTD.COURSE_MARKINGPERIOD);
		AddChild( EtranscriptsDTD.COURSE_MARKINGPERIOD, new MarkingPeriod( GradeLevelWhenTaken, CourseCreditsAttempted, CourseCreditsEarned ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MarkingPeriod&gt;</c> element.
	/// </summary>
	/// <value> A MarkingPeriod </value>
	/// <remarks>
	/// <para>To remove the <c>MarkingPeriod</c>, set <c>MarkingPeriod</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public MarkingPeriod MarkingPeriod
	{
		get
		{
			return (MarkingPeriod)GetChild( EtranscriptsDTD.COURSE_MARKINGPERIOD);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_MARKINGPERIOD);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_MARKINGPERIOD, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;MarkingPeriods&gt;</c> element.</summary>
	/// <param name="MarkingPeriod">A MarkingPeriod</param>
	///<remarks>
	/// <para>This form of <c>setMarkingPeriods</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>MarkingPeriods</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetMarkingPeriods( MarkingPeriod MarkingPeriod ) {
		RemoveChild( EtranscriptsDTD.COURSE_MARKINGPERIODS);
		AddChild( EtranscriptsDTD.COURSE_MARKINGPERIODS, new MarkingPeriods( MarkingPeriod ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MarkingPeriods&gt;</c> element.
	/// </summary>
	/// <value> A MarkingPeriods </value>
	/// <remarks>
	/// <para>To remove the <c>MarkingPeriods</c>, set <c>MarkingPeriods</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public MarkingPeriods MarkingPeriods
	{
		get
		{
			return (MarkingPeriods)GetChild( EtranscriptsDTD.COURSE_MARKINGPERIODS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_MARKINGPERIODS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_MARKINGPERIODS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SectionInfoData&gt;</c> element.
	/// </summary>
	/// <value> A SectionInfoData </value>
	/// <remarks>
	/// <para>To remove the <c>SectionInfoData</c>, set <c>SectionInfoData</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SectionInfoData SectionInfoData
	{
		get
		{
			return (SectionInfoData)GetChild( EtranscriptsDTD.COURSE_SECTIONINFODATA);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_SECTIONINFODATA);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_SECTIONINFODATA, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedElements&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ExtendedElements </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ExtendedElements</c>, set <c>SIF_ExtendedElements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SIF_ExtendedElements SIF_ExtendedElements
	{
		get
		{
			return (SIF_ExtendedElements)GetChild( EtranscriptsDTD.COURSE_SIF_EXTENDEDELEMENTS);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.COURSE_SIF_EXTENDEDELEMENTS);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.COURSE_SIF_EXTENDEDELEMENTS, value );
			}
		}
	}

}}
