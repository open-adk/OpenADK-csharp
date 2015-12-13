// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever an HomeEnrollmentStatusSif3
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an HomeEnrollmentStatusSif3 object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class HomeEnrollmentStatusSif3 : SifEnum
	{
	/// <summary>Inactive ("Inactive")</summary>
	public static readonly HomeEnrollmentStatusSif3 INACTIVE = new HomeEnrollmentStatusSif3("Inactive");

	/// <summary>Active ("Active")</summary>
	public static readonly HomeEnrollmentStatusSif3 ACTIVE = new HomeEnrollmentStatusSif3("Active");

	/// <summary>Unreported ("Unreported")</summary>
	public static readonly HomeEnrollmentStatusSif3 UNREPORTED = new HomeEnrollmentStatusSif3("Unreported");

	///<summary>Wrap an arbitrary string value in an HomeEnrollmentStatusSif3 object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static HomeEnrollmentStatusSif3 Wrap( String wrappedValue ) {
		return new HomeEnrollmentStatusSif3( wrappedValue );
	}

	private HomeEnrollmentStatusSif3( string enumDefValue ) : base( enumDefValue ) {}
	}
}