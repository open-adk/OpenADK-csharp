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

/// <summary>This object contains the final grade for a student in a section.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Grade : SifElement
{
	/// <summary>
	/// Creates an instance of a Grade
	/// </summary>
	public Grade() : base ( StudentDTD.GRADE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Grade( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Percentage&gt;</c> element.
	/// </summary>
	/// <value> The <c>Percentage</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The grade percentage for this grade (0.00-100.00)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? Percentage
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.GRADE_PERCENTAGE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_PERCENTAGE, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Numeric&gt;</c> element.
	/// </summary>
	/// <value> The <c>Numeric</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The raw numeric value for this grade. If this is provided, the"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? Numeric
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.GRADE_NUMERIC ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_NUMERIC, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OutOf&gt;</c> element.
	/// </summary>
	/// <value> The <c>OutOf</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "his is the high value equivalent to 100% without extra points or extra credit (e.g. if a student received 3.5 out of 4, 4 would be the "</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? OutOf
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.GRADE_OUTOF ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_OUTOF, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Low&gt;</c> element.
	/// </summary>
	/// <value> The <c>Low</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Lowest grade value in the range for the numeric grade."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? Low
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.GRADE_LOW ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_LOW, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;High&gt;</c> element.
	/// </summary>
	/// <value> The <c>High</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Highest grade value in the range for the numeric grade.  NOTE: This could be higher than the"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? High
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.GRADE_HIGH ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_HIGH, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Letter&gt;</c> element.
	/// </summary>
	/// <value> The <c>Letter</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The letter grade value for this grade. If this is provided, the numeric value or percentage value must also be entered in order to provide a numeric value for the grade to be utilized in any computations."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Letter
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.GRADE_LETTER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_LETTER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Narrative&gt;</c> element.
	/// </summary>
	/// <value> The <c>Narrative</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The free form text narrative for this grade."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Narrative
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.GRADE_NARRATIVE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.GRADE_NARRATIVE, new SifString( value ), value );
		}
	}

}}