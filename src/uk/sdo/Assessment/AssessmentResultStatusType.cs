// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AssessmentResultStatusType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AssessmentResultStatusType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	[Serializable]
	public class AssessmentResultStatusType : SifEnum
	{
	/// <summary>Target ("T")</summary>
	public static readonly AssessmentResultStatusType T_TARGET = new AssessmentResultStatusType("T");

	/// <summary>Provisional (subject to regarding/appeal ("P")</summary>
	public static readonly AssessmentResultStatusType P_PROVISIONAL_SUBJECT_TO_REGARDING = new AssessmentResultStatusType("P");

	/// <summary>Interim ("I")</summary>
	public static readonly AssessmentResultStatusType I_INTERIM = new AssessmentResultStatusType("I");

	/// <summary>Result ("R")</summary>
	public static readonly AssessmentResultStatusType R_RESULT = new AssessmentResultStatusType("R");

	/// <summary>Estimate ("E")</summary>
	public static readonly AssessmentResultStatusType E_ESTIMATE = new AssessmentResultStatusType("E");

	///<summary>Wrap an arbitrary string value in an AssessmentResultStatusType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AssessmentResultStatusType Wrap( String wrappedValue ) {
		return new AssessmentResultStatusType( wrappedValue );
	}

	private AssessmentResultStatusType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
