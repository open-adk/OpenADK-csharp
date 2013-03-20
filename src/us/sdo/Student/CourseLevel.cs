// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a CourseLevel
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a CourseLevel object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class CourseLevel : SifEnum
	{
	/// <summary>Honors ("H")</summary>
	public static readonly CourseLevel H = new CourseLevel("H");

	/// <summary>General or regular ("G")</summary>
	public static readonly CourseLevel G = new CourseLevel("G");

	/// <summary>Enriched or advanced ("E")</summary>
	public static readonly CourseLevel E = new CourseLevel("E");

	/// <summary>Basic or remedial ("B")</summary>
	public static readonly CourseLevel B = new CourseLevel("B");

	///<summary>Wrap an arbitrary string value in a CourseLevel object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static CourseLevel Wrap( String wrappedValue ) {
		return new CourseLevel( wrappedValue );
	}

	private CourseLevel( string enumDefValue ) : base( enumDefValue ) {}
	}
}
