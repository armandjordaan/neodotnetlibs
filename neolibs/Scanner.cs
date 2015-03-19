/*
                    GNU LESSER GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.


  This version of the GNU Lesser General Public License incorporates
the terms and conditions of version 3 of the GNU General Public
License, supplemented by the additional permissions listed below.

  0. Additional Definitions.

  As used herein, "this License" refers to version 3 of the GNU Lesser
General Public License, and the "GNU GPL" refers to version 3 of the GNU
General Public License.

  "The Library" refers to a covered work governed by this License,
other than an Application or a Combined Work as defined below.

  An "Application" is any work that makes use of an interface provided
by the Library, but which is not otherwise based on the Library.
Defining a subclass of a class defined by the Library is deemed a mode
of using an interface provided by the Library.

  A "Combined Work" is a work produced by combining or linking an
Application with the Library.  The particular version of the Library
with which the Combined Work was made is also called the "Linked
Version".

  The "Minimal Corresponding Source" for a Combined Work means the
Corresponding Source for the Combined Work, excluding any source code
for portions of the Combined Work that, considered in isolation, are
based on the Application, and not on the Linked Version.

  The "Corresponding Application Code" for a Combined Work means the
object code and/or source code for the Application, including any data
and utility programs needed for reproducing the Combined Work from the
Application, but excluding the System Libraries of the Combined Work.

  1. Exception to Section 3 of the GNU GPL.

  You may convey a covered work under sections 3 and 4 of this License
without being bound by section 3 of the GNU GPL.

  2. Conveying Modified Versions.

  If you modify a copy of the Library, and, in your modifications, a
facility refers to a function or data to be supplied by an Application
that uses the facility (other than as an argument passed when the
facility is invoked), then you may convey a copy of the modified
version:

   a) under this License, provided that you make a good faith effort to
   ensure that, in the event an Application does not supply the
   function or data, the facility still operates, and performs
   whatever part of its purpose remains meaningful, or

   b) under the GNU GPL, with none of the additional permissions of
   this License applicable to that copy.

  3. Object Code Incorporating Material from Library Header Files.

  The object code form of an Application may incorporate material from
a header file that is part of the Library.  You may convey such object
code under terms of your choice, provided that, if the incorporated
material is not limited to numerical parameters, data structure
layouts and accessors, or small macros, inline functions and templates
(ten or fewer lines in length), you do both of the following:

   a) Give prominent notice with each copy of the object code that the
   Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the object code with a copy of the GNU GPL and this license
   document.

  4. Combined Works.

  You may convey a Combined Work under terms of your choice that,
taken together, effectively do not restrict modification of the
portions of the Library contained in the Combined Work and reverse
engineering for debugging such modifications, if you also do each of
the following:

   a) Give prominent notice with each copy of the Combined Work that
   the Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the Combined Work with a copy of the GNU GPL and this license
   document.

   c) For a Combined Work that displays copyright notices during
   execution, include the copyright notice for the Library among
   these notices, as well as a reference directing the user to the
   copies of the GNU GPL and this license document.

   d) Do one of the following:

       0) Convey the Minimal Corresponding Source under the terms of this
       License, and the Corresponding Application Code in a form
       suitable for, and under terms that permit, the user to
       recombine or relink the Application with a modified version of
       the Linked Version to produce a modified Combined Work, in the
       manner specified by section 6 of the GNU GPL for conveying
       Corresponding Source.

       1) Use a suitable shared library mechanism for linking with the
       Library.  A suitable mechanism is one that (a) uses at run time
       a copy of the Library already present on the user's computer
       system, and (b) will operate properly with a modified version
       of the Library that is interface-compatible with the Linked
       Version.

   e) Provide Installation Information, but only if you would otherwise
   be required to provide such information under section 6 of the
   GNU GPL, and only to the extent that such information is
   necessary to install and execute a modified version of the
   Combined Work produced by recombining or relinking the
   Application with a modified version of the Linked Version. (If
   you use option 4d0, the Installation Information must accompany
   the Minimal Corresponding Source and Corresponding Application
   Code. If you use option 4d1, you must provide the Installation
   Information in the manner specified by section 6 of the GNU GPL
   for conveying Corresponding Source.)

  5. Combined Libraries.

  You may place library facilities that are a work based on the
Library side by side in a single library together with other library
facilities that are not Applications and are not covered by this
License, and convey such a combined library under terms of your
choice, if you do both of the following:

   a) Accompany the combined library with a copy of the same work based
   on the Library, uncombined with any other library facilities,
   conveyed under the terms of this License.

   b) Give prominent notice with the combined library that part of it
   is a work based on the Library, and explaining where to find the
   accompanying uncombined form of the same work.

  6. Revised Versions of the GNU Lesser General Public License.

  The Free Software Foundation may publish revised and/or new versions
of the GNU Lesser General Public License from time to time. Such new
versions will be similar in spirit to the present version, but may
differ in detail to address new problems or concerns.

  Each version is given a distinguishing version number. If the
Library as you received it specifies that a certain numbered version
of the GNU Lesser General Public License "or any later version"
applies to it, you have the option of following the terms and
conditions either of that published version or of any later version
published by the Free Software Foundation. If the Library as you
received it does not specify a version number of the GNU Lesser
General Public License, you may choose any version of the GNU Lesser
General Public License ever published by the Free Software Foundation.

  If the Library as you received it specifies that a proxy can decide
whether future versions of the GNU Lesser General Public License shall
apply, that proxy's public statement of acceptance of any version is
permanent authorization for you to choose that version for the
Library.

 */

//
// Geoffrey Slinker - from CodeProject.com
//
using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

namespace neolibs.Scanning
{
	/// <summary>
	/// Summary description for Scanner.
	/// </summary>
	public class Scanner
	{
        /// <summary>
        /// Typepatterns hashtable (???!!)
        /// </summary>
		protected readonly Hashtable typePatterns;

        /// <summary>
        /// Constructor for Scanner class
        /// </summary>
		public Scanner()
		{
			typePatterns = new Hashtable();

			typePatterns.Add("String",@"[\w\d\S]+");
			typePatterns.Add("Int16",  @"-[0-9]+|[0-9]+");
			typePatterns.Add("UInt16",  @"[0-9]+");
			typePatterns.Add("Int32",  @")(-[0-9]+|[0-9]+)(");
			typePatterns.Add("UInt32",  @"[0-9]+");
			typePatterns.Add("Int64",   @"-[0-9]+|[0-9]+");
			typePatterns.Add("UInt64",   @"[0-9]+");
			typePatterns.Add("Boolean",   @"true|false");
			typePatterns.Add("Byte",  @"[0-9]{1,3}");
			typePatterns.Add("SByte",  @"-[0-9]{1,3}|[0-9]{1,3}");
			typePatterns.Add("Char",  @"[\w\S]{1}");

			//typePatterns.Add("Single",   @"[-]|[.]|[-.]|[0-9][0-9]*[.]*[0-9]+");
			//typePatterns.Add("Double",   @"[-]|[.]|[-.]|[0-9][0-9]*[.]*[0-9]+");
			//typePatterns.Add("Decimal", @"[-]|[.]|[-.]|[0-9][0-9]*[.]*[0-9]+");

            typePatterns.Add("Double", @"[-|+]?[0-9]*[.]?[0-9]*");
            typePatterns.Add("Single", @"[-|+]?[0-9]*[.]?[0-9]*");   
            typePatterns.Add("Decimal",@"[-|+]?[0-9]*[.]?[0-9]*");
		}

		/// <summary>
		/// Scan memics scanf.
		/// A master regular expression pattern is created that will group each "word" in the text and using regex grouping
		/// extract the values for the field specifications.
		/// Example text: "Hello true 6.5"  fieldSpecification: "{String} {Boolean} {Double}"
		/// The fieldSpecification will result in the generation of a master Pattern:
		/// ([\w\d\S]+)\s+(true|false)\s+([-]|[.]|[-.]|[0-9][0-9]*[.]*[0-9]+)
		/// This masterPattern is ran against the text string and the groups are extracted.
		/// </summary>
		/// <param name="text"></param>
		/// <param name="fieldSpecification">A string that may contain simple field specifications of the form {Int16}, {String}, etc</param>
		/// <returns>object[] that contains values for each field</returns>
		public object[] Scan(string text, string fieldSpecification)
		{
			object[] targets = null;
			try
			{
				ArrayList targetMatchGroups = new ArrayList();
				ArrayList targetTypes = new ArrayList();

				string matchingPattern = "";
				Regex reggie = null;
				MatchCollection matches = null;

				//masterPattern is going to hold a "big" regex pattern that will be ran against the original text
				string masterPattern = fieldSpecification.Trim();
				matchingPattern =  @"(\S+)";
				masterPattern = Regex.Replace(masterPattern,matchingPattern,"($1)");		//insert grouping parens

				//store the group location of the format tags so that we can select the correct group values later.
				matchingPattern = @"(\([\w\d\S]+\))";
				reggie = new Regex(matchingPattern);
				matches = reggie.Matches(masterPattern);
				for(int i = 0; i < matches.Count; i++)
				{
					Match m = matches[i];
					string sVal = m.Groups[1].Captures[0].Value;

					//is this value a {n} value. We will determine this by checking for {
					if(sVal.IndexOf('{') >= 0)
					{
						targetMatchGroups.Add(i);
						string p = @"\(\{(\w*)\}\)";	//pull out the type
						sVal = Regex.Replace(sVal,p,"$1");
						targetTypes.Add(sVal);
					}
				}
			
				//Replace all of the types with the pattern that matches that type
				masterPattern = Regex.Replace(masterPattern,@"\{String\}",  (String)typePatterns["String"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Int16\}",  (String)typePatterns["Int16"]);
				masterPattern = Regex.Replace(masterPattern,@"\{UInt16\}",  (String)typePatterns["UInt16"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Int32\}",  (String)typePatterns["Int32"]);
				masterPattern = Regex.Replace(masterPattern,@"\{UInt32\}",  (String)typePatterns["UInt32"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Int64\}",  (String)typePatterns["Int64"]);
				masterPattern = Regex.Replace(masterPattern,@"\{UInt64\}",   (String)typePatterns["UInt64"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Single\}",   (String)typePatterns["Single"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Double\}",   (String)typePatterns["Double"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Boolean\}",   (String)typePatterns["Boolean"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Byte\}",  (String)typePatterns["Byte"]);
				masterPattern = Regex.Replace(masterPattern,@"\{SByte\}",  (String)typePatterns["SByte"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Char\}",  (String)typePatterns["Char"]);
				masterPattern = Regex.Replace(masterPattern,@"\{Decimal\}", (String)typePatterns["Decimal"]);
				
				masterPattern = Regex.Replace(masterPattern,@"\s+","\\s+");	//replace the white space with the pattern for white space

				//run our generated pattern against the original text.
				reggie = new Regex(masterPattern);
				matches = reggie.Matches(text);
				//PrintMatches(matches);

				//allocate the targets
				targets = new object[targetMatchGroups.Count];
				for(int x = 0; x < targetMatchGroups.Count; x++)
				{
					int i = (int)targetMatchGroups[x];	
					string tName = (string)targetTypes[x];
					if(i < matches[0].Groups.Count)
					{
						//add 1 to i because i is a result of serveral matches each resulting in one group.
						//this query is one match resulting in serveral groups.
						string sValue = matches[0].Groups[i+1].Captures[0].Value;
						targets[x] = ReturnValue(tName,sValue);
					}
				}
			}
			catch(Exception ex)
			{
				throw new ScanExeption("Scan exception",ex);
			}
			
			return targets;
		}//Scan

		/// Scan memics scanf.
		/// A master regular expression pattern is created that will group each "word" in the text and using regex grouping
		/// extract the values for the field specifications.
		/// Example text: "Hello true 6.5"  fieldSpecification: "{0} {1} {2}" and the target array has objects of these types: "String, ,Boolean, Double"
		/// The targets are scanned and each target type is extracted in order to build a master pattern based on these types
		/// The fieldSpecification and target types will result in the generation of a master Pattern:
		/// ([\w\d\S]+)\s+(true|false)\s+([-]|[.]|[-.]|[0-9][0-9]*[.]*[0-9]+)
		/// This masterPattern is ran against the text string and the groups are extracted and placed back into the targets
		/// <param name="text"></param>
		/// <param name="fieldSpecification"></param>
		/// <param name="targets"></param>
		public void Scan(string text, string fieldSpecification, params object[] targets)
		{
			try
			{
				ArrayList targetMatchGroups = new ArrayList();

				string matchingPattern = "";
				Regex reggie = null;
				MatchCollection matches = null;

				//masterPattern is going to hold a "big" regex pattern that will be ran against the original text
				string masterPattern = fieldSpecification.Trim();
				matchingPattern =  @"(\S+)";
				masterPattern = Regex.Replace(masterPattern,matchingPattern,"($1)");		//insert grouping parens

				//store the group location of the format tags so that we can select the correct group values later.
				matchingPattern = @"(\([\w\d\S]+\))";
				reggie = new Regex(matchingPattern);
				matches = reggie.Matches(masterPattern);
				for(int i = 0; i < matches.Count; i++)
				{
					Match m = matches[i];
					string sVal = m.Groups[1].Captures[0].Value;

					//is this value a {n} value. We will determine this by checking for {
					if(sVal.IndexOf('{') >= 0)
					{
						targetMatchGroups.Add(i);
					}
				}
			
				matchingPattern = @"(\{\S+\})";	//match each paramter tag of the format {n} where n is a digit
				reggie = new Regex(matchingPattern);
				matches = reggie.Matches(masterPattern);

				for(int i = 0; i < targets.Length && i < matches.Count; i++)
				{
					string groupID = String.Format("${0}",(i+1));
					string innerPattern = "";

					Type t = targets[i].GetType();
					innerPattern = ReturnPattern(t.Name);

					//replace the {n} with the type's pattern
					string groupPattern = "\\{" + i + "\\}";
					masterPattern = Regex.Replace(masterPattern,groupPattern,innerPattern);
				}

				masterPattern = Regex.Replace(masterPattern,@"\s+","\\s+");	//replace white space with the whitespace pattern

				//run our generated pattern against the original text.
				reggie = new Regex(masterPattern);
				matches = reggie.Matches(text);
				for(int x = 0; x < targetMatchGroups.Count; x++)
				{
					int i = (int)targetMatchGroups[x];
					if(i < matches[0].Groups.Count)
					{
						//add 1 to i because i is a result of serveral matches each resulting in one group.
						//this query is one match resulting in serveral groups.
						string sValue = matches[0].Groups[i+1].Captures[0].Value;
						Type t = targets[x].GetType();
						targets[x] = ReturnValue(t.Name,sValue);
					}
				}
			}
			catch(Exception ex)
			{
				throw new ScanExeption("Scan exception",ex);
			}
		}	//Scan

		/// <summary>
		/// Return the Value inside of an object that boxes the built in type or references the string
		/// </summary>
		/// <param name="typeName"></param>
		/// <param name="sValue"></param>
		/// <returns></returns>
		private object ReturnValue(string typeName, string sValue)
		{
			object o = null;
			switch(typeName)
			{
				case "String":
					o = sValue;
					break;
														
				case "Int16":
					o = Int16.Parse(sValue);
					break;

				case "UInt16":
					o = UInt16.Parse(sValue);
					break;

				case "Int32":
					o = Int32.Parse(sValue);
					break;

				case "UInt32":
					o = UInt32.Parse(sValue);
					break;

				case "Int64":
					o = Int64.Parse(sValue);
					break;

				case "UInt64":
					o = UInt64.Parse(sValue);
					break;

				case "Single":
					o = Single.Parse(sValue);
					break;

				case "Double":
					o = Double.Parse(sValue);
					break;

				case "Boolean":
					o = Boolean.Parse(sValue);
					break;

				case "Byte":
					o = Byte.Parse(sValue);
					break;

				case "SByte":
					o = SByte.Parse(sValue);
					break;

				case "Char":
					o = Char.Parse(sValue);
					break;

				case "Decimal":
					o = Decimal.Parse(sValue);
					break;
			}
			return o;
		}//ReturnValue

		/// <summary>
		/// Return a pattern for regular expressions that will match the built in type specified by name
		/// </summary>
		/// <param name="typeName"></param>
		/// <returns></returns>
		private string ReturnPattern(string typeName)
		{
			string innerPattern = "";
			switch(typeName)
			{
				case "Int16":
					innerPattern = (String)typePatterns["Int16"];
					break;

				case "UInt16":
					innerPattern = (String)typePatterns["UInt16"];
					break;

				case "Int32":
					innerPattern = (String)typePatterns["Int32"];
					break;

				case "UInt32":
					innerPattern = (String)typePatterns["UInt32"];
					break;

				case "Int64":
					innerPattern = (String)typePatterns["Int64"];
					break;

				case "UInt64":
					innerPattern = (String)typePatterns["UInt64"];
					break;

				case "Single":
					innerPattern = (String)typePatterns["Single"];
					break;

				case "Double":
					innerPattern = (String)typePatterns["Double"];
					break;

				case "Boolean":
					innerPattern = (String)typePatterns["Boolean"];
					break;

				case "Byte":
					innerPattern = (String)typePatterns["Byte"];
					break;

				case "SByte":
					innerPattern = (String)typePatterns["SByte"];
					break;

				case "Char":
					innerPattern = (String)typePatterns["Char"];
					break;

				case "Decimal":
					innerPattern = (String)typePatterns["Decimal"];
					break;

				case "String":
					innerPattern = (String)typePatterns["String"];
					break;
			}
			return innerPattern;
		}	//ReturnPattern

		static void PrintMatches(MatchCollection matches)
		{
			Console.WriteLine("===---===---===---===");
			int matchCount = 0;
			Console.WriteLine("Match Count = " + matches.Count);
			foreach(Match m in matches)
			{
				if(m == Match.Empty) Console.WriteLine("Empty match");
				Console.WriteLine("Match"+ (++matchCount));
				for (int i = 0; i < m.Groups.Count; i++) 
				{
					Group g = m.Groups[i];
					Console.WriteLine("Group"+i+"='" + g + "'");
					CaptureCollection cc = g.Captures;
					for (int j = 0; j < cc.Count; j++) 
					{
						Capture c = cc[j];
						System.Console.Write("Capture"+j+"='" + c + "', Position="+c.Index + "   <");
						for(int k = 0; k < c.ToString().Length; k++)
						{
							Console.Write(((Int32)(c.ToString()[k])));
						}
						Console.WriteLine(">");
					}
				}
			}
		}
	}

	/// <summary>
	/// Exceptions that are thrown by this namespace and the Scanner Class
	/// </summary>
	class ScanExeption : Exception
	{
		public ScanExeption() : base()
		{
		}

		public ScanExeption(string message) : base(message)
		{
		}

		public ScanExeption(string message, Exception inner) : base(message, inner)
		{
		}

		public ScanExeption(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
