// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Library
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FineType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FineType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class FineType : SifEnum
	{
	/// <summary>Other ("Other")</summary>
	public static readonly FineType OTHER = new FineType("Other");

	/// <summary>Overdue ("Overdue")</summary>
	public static readonly FineType OVERDUE = new FineType("Overdue");

	/// <summary>Refund ("Refund")</summary>
	public static readonly FineType REFUND = new FineType("Refund");

	/// <summary>Damaged ("Damaged")</summary>
	public static readonly FineType DAMAGED = new FineType("Damaged");

	/// <summary>Lost ("Lost")</summary>
	public static readonly FineType LOST = new FineType("Lost");

	///<summary>Wrap an arbitrary string value in a FineType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FineType Wrap( String wrappedValue ) {
		return new FineType( wrappedValue );
	}

	private FineType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
