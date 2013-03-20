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

namespace OpenADK.Library.us.Student{

/// <summary>Contains all of the personal information relating to a staff member, who might be a teacher or other employee of the school or district.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class StaffPersonal : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StaffPersonal
	/// </summary>
	public StaffPersonal() : base( Adk.SifVersion, StudentDTD.STAFFPERSONAL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID of the staff member.</param>
	///<param name="name">Name of the staff member.  Note: Always use Type value of 04.</param>
	///
	public StaffPersonal( string refId, Name name ) : base( Adk.SifVersion, StudentDTD.STAFFPERSONAL )
	{
		this.RefId = refId;
		this.Name = name;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StaffPersonal( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STAFFPERSONAL_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID of the staff member."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFPERSONAL_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFPERSONAL_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherIdList&gt;</c> element.
	/// </summary>
	/// <value> An OtherIdList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Lists all "other" identifiers associated with the staff member."</para>
	/// <para>To remove the <c>OtherIdList</c>, set <c>OtherIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public OtherIdList OtherIdList
	{
		get
		{
			return (OtherIdList)GetChild( StudentDTD.STAFFPERSONAL_OTHERIDLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_OTHERIDLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_OTHERIDLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this staff member."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFPERSONAL_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFPERSONAL_LOCALID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Name&gt;</c> element.</summary>
	/// <param name="Type">Code that specifies what type of name this is.  If unsure, use 04.</param>
	/// <param name="LastName">The last name.</param>
	/// <param name="FirstName">The first name.</param>
	///<remarks>
	/// <para>This form of <c>setName</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Name</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetName( NameType Type, string LastName, string FirstName ) {
		RemoveChild( StudentDTD.STAFFPERSONAL_NAME);
		AddChild( StudentDTD.STAFFPERSONAL_NAME, new Name( Type, LastName, FirstName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> A Name </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Name of the staff member.  Note: Always use Type value of 04."</para>
	/// <para>To remove the <c>Name</c>, set <c>Name</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public Name Name
	{
		get
		{
			return (Name)GetChild( StudentDTD.STAFFPERSONAL_NAME);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_NAME);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_NAME, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state-assigned identifier for this staff member."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;StateProvinceId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFPERSONAL_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFPERSONAL_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ElectronicIdList&gt;</c> element.
	/// </summary>
	/// <value> An ElectronicIdList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Electronic identifier(s) associated with this entity."</para>
	/// <para>To remove the <c>ElectronicIdList</c>, set <c>ElectronicIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public ElectronicIdList ElectronicIdList
	{
		get
		{
			return (ElectronicIdList)GetChild( StudentDTD.STAFFPERSONAL_ELECTRONICIDLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_ELECTRONICIDLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_ELECTRONICIDLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The staff member's title."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFPERSONAL_TITLE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFPERSONAL_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmailList&gt;</c> element.
	/// </summary>
	/// <value> An EmailList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The staff member's e-mail address(es)."</para>
	/// <para>To remove the <c>EmailList</c>, set <c>EmailList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public EmailList EmailList
	{
		get
		{
			return (EmailList)GetChild( StudentDTD.STAFFPERSONAL_EMAILLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_EMAILLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_EMAILLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Demographics&gt;</c> element.
	/// </summary>
	/// <value> A Demographics </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This element contains information related to staff member demographics."</para>
	/// <para>To remove the <c>Demographics</c>, set <c>Demographics</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public Demographics Demographics
	{
		get
		{
			return (Demographics)GetChild( StudentDTD.STAFFPERSONAL_DEMOGRAPHICS);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_DEMOGRAPHICS);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_DEMOGRAPHICS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherNames&gt;</c> element.
	/// </summary>
	/// <value> An OtherNames </value>
	/// <remarks>
	/// <para>To remove the <c>OtherNames</c>, set <c>OtherNames</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherNames OtherNames
	{
		get
		{
			return (OtherNames)GetChild( StudentDTD.STAFFPERSONAL_OTHERNAMES);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_OTHERNAMES);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_OTHERNAMES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AddressList&gt;</c> element.
	/// </summary>
	/// <value> An AddressList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The staff member's address(es)."</para>
	/// <para>To remove the <c>AddressList</c>, set <c>AddressList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public AddressList AddressList
	{
		get
		{
			return (AddressList)GetChild( StudentDTD.STAFFPERSONAL_ADDRESSLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_ADDRESSLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_ADDRESSLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumberList&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumberList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The staff member's phone number(s)."</para>
	/// <para>To remove the <c>PhoneNumberList</c>, set <c>PhoneNumberList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public PhoneNumberList PhoneNumberList
	{
		get
		{
			return (PhoneNumberList)GetChild( StudentDTD.STAFFPERSONAL_PHONENUMBERLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STAFFPERSONAL_PHONENUMBERLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STAFFPERSONAL_PHONENUMBERLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmployeePersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>EmployeePersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Allows for a linkage to the HR/Fin EmployeePersonal object."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;EmployeePersonalRefId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string EmployeePersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STAFFPERSONAL_EMPLOYEEPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STAFFPERSONAL_EMPLOYEEPERSONALREFID, new SifString( value ), value );
		}
	}

}}
