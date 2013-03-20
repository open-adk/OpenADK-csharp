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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_Publisher</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_Publisher : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_Publisher
	/// </summary>
	public SIF_Publisher() : base ( InfraDTD.SIF_PUBLISHER ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sourceId">The identifier of the SIF node that is providing objects. This is the agent or ZIS identifier that would appear in the SIF_SourceId field of any SIF_Header created by the SIF node.</param>
	///
	public SIF_Publisher( string sourceId ) : base( InfraDTD.SIF_PUBLISHER )
	{
		this.SourceId = sourceId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Publisher( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_PUBLISHER_SOURCEID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SourceId</c> attribute.
	/// </summary>
	/// <value> The <c>SourceId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The identifier of the SIF node that is providing objects. This is the agent or ZIS identifier that would appear in the SIF_SourceId field of any SIF_Header created by the SIF node."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SourceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_PUBLISHER_SOURCEID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_PUBLISHER_SOURCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ObjectList&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ObjectList </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ObjectList</c>, set <c>SIF_ObjectList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_ObjectList SIF_ObjectList
	{
		get
		{
			return (SIF_ObjectList)GetChild( InfraDTD.SIF_PUBLISHER_SIF_OBJECTLIST);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_PUBLISHER_SIF_OBJECTLIST);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_PUBLISHER_SIF_OBJECTLIST, value );
			}
		}
	}

}}
