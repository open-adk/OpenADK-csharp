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
	/// Defines the set of values that can be specified whenever a SafetyTimeType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SafetyTimeType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class SafetyTimeType : SifEnum
	{
	/// <summary>Unknown ("999")</summary>
	public static readonly SafetyTimeType C999 = new SafetyTimeType("999");

	/// <summary>In Transit ("200")</summary>
	public static readonly SafetyTimeType C200 = new SafetyTimeType("200");

	/// <summary>After classes ("150")</summary>
	public static readonly SafetyTimeType C150 = new SafetyTimeType("150");

	/// <summary>During class ("120")</summary>
	public static readonly SafetyTimeType C120 = new SafetyTimeType("120");

	/// <summary>Outside School Hours ("300")</summary>
	public static readonly SafetyTimeType C300 = new SafetyTimeType("300");

	/// <summary>On the way from school ("220")</summary>
	public static readonly SafetyTimeType C220 = new SafetyTimeType("220");

	/// <summary>Other time during school hours ("197")</summary>
	public static readonly SafetyTimeType C197 = new SafetyTimeType("197");

	/// <summary>During lunch/recess ("140")</summary>
	public static readonly SafetyTimeType C140 = new SafetyTimeType("140");

	/// <summary>Before classes ("110")</summary>
	public static readonly SafetyTimeType C110 = new SafetyTimeType("110");

	/// <summary>Nonschool-sponsored activity ("320")</summary>
	public static readonly SafetyTimeType C320 = new SafetyTimeType("320");

	/// <summary>On the way to school ("210")</summary>
	public static readonly SafetyTimeType C210 = new SafetyTimeType("210");

	/// <summary>During passing ("130")</summary>
	public static readonly SafetyTimeType C130 = new SafetyTimeType("130");

	/// <summary>Other ("397")</summary>
	public static readonly SafetyTimeType C397 = new SafetyTimeType("397");

	/// <summary>During School Hours ("100")</summary>
	public static readonly SafetyTimeType C100 = new SafetyTimeType("100");

	/// <summary>School-sponsored activity ("310")</summary>
	public static readonly SafetyTimeType C310 = new SafetyTimeType("310");

	///<summary>Wrap an arbitrary string value in a SafetyTimeType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SafetyTimeType Wrap( String wrappedValue ) {
		return new SafetyTimeType( wrappedValue );
	}

	private SafetyTimeType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
