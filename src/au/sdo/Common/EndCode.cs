// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EndCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EndCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class EndCode : SifEnum
	{
	/// <summary>Year 8 ("8")</summary>
	public static readonly EndCode C8_YEAR_8 = new EndCode("8");

	/// <summary>Year 3 ("3")</summary>
	public static readonly EndCode C3_YEAR_3 = new EndCode("3");

	/// <summary>Year 11 ("11")</summary>
	public static readonly EndCode C11_YEAR_11 = new EndCode("11");

	/// <summary>Year 7 ("7")</summary>
	public static readonly EndCode C7_YEAR_7 = new EndCode("7");

	/// <summary>Ungraded ("UG")</summary>
	public static readonly EndCode UG_UNGRADED = new EndCode("UG");

	/// <summary>Year 12 ("12")</summary>
	public static readonly EndCode C12_YEAR_12 = new EndCode("12");

	/// <summary>Kindergarten ("K")</summary>
	public static readonly EndCode K_KINDERGARTEN = new EndCode("K");

	/// <summary>Year 2 ("2")</summary>
	public static readonly EndCode C2_YEAR_2 = new EndCode("2");

	/// <summary>Year 10 ("10")</summary>
	public static readonly EndCode C10_YEAR_10 = new EndCode("10");

	/// <summary>Pre-School ("PS")</summary>
	public static readonly EndCode PS_PRESCHOOL = new EndCode("PS");

	/// <summary>Year 6 ("6")</summary>
	public static readonly EndCode C6_YEAR_6 = new EndCode("6");

	/// <summary>Year 1 ("1")</summary>
	public static readonly EndCode C1_YEAR_1 = new EndCode("1");

	/// <summary>Prep ("P")</summary>
	public static readonly EndCode P_PREP = new EndCode("P");

	/// <summary>Year 5 ("5")</summary>
	public static readonly EndCode C5_YEAR_5 = new EndCode("5");

	/// <summary>Year 9 ("9")</summary>
	public static readonly EndCode C9_YEAR_9 = new EndCode("9");

	/// <summary>Year 13 ("13")</summary>
	public static readonly EndCode C13_YEAR_13 = new EndCode("13");

	/// <summary>Year 4 ("4")</summary>
	public static readonly EndCode C4_YEAR_4 = new EndCode("4");

	///<summary>Wrap an arbitrary string value in an EndCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EndCode Wrap( String wrappedValue ) {
		return new EndCode( wrappedValue );
	}

	private EndCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
