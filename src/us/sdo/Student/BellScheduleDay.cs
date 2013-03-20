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

namespace OpenADK.Library.us.Student{

/// <summary>A BellScheduleDay</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class BellScheduleDay : SifElement
{
	/// <summary>
	/// Creates an instance of a BellScheduleDay
	/// </summary>
	public BellScheduleDay() : base ( StudentDTD.BELLSCHEDULEDAY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="bellScheduleRefId">The GUID of a bell schedule to be utilized for the calendar date.</param>
	///<param name="timetableDayIdentifier">The unique identifier of a timetable day to be utilized for the calendar date (from the list of timetable days defined for the calendar in the referenced BellSchedule object).</param>
	///
	public BellScheduleDay( string bellScheduleRefId, string timetableDayIdentifier ) : base( StudentDTD.BELLSCHEDULEDAY )
	{
		this.BellScheduleRefId = bellScheduleRefId;
		this.TimetableDayIdentifier = timetableDayIdentifier;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected BellScheduleDay( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.BELLSCHEDULEDAY_BELLSCHEDULEREFID, StudentDTD.BELLSCHEDULEDAY_TIMETABLEDAYIDENTIFIER }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BellScheduleRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>BellScheduleRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The GUID of a bell schedule to be utilized for the calendar date."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string BellScheduleRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.BELLSCHEDULEDAY_BELLSCHEDULEREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLSCHEDULEDAY_BELLSCHEDULEREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimetableDayIdentifier&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimetableDayIdentifier</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The unique identifier of a timetable day to be utilized for the calendar date (from the list of timetable days defined for the calendar in the referenced BellSchedule object)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string TimetableDayIdentifier
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.BELLSCHEDULEDAY_TIMETABLEDAYIDENTIFIER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLSCHEDULEDAY_TIMETABLEDAYIDENTIFIER, new SifString( value ), value );
		}
	}

}}
