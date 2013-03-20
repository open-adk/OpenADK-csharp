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

/// <summary>An entry for each unique timetable day</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class TimetableDay : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a TimetableDay
	/// </summary>
	public TimetableDay() : base ( StudentDTD.TIMETABLEDAY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="identifier">The unique identifier for the timetable day for this school calendar.</param>
	///
	public TimetableDay( string identifier ) : base( StudentDTD.TIMETABLEDAY )
	{
		this.Identifier = identifier;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TimetableDay( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.TIMETABLEDAY_IDENTIFIER }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Identifier&gt;</c> element.
	/// </summary>
	/// <value> The <c>Identifier</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The unique identifier for the timetable day for this school calendar."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Identifier
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.TIMETABLEDAY_IDENTIFIER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.TIMETABLEDAY_IDENTIFIER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The name of the timetable day."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.TIMETABLEDAY_NAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.TIMETABLEDAY_NAME, new SifString( value ), value );
		}
	}

}}
