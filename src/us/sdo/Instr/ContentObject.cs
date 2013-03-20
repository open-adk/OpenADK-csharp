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

/// <summary>A learning object.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class ContentObject : SifElement
{
	/// <summary>
	/// Creates an instance of a ContentObject
	/// </summary>
	public ContentObject() : base ( InstrDTD.CONTENTOBJECT ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ContentObject( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Sets the value of the <c>&lt;SourceObject&gt;</c> element.</summary>
	/// <param name="SifRefObject">The type of learning object the source object is.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;SourceObject&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSourceObject</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SourceObject</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetSourceObject( string SifRefObject, string Value ) {
		RemoveChild( InstrDTD.CONTENTOBJECT_SOURCEOBJECT);
		AddChild( InstrDTD.CONTENTOBJECT_SOURCEOBJECT, new SourceObject( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SourceObject&gt;</c> element.
	/// </summary>
	/// <value> A SourceObject </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "GUID assigned to the source object."</para>
	/// <para>To remove the <c>SourceObject</c>, set <c>SourceObject</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SourceObject SourceObject
	{
		get
		{
			return (SourceObject)GetChild( InstrDTD.CONTENTOBJECT_SOURCEOBJECT);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTOBJECT_SOURCEOBJECT);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTOBJECT_SOURCEOBJECT, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Location&gt;</c> element.</summary>
	/// <param name="ReferenceType">A qualifying attribute for the Location payload. If ReferenceType is "URI", the payload contains a web address where the resource can be found.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ContentLocation&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLocation</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Location</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetLocation( string ReferenceType, string Value ) {
		RemoveChild( InstrDTD.CONTENTOBJECT_LOCATION);
		AddChild( InstrDTD.CONTENTOBJECT_LOCATION, new ContentLocation( ReferenceType, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Location&gt;</c> element.
	/// </summary>
	/// <value> A ContentLocation </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Description of location of resource, i.e. location in library or URL, community resource, outside resource supplier."</para>
	/// <para>To remove the <c>ContentLocation</c>, set <c>Location</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ContentLocation Location
	{
		get
		{
			return (ContentLocation)GetChild( InstrDTD.CONTENTOBJECT_LOCATION);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTOBJECT_LOCATION);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTOBJECT_LOCATION, value );
			}
		}
	}

}}
