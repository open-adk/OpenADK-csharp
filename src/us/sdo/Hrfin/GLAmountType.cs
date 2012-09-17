// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Hrfin
{
	///<summary>
	/// Defines the set of values that can be specified whenever a GLAmountType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a GLAmountType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class GLAmountType : SifEnum
	{
	/// <summary>Auxiliary services of non-profit private and parochial schools ("11")</summary>
	public static readonly GLAmountType AUXILIARY_SERVICES = new GLAmountType("11");

	/// <summary>Education Planning ("3")</summary>
	public static readonly GLAmountType EDUCATION_PLANNING = new GLAmountType("3");

	/// <summary>Curriculum Development and Improvement ("2")</summary>
	public static readonly GLAmountType CURRICULUM_DEVELOPMENT = new GLAmountType("2");

	/// <summary>Other ("12")</summary>
	public static readonly GLAmountType OTHER = new GLAmountType("12");

	/// <summary>Continuing Education ("6")</summary>
	public static readonly GLAmountType CONTINUING_EDUCATION = new GLAmountType("6");

	/// <summary>Medical Assistance ("10")</summary>
	public static readonly GLAmountType MEDICAL_ASSISTANCE = new GLAmountType("10");

	/// <summary>Instructional Materials ("4")</summary>
	public static readonly GLAmountType INSTRUCTIONAL_MATERIALS = new GLAmountType("4");

	/// <summary>Pupil Personnel ("7")</summary>
	public static readonly GLAmountType PUPIL_PERSONNEL = new GLAmountType("7");

	/// <summary>Administration ("1")</summary>
	public static readonly GLAmountType ADMINISTRATION = new GLAmountType("1");

	/// <summary>State and Federal Liaison ("8")</summary>
	public static readonly GLAmountType STATE_AND_FEDERAL_LIAISON = new GLAmountType("8");

	/// <summary>Management ("5")</summary>
	public static readonly GLAmountType MANAGEMENT = new GLAmountType("5");

	/// <summary>Federal ("9")</summary>
	public static readonly GLAmountType FEDERAL = new GLAmountType("9");

	///<summary>Wrap an arbitrary string value in a GLAmountType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static GLAmountType Wrap( String wrappedValue ) {
		return new GLAmountType( wrappedValue );
	}

	private GLAmountType( string enumDefValue ) : base( enumDefValue ) {}
	}
}