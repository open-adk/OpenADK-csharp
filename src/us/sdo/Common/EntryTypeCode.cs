// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EntryTypeCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EntryTypeCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class EntryTypeCode : SifEnum
	{
	/// <summary>Student was received from a School in the same District ("D05")</summary>
	public static readonly EntryTypeCode ENTRY_D05 = new EntryTypeCode("D05");

	/// <summary>Transfer from a public school in the same local education agency ("1821")</summary>
	public static readonly EntryTypeCode C0619_1821 = new EntryTypeCode("1821");

	/// <summary>Student was received from another Attendance Reporting Unit in the same School ("D04")</summary>
	public static readonly EntryTypeCode ENTRY_D04 = new EntryTypeCode("D04");

	/// <summary>Student has attended a non-Public School or Home Education Program in or out of state this year, but is entering a Public School in this state for the first time this school year ("D03")</summary>
	public static readonly EntryTypeCode ENTRY_D03 = new EntryTypeCode("D03");

	/// <summary>Original entry into a United States school from a foreign country with no interruption in schooling ("1839")</summary>
	public static readonly EntryTypeCode C0619_1839 = new EntryTypeCode("1839");

	/// <summary>Original entry into a United States school ("1838")</summary>
	public static readonly EntryTypeCode C0619_1838 = new EntryTypeCode("1838");

	/// <summary>Re-entry after an involuntary withdrawal ("1837")</summary>
	public static readonly EntryTypeCode C0619_1837 = new EntryTypeCode("1837");

	/// <summary>Re-entry after a voluntary withdrawal ("1836")</summary>
	public static readonly EntryTypeCode C0619_1836 = new EntryTypeCode("1836");

	/// <summary>Re-entry from the same school with no interruption of schooling ("1835")</summary>
	public static readonly EntryTypeCode C0619_1835 = new EntryTypeCode("1835");

	/// <summary>Matriculation from another school ("1834")</summary>
	public static readonly EntryTypeCode C0619_1834 = new EntryTypeCode("1834");

	/// <summary>Transfer from home schooling ("1833")</summary>
	public static readonly EntryTypeCode C0619_1833 = new EntryTypeCode("1833");

	/// <summary>Transfer from a charter school ("1832")</summary>
	public static readonly EntryTypeCode C0619_1832 = new EntryTypeCode("1832");

	/// <summary>Transfer from an institution ("1831")</summary>
	public static readonly EntryTypeCode C0619_1831 = new EntryTypeCode("1831");

	/// <summary>Transfer from a school outside of the country ("1830")</summary>
	public static readonly EntryTypeCode C0619_1830 = new EntryTypeCode("1830");

	/// <summary>Original entry into a United States school from a foreign country with an interruption in schooling ("1840")</summary>
	public static readonly EntryTypeCode C0619_1840 = new EntryTypeCode("1840");

	/// <summary>Previously attended out-of-state public school this year, but is entering a public school in this state for the first time this school year ("D23")</summary>
	public static readonly EntryTypeCode ENTRY_D23 = new EntryTypeCode("D23");

	/// <summary>Student has not entered any school in this or any other state this school year ("D22")</summary>
	public static readonly EntryTypeCode ENTRY_D22 = new EntryTypeCode("D22");

	/// <summary>Transfer from a private, religiously-affiliated school in a different state ("1829")</summary>
	public static readonly EntryTypeCode C0619_1829 = new EntryTypeCode("1829");

	/// <summary>Transfer from a private, religiously-affiliated school in a different local education agency in the same state ("1828")</summary>
	public static readonly EntryTypeCode C0619_1828 = new EntryTypeCode("1828");

	/// <summary>Transfer from a private, religiously-affiliated school in the same local education agency ("1827")</summary>
	public static readonly EntryTypeCode C0619_1827 = new EntryTypeCode("1827");

	/// <summary>Transfer from a private, non-religiously-affiliated school in a different state ("1826")</summary>
	public static readonly EntryTypeCode C0619_1826 = new EntryTypeCode("1826");

	/// <summary>Transfer from a private, non-religiously-affiliated school in a different local education agency in the same state ("1825")</summary>
	public static readonly EntryTypeCode C0619_1825 = new EntryTypeCode("1825");

	/// <summary>Transfer from a private, non-religiously-affiliated school in the same local education agency ("1824")</summary>
	public static readonly EntryTypeCode C0619_1824 = new EntryTypeCode("1824");

	/// <summary>Student unexpectedly re-entered the same school after withdrawing or being discharged ("D08")</summary>
	public static readonly EntryTypeCode ENTRY_D08 = new EntryTypeCode("D08");

	/// <summary>Other ("9999")</summary>
	public static readonly EntryTypeCode C0619_9999 = new EntryTypeCode("9999");

	/// <summary>Transfer from a public school in a different state ("1823")</summary>
	public static readonly EntryTypeCode C0619_1823 = new EntryTypeCode("1823");

	/// <summary>Student was received from a non-Public School either in or out of the District or has returned after having been enrolled in a Home Education Program; the student must have been enrolled previously in a Public School this year ("D07")</summary>
	public static readonly EntryTypeCode ENTRY_D07 = new EntryTypeCode("D07");

	/// <summary>Transfer from a public school in a different local education agency in the same state ("1822")</summary>
	public static readonly EntryTypeCode C0619_1822 = new EntryTypeCode("1822");

	/// <summary>Student was received from another Public School outside the District either in or out of state ("D06")</summary>
	public static readonly EntryTypeCode ENTRY_D06 = new EntryTypeCode("D06");

	///<summary>Wrap an arbitrary string value in an EntryTypeCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EntryTypeCode Wrap( String wrappedValue ) {
		return new EntryTypeCode( wrappedValue );
	}

	private EntryTypeCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}
