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

namespace OpenADK.Library.us.Profdev{

/// <summary>Information about the school and assignment of employee</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class EmplAssignment : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an EmplAssignment
	/// </summary>
	public EmplAssignment() : base ( ProfdevDTD.EMPLASSIGNMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="schoolInfoRefId">References SchoolInfo object to determine school in which this assignment pertains.</param>
	///<param name="gradeLevels">A GradeLevels</param>
	///<param name="jobFunction">A JobFunction</param>
	///
	public EmplAssignment( string schoolInfoRefId, GradeLevels gradeLevels, JobFunction jobFunction ) : base( ProfdevDTD.EMPLASSIGNMENT )
	{
		this.SchoolInfoRefId = schoolInfoRefId;
		this.GradeLevels = gradeLevels;
		this.JobFunction = jobFunction;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EmplAssignment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProfdevDTD.EMPLASSIGNMENT_SCHOOLINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "References SchoolInfo object to determine school in which this assignment pertains."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.EMPLASSIGNMENT_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.EMPLASSIGNMENT_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( ProfdevDTD.EMPLASSIGNMENT_GRADELEVELS);
		}
		set
		{
			RemoveChild( ProfdevDTD.EMPLASSIGNMENT_GRADELEVELS);
			if( value != null)
			{
				AddChild( ProfdevDTD.EMPLASSIGNMENT_GRADELEVELS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;JobFunction&gt;</c> element.</summary>
	/// <param name="Code">Code representing the type of job function.</param>
	///<remarks>
	/// <para>This form of <c>setJobFunction</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>JobFunction</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetJobFunction( JobFunctionCode Code ) {
		RemoveChild( ProfdevDTD.EMPLASSIGNMENT_JOBFUNCTION);
		AddChild( ProfdevDTD.EMPLASSIGNMENT_JOBFUNCTION, new JobFunction( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;JobFunction&gt;</c> element.
	/// </summary>
	/// <value> A JobFunction </value>
	/// <remarks>
	/// <para>To remove the <c>JobFunction</c>, set <c>JobFunction</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public JobFunction JobFunction
	{
		get
		{
			return (JobFunction)GetChild( ProfdevDTD.EMPLASSIGNMENT_JOBFUNCTION);
		}
		set
		{
			RemoveChild( ProfdevDTD.EMPLASSIGNMENT_JOBFUNCTION);
			if( value != null)
			{
				AddChild( ProfdevDTD.EMPLASSIGNMENT_JOBFUNCTION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FTE&gt;</c> element.
	/// </summary>
	/// <value> The <c>FTE</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Full-time equivalent for this school"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public decimal? FTE
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( ProfdevDTD.EMPLASSIGNMENT_FTE ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.EMPLASSIGNMENT_FTE, new SifDecimal( value ), value );
		}
	}

}}