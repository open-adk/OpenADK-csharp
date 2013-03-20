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
	/// Defines the set of values that can be specified whenever a FullTimeStatus
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FullTimeStatus object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class FullTimeStatus : SifEnum
	{
	/// <summary>Full-time ("0843")</summary>
	public static readonly FullTimeStatus FULLTIME = new FullTimeStatus("0843");

	/// <summary>Part-time ("0844")</summary>
	public static readonly FullTimeStatus PARTTIME = new FullTimeStatus("0844");

	///<summary>Wrap an arbitrary string value in a FullTimeStatus object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FullTimeStatus Wrap( String wrappedValue ) {
		return new FullTimeStatus( wrappedValue );
	}

	private FullTimeStatus( string enumDefValue ) : base( enumDefValue ) {}
	}
}
