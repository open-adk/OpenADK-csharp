// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using OpenADK.Util;
using OpenADK.Library;
using OpenADK.Library.Impl;
using CommonDTD = OpenADK.Library.au.Common.CommonDTD;
using ReportingDTD = OpenADK.Library.au.Reporting.ReportingDTD;

namespace OpenADK.Library.au.System
{

// BEGIN FILE... (SIFDTD_Comments_CS.txt)

	/// <summary>Metadata for the Schools Interoperability Framework (SIF)</summary>
	/// <remarks>
	/// <para>
	/// SIFDTD defines global {@linkplain com.edustructures.sifworks.ElementDef} 
	/// constants that describe SIF Data Objects, elements, and attributes across all 
	/// supported versions of the SIF Specification. The ADK uses this metadata 
	/// internally to parse and render SIF Data Objects.  In addition, many of the 
	/// framework APIs require that the programmer pass an ElementDef constant from 
	/// the SIFDTD class to identify an object, element, or attribute.
	/// </para>
	/// <para>
	/// ElementDef constants are named <c>[PARENT_]ENTITY</c>, where 
	/// <c>PARENT</c> is the name of the parent element and 
	/// <c>ENTITY</c> is the name of the element or attribute 
	/// encapsulated by the ElementDef. Some examples of ElementDef constants defined
	/// by this class include:
	/// </para>
	/// <list type="table">
	/// <listheader><term>IElementDef</term><description>Description</description></listheader>
	/// <item><term><c>SIFDTD.STUDENTPERSONAL</c></term><description>Identifies the StudentPersonal data object</description></item>
	/// <item><term><c>SIFDTD.SCHOOLINFO</c></term><description>Identifies the SchoolInfo data object</description></item>
	/// </list>
	/// Many of the Adk's public interfaces require an ElementDef constant to be passed
	/// as a parameter. For example, the first parameter to the <see cref="IZone.SetSubscriber"/>
	/// method is an IElementDef:
	/// <code>myZone.setSubscriber( SIFDTD.BUSINFO, this, ADKFlags.PROV_SUBSCRIBE );</code>
	/// ElementDef also identifies child elements and attributes as demonstrated by the	<c>Query.AddCondition</c> method:
	/// <code>
	/// Query query = new Query( SifDtd.STUDENTPERSONAL );
	/// query.AddCondition( SifDtd.STUDENTPERSONAL_REFID, Condition.EQ, "4A37969803F0D00322AF0EB969038483" );
	/// </code>
	/// <para>
	/// <b>SDO Libraries</b>
	/// </para>
	/// <para>
	/// ElementDef metadata is grouped into "SDO Libraries", which are organized along 
	/// SIF Working Group boundaries. SDO Libraries are loaded into the <c>SifDdt</c> 
	/// class when the Adk is initialized. All or part of the metadata is loaded into depending on the flags passed to the
	/// <see cref="Adk.Initialize(SifVersion, SdoLibraryType)"/> method,
	/// metadata from one or more SDO Libraries may be loaded. For example, the following
	/// call loads metadata for the <c>Student Information Working Group Objects</c>  
	/// and <c>Transportation And Geographic Information Working Group Objects</c> 
	/// (Common Elements and <c>Infrastructure Working Group Objects</c> metadata is always loaded
	/// </para>
	/// <code>Adk.Initialize( SiFVersion.LATEST, SdoLibraryType.Student | SdoLibraryType.Trans )</code>
	/// <para>
	/// If an given SDO Library is not loaded, all of the SIFDTD constants that belong
	/// to that library will be <code>null</code> and cannot be referenced. For example,
	/// given the SDO Libraries loaded above, attempting to reference the 
	/// <code>SIFDTD.LIBRARYPATRONSTATUS</code> object from the Library Automation Working
	/// Group would result in a NullPointerException:
	/// </para>
	/// <code>SifDtd.LIBRARYPATRONSTATUS.Name;</code>
	/// </remarks>
	public class SystemDTD : OpenADK.Library.Impl.SdoLibraryImpl
	{
	/** Defines the &lt;Role&gt; SIF Data Object */
	public static IElementDef ROLE = null;
	/** Defines the &lt;RoleList&gt; SIF Data Object */
	public static IElementDef ROLELIST = null;
	/** Defines the &lt;RoleScope&gt; SIF Data Object */
	public static IElementDef ROLESCOPE = null;
	/** Defines the &lt;RoleScopeList&gt; SIF Data Object */
	public static IElementDef ROLESCOPELIST = null;
	/** Defines the &lt;RoleScopeRefId&gt; SIF Data Object */
	public static IElementDef ROLESCOPEREFID = null;
	/** Defines the &lt;SystemContext&gt; SIF Data Object */
	public static IElementDef SYSTEMCONTEXT = null;
	/** Defines the &lt;SystemContextList&gt; SIF Data Object */
	public static IElementDef SYSTEMCONTEXTLIST = null;
	/** Defines the &lt;SystemRole&gt; SIF Data Object */
	public static IElementDef SYSTEMROLE = null;
	/** Defines the &lt;SystenRoleSIF_RefId&gt; SIF Data Object */
	public static IElementDef SYSTENROLESIF_REFID = null;


	// Field elements of ROLE (2 fields)
	/** Defines the RoleId attribute as a child of &lt;Role&gt; */
	public static IElementDef ROLE_ROLEID = null;
	/** Defines the &lt;RoleScopeList&gt; element as a child of &lt;Role&gt; */
	public static IElementDef ROLE_ROLESCOPELIST = null;

	// Field elements of ROLELIST (1 fields)
	/** Defines the &lt;Role&gt; element as a child of &lt;RoleList&gt; */
	public static IElementDef ROLELIST_ROLE = null;

	// Field elements of ROLESCOPE (2 fields)
	/** Defines the &lt;RoleScopeName&gt; element as a child of &lt;RoleScope&gt; */
	public static IElementDef ROLESCOPE_ROLESCOPENAME = null;
	/** Defines the &lt;RoleScopeRefId&gt; element as a child of &lt;RoleScope&gt; */
	public static IElementDef ROLESCOPE_ROLESCOPEREFID = null;

	// Field elements of ROLESCOPELIST (1 fields)
	/** Defines the &lt;RoleScope&gt; element as a child of &lt;RoleScopeList&gt; */
	public static IElementDef ROLESCOPELIST_ROLESCOPE = null;

	// Field elements of ROLESCOPEREFID (1 fields)
	/** Defines the SIF_RefObject attribute as a child of &lt;RoleScopeRefId&gt; */
	public static IElementDef ROLESCOPEREFID_SIF_REFOBJECT = null;

	// Field elements of SYSTEMCONTEXT (2 fields)
	/** Defines the SystemId attribute as a child of &lt;SystemContext&gt; */
	public static IElementDef SYSTEMCONTEXT_SYSTEMID = null;
	/** Defines the &lt;RoleList&gt; element as a child of &lt;SystemContext&gt; */
	public static IElementDef SYSTEMCONTEXT_ROLELIST = null;

	// Field elements of SYSTEMCONTEXTLIST (1 fields)
	/** Defines the &lt;SystemContext&gt; element as a child of &lt;SystemContextList&gt; */
	public static IElementDef SYSTEMCONTEXTLIST_SYSTEMCONTEXT = null;

	// Field elements of SYSTEMROLE (2 fields)
	/** Defines the RefId attribute as a child of &lt;SystemRole&gt; */
	public static IElementDef SYSTEMROLE_REFID = null;
	/** Defines the &lt;SIF_RefId&gt; element as a child of &lt;SystemRole&gt; */
	public static IElementDef SYSTEMROLE_SIF_REFID = null;
	/** SIF 1.5 and later: Defines the built-in SIF_ExtendedElements element common to all SIF Data Objects */
	public static IElementDef SYSTEMROLE_SIF_EXTENDEDELEMENTS = null;
	/** SIF 2.0 and later: Defines the built-in SIF_Metadata element common to all SIF Data Objects */
	public static IElementDef SYSTEMROLE_SIF_METADATA = null;

	// Field elements of SYSTENROLESIF_REFID (2 fields)
	/** Defines the SIF_RefObject attribute as a child of &lt;SystenRoleSIF_RefId&gt; */
	public static IElementDef SYSTENROLESIF_REFID_SIF_REFOBJECT = null;
	/** Defines the &lt;SystemContextList&gt; element as a child of &lt;SystenRoleSIF_RefId&gt; */
	public static IElementDef SYSTENROLESIF_REFID_SYSTEMCONTEXTLIST = null;

	public override void Load()
	{
		//  Objects defined by this SDO Library...

		ROLE = new ElementDefImpl( null, "Role", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		ROLELIST = new ElementDefImpl( null, "RoleList", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		ROLESCOPE = new ElementDefImpl( null, "RoleScope", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		ROLESCOPELIST = new ElementDefImpl( null, "RoleScopeList", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		ROLESCOPEREFID = new ElementDefImpl( null, "RoleScopeRefId", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );
		SYSTEMCONTEXT = new ElementDefImpl( null, "SystemContext", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		SYSTEMCONTEXTLIST = new ElementDefImpl( null, "SystemContextList", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		SYSTEMROLE = new ElementDefImpl( null, "SystemRole", null, 0, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_OBJECT), SifVersion.SIF24, SifVersion.SIF26 );
		SYSTENROLESIF_REFID = new ElementDefImpl( null, "SystenRoleSIF_RefId", null, 0, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );


		// <Role> fields (2 entries)
		SystemDTD.ROLE_ROLEID = new ElementDefImpl( ROLE, "RoleId", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );
		SystemDTD.ROLE_ROLESCOPELIST = new ElementDefImpl( ROLE, "RoleScopeList", null, 2, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );

		// <RoleList> fields (1 entries)
		SystemDTD.ROLELIST_ROLE = new ElementDefImpl( ROLELIST, "Role", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF24, SifVersion.SIF26 );

		// <RoleScope> fields (2 entries)
		SystemDTD.ROLESCOPE_ROLESCOPENAME = new ElementDefImpl( ROLESCOPE, "RoleScopeName", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_FIELD), SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );
		SystemDTD.ROLESCOPE_ROLESCOPEREFID = new ElementDefImpl( ROLESCOPE, "RoleScopeRefId", null, 2, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );

		// <RoleScopeList> fields (1 entries)
		SystemDTD.ROLESCOPELIST_ROLESCOPE = new ElementDefImpl( ROLESCOPELIST, "RoleScope", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF24, SifVersion.SIF26 );

		// <RoleScopeRefId> fields (1 entries)
		SystemDTD.ROLESCOPEREFID_SIF_REFOBJECT = new ElementDefImpl( ROLESCOPEREFID, "SIF_RefObject", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );

		// <SystemContext> fields (2 entries)
		SystemDTD.SYSTEMCONTEXT_SYSTEMID = new ElementDefImpl( SYSTEMCONTEXT, "SystemId", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );
		SystemDTD.SYSTEMCONTEXT_ROLELIST = new ElementDefImpl( SYSTEMCONTEXT, "RoleList", null, 2, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );

		// <SystemContextList> fields (1 entries)
		SystemDTD.SYSTEMCONTEXTLIST_SYSTEMCONTEXT = new ElementDefImpl( SYSTEMCONTEXTLIST, "SystemContext", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_REPEATABLE), SifVersion.SIF24, SifVersion.SIF26 );

		// <SystemRole> fields (2 entries)
		SystemDTD.SYSTEMROLE_REFID = new ElementDefImpl( SYSTEMROLE, "RefId", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );
		SystemDTD.SYSTEMROLE_SIF_REFID = new ElementDefAlias( SYSTEMROLE, "SIF_RefId", null, "SystenRoleSIF_RefId", 2, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
		SYSTEMROLE_SIF_EXTENDEDELEMENTS = new ElementDefImpl( SYSTEMROLE, "SIF_ExtendedElements", null, 127, SifDtd.GLOBAL, null, (0), SifVersion.SIF15r1, SifVersion.SIF26 );
		SYSTEMROLE_SIF_METADATA = new ElementDefImpl( SYSTEMROLE, "SIF_Metadata", null, 128, SifDtd.DATAMODEL, "au", (0), SifVersion.SIF20, SifVersion.SIF26 );

		// <SystenRoleSIF_RefId> fields (2 entries)
		SystemDTD.SYSTENROLESIF_REFID_SIF_REFOBJECT = new ElementDefImpl( SYSTENROLESIF_REFID, "SIF_RefObject", null, 1, SifDtd.SYSTEM, "au", (ElementDefImpl.FD_ATTRIBUTE), SifVersion.SIF24, SifVersion.SIF26, SifTypeConverters.STRING );
		SystemDTD.SYSTENROLESIF_REFID_SYSTEMCONTEXTLIST = new ElementDefImpl( SYSTENROLESIF_REFID, "SystemContextList", null, 2, SifDtd.SYSTEM, "au", 0, SifVersion.SIF24, SifVersion.SIF26 );
	}

	#region Update SifDtd
	public override void AddElementMappings( IDictionary<String, IElementDef> dictionary )
	{
		dictionary[ "SystemRole" ] = SYSTEMROLE;
		dictionary[ "SystemRole_SIF_ExtendedElements" ] = SYSTEMROLE_SIF_EXTENDEDELEMENTS ;
		dictionary[ "SystemRole_SIF_Metadata" ] = SYSTEMROLE_SIF_METADATA;
		dictionary["SystemRole_RefId"] = SystemDTD.SYSTEMROLE_REFID ;
		dictionary["SystemRole_SIF_RefId"] = SystemDTD.SYSTEMROLE_SIF_REFID ;
		dictionary[ "SystemContextList" ] = SYSTEMCONTEXTLIST;
		dictionary["SystemContextList_SystemContext"] = SystemDTD.SYSTEMCONTEXTLIST_SYSTEMCONTEXT ;
		dictionary[ "RoleScope" ] = ROLESCOPE;
		dictionary["RoleScope_RoleScopeName"] = SystemDTD.ROLESCOPE_ROLESCOPENAME ;
		dictionary["RoleScope_RoleScopeRefId"] = SystemDTD.ROLESCOPE_ROLESCOPEREFID ;
		dictionary[ "Role" ] = ROLE;
		dictionary["Role_RoleId"] = SystemDTD.ROLE_ROLEID ;
		dictionary["Role_RoleScopeList"] = SystemDTD.ROLE_ROLESCOPELIST ;
		dictionary[ "SystenRoleSIF_RefId" ] = SYSTENROLESIF_REFID;
		dictionary["SystenRoleSIF_RefId_SIF_RefObject"] = SystemDTD.SYSTENROLESIF_REFID_SIF_REFOBJECT ;
		dictionary["SystenRoleSIF_RefId_SystemContextList"] = SystemDTD.SYSTENROLESIF_REFID_SYSTEMCONTEXTLIST ;
		dictionary[ "RoleList" ] = ROLELIST;
		dictionary["RoleList_Role"] = SystemDTD.ROLELIST_ROLE ;
		dictionary[ "RoleScopeRefId" ] = ROLESCOPEREFID;
		dictionary["RoleScopeRefId_SIF_RefObject"] = SystemDTD.ROLESCOPEREFID_SIF_REFOBJECT ;
		dictionary[ "RoleScopeList" ] = ROLESCOPELIST;
		dictionary["RoleScopeList_RoleScope"] = SystemDTD.ROLESCOPELIST_ROLESCOPE ;
		dictionary[ "SystemContext" ] = SYSTEMCONTEXT;
		dictionary["SystemContext_RoleList"] = SystemDTD.SYSTEMCONTEXT_ROLELIST ;
		dictionary["SystemContext_SystemId"] = SystemDTD.SYSTEMCONTEXT_SYSTEMID ;
	}
	#endregion
}}
