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

namespace OpenADK.Library.us.Dw{

/// <summary>An AggregateCharacteristicInfoRefId</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class AggregateCharacteristicInfoRefId : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an AggregateCharacteristicInfoRefId
	/// </summary>
	public AggregateCharacteristicInfoRefId() : base ( DwDTD.AGGREGATECHARACTERISTICINFOREFID ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;AggregateCharacteristicInfoRefId&amp;gt; element</param>
	///
	public AggregateCharacteristicInfoRefId( string value ) : base( DwDTD.AGGREGATECHARACTERISTICINFOREFID )
	{
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AggregateCharacteristicInfoRefId( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { DwDTD.AGGREGATECHARACTERISTICINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AggregateCharacteristicInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;AggregateCharacteristicInfoRefId&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DwDTD.AGGREGATECHARACTERISTICINFOREFID ) ;
		}
		set
		{
			SetFieldValue( DwDTD.AGGREGATECHARACTERISTICINFOREFID, new SifString( value ), value );
		}
	}

}}
