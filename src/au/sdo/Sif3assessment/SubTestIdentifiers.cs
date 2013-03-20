// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A SubTestIdentifiers</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class SubTestIdentifiers : SifKeyedList<SubTestIdentifier>
{
	/// <summary>
	/// Creates an instance of a SubTestIdentifiers
	/// </summary>
	public SubTestIdentifiers() : base ( Sif3assessmentDTD.SUBTESTIDENTIFIERS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="subTestIdentifier">A SubTestIdentifier</param>
	///
	public SubTestIdentifiers( SubTestIdentifier subTestIdentifier ) : base( Sif3assessmentDTD.SUBTESTIDENTIFIERS )
	{
		this.SafeAddChild( Sif3assessmentDTD.SUBTESTIDENTIFIERS_SUBTESTIDENTIFIER, subTestIdentifier );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SubTestIdentifiers( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SUBTESTIDENTIFIERS_SUBTESTIDENTIFIER }; }
	}

	///<summary>Adds the value of the <c>&lt;SubTestIdentifier&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;SubTestIdentifier&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSubTestIdentifier</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSubTestIdentifier</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddSubTestIdentifier( string Value ) {
		AddChild( Sif3assessmentDTD.SUBTESTIDENTIFIERS_SUBTESTIDENTIFIER, new SubTestIdentifier( Value ) );
	}

}}
