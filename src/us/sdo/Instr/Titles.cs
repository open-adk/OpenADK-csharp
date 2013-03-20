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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Instr{

/// <summary>A Titles</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Titles : SifKeyedList<Title>
{
	/// <summary>
	/// Creates an instance of a Titles
	/// </summary>
	public Titles() : base ( InstrDTD.TITLES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="title">Name of this type of curriculum object (e.g., "American Revolutionary War")</param>
	///
	public Titles( Title title ) : base( InstrDTD.TITLES )
	{
		this.SafeAddChild( InstrDTD.TITLES_TITLE, title );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Titles( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.TITLES_TITLE }; }
	}

	///<summary>Adds the value of the <c>&lt;Title&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Title&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setTitle</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddTitle</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddTitle( string Value ) {
		AddChild( InstrDTD.TITLES_TITLE, new Title( Value ) );
	}

}}
