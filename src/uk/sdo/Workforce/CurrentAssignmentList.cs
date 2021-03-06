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

namespace OpenADK.Library.uk.Workforce{

/// <summary>A list of assignments associated with a workforce member, including school and role.  This list serves as a quick lookup for information relating to a workforce member's postings or assignments to an LA, School, or other establishment.  An agent will operate more eficiently if the data represented here is sufficient.  Otherwise, it will be necessary for the agent to also request the WorkforceAssignment object(s).</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class CurrentAssignmentList : SifList<CurrentAssignment>
{
	/// <summary>
	/// Creates an instance of a CurrentAssignmentList
	/// </summary>
	public CurrentAssignmentList() : base ( WorkforceDTD.CURRENTASSIGNMENTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="currentAssignment">A workforce member's assignment.</param>
	///
	public CurrentAssignmentList( CurrentAssignment currentAssignment ) : base( WorkforceDTD.CURRENTASSIGNMENTLIST )
	{
		this.SafeAddChild( WorkforceDTD.CURRENTASSIGNMENTLIST_CURRENTASSIGNMENT, currentAssignment );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CurrentAssignmentList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { WorkforceDTD.CURRENTASSIGNMENTLIST_CURRENTASSIGNMENT }; }
	}

}}
