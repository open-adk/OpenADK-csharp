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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A Sif3Score</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3Score : SifElement
{
	/// <summary>
	/// Creates an instance of a Sif3Score
	/// </summary>
	public Sif3Score() : base ( Sif3assessmentDTD.SIF3SCORE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3Score( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoreCode</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ScoreCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3SCORE_SCORECODE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3SCORE_SCORECODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreCodeDefinition&gt;</c> element.
	/// </summary>
	/// <value> An AbstractContentElementType </value>
	/// <remarks>
	/// <para>To remove the <c>AbstractContentElementType</c>, set <c>ScoreCodeDefinition</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AbstractContentElementType ScoreCodeDefinition
	{
		get
		{
			return (AbstractContentElementType)GetChild( Sif3assessmentDTD.SIF3SCORE_SCORECODEDEFINITION);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3SCORE_SCORECODEDEFINITION);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3SCORE_SCORECODEDEFINITION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>ScoreValue</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public decimal? ScoreValue
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3SCORE_SCOREVALUE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3SCORE_SCOREVALUE, new SifDecimal( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ScoreDescriptions&gt;</c> element.</summary>
	/// <param name="ScoreDescription">An individual statement that defines the specific expectations that the response must illustrate in order to achieve this score point. This is a complex content type in order to support math or other subjects that may require non-text representations of expectations.</param>
	///<remarks>
	/// <para>This form of <c>setScoreDescriptions</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ScoreDescriptions</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScoreDescriptions( AbstractContentElementType ScoreDescription ) {
		RemoveChild( Sif3assessmentDTD.SIF3SCORE_SCOREDESCRIPTIONS);
		AddChild( Sif3assessmentDTD.SIF3SCORE_SCOREDESCRIPTIONS, new ScoreDescriptionList( ScoreDescription ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreDescriptions&gt;</c> element.
	/// </summary>
	/// <value> A ScoreDescriptionList </value>
	/// <remarks>
	/// <para>To remove the <c>ScoreDescriptionList</c>, set <c>ScoreDescriptions</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ScoreDescriptionList ScoreDescriptions
	{
		get
		{
			return (ScoreDescriptionList)GetChild( Sif3assessmentDTD.SIF3SCORE_SCOREDESCRIPTIONS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3SCORE_SCOREDESCRIPTIONS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3SCORE_SCOREDESCRIPTIONS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ScoreComments&gt;</c> element.</summary>
	/// <param name="ScoreComment">A ScoreComment</param>
	///<remarks>
	/// <para>This form of <c>setScoreComments</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ScoreComments</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetScoreComments( ScoreComment ScoreComment ) {
		RemoveChild( Sif3assessmentDTD.SIF3SCORE_SCORECOMMENTS);
		AddChild( Sif3assessmentDTD.SIF3SCORE_SCORECOMMENTS, new ScoreCommentList( ScoreComment ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ScoreComments&gt;</c> element.
	/// </summary>
	/// <value> A ScoreCommentList </value>
	/// <remarks>
	/// <para>To remove the <c>ScoreCommentList</c>, set <c>ScoreComments</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ScoreCommentList ScoreComments
	{
		get
		{
			return (ScoreCommentList)GetChild( Sif3assessmentDTD.SIF3SCORE_SCORECOMMENTS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3SCORE_SCORECOMMENTS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3SCORE_SCORECOMMENTS, value );
			}
		}
	}

}}
