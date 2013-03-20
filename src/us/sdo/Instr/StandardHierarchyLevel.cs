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

/// <summary>A StandardHierarchyLevel</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class StandardHierarchyLevel : SifElement
{
	/// <summary>
	/// Creates an instance of a StandardHierarchyLevel
	/// </summary>
	public StandardHierarchyLevel() : base ( InstrDTD.STANDARDHIERARCHYLEVEL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="description">Used to describe what role this item is serving in the structure. Some standards describe their levels in terms of standard, strands, and topics. Others use standards, benchmarks, and indicators. This attribute names the level of the item.</param>
	///<param name="number">Integer assigned to each hierarchical level within standards tree. The top level is "1".</param>
	///
	public StandardHierarchyLevel( string description, int? number ) : base( InstrDTD.STANDARDHIERARCHYLEVEL )
	{
		this.Description = description;
		this.Number = number;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StandardHierarchyLevel( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>Description</c> attribute.
	/// </summary>
	/// <value> The <c>Description</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Used to describe what role this item is serving in the structure. Some standards describe their levels in terms of standard, strands, and topics. Others use standards, benchmarks, and indicators. This attribute names the level of the item."</para>
	/// <para>This attribute is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering attributes of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Description&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.STANDARDHIERARCHYLEVEL_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.STANDARDHIERARCHYLEVEL_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Number&gt;</c> element.
	/// </summary>
	/// <value> The <c>Number</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Integer assigned to each hierarchical level within standards tree. The top level is "1"."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public int? Number
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InstrDTD.STANDARDHIERARCHYLEVEL_NUMBER ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.STANDARDHIERARCHYLEVEL_NUMBER, new SifInt( value ), value );
		}
	}

}}
