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

/// <summary>Contains one of the SIF message types.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Unsubscribe : SifMessagePayload
{
	/// <summary>
	/// Creates an instance of a SIF_Unsubscribe
	/// </summary>
	public SIF_Unsubscribe() : base ( InfraDTD.SIF_UNSUBSCRIBE ){}
	/// <summary>
	/// Creates an instance of a SIF_Unsubscribe
	/// </summary>
	///  <param name="sifVersion">The version of SIF to render this message in</param>
	///
	public SIF_Unsubscribe( SifVersion sifVersion ) : base( sifVersion, InfraDTD.SIF_UNSUBSCRIBE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Unsubscribe( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Header&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Header </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Header information associated with this message."</para>
	/// <para>To remove the <c>SIF_Header</c>, set <c>SIF_Header</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Header SIF_Header
	{
		get
		{
			return (SIF_Header)GetChild( InfraDTD.SIF_UNSUBSCRIBE_SIF_HEADER);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_UNSUBSCRIBE_SIF_HEADER);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_UNSUBSCRIBE_SIF_HEADER, value );
			}
		}
	}

	/// <summary>Adds a new <c>&lt;SIF_Object&gt;</c> child element.</summary>
	/// <param name="val">A SIF_Object object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void AddSIF_Object( SIF_Object val ) { 
		AddChild( InfraDTD.SIF_UNSUBSCRIBE_SIF_OBJECT, val );
	}

	/// <summary>
	/// Removes a <see cref="SIF_Object"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="ObjectName">Identifies the SIF_Object object to remove by its ObjectName value</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void RemoveSIF_Object( string ObjectName ) { 
		RemoveChild( InfraDTD.SIF_UNSUBSCRIBE_SIF_OBJECT, new String[] { ObjectName.ToString() } );
	}

	/// <summary>
	/// Gets a <see cref="SIF_Object"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="ObjectName">Identifies the SIF_Object object to return by its "ObjectName" attribute value</param>
	/// <returns>A SIF_Object object</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Object GetSIF_Object( string ObjectName ) { 
		return (SIF_Object)GetChild( InfraDTD.SIF_UNSUBSCRIBE_SIF_OBJECT, new string[] { ObjectName.ToString() } );
	}

	/// <summary>
	/// Gets all SIF_Object object instances. More than once instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <returns>An array of SIF_Object objects</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Object[] GetSIF_Objects()
	{
		return GetChildren<SIF_Object>().ToArray();
	}

	/// <summary>
	/// Sets all SIF_Object object instances. All existing 
	/// <c>SIF_Object</c> instances 
	/// are removed and replaced with this list. Calling this method with the 
	/// parameter value set to null removes all <c>SIF_Objects</c>.
	/// </summary>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetSIF_Objects( SIF_Object[] items)
	{
		SetChildren( InfraDTD.SIF_UNSUBSCRIBE_SIF_OBJECT, items );
	}

}}
