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

namespace OpenADK.Library.au.School{

/// <summary>A SchoolPrograms</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SchoolPrograms : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SchoolPrograms
	/// </summary>
	public SchoolPrograms() : base( Adk.SifVersion, SchoolDTD.SCHOOLPROGRAMS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that uniquely identifies this instance of the object.</param>
	///<param name="schoolInfoRefId">GUID that identifies the school offering this program.</param>
	///
	public SchoolPrograms( string refId, string schoolInfoRefId ) : base( Adk.SifVersion, SchoolDTD.SCHOOLPROGRAMS )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SchoolPrograms( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SchoolDTD.SCHOOLPROGRAMS_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that uniquely identifies this instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SCHOOLPROGRAMS_REFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SCHOOLPROGRAMS_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "GUID that identifies the school offering this program."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SchoolDTD.SCHOOLPROGRAMS_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SCHOOLPROGRAMS_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g., "2009")."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( SchoolDTD.SCHOOLPROGRAMS_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( SchoolDTD.SCHOOLPROGRAMS_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolProgramList&gt;</c> element.
	/// </summary>
	/// <value> A SchoolProgramList </value>
	/// <remarks>
	/// <para>To remove the <c>SchoolProgramList</c>, set <c>SchoolProgramList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SchoolProgramList SchoolProgramList
	{
		get
		{
			return (SchoolProgramList)GetChild( SchoolDTD.SCHOOLPROGRAMS_SCHOOLPROGRAMLIST);
		}
		set
		{
			RemoveChild( SchoolDTD.SCHOOLPROGRAMS_SCHOOLPROGRAMLIST);
			if( value != null)
			{
				AddChild( SchoolDTD.SCHOOLPROGRAMS_SCHOOLPROGRAMLIST, value );
			}
		}
	}

}}
