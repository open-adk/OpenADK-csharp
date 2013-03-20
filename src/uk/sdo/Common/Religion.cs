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

namespace OpenADK.Library.uk.Common{

/// <summary>Definition of a person's religious faith.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Religion : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Religion
	/// </summary>
	public Religion() : base ( CommonDTD.RELIGION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="affiliationCode">Person's religious faith. CBDS: 100029</param>
	///
	public Religion( ReligiousAffiliation affiliationCode ) : base( CommonDTD.RELIGION )
	{
		this.SetAffiliationCode( affiliationCode );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Religion( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.RELIGION_AFFILIATIONCODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AffiliationCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>AffiliationCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Person's religious faith. CBDS: 100029"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AffiliationCode
	{
		get
		{ 
			return GetFieldValue( CommonDTD.RELIGION_AFFILIATIONCODE );
		}
		set
		{
			SetField( CommonDTD.RELIGION_AFFILIATIONCODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AffiliationCode&gt;</c> element.
	/// </summary>
	/// <param name="val">A ReligiousAffiliation object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Person's religious faith. CBDS: 100029"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAffiliationCode( ReligiousAffiliation val )
	{
		SetField( CommonDTD.RELIGION_AFFILIATIONCODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EducationStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>EducationStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates whether the person is actively attending religious education classes. CBDS: 100030"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string EducationStatus
	{
		get
		{ 
			return GetFieldValue( CommonDTD.RELIGION_EDUCATIONSTATUS );
		}
		set
		{
			SetField( CommonDTD.RELIGION_EDUCATIONSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;EducationStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A EducationStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates whether the person is actively attending religious education classes. CBDS: 100030"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetEducationStatus( EducationStatus val )
	{
		SetField( CommonDTD.RELIGION_EDUCATIONSTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CollectiveWorshipStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>CollectiveWorshipStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates whether the person is participating in religious collective worship. CBDS: 100031"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string CollectiveWorshipStatus
	{
		get
		{ 
			return GetFieldValue( CommonDTD.RELIGION_COLLECTIVEWORSHIPSTATUS );
		}
		set
		{
			SetField( CommonDTD.RELIGION_COLLECTIVEWORSHIPSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CollectiveWorshipStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A EducationStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates whether the person is participating in religious collective worship. CBDS: 100031"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCollectiveWorshipStatus( EducationStatus val )
	{
		SetField( CommonDTD.RELIGION_COLLECTIVEWORSHIPSTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Source&gt;</c> element.
	/// </summary>
	/// <value> The <c>Source</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Source of person's religious affiliation code. CBDS: 100058"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Source
	{
		get
		{ 
			return GetFieldValue( CommonDTD.RELIGION_SOURCE );
		}
		set
		{
			SetField( CommonDTD.RELIGION_SOURCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Source&gt;</c> element.
	/// </summary>
	/// <param name="val">A SourceOfCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Source of person's religious affiliation code. CBDS: 100058"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSource( SourceOfCode val )
	{
		SetField( CommonDTD.RELIGION_SOURCE, val );
	}

}}
