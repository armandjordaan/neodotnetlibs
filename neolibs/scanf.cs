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
using System.Linq;
using System.Text;

namespace neolibs
{
    /// <summary>
    /// Class that provides functionality of the standard C library sscanf()
    /// function.
    /// </summary>
    public class scanf
    {
        /// <summary>
        /// Format type specifiers 
        /// </summary>
        protected enum Types
        {
            /// <summary>
            /// Character format type
            /// </summary>
            Character,

            /// <summary>
            /// Decimal format type
            /// </summary>
            Decimal,

            /// <summary>
            /// Float format type
            /// </summary>
            Float,

            /// <summary>
            /// Hexedecimal format type
            /// </summary>
            Hexadecimal,

            /// <summary>
            /// Octal format type
            /// </summary>
            Octal,

            /// <summary>
            /// Scan a set - format specifier
            /// </summary>
            ScanSet,

            /// <summary>
            /// string format specifier
            /// </summary>
            String,

            /// <summary>
            /// Unsigned format specifier
            /// </summary>
            Unsigned
        }

        /// <summary>
        /// Format modifiers
        /// </summary>
        protected enum Modifiers
        {
            /// <summary>
            /// modifier - none
            /// </summary>
            None,

            /// <summary>
            /// modifier short short
            /// </summary>
            ShortShort,

            /// <summary>
            /// modifier short
            /// </summary>
            Short,

            /// <summary>
            /// modifier long
            /// </summary>
            Long,

            /// <summary>
            /// modifier long long
            /// </summary>
            LongLong
        }

        /// <summary>
        /// Delegate to parse a type
        /// </summary>
        /// <param name="input">Textparser</param>
        /// <param name="spec">Format specifier</param>
        /// <returns>bool</returns>
        protected delegate bool ParseValue(TextParser input, FormatSpecifier spec);

        /// <summary>
        /// Type parser class
        /// Class to associate format type with type parser
        /// </summary>
        protected class TypeParser
        {
            /// <summary>
            /// Types property
            /// </summary>
            public Types Type { get; set; }

            /// <summary>
            /// Parser property
            /// </summary>
            public ParseValue Parser { get; set; }
        }

        /// <summary>
        /// Class to hold format specifier information
        /// </summary>
        protected class FormatSpecifier
        {
            /// <summary>
            /// Types property
            /// </summary>
            public Types Type { get; set; }

            /// <summary>
            /// Modfiers property
            /// </summary>
            public Modifiers Modifier { get; set; }

            /// <summary>
            /// Width property
            /// </summary>
            public int Width { get; set; }

            /// <summary>
            /// No result property
            /// </summary>
            public bool NoResult { get; set; }

            /// <summary>
            /// Scanset property
            /// </summary>
            public string ScanSet { get; set; }

            /// <summary>
            /// Scanset exclude
            /// </summary>
            public bool ScanSetExclude { get; set; }
        }

        /// <summary>
        /// Lookup table to find parser by parser type 
        /// </summary>
        protected TypeParser[] _typeParsers;

        /// <summary>
        /// Holds results after calling Parse()
        /// </summary>
        public List<object> Results;

        /// <summary>
        /// Constructor
        /// </summary>
        public scanf()
        {
            // Populate parser type lookup table
            _typeParsers = new TypeParser[] {
                new TypeParser() { Type = Types.Character, Parser = ParseCharacter },
                new TypeParser() { Type = Types.Decimal, Parser = ParseDecimal },
                new TypeParser() { Type = Types.Float, Parser = ParseFloat },
                new TypeParser() { Type = Types.Hexadecimal, Parser = ParseHexadecimal },
                new TypeParser() { Type = Types.Octal, Parser = ParseOctal },
                new TypeParser() { Type = Types.ScanSet, Parser = ParseScanSet },
                new TypeParser() { Type = Types.String, Parser = ParseString },
                new TypeParser() { Type = Types.Unsigned, Parser = ParseDecimal }
            };
            // Allocate results collection
            Results = new List<object>();
        }

        /// <summary>
        /// Parses the input string according to the rules in the
        /// format string. Similar to the standard C library's
        /// sscanf() function. Parsed fields are placed in the
        /// class' Results member.
        /// </summary>
        /// <param name="input">String to parse</param>
        /// <param name="format">Specifies rules for parsing input</param>
        public int Parse(string input, string format)
        {
            TextParser inp = new TextParser(input);
            TextParser fmt = new TextParser(format);
            List<object> results = new List<object>();
            FormatSpecifier spec = new FormatSpecifier();
            int count = 0;

            // Clear any previous results
            Results.Clear();

            // Process input string as indicated in format string
            while (!fmt.EndOfText && !inp.EndOfText)
            {
                if (ParseFormatSpecifier(fmt, spec))
                {
                    // Found a format specifier
                    TypeParser parser = _typeParsers.First(tp => tp.Type == spec.Type);
                    if (parser.Parser(inp, spec))
                        count++;
                    else
                        break;
                }
                else if (Char.IsWhiteSpace(fmt.Peek()))
                {
                    // Whitespace
                    inp.MovePastWhitespace();
                    fmt.MoveAhead();
                }
                else if (fmt.Peek() == inp.Peek())
                {
                    // Matching character
                    inp.MoveAhead();
                    fmt.MoveAhead();
                }
                else break;    // Break at mismatch
            }

            // Return number of fields successfully parsed
            return count;
        }

        /// <summary>
        /// Attempts to parse a field format specifier from the format string.
        /// </summary>
        protected bool ParseFormatSpecifier(TextParser format, FormatSpecifier spec)
        {
            // Return if not a field format specifier
            if (format.Peek() != '%')
                return false;
            format.MoveAhead();

            // Return if "%%" (treat as '%' literal)
            if (format.Peek() == '%')
                return false;

            // Test for asterisk, which indicates result is not stored
            if (format.Peek() == '*')
            {
                spec.NoResult = true;
                format.MoveAhead();
            }
            else spec.NoResult = false;

            // Parse width
            int start = format.Position;
            while (Char.IsDigit(format.Peek()))
                format.MoveAhead();
            if (format.Position > start)
                spec.Width = int.Parse(format.Extract(start, format.Position));
            else
                spec.Width = 0;

            // Parse modifier
            if (format.Peek() == 'h')
            {
                format.MoveAhead();
                if (format.Peek() == 'h')
                {
                    format.MoveAhead();
                    spec.Modifier = Modifiers.ShortShort;
                }
                else spec.Modifier = Modifiers.Short;
            }
            else if (Char.ToLower(format.Peek()) == 'l')
            {
                format.MoveAhead();
                if (format.Peek() == 'l')
                {
                    format.MoveAhead();
                    spec.Modifier = Modifiers.LongLong;
                }
                else spec.Modifier = Modifiers.Long;
            }
            else spec.Modifier = Modifiers.None;

            // Parse type
            switch (format.Peek())
            {
                case 'c':
                    spec.Type = Types.Character;
                    break;
                case 'd':
                case 'i':
                    spec.Type = Types.Decimal;
                    break;
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'f':
                case 'F':
                case 'g':
                case 'G':
                    spec.Type = Types.Float;
                    break;
                case 'o':
                    spec.Type = Types.Octal;
                    break;
                case 's':
                    spec.Type = Types.String;
                    break;
                case 'u':
                    spec.Type = Types.Unsigned;
                    break;
                case 'x':
                case 'X':
                    spec.Type = Types.Hexadecimal;
                    break;
                case '[':
                    spec.Type = Types.ScanSet;
                    format.MoveAhead();
                    // Parse scan set characters
                    if (format.Peek() == '^')
                    {
                        spec.ScanSetExclude = true;
                        format.MoveAhead();
                    }
                    else spec.ScanSetExclude = false;
                    start = format.Position;
                    // Treat immediate ']' as literal
                    if (format.Peek() == ']')
                        format.MoveAhead();
                    format.MoveTo(']');
                    if (format.EndOfText)
                        throw new Exception("Type specifier expected character : ']'");
                    spec.ScanSet = format.Extract(start, format.Position);
                    break;
                default:
                    string msg = String.Format("Unknown format type specified : '{0}'", format.Peek());
                    throw new Exception(msg);
            }
            format.MoveAhead();
            return true;
        }

        /// <summary>
        /// Parse a character field
        /// </summary>
        private bool ParseCharacter(TextParser input, FormatSpecifier spec)
        {
            // Parse character(s)
            int start = input.Position;
            int count = (spec.Width > 1) ? spec.Width : 1;
            while (!input.EndOfText && count-- > 0)
                input.MoveAhead();

            // Extract token
            if (count <= 0 && input.Position > start)
            {
                if (!spec.NoResult)
                {
                    string token = input.Extract(start, input.Position);
                    if (token.Length > 1)
                        Results.Add(token.ToCharArray());
                    else
                        Results.Add(token[0]);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parse integer field
        /// </summary>
        private bool ParseDecimal(TextParser input, FormatSpecifier spec)
        {
            int radix = 10;

            // Skip any whitespace
            input.MovePastWhitespace();

            // Parse leading sign
            int start = input.Position;
            if (input.Peek() == '+' || input.Peek() == '-')
            {
                input.MoveAhead();
            }
            else if (input.Peek() == '0')
            {
                if (Char.ToLower(input.Peek(1)) == 'x')
                {
                    radix = 16;
                    input.MoveAhead(2);
                }
                else
                {
                    radix = 8;
                    input.MoveAhead();
                }
            }

            // Parse digits
            while (IsValidDigit(input.Peek(), radix))
                input.MoveAhead();

            // Don't exceed field width
            if (spec.Width > 0)
            {
                int count = input.Position - start;
                if (spec.Width < count)
                    input.MoveAhead(spec.Width - count);
            }

            // Extract token
            if (input.Position > start)
            {
                if (!spec.NoResult)
                {
                    if (spec.Type == Types.Decimal)
                        AddSigned(input.Extract(start, input.Position), spec.Modifier, radix);
                    else
                        AddUnsigned(input.Extract(start, input.Position), spec.Modifier, radix);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parse a floating-point field
        /// </summary>
        private bool ParseFloat(TextParser input, FormatSpecifier spec)
        {
            // Skip any whitespace
            input.MovePastWhitespace();

            // Parse leading sign
            int start = input.Position;
            if (input.Peek() == '+' || input.Peek() == '-')
                input.MoveAhead();

            // Parse digits
            bool hasPoint = false;
            while (Char.IsDigit(input.Peek()) || input.Peek() == '.')
            {
                if (input.Peek() == '.')
                {
                    if (hasPoint)
                        break;
                    hasPoint = true;
                }
                input.MoveAhead();
            }

            // Parse exponential notation
            if (Char.ToLower(input.Peek()) == 'e')
            {
                input.MoveAhead();
                if (input.Peek() == '+' || input.Peek() == '-')
                    input.MoveAhead();
                while (Char.IsDigit(input.Peek()))
                    input.MoveAhead();
            }

            // Don't exceed field width
            if (spec.Width > 0)
            {
                int count = input.Position - start;
                if (spec.Width < count)
                    input.MoveAhead(spec.Width - count);
            }

            // Because we parse the exponential notation before we apply
            // any field-width constraint, it becomes awkward to verify
            // we have a valid floating point token. To prevent an
            // exception, we use TryParse() here instead of Parse().
            double result;

            // Extract token
            if (input.Position > start &&
                double.TryParse(input.Extract(start, input.Position), out result))
            {
                if (!spec.NoResult)
                {
                    if (spec.Modifier == Modifiers.Long ||
                        spec.Modifier == Modifiers.LongLong)
                        Results.Add(result);
                    else
                        Results.Add((float)result);
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parse hexadecimal field
        /// </summary>
        protected bool ParseHexadecimal(TextParser input, FormatSpecifier spec)
        {
            // Skip any whitespace
            input.MovePastWhitespace();

            // Parse 0x prefix
            int start = input.Position;
            if (input.Peek() == '0' && input.Peek(1) == 'x')
                input.MoveAhead(2);

            // Parse digits
            while (IsValidDigit(input.Peek(), 16))
                input.MoveAhead();

            // Don't exceed field width
            if (spec.Width > 0)
            {
                int count = input.Position - start;
                if (spec.Width < count)
                    input.MoveAhead(spec.Width - count);
            }

            // Extract token
            if (input.Position > start)
            {
                if (!spec.NoResult)
                    AddUnsigned(input.Extract(start, input.Position), spec.Modifier, 16);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parse an octal field
        /// </summary>
        private bool ParseOctal(TextParser input, FormatSpecifier spec)
        {
            // Skip any whitespace
            input.MovePastWhitespace();

            // Parse digits
            int start = input.Position;
            while (IsValidDigit(input.Peek(), 8))
                input.MoveAhead();

            // Don't exceed field width
            if (spec.Width > 0)
            {
                int count = input.Position - start;
                if (spec.Width < count)
                    input.MoveAhead(spec.Width - count);
            }

            // Extract token
            if (input.Position > start)
            {
                if (!spec.NoResult)
                    AddUnsigned(input.Extract(start, input.Position), spec.Modifier, 8);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parse a scan-set field
        /// </summary>
        protected bool ParseScanSet(TextParser input, FormatSpecifier spec)
        {
            // Parse characters
            int start = input.Position;
            if (!spec.ScanSetExclude)
            {
                while (spec.ScanSet.Contains(input.Peek()))
                    input.MoveAhead();
            }
            else
            {
                while (!input.EndOfText && !spec.ScanSet.Contains(input.Peek()))
                    input.MoveAhead();
            }

            // Don't exceed field width
            if (spec.Width > 0)
            {
                int count = input.Position - start;
                if (spec.Width < count)
                    input.MoveAhead(spec.Width - count);
            }

            // Extract token
            if (input.Position > start)
            {
                if (!spec.NoResult)
                    Results.Add(input.Extract(start, input.Position));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Parse a string field
        /// </summary>
        private bool ParseString(TextParser input, FormatSpecifier spec)
        {
            // Skip any whitespace
            input.MovePastWhitespace();

            // Parse string characters
            int start = input.Position;
            while (!input.EndOfText && !Char.IsWhiteSpace(input.Peek()))
                input.MoveAhead();

            // Don't exceed field width
            if (spec.Width > 0)
            {
                int count = input.Position - start;
                if (spec.Width < count)
                    input.MoveAhead(spec.Width - count);
            }

            // Extract token
            if (input.Position > start)
            {
                if (!spec.NoResult)
                    Results.Add(input.Extract(start, input.Position));
                return true;
            }
            return false;
        }

        // Determines if the given digit is valid for the given radix
        private bool IsValidDigit(char c, int radix)
        {
            int i = "0123456789abcdef".IndexOf(Char.ToLower(c));
            if (i >= 0 && i < radix)
                return true;
            return false;
        }

        // Parse signed token and add to results
        private void AddSigned(string token, Modifiers mod, int radix)
        {
            object obj;
            if (mod == Modifiers.ShortShort)
                obj = Convert.ToSByte(token, radix);
            else if (mod == Modifiers.Short)
                obj = Convert.ToInt16(token, radix);
            else if (mod == Modifiers.Long ||
                mod == Modifiers.LongLong)
                obj = Convert.ToInt64(token, radix);
            else
                obj = Convert.ToInt32(token, radix);
            Results.Add(obj);
        }

        // Parse unsigned token and add to results
        private void AddUnsigned(string token, Modifiers mod, int radix)
        {
            object obj;
            if (mod == Modifiers.ShortShort)
                obj = Convert.ToByte(token, radix);
            else if (mod == Modifiers.Short)
                obj = Convert.ToUInt16(token, radix);
            else if (mod == Modifiers.Long ||
                mod == Modifiers.LongLong)
                obj = Convert.ToUInt64(token, radix);
            else
                obj = Convert.ToUInt32(token, radix);
            Results.Add(obj);
        }
    }
}
