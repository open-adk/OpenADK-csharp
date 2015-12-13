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
	/// Defines the set of values that can be specified whenever an AssociationType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AssociationType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class AssociationType : SifEnum
	{
	/// <summary>Indicates that the two items are enemies and should not appear on the same test together. ("enemy")</summary>
	public static readonly AssociationType ENEMY = new AssociationType("enemy");

	/// <summary>Indicates that the two items were derived from one another (such as language translation). ("derivative")</summary>
	public static readonly AssociationType DERIVATIVE = new AssociationType("derivative");

	///<summary>Wrap an arbitrary string value in an AssociationType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AssociationType Wrap( String wrappedValue ) {
		return new AssociationType( wrappedValue );
	}

	private AssociationType( string enumDefValue ) : base( enumDefValue ) {}
	}
}