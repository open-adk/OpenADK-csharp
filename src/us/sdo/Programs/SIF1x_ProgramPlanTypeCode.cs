// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Programs
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SIF1x_ProgramPlanTypeCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SIF1x_ProgramPlanTypeCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class SIF1x_ProgramPlanTypeCode : SifEnum
	{
	/// <summary>Services Plan ("SP")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_SERVICES_PLAN = new SIF1x_ProgramPlanTypeCode("SP");

	/// <summary>Literacy Plan ("LIT")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_LITERACY_PLAN = new SIF1x_ProgramPlanTypeCode("LIT");

	/// <summary>Individualized Learning Plan ("ILP")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_IND_LEARNING = new SIF1x_ProgramPlanTypeCode("ILP");

	/// <summary>Individualized Transition Plan ("ITP")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_IND_TRANSITION = new SIF1x_ProgramPlanTypeCode("ITP");

	/// <summary>Individualized Family Service Plan ("IFSP")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_IND_FAMILY_SERVICE = new SIF1x_ProgramPlanTypeCode("IFSP");

	/// <summary>Individualized Education Plan ("IEP")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_IND_EDUCATION = new SIF1x_ProgramPlanTypeCode("IEP");

	/// <summary>Other ("Other")</summary>
	public static readonly SIF1x_ProgramPlanTypeCode SIF1x_OTHER = new SIF1x_ProgramPlanTypeCode("Other");

	///<summary>Wrap an arbitrary string value in a SIF1x_ProgramPlanTypeCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SIF1x_ProgramPlanTypeCode Wrap( String wrappedValue ) {
		return new SIF1x_ProgramPlanTypeCode( wrappedValue );
	}

	private SIF1x_ProgramPlanTypeCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
