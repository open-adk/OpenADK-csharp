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

namespace OpenADK.Library.au.Student{

/// <summary>A SummaryEnrollmentInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SummaryEnrollmentInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SummaryEnrollmentInfo
	/// </summary>
	public SummaryEnrollmentInfo() : base( Adk.SifVersion, StudentDTD.SUMMARYENROLLMENTINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies the enrollment.</param>
	///<param name="schoolYear">A SchoolYear</param>
	///<param name="parentObjectRefId">A ParentObjectRefId</param>
	///<param name="localId">A LocalId</param>
	///<param name="personInfo">A PersonInfo</param>
	///<param name="schoolEnrollmentList">A SchoolEnrollmentList</param>
	///
	public SummaryEnrollmentInfo( string refId, int? schoolYear, ParentObjectRefId parentObjectRefId, string localId, PersonInfo personInfo, SchoolEnrollment schoolEnrollmentList ) : base( Adk.SifVersion, StudentDTD.SUMMARYENROLLMENTINFO )
	{
		this.RefId = refId;
		this.SchoolYear = schoolYear;
		this.ParentObjectRefId = parentObjectRefId;
		this.LocalId = localId;
		this.PersonInfo = personInfo;
		this.SchoolEnrollmentList =  new SchoolEnrollmentList( schoolEnrollmentList );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SummaryEnrollmentInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SUMMARYENROLLMENTINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the enrollment."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolYear</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ParentObjectRefId&gt;</c> element.</summary>
	/// <param name="SifRefObject">The name of the object reference.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ParentObjectRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setParentObjectRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ParentObjectRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetParentObjectRefId( ParentObjectRefIdSIF_RefObject SifRefObject, string Value ) {
		RemoveChild( StudentDTD.SUMMARYENROLLMENTINFO_PARENTOBJECTREFID);
		AddChild( StudentDTD.SUMMARYENROLLMENTINFO_PARENTOBJECTREFID, new ParentObjectRefId( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentObjectRefId&gt;</c> element.
	/// </summary>
	/// <value> A ParentObjectRefId </value>
	/// <remarks>
	/// <para>To remove the <c>ParentObjectRefId</c>, set <c>ParentObjectRefId</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public ParentObjectRefId ParentObjectRefId
	{
		get
		{
			return (ParentObjectRefId)GetChild( StudentDTD.SUMMARYENROLLMENTINFO_PARENTOBJECTREFID);
		}
		set
		{
			RemoveChild( StudentDTD.SUMMARYENROLLMENTINFO_PARENTOBJECTREFID);
			if( value != null)
			{
				AddChild( StudentDTD.SUMMARYENROLLMENTINFO_PARENTOBJECTREFID, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The state-assigned identifier for this student/teacher."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SUMMARYENROLLMENTINFO_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PersonInfo&gt;</c> element.</summary>
	/// <param name="Name">The name of the person. Note: Type attribute value of LGL must be used here.</param>
	///<remarks>
	/// <para>This form of <c>setPersonInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PersonInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPersonInfo( Name Name ) {
		RemoveChild( StudentDTD.SUMMARYENROLLMENTINFO_PERSONINFO);
		AddChild( StudentDTD.SUMMARYENROLLMENTINFO_PERSONINFO, new PersonInfo( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PersonInfo&gt;</c> element.
	/// </summary>
	/// <value> A PersonInfo </value>
	/// <remarks>
	/// <para>To remove the <c>PersonInfo</c>, set <c>PersonInfo</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PersonInfo PersonInfo
	{
		get
		{
			return (PersonInfo)GetChild( StudentDTD.SUMMARYENROLLMENTINFO_PERSONINFO);
		}
		set
		{
			RemoveChild( StudentDTD.SUMMARYENROLLMENTINFO_PERSONINFO);
			if( value != null)
			{
				AddChild( StudentDTD.SUMMARYENROLLMENTINFO_PERSONINFO, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SchoolEnrollmentList&gt;</c> element.</summary>
	/// <param name="SchoolEnrollment">A SchoolEnrollment</param>
	///<remarks>
	/// <para>This form of <c>setSchoolEnrollmentList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SchoolEnrollmentList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSchoolEnrollmentList( SchoolEnrollment SchoolEnrollment ) {
		RemoveChild( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLENROLLMENTLIST);
		AddChild( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLENROLLMENTLIST, new SchoolEnrollmentList( SchoolEnrollment ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolEnrollmentList&gt;</c> element.
	/// </summary>
	/// <value> A SchoolEnrollmentList </value>
	/// <remarks>
	/// <para>To remove the <c>SchoolEnrollmentList</c>, set <c>SchoolEnrollmentList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public SchoolEnrollmentList SchoolEnrollmentList
	{
		get
		{
			return (SchoolEnrollmentList)GetChild( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLENROLLMENTLIST);
		}
		set
		{
			RemoveChild( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLENROLLMENTLIST);
			if( value != null)
			{
				AddChild( StudentDTD.SUMMARYENROLLMENTINFO_SCHOOLENROLLMENTLIST, value );
			}
		}
	}

}}
