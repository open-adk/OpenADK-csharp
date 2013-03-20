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

namespace OpenADK.Library.us.Trans{

/// <summary>Current speedometer reading.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class Speedometer : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Speedometer
	/// </summary>
	public Speedometer() : base ( TransDTD.SPEEDOMETER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="unit">Units used in the speedometer reading. </param>
	///<param name="value">Gets or sets the content value of the &amp;lt;Speedometer&amp;gt; element</param>
	///
	public Speedometer( DistanceUnit unit, decimal? value ) : base( TransDTD.SPEEDOMETER )
	{
		this.SetUnit( unit );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Speedometer( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { TransDTD.SPEEDOMETER_UNIT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Speedometer&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;Speedometer&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public decimal? Value
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( TransDTD.SPEEDOMETER ) ;
		}
		set
		{
			SetFieldValue( TransDTD.SPEEDOMETER, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Unit</c> attribute.
	/// </summary>
	/// <value> The <c>Unit</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Units used in the speedometer reading. "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Unit
	{
		get
		{ 
			return GetFieldValue( TransDTD.SPEEDOMETER_UNIT );
		}
		set
		{
			SetField( TransDTD.SPEEDOMETER_UNIT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Unit</c> attribute.
	/// </summary>
	/// <param name="val">A DistanceUnit object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Units used in the speedometer reading. "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetUnit( DistanceUnit val )
	{
		SetField( TransDTD.SPEEDOMETER_UNIT, val );
	}

}}
