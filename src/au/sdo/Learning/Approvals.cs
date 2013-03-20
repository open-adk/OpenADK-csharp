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

namespace OpenADK.Library.au.Learning{

/// <summary>An Approvals</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Approvals : SifList<Approval>
{
	/// <summary>
	/// Creates an instance of an Approvals
	/// </summary>
	public Approvals() : base ( LearningDTD.APPROVALS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="approval">An Approval</param>
	///
	public Approvals( Approval approval ) : base( LearningDTD.APPROVALS )
	{
		this.SafeAddChild( LearningDTD.APPROVALS_APPROVAL, approval );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Approvals( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Approval&gt;</c> element.</summary>
	/// <param name="Organization">An Organization</param>
	/// <param name="Date">A Date</param>
	///<remarks>
	/// <para>This form of <c>setApproval</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddApproval</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddApproval( string Organization, DateTime? Date ) {
		AddChild( LearningDTD.APPROVALS_APPROVAL, new Approval( Organization, Date ) );
	}

}}
