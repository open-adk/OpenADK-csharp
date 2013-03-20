// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Sif3assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SourceObjectRefObjEnum
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SourceObjectRefObjEnum object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class SourceObjectRefObjEnum : SifEnum
	{
	/// <summary>Lesson ("Lesson")</summary>
	public static readonly SourceObjectRefObjEnum LESSON = new SourceObjectRefObjEnum("Lesson");

	/// <summary>Activity ("Activity")</summary>
	public static readonly SourceObjectRefObjEnum ACTIVITY = new SourceObjectRefObjEnum("Activity");

	/// <summary>LearningResource ("LearningResource")</summary>
	public static readonly SourceObjectRefObjEnum LEARNINGRESOURCE = new SourceObjectRefObjEnum("LearningResource");

	/// <summary>Assessment ("Assessment")</summary>
	public static readonly SourceObjectRefObjEnum ASSESSMENT = new SourceObjectRefObjEnum("Assessment");

	///<summary>Wrap an arbitrary string value in a SourceObjectRefObjEnum object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SourceObjectRefObjEnum Wrap( String wrappedValue ) {
		return new SourceObjectRefObjEnum( wrappedValue );
	}

	private SourceObjectRefObjEnum( string enumDefValue ) : base( enumDefValue ) {}
	}
}
