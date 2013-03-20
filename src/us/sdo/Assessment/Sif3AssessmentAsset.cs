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

/// <summary>A Sif3AssessmentAsset</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3AssessmentAsset : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3AssessmentAsset
	/// </summary>
	public Sif3AssessmentAsset() : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTASSET ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assetType">An AssetType</param>
	///<param name="assetContent">Contains the actual asset content. Content could be text, images, audio/video, interactive tools, etc.</param>
	///
	public Sif3AssessmentAsset( AssetType assetType, ContentElement assetContent ) : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTASSET )
	{
		this.SetAssetType( assetType );
		this.AssetContent = assetContent;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3AssessmentAsset( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SIF3ASSESSMENTASSET_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of this object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetVersion&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssetVersion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifies the version of the asset that this object represents. New versions of the asset will generate new RefIds and therefore new instances of the object. The format of the version number is defined by the assessment provider."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssetVersion
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETVERSION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETVERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetPublishDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssetPublishDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date that this version of the asset was published (published means made available for use). If the AssetVersion is provided, then this date should also be provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? AssetPublishDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETPUBLISHDATE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETPUBLISHDATE, new SifDateTime( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AssetIdentifiers&gt;</c> element.</summary>
	/// <param name="AssetIdentifier">The identifier for this asset</param>
	///<remarks>
	/// <para>This form of <c>setAssetIdentifiers</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssetIdentifiers</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssetIdentifiers( AssetIdentifier AssetIdentifier ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETIDENTIFIERS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETIDENTIFIERS, new AssetIdentifiers( AssetIdentifier ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetIdentifiers&gt;</c> element.
	/// </summary>
	/// <value> An AssetIdentifiers </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "If the authoring system provides for a unique coding system for assets then this element is used to store that information."</para>
	/// <para>To remove the <c>AssetIdentifiers</c>, set <c>AssetIdentifiers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssetIdentifiers AssetIdentifiers
	{
		get
		{
			return (AssetIdentifiers)GetChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETIDENTIFIERS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETIDENTIFIERS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETIDENTIFIERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetName&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssetName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssetName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetType&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssetType</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssetType
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETTYPE );
		}
		set
		{
			SetField( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AssetType&gt;</c> element.
	/// </summary>
	/// <param name="val">A AssetType object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssetType( AssetType val )
	{
		SetField( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetOwner&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssetOwner</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The name of the owner (publisher) of the asset."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssetOwner
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETOWNER ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETOWNER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetSubjects&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreaList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This will list all subjects to which this asset can be applied."</para>
	/// <para>To remove the <c>SubjectAreaList</c>, set <c>AssetSubjects</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public SubjectAreaList AssetSubjects
	{
		get
		{
			return (SubjectAreaList)GetChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETSUBJECTS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETSUBJECTS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETSUBJECTS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssestGadeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The grade levels to which this asset can be applied."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>AssestGadeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public GradeLevels AssestGadeLevels
	{
		get
		{
			return (GradeLevels)GetChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSESTGADELEVELS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSESTGADELEVELS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSESTGADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetLanguage&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssetLanguage</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The language in which this asset is written (if applicable)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssetLanguage
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLANGUAGE );
		}
		set
		{
			SetField( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLANGUAGE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AssetLanguage&gt;</c> element.
	/// </summary>
	/// <param name="val">A NISOZ3953LanguageCodesType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The language in which this asset is written (if applicable)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssetLanguage( NISOZ3953LanguageCodesType val )
	{
		SetField( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLANGUAGE, val );
	}

	///<summary>Sets the value of the <c>&lt;AssetLearningStandards&gt;</c> element.</summary>
	/// <param name="AssetLearningStandard">The RefId of a specific learning standard for the asset. If the asset is linked to all children learning standards in a hierarchy, then the parent learning standard should also be linked.</param>
	///<remarks>
	/// <para>This form of <c>setAssetLearningStandards</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssetLearningStandards</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssetLearningStandards( AssetLearningStandard AssetLearningStandard ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLEARNINGSTANDARDS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLEARNINGSTANDARDS, new AssetLearningStandards( AssetLearningStandard ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetLearningStandards&gt;</c> element.
	/// </summary>
	/// <value> An AssetLearningStandards </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of LearningStandardItem RefIds."</para>
	/// <para>To remove the <c>AssetLearningStandards</c>, set <c>AssetLearningStandards</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssetLearningStandards AssetLearningStandards
	{
		get
		{
			return (AssetLearningStandards)GetChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLEARNINGSTANDARDS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLEARNINGSTANDARDS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETLEARNINGSTANDARDS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssetContent&gt;</c> element.
	/// </summary>
	/// <value> A ContentElement </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Contains the actual asset content. Content could be text, images, audio/video, interactive tools, etc."</para>
	/// <para>To remove the <c>ContentElement</c>, set <c>AssetContent</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ContentElement AssetContent
	{
		get
		{
			return (ContentElement)GetChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETCONTENT);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETCONTENT);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTASSET_ASSETCONTENT, value );
			}
		}
	}

}}
