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

namespace OpenADK.Library.us.Profdev{

/// <summary>A ProfessionalDevelopmentRegistration</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class ProfessionalDevelopmentRegistration : SifDataObject
{
	/// <summary>
	/// Creates an instance of a ProfessionalDevelopmentRegistration
	/// </summary>
	public ProfessionalDevelopmentRegistration() : base( Adk.SifVersion, ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="employeePersonalRefId">Who this record affects.</param>
	///<param name="registrationStatus">Tracks the status of the user in the professional development activity.</param>
	///
	public ProfessionalDevelopmentRegistration( string refId, string employeePersonalRefId, RegistrationStatus registrationStatus ) : base( Adk.SifVersion, ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION )
	{
		this.RefId = refId;
		this.EmployeePersonalRefId = employeePersonalRefId;
		this.SetRegistrationStatus( registrationStatus );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ProfessionalDevelopmentRegistration( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_REFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>EmployeePersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>EmployeePersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Who this record affects."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string EmployeePersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_EMPLOYEEPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_EMPLOYEEPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RegistrationStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>RegistrationStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Tracks the status of the user in the professional development activity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string RegistrationStatus
	{
		get
		{ 
			return GetFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_REGISTRATIONSTATUS );
		}
		set
		{
			SetField( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_REGISTRATIONSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;RegistrationStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A RegistrationStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Tracks the status of the user in the professional development activity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetRegistrationStatus( RegistrationStatus val )
	{
		SetField( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_REGISTRATIONSTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProfessionalDevelopmentActivityRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>ProfessionalDevelopmentActivityRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Relationship ID for professional development activity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string ProfessionalDevelopmentActivityRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PROFESSIONALDEVELOPMENTACTIVITYREFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PROFESSIONALDEVELOPMENTACTIVITYREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProfessionalDevelopmentProgramRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>ProfessionalDevelopmentProgramRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Relationship ID for professional development program."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string ProfessionalDevelopmentProgramRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PROFESSIONALDEVELOPMENTPROGRAMREFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PROFESSIONALDEVELOPMENTPROGRAMREFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PaidAmount&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setPaidAmount</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PaidAmount</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetPaidAmount( decimal? Value ) {
		RemoveChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PAIDAMOUNT);
		AddChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PAIDAMOUNT, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PaidAmount&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This optional field is used if there is a fee for the professional development activity and for tracking the amount the user paid to participate in the professional development activity."</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>PaidAmount</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public MonetaryAmount PaidAmount
	{
		get
		{
			return (MonetaryAmount)GetChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PAIDAMOUNT);
		}
		set
		{
			RemoveChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PAIDAMOUNT);
			if( value != null)
			{
				AddChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_PAIDAMOUNT, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Stipend&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setStipend</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Stipend</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetStipend( decimal? Value ) {
		RemoveChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_STIPEND);
		AddChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_STIPEND, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Stipend&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Optional field for tracking the amount the user is paid to participate in the professional development activity."</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>Stipend</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public MonetaryAmount Stipend
	{
		get
		{
			return (MonetaryAmount)GetChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_STIPEND);
		}
		set
		{
			RemoveChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_STIPEND);
			if( value != null)
			{
				AddChild( ProfdevDTD.PROFESSIONALDEVELOPMENTREGISTRATION_STIPEND, value );
			}
		}
	}

}}
