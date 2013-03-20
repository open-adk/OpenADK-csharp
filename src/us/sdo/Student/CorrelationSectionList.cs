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

namespace OpenADK.Library.us.Student{

/// <summary>A CorrelationSectionList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class CorrelationSectionList : SifKeyedList<CorrelationSection>
{
	/// <summary>
	/// Creates an instance of a CorrelationSectionList
	/// </summary>
	public CorrelationSectionList() : base ( StudentDTD.CORRELATIONSECTIONLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="correlationSection">Reference to a SectionInfo object to be correlated.</param>
	///
	public CorrelationSectionList( CorrelationSection correlationSection ) : base( StudentDTD.CORRELATIONSECTIONLIST )
	{
		this.SafeAddChild( StudentDTD.CORRELATIONSECTIONLIST_CORRELATIONSECTION, correlationSection );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CorrelationSectionList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.CORRELATIONSECTIONLIST_CORRELATIONSECTION }; }
	}

	///<summary>Adds the value of the <c>&lt;CorrelationSection&gt;</c> element.</summary>
	/// <param name="Primary">Indicate whether a SectionInfo is primary. Only one SectionInfo in the CorrelationSectionList can be primary.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;CorrelationSection&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setCorrelationSection</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddCorrelationSection</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddCorrelationSection( Primary Primary, string Value ) {
		AddChild( StudentDTD.CORRELATIONSECTIONLIST_CORRELATIONSECTION, new CorrelationSection( Primary, Value ) );
	}

}}
