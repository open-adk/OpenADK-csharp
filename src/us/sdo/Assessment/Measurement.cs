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

namespace OpenADK.Library.us.Assessment{

/// <summary>A Measurement</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.5</para>
/// </remarks>
[Serializable]
public class Measurement : SifElement
{
	/// <summary>
	/// Creates an instance of a Measurement
	/// </summary>
	public Measurement() : base ( AssessmentDTD.MEASUREMENT ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Measurement( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>MeasurementCode</c> attribute.
	/// </summary>
	/// <value> The <c>MeasurementCode</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A code representing the type of statistic or analysis."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string MeasurementCode
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.MEASUREMENT_MEASUREMENTCODE );
		}
		set
		{
			SetField( AssessmentDTD.MEASUREMENT_MEASUREMENTCODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>MeasurementCode</c> attribute.
	/// </summary>
	/// <param name="val">A MeasurementCodeEnum object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A code representing the type of statistic or analysis."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public void SetMeasurementCode( MeasurementCodeEnum val )
	{
		SetField( AssessmentDTD.MEASUREMENT_MEASUREMENTCODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MeasurementDescription&gt;</c> element.
	/// </summary>
	/// <value> The <c>MeasurementDescription</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An additional description of the statistic or analysis."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string MeasurementDescription
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.MEASUREMENT_MEASUREMENTDESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.MEASUREMENT_MEASUREMENTDESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScaleValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScaleValue</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The value of the Item based on this analysis"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string ScaleValue
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.MEASUREMENT_SCALEVALUE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.MEASUREMENT_SCALEVALUE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Min&gt;</c> element.
	/// </summary>
	/// <value> The <c>Min</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The minimum value possible for the measurement and test design."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string Min
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.MEASUREMENT_MIN ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.MEASUREMENT_MIN, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Max&gt;</c> element.
	/// </summary>
	/// <value> The <c>Max</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The maximum value possible for the measurement and test design."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string Max
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.MEASUREMENT_MAX ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.MEASUREMENT_MAX, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Optimal&gt;</c> element.
	/// </summary>
	/// <value> The <c>Optimal</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The optimal value for this measurement and test design."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.5</para>
	/// </remarks>
	public string Optimal
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.MEASUREMENT_OPTIMAL ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.MEASUREMENT_OPTIMAL, new SifString( value ), value );
		}
	}

}}