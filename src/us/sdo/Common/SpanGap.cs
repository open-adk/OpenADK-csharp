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

namespace OpenADK.Library.us.Common{

/// <summary>This element is designed to contain the time period attached to an object. Very long periods (school year, quarter, etc.) and very small periods (second, millisecond, etc.) can be defined. This element provides a scoping description of the time metadata enclosed.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SpanGap : SifElement
{
	/// <summary>
	/// Creates an instance of a SpanGap
	/// </summary>
	public SpanGap() : base ( CommonDTD.SPANGAP ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">A Type</param>
	///<param name="code">This element provides a place for the application to send structured data (code values, unique identifier, timestamps). This code value can, depending upon the use case agreement between agents, be used to qualify the data in the Value element.</param>
	///<param name="name">Contains a human-readable description of the value in Value.</param>
	///<param name="value">Contains the human-readable value.</param>
	///
	public SpanGap( TimeElementType type, string code, string name, string value ) : base( CommonDTD.SPANGAP )
	{
		this.SetType( type );
		this.Code = code;
		this.Name = name;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SpanGap( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <value> The <c>Type</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( CommonDTD.SPANGAP_TYPE );
		}
		set
		{
			SetField( CommonDTD.SPANGAP_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <param name="val">A TimeElementType object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetType( TimeElementType val )
	{
		SetField( CommonDTD.SPANGAP_TYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element provides a place for the application to send structured data (code values, unique identifier, timestamps). This code value can, depending upon the use case agreement between agents, be used to qualify the data in the Value element."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SPANGAP_CODE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SPANGAP_CODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Contains a human-readable description of the value in Value."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SPANGAP_NAME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SPANGAP_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Value&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Contains the human-readable value."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SPANGAP_VALUE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SPANGAP_VALUE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? StartDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.SPANGAP_STARTDATETIME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SPANGAP_STARTDATETIME, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? EndDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.SPANGAP_ENDDATETIME ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SPANGAP_ENDDATETIME, new SifDateTime( value ), value );
		}
	}

}}
