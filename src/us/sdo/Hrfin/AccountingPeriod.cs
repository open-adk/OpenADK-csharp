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

namespace OpenADK.Library.us.Hrfin{

/// <summary>This object defines an accounting period within a fiscal year.  SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class AccountingPeriod : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AccountingPeriod
	/// </summary>
	public AccountingPeriod() : base( Adk.SifVersion, HrfinDTD.ACCOUNTINGPERIOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies this accounting period.</param>
	///<param name="name">Name of the accounting period.</param>
	///<param name="fiscalYearRefId">Fiscal year to which this accounting period belongs.</param>
	///<param name="startDate">Start date of the accounting period.</param>
	///<param name="endDate">End date of the accounting period.</param>
	///
	public AccountingPeriod( string refId, string name, string fiscalYearRefId, DateTime? startDate, DateTime? endDate ) : base( Adk.SifVersion, HrfinDTD.ACCOUNTINGPERIOD )
	{
		this.RefId = refId;
		this.Name = name;
		this.FiscalYearRefId = fiscalYearRefId;
		this.StartDate = startDate;
		this.EndDate = endDate;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AccountingPeriod( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.ACCOUNTINGPERIOD_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies this accounting period."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.ACCOUNTINGPERIOD_REFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.ACCOUNTINGPERIOD_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the accounting period."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Name&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.ACCOUNTINGPERIOD_NAME ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.ACCOUNTINGPERIOD_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.ACCOUNTINGPERIOD_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.ACCOUNTINGPERIOD_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FiscalYearRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>FiscalYearRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Fiscal year to which this accounting period belongs."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string FiscalYearRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.ACCOUNTINGPERIOD_FISCALYEARREFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.ACCOUNTINGPERIOD_FISCALYEARREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Start date of the accounting period."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.ACCOUNTINGPERIOD_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.ACCOUNTINGPERIOD_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "End date of the accounting period."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.ACCOUNTINGPERIOD_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.ACCOUNTINGPERIOD_ENDDATE, new SifDate( value ), value );
		}
	}

}}
