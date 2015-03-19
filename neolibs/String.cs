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

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace neolibs
{
    /// <summary>
    /// neo Systems String utilities
    /// </summary>
    public class StringUtils
    {
        /// <summary>
        /// return only the numerics from dirty string 
        /// </summary>
        /// <param name="dirtystring">The string containng all kinds of chars</param>
        /// <returns>Clean string</returns>
        public static string StringToNumericsOnly(string dirtystring)
        {
            string cleanstring = Regex.Replace(dirtystring, @"[^0-9]", "").Trim(".".ToCharArray());
            return cleanstring;
        }

        /// <summary>
        /// Returns the text string from a string between two other string markers
        /// </summary>
        /// <param name="origtext">Original Text to search in</param>
        /// <param name="marker1">Text marker 1 to look for</param>
        /// <param name="marker2">Text marker 2 to look for</param>
        /// <returns>Text between markers (or empty string if nothing found)</returns>
        public static string GetTextBetweenMarkers(string origtext, string marker1, string marker2)
        {
            string res = "";

            int p1 = origtext.IndexOf(marker1);
            int p2 = origtext.IndexOf(marker2,p1);
            p1 += marker1.Length;
            res = origtext.Substring(p1,p2-p1);
            return res;
        }

        /// <summary>
        /// Remove a comment from a line, 
        /// </summary>
        /// <param name="s">string to remove comment from</param>
        /// <param name="commentchar">character that starts the comment</param>
        /// <returns>the string with the comment removed</returns>
        public static string RemoveComment(string s, char commentchar)
        {
            string res = s;
            int p = res.IndexOf(commentchar);

            if (p != (-1))
            {
                res = res.Substring(0,p);
            }
            return res;
        }

        /// <summary>
        /// Fill a string s to length l, using char c
        /// </summary>
        /// <param name="s">string to fill</param>
        /// <param name="c">character to fill with</param>
        /// <param name="l">length to fill to</param>
        /// <returns>filled up string</returns>
        public static string FillToLength(string s, char c, int l)
        {
            string fillstr = ConstCharStr(c,l - s.Length);
            return s + fillstr;
        }

        /// <summary>
        /// Convert a software version represented in a word to a version string
        /// (ie 12345 = V 1.23.45)
        /// </summary>
        /// <param name="version">word representing the version</param>
        /// <returns></returns>
        public static string VersionString(ushort version)
        {
            StringBuilder s = new StringBuilder(100);

            int ver = (int)version;

            int major = ver / 10000;
            int minor = ver % 100;

            ver = ver / 100;
            int mid = ver % 100;

            s.Append("V ");
            s.Append(major.ToString() + ".");
            s.Append(mid.ToString("D2") + ".");
            s.Append(minor.ToString("D2"));

            return s.ToString();
        }

        /// <summary>
        /// Method to create and return a constant character array of a specified length
        /// </summary>
        /// <param name="c">character to use in the initialisation of the array</param>
        /// <param name="length">number of elemenets in the array</param>
        /// <returns></returns>
        public static char[] ConstCharArray(char c,int length)
        {
            char[] ca = new char[length];

            for(int i=0; i<length; i++)
            {
                ca[i] = c;
            }
            return ca;
        }

        // ********************************************************************
        /// <summary>
        /// Convert the text to a float, within the parameters given
        /// </summary>
        /// <param name="str">string to convert to a float</param>
        /// <param name="min">minimum allowed value. If the string is less than this value, this value will be used</param>
        /// <param name="def">default value. If an invalid value is entered, the answer will be equal to the default</param>
        /// <param name="max">maximum allowed value. If the string is more than this value, this value will be used</param>
        /// <returns></returns>
        // ********************************************************************
        public static float TextToFloat(string str, float min, float def, float max)
        {
            float temp;

            try
            {
                temp = (float)Convert.ToDouble(str);

                if (temp < min) temp = min;
                if (temp > max) temp = max;
            }
            catch
            {
                temp = def;
            }

            return temp;
        }

        // ********************************************************************
        /// <summary>
        /// Convert a boolean value to a string
        /// </summary>
        /// <param name="Value">Boolean to display</param>
        /// <param name="truestring">String to return for a value that is true</param>
        /// <param name="falsestring">String to return for a value that is false</param>
        public static string BoolToString(bool Value, string truestring = "True", string falsestring = "False")
        {
            if (Value)
            {
                return truestring;
            }
            else
            {
                return falsestring;
            }
        }

        // ********************************************************************
        /// <summary>
        /// Returns a true/false string for a masked bit in a u32 (uint in C#, or System.UInt32) value
        /// </summary>
        /// <param name="value">Bitmasked value</param>
        /// <param name="mask">Mask to test for</param>
        /// <param name="truestring">Text for a value of non zero (Default = "True")</param>
        /// <param name="falsestring">Text for a value of zero (Default = "False")</param>
        /// <returns>string containg truestring or falsestring </returns>
        public static string MaskedBoolToStr(uint value, uint mask, string truestring = "True", string falsestring = "False")
        {
            if ((value & mask) != 0)
            {
                return truestring;
            }
            else
            {
                return falsestring;
            }
        }

        // ********************************************************************
        /// <summary>
        /// Returns a "Yes"/"No" string for a masked bit in a u32 (uint in C#, or System.UInt32) value
        /// </summary>
        /// <param name="value">Bitmasked value</param>
        /// <param name="mask">Mask to test for</param>
        /// <returns>string containg "Yes" or "No"</returns>
        public static string MaskedBoolToYesNo(uint value, uint mask)
        {
            return MaskedBoolToStr(value,mask,"Yes","No");
        }

        // ********************************************************************
        /// <summary>
        /// Returns a "Active"/"Inactive" string for a masked bit in a u32 (uint in C#, or System.UInt32) value
        /// </summary>
        /// <param name="value">Bitmasked value</param>
        /// <param name="mask">Mask to test for</param>
        /// <returns>string containg "Active" or "Inactive"</returns>
        public static string MaskedBoolToActiveInactive(uint value, uint mask)
        {
            return MaskedBoolToStr(value, mask, "Active", "Inactive");
        }

        /// <summary>
        /// Replace multiple characters in a string with a particaluar character
        /// </summary>
        /// <param name="old_multichars">a string containg the characters to be replaced</param>
        /// <param name="newchar">the new character to replace with</param>
        /// <param name="str">the result string where characters hace been replaced</param>
        /// <returns></returns>
        public static string MultiCharReplace(string old_multichars, char newchar, string str)
        {
            string res = str;
            foreach(char c in old_multichars)
            {
                res = res.Replace(c,newchar);
            }

            return res;
        }

        /// <summary>
        /// Convert a string so that it can be used as a identifier
        /// </summary>
        /// <param name="str">string description</param>
        /// <returns>string to be used as an identifier</returns>
        public static string StringToIdentifier(string str)
        {
            string t = MultiCharReplace(@" `¬!""£$%^&*()+=-;'#:@~,./<>?\|",'_',str);
            try
            {
                if (Char.IsNumber(t[0]))
                {
                    t = "a" + t;
                }
            }
            catch
            {
            }
            return t;
        }

        /// <summary>
        /// Returns a string filled with count x the specified char
        /// </summary>
        /// <param name="c">char to use</param>
        /// <param name="count">number of chars</param>
        /// <returns>string contain count x specified char</returns>
        public static string ConstCharStr(char c, int count)
        {
            StringBuilder sb = new StringBuilder(count+2);

            for(int i=0; i<count; i++)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Options for the SplitOnSize method
        /// </summary>
        [Flags]
        public enum SplitOnSizeOptions 
        {
            /// <summary>
            /// When splitting, make sure whole words are kept together
            /// </summary>
            WholeWords = 1
        }

        /// <summary>
        /// Split a string into seperate string not bigger than a specified size
        /// </summary>
        /// <param name="str">string to split</param>
        /// <param name="maxsize">maximum string size</param>
        /// <param name="opt">split options</param>
        /// <returns>array of strings</returns>
        public static string[] SplitOnSize(string str, int maxsize, SplitOnSizeOptions opt)
        {
            List<string>strs = new List<string>();
            SplitOnSizeOptions options = opt;

            while(str.Length > maxsize)
            {
                int ls = maxsize;

                // note cannot use HasFlag because HasFlag is for .NET framework >= 4.0
                if ((options & SplitOnSizeOptions.WholeWords) != 0)
                {
                    if  (ls < (str.Length-1))
                    {
                        if (str[ls] != ' ')
                        {
                            ls++;
                        }
                    }
                }
                string temp = str.Substring(0,ls);
                str = str.Substring(ls);
                strs.Add(temp);
            }

            if (str.Length != 0)
            {
                strs.Add(str);
            }
            return strs.ToArray();
        }

        /// <summary>
        /// Count the number of occurences of the leading char c in string s
        /// </summary>
        /// <param name="s">string s to look in</param>
        /// <param name="c">leading char c</param>
        /// <returns>the number of leading characters c in string s</returns>
        public static int CountLeading(string s, char c)
        {
            int res = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] != c) return res;
                res++;
            }

            return res;
        }

        /// <summary>
        /// Trim all the text in s to the end from the last occurence of c
        /// </summary>
        /// <param name="s">string to trim</param>
        /// <param name="c">c - last character to trim from onwards</param>
        /// <returns>new trimmed string</returns>
        public static string TrimFromLast(string s, char c)
        {
            int idx = s.LastIndexOf(c);

            if (idx == 0)
            {
                return s;
            }
            else
            {
                return s.Substring(0,idx);
            }
        }

        /// <summary>
        /// Tests if a string is a South African cellphone number
        /// </summary>
        /// <param name="num">Phone Number string</param>
        /// <returns>true if cellphone number, false if not a cellphone number</returns>
        public static bool IsZARCellPhoneNumber(string num)
        {
            try
            {
                bool res = false;
                string s = num.Trim();
                s = s.Substring(0,3);

                if ((s.Contains("081")) ||
                    (s.Contains("082")) ||
                    (s.Contains("083")) ||
                    (s.Contains("084")) ||
                    (s.Contains("071")) ||
                    (s.Contains("072")) ||
                    (s.Contains("073")) ||
                    (s.Contains("074")) ||
                    (s.Contains("076"))
                    )
                {
                    res = true;
                }

                return res;
            }
            catch
            {
                return false;
            }
        }
    }


}