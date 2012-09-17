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
	/// Defines the set of values that can be specified whenever a MembershipType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a MembershipType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class MembershipType : SifEnum
	{
	/// <summary>Concurrent Enrolment ("03")</summary>
	public static readonly MembershipType C03_CONCURRENT_ENROLMENT = new MembershipType("03");

	/// <summary>Home School ("01")</summary>
	public static readonly MembershipType C01_HOME_SCHOOL = new MembershipType("01");

	/// <summary>Other School ("02")</summary>
	public static readonly MembershipType C02_OT_SCHOOL = new MembershipType("02");

	///<summary>Wrap an arbitrary string value in a MembershipType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static MembershipType Wrap( String wrappedValue ) {
		return new MembershipType( wrappedValue );
	}

	private MembershipType( string enumDefValue ) : base( enumDefValue ) {}
	}
}