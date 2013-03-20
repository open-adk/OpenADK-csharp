// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever a TTSiteType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a TTSiteType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class TTSiteType : SifEnum
	{
	/// <summary>an external site (eg: another school in a federation, or a local business) ("E")</summary>
	public static readonly TTSiteType E_AN_EXTERNAL_SITE_EG_ANOT_SCHOOL = new TTSiteType("E");

	/// <summary>a site on your school ("S")</summary>
	public static readonly TTSiteType S_A_SITE_ON_YOUR_SCHOOL = new TTSiteType("S");

	/// <summary>virtual (ie: not a physical site) ("V")</summary>
	public static readonly TTSiteType V_VIRTUAL_IE_NOTPHYSICAL_SITE = new TTSiteType("V");

	///<summary>Wrap an arbitrary string value in a TTSiteType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static TTSiteType Wrap( String wrappedValue ) {
		return new TTSiteType( wrappedValue );
	}

	private TTSiteType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
