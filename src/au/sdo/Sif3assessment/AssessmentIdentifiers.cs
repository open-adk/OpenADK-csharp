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

/// <summary>An AssessmentIdentifiers</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class AssessmentIdentifiers : SifKeyedList<AssessmentIdentifier>
{
	/// <summary>
	/// Creates an instance of an AssessmentIdentifiers
	/// </summary>
	public AssessmentIdentifiers() : base ( Sif3assessmentDTD.ASSESSMENTIDENTIFIERS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentIdentifier">An AssessmentIdentifier</param>
	///
	public AssessmentIdentifiers( AssessmentIdentifier assessmentIdentifier ) : base( Sif3assessmentDTD.ASSESSMENTIDENTIFIERS )
	{
		this.SafeAddChild( Sif3assessmentDTD.ASSESSMENTIDENTIFIERS_ASSESSMENTIDENTIFIER, assessmentIdentifier );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentIdentifiers( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.ASSESSMENTIDENTIFIERS_ASSESSMENTIDENTIFIER }; }
	}

	///<summary>Adds the value of the <c>&lt;AssessmentIdentifier&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssessmentIdentifier&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentIdentifier</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssessmentIdentifier</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddAssessmentIdentifier( string Value ) {
		AddChild( Sif3assessmentDTD.ASSESSMENTIDENTIFIERS_ASSESSMENTIDENTIFIER, new AssessmentIdentifier( Value ) );
	}

}}