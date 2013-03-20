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

namespace OpenADK.Library.uk.School{

/// <summary>A Lesson</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Lesson : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Lesson
	/// </summary>
	public Lesson() : base( Adk.SifVersion, SchoolDTD.LESSON ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="ttDayId">A TTDayId</param>
	///<param name="periodIndex">Index of period this lesson/meeting starts</param>
	///<param name="type">Lesson/meeting type The value here determines whether a TeachingGroupID or an NTCode is required</param>
	///
	public Lesson( string refId, string ttDayId, int? periodIndex, LessonType type ) : base( Adk.SifVersion, SchoolDTD.LESSON )
	{
		this.RefId = refId;
		this.TTDayId = ttDayId;
		this.PeriodIndex = periodIndex;
		this.SetType( type );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Lesson( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SchoolDTD.LESSON_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.LESSON_REFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TTDayId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TTDayId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string TTDayId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.LESSON_TTDAYID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_TTDAYID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PeriodIndex&gt;</c> element.
	/// </summary>
	/// <value> The <c>PeriodIndex</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Index of period this lesson/meeting starts"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? PeriodIndex
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( SchoolDTD.LESSON_PERIODINDEX ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_PERIODINDEX, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <value> The <c>Type</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lesson/meeting type The value here determines whether a TeachingGroupID or an NTCode is required"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( SchoolDTD.LESSON_TYPE );
		}
		set
		{
			SetField( SchoolDTD.LESSON_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <param name="val">A LessonType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lesson/meeting type The value here determines whether a TeachingGroupID or an NTCode is required"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetType( LessonType val )
	{
		SetField( SchoolDTD.LESSON_TYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Length&gt;</c> element.
	/// </summary>
	/// <value> The <c>Length</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Length of lesson in periods (1=single, 2=double, etc). Can omit if just a single."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? Length
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( SchoolDTD.LESSON_LENGTH ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_LENGTH, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TeachingGroupRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TeachingGroupRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The Teaching Group being taught (may not be one if Type != "T") (see TeachingGroup)"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string TeachingGroupRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.LESSON_TEACHINGGROUPREFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_TEACHINGGROUPREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NTCodeRef&gt;</c> element.
	/// </summary>
	/// <value> The <c>NTCodeRef</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "If there is no TeachingGroupRefID (see NTCode)"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string NTCodeRef
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.LESSON_NTCODEREF ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_NTCODEREF, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;TeacherList&gt;</c> element.</summary>
	/// <param name="TtTeacherRefId">A TTTeacherRefId</param>
	///<remarks>
	/// <para>This form of <c>setTeacherList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>TeacherList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetTeacherList( TTTeacherRefId TtTeacherRefId ) {
		RemoveChild( SchoolDTD.LESSON_TEACHERLIST);
		AddChild( SchoolDTD.LESSON_TEACHERLIST, new TeacherIDList( TtTeacherRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TeacherList&gt;</c> element.
	/// </summary>
	/// <value> A TeacherIDList </value>
	/// <remarks>
	/// <para>To remove the <c>TeacherIDList</c>, set <c>TeacherList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public TeacherIDList TeacherList
	{
		get
		{
			return (TeacherIDList)GetChild( SchoolDTD.LESSON_TEACHERLIST);
		}
		set
		{
			RemoveChild( SchoolDTD.LESSON_TEACHERLIST);
			if( value != null)
			{
				AddChild( SchoolDTD.LESSON_TEACHERLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TTRoomRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>TTRoomRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The room (or location) where this lesson is taking place (see TTRoom)"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string TTRoomRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.LESSON_TTROOMREFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.LESSON_TTROOMREFID, new SifString( value ), value );
		}
	}

}}
