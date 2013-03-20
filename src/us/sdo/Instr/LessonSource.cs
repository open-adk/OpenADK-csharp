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

namespace OpenADK.Library.us.Instr{

/// <summary>One or more sources for the lesson.  This describes the lesson's origin.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class LessonSource : SifList<SourceAuthor>
{
	/// <summary>
	/// Creates an instance of a LessonSource
	/// </summary>
	public LessonSource() : base ( InstrDTD.LESSONSOURCE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="author">For each source, the authors of the source.</param>
	///
	public LessonSource( SourceAuthor author ) : base( InstrDTD.LESSONSOURCE )
	{
		this.SafeAddChild( InstrDTD.LESSONSOURCE_AUTHOR, author );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LessonSource( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
}}
