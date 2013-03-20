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

namespace OpenADK.Library.au.Learning{

/// <summary>An AssociatedObject</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class AssociatedObject : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an AssociatedObject
	/// </summary>
	public AssociatedObject() : base ( LearningDTD.ASSOCIATEDOBJECT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifRefObject">A SIF_RefObject</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;AssociatedObject&amp;gt; element</param>
	///
	public AssociatedObject( string sifRefObject, string value ) : base( LearningDTD.ASSOCIATEDOBJECT )
	{
		this.SIF_RefObject = sifRefObject;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssociatedObject( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.ASSOCIATEDOBJECT_SIF_REFOBJECT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssociatedObject&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;AssociatedObject&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.ASSOCIATEDOBJECT ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.ASSOCIATEDOBJECT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefObject</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string SIF_RefObject
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.ASSOCIATEDOBJECT_SIF_REFOBJECT ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.ASSOCIATEDOBJECT_SIF_REFOBJECT, new SifString( value ), value );
		}
	}

}}
