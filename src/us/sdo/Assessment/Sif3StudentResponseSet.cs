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

/// <summary>This object transmits the student's responses to stimuli presented in an assessment. This object contains the raw responses as well as provides item-level scores and feedback to the student based on those responses.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3StudentResponseSet : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3StudentResponseSet
	/// </summary>
	public Sif3StudentResponseSet() : base( Adk.SifVersion, AssessmentDTD.SIF3STUDENTRESPONSESET ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="assessmentAdministrationRefId">The administration associated with this score set.</param>
	///<param name="studentPersonalRefId">The student associated with the response set.</param>
	///
	public Sif3StudentResponseSet( string refId, string assessmentAdministrationRefId, string studentPersonalRefId ) : base( Adk.SifVersion, AssessmentDTD.SIF3STUDENTRESPONSESET )
	{
		this.RefId = refId;
		this.AssessmentAdministrationRefId = assessmentAdministrationRefId;
		this.StudentPersonalRefId = studentPersonalRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3StudentResponseSet( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SIF3STUDENTRESPONSESET_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentAdministrationRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentAdministrationRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The administration associated with this score set."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentAdministrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTADMINISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTADMINISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The student associated with the response set."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentRegistrationRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentRegistrationRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The registration associated with the response set."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentRegistrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTREGISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTREGISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemsSif3&gt;</c> element.
	/// </summary>
	/// <value> An ItemsSif3 </value>
	/// <remarks>
	/// <para>To remove the <c>ItemsSif3</c>, set <c>ItemsSif3</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ItemsSif3 ItemsSif3
	{
		get
		{
			return (ItemsSif3)GetChild( AssessmentDTD.SIF3STUDENTRESPONSESET_ITEMSSIF3);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3STUDENTRESPONSESET_ITEMSSIF3);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3STUDENTRESPONSESET_ITEMSSIF3, value );
			}
		}
	}

}}
