// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Food
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AccountType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AccountType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class AccountType : SifEnum
	{
	/// <summary>PrepaidCash ("PrepaidCash")</summary>
	public static readonly AccountType PREPAIDCASH = new AccountType("PrepaidCash");

	/// <summary>NA ("NA")</summary>
	public static readonly AccountType NA = new AccountType("NA");

	/// <summary>LunchCredit ("LunchCredit")</summary>
	public static readonly AccountType LUNCHCREDIT = new AccountType("LunchCredit");

	/// <summary>BreakfastCredit ("BreakfastCredit")</summary>
	public static readonly AccountType BREAKFASTCREDIT = new AccountType("BreakfastCredit");

	///<summary>Wrap an arbitrary string value in an AccountType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AccountType Wrap( String wrappedValue ) {
		return new AccountType( wrappedValue );
	}

	private AccountType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
