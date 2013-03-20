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

/// <summary>This message is used to invoke a method that is exposed by a SIF Zone Service.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SIF_ServiceInput : SifMessagePayload
{
	/// <summary>
	/// Creates an instance of a SIF_ServiceInput
	/// </summary>
	public SIF_ServiceInput() : base ( InfraDTD.SIF_SERVICEINPUT ){}
	/// <summary>
	/// Creates an instance of a SIF_ServiceInput
	/// </summary>
	///  <param name="sifVersion">The version of SIF to render this message in</param>
	///
	public SIF_ServiceInput( SifVersion sifVersion ) : base( sifVersion, InfraDTD.SIF_SERVICEINPUT ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ServiceInput( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Header&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Header </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Header information associated with this message."</para>
	/// <para>To remove the <c>SIF_Header</c>, set <c>SIF_Header</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_Header SIF_Header
	{
		get
		{
			return (SIF_Header)GetChild( InfraDTD.SIF_SERVICEINPUT_SIF_HEADER);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_SERVICEINPUT_SIF_HEADER);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_SERVICEINPUT_SIF_HEADER, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Service&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Service</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The name of the SIF Zone Service that is being invoked."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SIF_Service
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_SERVICE ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_SERVICE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Operation&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Operation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The name of the service operation that is being invoked."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SIF_Operation
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_OPERATION ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_OPERATION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ServiceMsgId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_ServiceMsgId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The unique ID of this service request invocation."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SIF_ServiceMsgId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_SERVICEMSGID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_SERVICEMSGID, new SifString( value ), value );
		}
	}

	/// <summary>Adds a new <c>&lt;SIF_Version&gt;</c> child element.</summary>
	/// <param name="val">A SIF_Version object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	///         Specifies which SIF Implementation Specification version should be used when returning the response data.
	///         Is a responder cannot return response data in this format, it should reject the SIF_ServiceInput.
	///         It is recommended that requesters use a wild card version for the minor portion of the version, such as 2.*.
	///       "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddSIF_Version( SIF_Version val ) { 
		AddChild( InfraDTD.SIF_SERVICEINPUT_SIF_VERSION, val );
	}

	/// <summary>
	/// Removes a <see cref="SIF_Version"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="Value">Identifies the SIF_Version object to remove by its Value value</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void RemoveSIF_Version( string Value ) { 
		RemoveChild( InfraDTD.SIF_SERVICEINPUT_SIF_VERSION, new String[] { Value.ToString() } );
	}

	/// <summary>
	/// Gets a <see cref="SIF_Version"/> object instance. More than one instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <param name="Value">Identifies the SIF_Version object to return by its "Value" attribute value</param>
	/// <returns>A SIF_Version object</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_Version GetSIF_Version( string Value ) { 
		return (SIF_Version)GetChild( InfraDTD.SIF_SERVICEINPUT_SIF_VERSION, new string[] { Value.ToString() } );
	}

	/// <summary>
	/// Gets all SIF_Version object instances. More than once instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <returns>An array of SIF_Version objects</returns>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_Version[] GetSIF_Versions()
	{
		return GetChildren<SIF_Version>().ToArray();
	}

	/// <summary>
	/// Sets all SIF_Version object instances. All existing 
	/// <c>SIF_Version</c> instances 
	/// are removed and replaced with this list. Calling this method with the 
	/// parameter value set to null removes all <c>SIF_Versions</c>.
	/// </summary>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSIF_Versions( SIF_Version[] items)
	{
		SetChildren( InfraDTD.SIF_SERVICEINPUT_SIF_VERSION, items );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_MaxBufferSize&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_MaxBufferSize</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specifies the maximum size of a response packet to be returned to the requester. The responder may return packets smaller than, or equal to, the maximum value. If the maximum size is too small to contain a single whole response object, the responder should reject the SIF_ServiceInput. To guarantee delivery of response packets, requesting agents must not specify a SIF_MaxBufferSize greater than its registered SIF_Register/SIF_MaxBufferSize."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SIF_MaxBufferSize
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_MAXBUFFERSIZE ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_MAXBUFFERSIZE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_PacketNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_PacketNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element represents the index of the SIF_ServiceInput message in the sequence of packets that make up a complete response. Its value must be in the range of 1 through n, with n equal to the total number of packets that make up a response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SIF_PacketNumber
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_PACKETNUMBER ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_PACKETNUMBER, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_MorePackets&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_MorePackets</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element provides an indication as to whether there are more packets besides this one to make up a complete response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SIF_MorePackets
	{
		get
		{ 
			return GetFieldValue( InfraDTD.SIF_SERVICEINPUT_SIF_MOREPACKETS );
		}
		set
		{
			SetField( InfraDTD.SIF_SERVICEINPUT_SIF_MOREPACKETS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;SIF_MorePackets&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element provides an indication as to whether there are more packets besides this one to make up a complete response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSIF_MorePackets( YesNo val )
	{
		SetField( InfraDTD.SIF_SERVICEINPUT_SIF_MOREPACKETS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Error&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Error </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Error</c>, set <c>SIF_Error</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_Error SIF_Error
	{
		get
		{
			return (SIF_Error)GetChild( InfraDTD.SIF_SERVICEINPUT_SIF_ERROR);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_SERVICEINPUT_SIF_ERROR);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_SERVICEINPUT_SIF_ERROR, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Body&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Body </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Contains a single child element that has the same name as the value of the SIF_Operation element."</para>
	/// <para>To remove the <c>SIF_Body</c>, set <c>SIF_Body</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SIF_Body SIF_Body
	{
		get
		{
			return (SIF_Body)GetChild( InfraDTD.SIF_SERVICEINPUT_SIF_BODY);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_SERVICEINPUT_SIF_BODY);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_SERVICEINPUT_SIF_BODY, value );
			}
		}
	}

}}
