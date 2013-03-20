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

/// <summary>Per pay distributions</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class PayRate : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a PayRate
	/// </summary>
	public PayRate() : base ( HrfinDTD.PAYRATE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Type of pay</param>
	///<param name="amount">Pay amount.</param>
	///<param name="percentage">Percentage of pay this represents.</param>
	///
	public PayRate( PayRateType type, MonetaryAmount amount, decimal? percentage ) : base( HrfinDTD.PAYRATE )
	{
		this.SetType( type );
		this.Amount = amount;
		this.Percentage = percentage;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PayRate( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.PAYRATE_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Type of pay"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( HrfinDTD.PAYRATE_TYPE );
		}
		set
		{
			SetField( HrfinDTD.PAYRATE_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A PayRateType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Type of pay"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetType( PayRateType val )
	{
		SetField( HrfinDTD.PAYRATE_TYPE, val );
	}

	///<summary>Sets the value of the <c>&lt;Amount&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAmount</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Amount</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetAmount( decimal? Value ) {
		RemoveChild( HrfinDTD.PAYRATE_AMOUNT);
		AddChild( HrfinDTD.PAYRATE_AMOUNT, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Amount&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Pay amount."</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>Amount</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public MonetaryAmount Amount
	{
		get
		{
			return (MonetaryAmount)GetChild( HrfinDTD.PAYRATE_AMOUNT);
		}
		set
		{
			RemoveChild( HrfinDTD.PAYRATE_AMOUNT);
			if( value != null)
			{
				AddChild( HrfinDTD.PAYRATE_AMOUNT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Percentage&gt;</c> element.
	/// </summary>
	/// <value> The <c>Percentage</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Percentage of pay this represents."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public decimal? Percentage
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( HrfinDTD.PAYRATE_PERCENTAGE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.PAYRATE_PERCENTAGE, new SifDecimal( value ), value );
		}
	}

}}
