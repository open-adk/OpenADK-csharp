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

namespace OpenADK.Library.us.Student{

/// <summary>A LanguageOfInstruction</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class LanguageOfInstruction : SifElement
{
	/// <summary>
	/// Creates an instance of a LanguageOfInstruction
	/// </summary>
	public LanguageOfInstruction() : base ( StudentDTD.LANGUAGEOFINSTRUCTION ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LanguageOfInstruction( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code representing the language of instruction."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( StudentDTD.LANGUAGEOFINSTRUCTION_CODE );
		}
		set
		{
			SetField( StudentDTD.LANGUAGEOFINSTRUCTION_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A LanguageCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code representing the language of instruction."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCode( LanguageCode val )
	{
		SetField( StudentDTD.LANGUAGEOFINSTRUCTION_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( StudentDTD.LANGUAGEOFINSTRUCTION_OTHERCODELIST);
		}
		set
		{
			RemoveChild( StudentDTD.LANGUAGEOFINSTRUCTION_OTHERCODELIST);
			if( value != null)
			{
				AddChild( StudentDTD.LANGUAGEOFINSTRUCTION_OTHERCODELIST, value );
			}
		}
	}

}}