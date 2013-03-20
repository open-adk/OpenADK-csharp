// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EmploymentType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EmploymentType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class EmploymentType : SifEnum
	{
	/// <summary>Machine Operators, hospitality staff, assistants, labourers and related workers ("4")</summary>
	public static readonly EmploymentType C4_MACHINE_OPERATORS_HOSPITALITY_STAFF_ASSISTANTS = new EmploymentType("4");

	/// <summary>Out of employed work for 12 months or more  (If less use previous occupational group.) ("8")</summary>
	public static readonly EmploymentType C8_OUT_OF_EMPLOYED_WORK12_MONTHS_OR_MORE_IF = new EmploymentType("8");

	/// <summary>Other business manages, arts/media/sportspersons and associate professionals ("2")</summary>
	public static readonly EmploymentType C2_OT_BUSINESS_MANAGES_ARTS_MEDIA_SPORTSPERSONS = new EmploymentType("2");

	/// <summary>Unknown ("9")</summary>
	public static readonly EmploymentType C9_UNKNOWN = new EmploymentType("9");

	/// <summary>Senior management in large business organisation, government administration and defence and qualified professionals. ("1")</summary>
	public static readonly EmploymentType C1_SENIOR_MANAGEMENT_IN_LARGE_BUSINESS_ORGANISATION = new EmploymentType("1");

	/// <summary>Tradsesmen/women, clerks and skilled office, sales and service staff ("3")</summary>
	public static readonly EmploymentType C3_TRADSESMEN_WOMEN_CLERKSSKILLED_OFFICE = new EmploymentType("3");

	///<summary>Wrap an arbitrary string value in an EmploymentType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EmploymentType Wrap( String wrappedValue ) {
		return new EmploymentType( wrappedValue );
	}

	private EmploymentType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
