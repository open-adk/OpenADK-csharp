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

/// <summary>A StudentSDTN</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentSDTN : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentSDTN
	/// </summary>
	public StudentSDTN() : base( Adk.SifVersion, StudentDTD.STUDENTSDTN ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies this SDTN Object.</param>
	///<param name="snapDate">The date that this object was sent.</param>
	///<param name="studentPersonalRefId">The RefId of the StudentPersonal object at the sending school.</param>
	///<param name="personInfo">A PersonInfo</param>
	///<param name="schoolInfoRefId">GUID that identifies the school that provided the SDTN.</param>
	///<param name="schoolName">Name of school/campus.</param>
	///
	public StudentSDTN( string refId, DateTime? snapDate, string studentPersonalRefId, PersonInfo personInfo, string schoolInfoRefId, string schoolName ) : base( Adk.SifVersion, StudentDTD.STUDENTSDTN )
	{
		this.RefId = refId;
		this.SnapDate = snapDate;
		this.StudentPersonalRefId = studentPersonalRefId;
		this.PersonInfo = personInfo;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.SchoolName = schoolName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentSDTN( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTSDTN_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies this SDTN Object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SnapDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>SnapDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date that this object was sent."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? SnapDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_SNAPDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_SNAPDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The RefId of the StudentPersonal object at the sending school."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PersonInfo&gt;</c> element.</summary>
	/// <param name="Name">The name of the person. Note: Type attribute value of LGL must be used here.</param>
	///<remarks>
	/// <para>This form of <c>setPersonInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PersonInfo</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPersonInfo( Name Name ) {
		RemoveChild( StudentDTD.STUDENTSDTN_PERSONINFO);
		AddChild( StudentDTD.STUDENTSDTN_PERSONINFO, new PersonInfo( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PersonInfo&gt;</c> element.
	/// </summary>
	/// <value> A PersonInfo </value>
	/// <remarks>
	/// <para>To remove the <c>PersonInfo</c>, set <c>PersonInfo</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PersonInfo PersonInfo
	{
		get
		{
			return (PersonInfo)GetChild( StudentDTD.STUDENTSDTN_PERSONINFO);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_PERSONINFO);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_PERSONINFO, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "GUID that identifies the school that provided the SDTN."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for the school in the original database (sender)"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_SCHOOLLOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_SCHOOLLOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of school/campus."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_SCHOOLNAME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_SCHOOLNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AddressList&gt;</c> element.</summary>
	/// <param name="Address">An Address</param>
	///<remarks>
	/// <para>This form of <c>setAddressList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AddressList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAddressList( Address Address ) {
		RemoveChild( StudentDTD.STUDENTSDTN_ADDRESSLIST);
		AddChild( StudentDTD.STUDENTSDTN_ADDRESSLIST, new AddressList( Address ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AddressList&gt;</c> element.
	/// </summary>
	/// <value> An AddressList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The school's addresses."</para>
	/// <para>To remove the <c>AddressList</c>, set <c>AddressList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public AddressList AddressList
	{
		get
		{
			return (AddressList)GetChild( StudentDTD.STUDENTSDTN_ADDRESSLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_ADDRESSLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_ADDRESSLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;PrincipalInfo&gt;</c> element.</summary>
	/// <param name="ContactName">The name of the principal.</param>
	///<remarks>
	/// <para>This form of <c>setPrincipalInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PrincipalInfo</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPrincipalInfo( ContactName ContactName ) {
		RemoveChild( StudentDTD.STUDENTSDTN_PRINCIPALINFO);
		AddChild( StudentDTD.STUDENTSDTN_PRINCIPALINFO, new PrincipalInfo( ContactName ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PrincipalInfo&gt;</c> element.
	/// </summary>
	/// <value> A PrincipalInfo </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Information about the campus or school principal."</para>
	/// <para>To remove the <c>PrincipalInfo</c>, set <c>PrincipalInfo</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PrincipalInfo PrincipalInfo
	{
		get
		{
			return (PrincipalInfo)GetChild( StudentDTD.STUDENTSDTN_PRINCIPALINFO);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_PRINCIPALINFO);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_PRINCIPALINFO, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FurtherInformation&gt;</c> element.
	/// </summary>
	/// <value> A FurtherInformation </value>
	/// <remarks>
	/// <para>To remove the <c>FurtherInformation</c>, set <c>FurtherInformation</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public FurtherInformation FurtherInformation
	{
		get
		{
			return (FurtherInformation)GetChild( StudentDTD.STUDENTSDTN_FURTHERINFORMATION);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_FURTHERINFORMATION);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_FURTHERINFORMATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EnrollmentDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EnrollmentDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date when the student first attended the school."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? EnrollmentDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_ENROLLMENTDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_ENROLLMENTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DepartureDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>DepartureDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The last school calendar day the student attended or sign-out date if departure is before end of school year."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? DepartureDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_DEPARTUREDATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_DEPARTUREDATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;YearLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the year level.</param>
	///<remarks>
	/// <para>This form of <c>setYearLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>YearLevel</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetYearLevel( YearLevelCode Code ) {
		RemoveChild( StudentDTD.STUDENTSDTN_YEARLEVEL);
		AddChild( StudentDTD.STUDENTSDTN_YEARLEVEL, new YearLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YearLevel&gt;</c> element.
	/// </summary>
	/// <value> A YearLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "School Year or academic level of student at departure date."</para>
	/// <para>To remove the <c>YearLevel</c>, set <c>YearLevel</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public YearLevel YearLevel
	{
		get
		{
			return (YearLevel)GetChild( StudentDTD.STUDENTSDTN_YEARLEVEL);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_YEARLEVEL);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_YEARLEVEL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReasonForLeaving&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReasonForLeaving</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string ReasonForLeaving
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_REASONFORLEAVING ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_REASONFORLEAVING, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PreviousSchoolsList&gt;</c> element.</summary>
	/// <param name="PreviousSchool">A PreviousSchool</param>
	///<remarks>
	/// <para>This form of <c>setPreviousSchoolsList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PreviousSchoolsList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPreviousSchoolsList( PreviousSchool PreviousSchool ) {
		RemoveChild( StudentDTD.STUDENTSDTN_PREVIOUSSCHOOLSLIST);
		AddChild( StudentDTD.STUDENTSDTN_PREVIOUSSCHOOLSLIST, new PreviousSchoolsList( PreviousSchool ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PreviousSchoolsList&gt;</c> element.
	/// </summary>
	/// <value> A PreviousSchoolsList </value>
	/// <remarks>
	/// <para>To remove the <c>PreviousSchoolsList</c>, set <c>PreviousSchoolsList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PreviousSchoolsList PreviousSchoolsList
	{
		get
		{
			return (PreviousSchoolsList)GetChild( StudentDTD.STUDENTSDTN_PREVIOUSSCHOOLSLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_PREVIOUSSCHOOLSLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_PREVIOUSSCHOOLSLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceConcerns&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceConcerns</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator of whether the Student had attendance concerns worth noting."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AttendanceConcerns
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_ATTENDANCECONCERNS );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_ATTENDANCECONCERNS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AttendanceConcerns&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator of whether the Student had attendance concerns worth noting."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAttendanceConcerns( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_ATTENDANCECONCERNS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HealthNeeds&gt;</c> element.
	/// </summary>
	/// <value> The <c>HealthNeeds</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator of whether the Student has any Health Care Needs."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string HealthNeeds
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_HEALTHNEEDS );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_HEALTHNEEDS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;HealthNeeds&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicator of whether the Student has any Health Care Needs."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetHealthNeeds( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_HEALTHNEEDS, val );
	}

	///<summary>Sets the value of the <c>&lt;AreasOfInterestList&gt;</c> element.</summary>
	/// <param name="ActivityInfo">An ActivityInfo</param>
	///<remarks>
	/// <para>This form of <c>setAreasOfInterestList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AreasOfInterestList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAreasOfInterestList( ActivityInfo ActivityInfo ) {
		RemoveChild( StudentDTD.STUDENTSDTN_AREASOFINTERESTLIST);
		AddChild( StudentDTD.STUDENTSDTN_AREASOFINTERESTLIST, new AreasOfInterestList( ActivityInfo ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AreasOfInterestList&gt;</c> element.
	/// </summary>
	/// <value> An AreasOfInterestList </value>
	/// <remarks>
	/// <para>To remove the <c>AreasOfInterestList</c>, set <c>AreasOfInterestList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public AreasOfInterestList AreasOfInterestList
	{
		get
		{
			return (AreasOfInterestList)GetChild( StudentDTD.STUDENTSDTN_AREASOFINTERESTLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_AREASOFINTERESTLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_AREASOFINTERESTLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NegotiatedCurriculumPlan&gt;</c> element.
	/// </summary>
	/// <value> The <c>NegotiatedCurriculumPlan</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have a negotiated curriculum plan?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string NegotiatedCurriculumPlan
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_NEGOTIATEDCURRICULUMPLAN );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_NEGOTIATEDCURRICULUMPLAN, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;NegotiatedCurriculumPlan&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have a negotiated curriculum plan?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetNegotiatedCurriculumPlan( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_NEGOTIATEDCURRICULUMPLAN, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AdjustedEducationProgram&gt;</c> element.
	/// </summary>
	/// <value> The <c>AdjustedEducationProgram</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have an adjusted education program?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AdjustedEducationProgram
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_ADJUSTEDEDUCATIONPROGRAM );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_ADJUSTEDEDUCATIONPROGRAM, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AdjustedEducationProgram&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have an adjusted education program?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAdjustedEducationProgram( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_ADJUSTEDEDUCATIONPROGRAM, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CareerGuidanceFileHeld&gt;</c> element.
	/// </summary>
	/// <value> The <c>CareerGuidanceFileHeld</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have a career guidance file?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string CareerGuidanceFileHeld
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_CAREERGUIDANCEFILEHELD );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_CAREERGUIDANCEFILEHELD, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CareerGuidanceFileHeld&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student have a career guidance file?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetCareerGuidanceFileHeld( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_CAREERGUIDANCEFILEHELD, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolCounsellorFileHeld&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolCounsellorFileHeld</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is there a School counsellor/psychologist file held?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolCounsellorFileHeld
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_SCHOOLCOUNSELLORFILEHELD );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_SCHOOLCOUNSELLORFILEHELD, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;SchoolCounsellorFileHeld&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is there a School counsellor/psychologist file held?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSchoolCounsellorFileHeld( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_SCHOOLCOUNSELLORFILEHELD, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherLearningSupport&gt;</c> element.
	/// </summary>
	/// <value> The <c>OtherLearningSupport</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Comments describing any other required learning support, eg ESL needs."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string OtherLearningSupport
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTSDTN_OTHERLEARNINGSUPPORT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTSDTN_OTHERLEARNINGSUPPORT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AcceleratedProgram&gt;</c> element.
	/// </summary>
	/// <value> The <c>AcceleratedProgram</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Did the student participate in an accelerated learning program?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AcceleratedProgram
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_ACCELERATEDPROGRAM );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_ACCELERATEDPROGRAM, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AcceleratedProgram&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Did the student participate in an accelerated learning program?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAcceleratedProgram( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_ACCELERATEDPROGRAM, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YoungCarersRole&gt;</c> element.
	/// </summary>
	/// <value> The <c>YoungCarersRole</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is the student a carer of other family members?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string YoungCarersRole
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_YOUNGCARERSROLE );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_YOUNGCARERSROLE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;YoungCarersRole&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is the student a carer of other family members?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetYoungCarersRole( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_YOUNGCARERSROLE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Literacy&gt;</c> element.
	/// </summary>
	/// <value> The <c>Literacy</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Progress in Literacy or English according to the National Standard."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Literacy
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_LITERACY );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_LITERACY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Literacy&gt;</c> element.
	/// </summary>
	/// <param name="val">A ProgressLevelType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Progress in Literacy or English according to the National Standard."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetLiteracy( ProgressLevelType val )
	{
		SetField( StudentDTD.STUDENTSDTN_LITERACY, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Numeracy&gt;</c> element.
	/// </summary>
	/// <value> The <c>Numeracy</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Progress in Numeracy or Maths according to the National Standard."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Numeracy
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_NUMERACY );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_NUMERACY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Numeracy&gt;</c> element.
	/// </summary>
	/// <param name="val">A StudentSDTNProgressLevelType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Progress in Numeracy or Maths according to the National Standard."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetNumeracy( StudentSDTNProgressLevelType val )
	{
		SetField( StudentDTD.STUDENTSDTN_NUMERACY, val );
	}

	///<summary>Sets the value of the <c>&lt;OtherLearningAreasList&gt;</c> element.</summary>
	/// <param name="OtherLearningArea">An OtherLearningArea</param>
	///<remarks>
	/// <para>This form of <c>setOtherLearningAreasList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>OtherLearningAreasList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetOtherLearningAreasList( OtherLearningArea OtherLearningArea ) {
		RemoveChild( StudentDTD.STUDENTSDTN_OTHERLEARNINGAREASLIST);
		AddChild( StudentDTD.STUDENTSDTN_OTHERLEARNINGAREASLIST, new OtherLearningAreasList( OtherLearningArea ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherLearningAreasList&gt;</c> element.
	/// </summary>
	/// <value> An OtherLearningAreasList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherLearningAreasList</c>, set <c>OtherLearningAreasList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public OtherLearningAreasList OtherLearningAreasList
	{
		get
		{
			return (OtherLearningAreasList)GetChild( StudentDTD.STUDENTSDTN_OTHERLEARNINGAREASLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_OTHERLEARNINGAREASLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_OTHERLEARNINGAREASLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LatestStudentReportAvailable&gt;</c> element.
	/// </summary>
	/// <value> The <c>LatestStudentReportAvailable</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is the latest student report available?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LatestStudentReportAvailable
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTSDTN_LATESTSTUDENTREPORTAVAILABLE );
		}
		set
		{
			SetField( StudentDTD.STUDENTSDTN_LATESTSTUDENTREPORTAVAILABLE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;LatestStudentReportAvailable&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is the latest student report available?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetLatestStudentReportAvailable( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.STUDENTSDTN_LATESTSTUDENTREPORTAVAILABLE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PastoralCare&gt;</c> element.
	/// </summary>
	/// <value> A PastoralCare </value>
	/// <remarks>
	/// <para>To remove the <c>PastoralCare</c>, set <c>PastoralCare</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PastoralCare PastoralCare
	{
		get
		{
			return (PastoralCare)GetChild( StudentDTD.STUDENTSDTN_PASTORALCARE);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTSDTN_PASTORALCARE);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTSDTN_PASTORALCARE, value );
			}
		}
	}

}}