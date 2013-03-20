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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learner{

/// <summary>A ParticipationTypes</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class ParticipationTypes : SifKeyedList<ParticipationType>
{
	/// <summary>
	/// Creates an instance of a ParticipationTypes
	/// </summary>
	public ParticipationTypes() : base ( LearnerDTD.PARTICIPATIONTYPES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="participationType">The capacity of Involvement</param>
	///
	public ParticipationTypes( ParticipationType participationType ) : base( LearnerDTD.PARTICIPATIONTYPES )
	{
		this.SafeAddChild( LearnerDTD.PARTICIPATIONTYPES_PARTICIPATIONTYPE, participationType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ParticipationTypes( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearnerDTD.PARTICIPATIONTYPES_PARTICIPATIONTYPE }; }
	}

	///<summary>Adds the value of the <c>&lt;ParticipationType&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ParticipationType&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setParticipationType</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddParticipationType</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddParticipationType( ParticipationEnum Value ) {
		AddChild( LearnerDTD.PARTICIPATIONTYPES_PARTICIPATIONTYPE, new ParticipationType( Value ) );
	}

}}
