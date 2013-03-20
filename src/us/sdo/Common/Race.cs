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

/// <summary>A Race</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class Race : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Race
	/// </summary>
	public Race() : base ( CommonDTD.RACE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">A code that specifies the coding structure used. The default is "NA".</param>
	///<param name="code">The general racial category which reflects the individual's recognition of his or her community or with which the individual most identifies.</param>
	///
	public Race( string type, RaceType code ) : base( CommonDTD.RACE )
	{
		this.Type = type;
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Race( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.RACE_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A code that specifies the coding structure used. The default is "NA"."</para>
	/// <para>Version: 1.5r1</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Type
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.RACE_TYPE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.RACE_TYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The general racial category which reflects the individual's recognition of his or her community or with which the individual most identifies."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.RACE_CODE );
		}
		set
		{
			SetField( CommonDTD.RACE_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <param name="val">A RaceType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The general racial category which reflects the individual's recognition of his or her community or with which the individual most identifies."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetCode( RaceType val )
	{
		SetField( CommonDTD.RACE_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( CommonDTD.RACE_OTHERCODELIST);
		}
		set
		{
			RemoveChild( CommonDTD.RACE_OTHERCODELIST);
			if( value != null)
			{
				AddChild( CommonDTD.RACE_OTHERCODELIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Proportion&gt;</c> element.
	/// </summary>
	/// <value> The <c>Proportion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A percentage associated with the race."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public decimal? Proportion
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( CommonDTD.RACE_PROPORTION ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.RACE_PROPORTION, new SifDecimal( value ), value );
		}
	}

}}
