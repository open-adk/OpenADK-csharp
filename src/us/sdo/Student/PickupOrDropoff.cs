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
	/// Defines the set of values that can be specified whenever a PickupOrDropoff
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a PickupOrDropoff object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class PickupOrDropoff : SifEnum
	{
	/// <summary>A Dropoff ("Dropoff")</summary>
	public static readonly PickupOrDropoff DROPOFF = new PickupOrDropoff("Dropoff");

	/// <summary>A NA ("NA")</summary>
	public static readonly PickupOrDropoff NA = new PickupOrDropoff("NA");

	/// <summary>A Pickup ("Pickup")</summary>
	public static readonly PickupOrDropoff PICKUP = new PickupOrDropoff("Pickup");

	/// <summary>A Both ("Both")</summary>
	public static readonly PickupOrDropoff BOTH = new PickupOrDropoff("Both");

	///<summary>Wrap an arbitrary string value in a PickupOrDropoff object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static PickupOrDropoff Wrap( String wrappedValue ) {
		return new PickupOrDropoff( wrappedValue );
	}

	private PickupOrDropoff( string enumDefValue ) : base( enumDefValue ) {}
	}
}
