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
using System.IO.Ports;
using System.Reflection;
using System.Windows.Forms;
using neolibs.Dialogs;
using System.ComponentModel;
using System.Diagnostics;

namespace neolibs.General
{
    // ************************************************************************
    /// <summary>
    /// A very simple countdown timer. Drawback: it has to be polled.
    /// In future the class can be derived to give a more complex and fully featured timer
    /// (or it could be easier to inherit a new class from one of the .NET classes)
    /// </summary>
    public class SimpleCountDownTimer
    {
        private long CountDownSecs;
        private long StartSecs;

        // ************************************************************************
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Seconds">The number of seconds the countdown timer is to count down</param>
        SimpleCountDownTimer(long Seconds)
        {
            Reload(Seconds);
        }

        // ************************************************************************
        /// <summary>
        /// Timeout is a property that can be read to determine if teh countdown has expired.
        /// It is true if the set amount of time has passed, false otherwise
        /// </summary>
        public bool Timeout
        {
            get
            {
                long nowsecs = TimeUtils.DateTimeToSeconds(DateTime.Now);
                if ((nowsecs - StartSecs) > CountDownSecs)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // ************************************************************************
        /// <summary>
        /// Method to reload the timer with a new timeout value
        /// </summary>
        /// <param name="Seconds">Time to reload the timer with</param>
        public void Reload(long Seconds)
        {
            CountDownSecs = Seconds;
            StartSecs = TimeUtils.DateTimeToSeconds(DateTime.Now);
        }
    }

    // ************************************************************************
    /// <summary>
    /// TimeUtils contain a number of time related functions
    /// </summary>
    public static class TimeUtils
    {
        // ********************************************************************
        /// <summary>
        /// Get the number of seconds since 1 Jan 0000, at 0:00:00 time
        /// </summary>
        /// <param name="t">Give a DateTime as parameter</param>
        /// <returns>Number of seconds</returns>
        public static long DateTimeToSeconds(DateTime t)
        {
            long ticks = t.Ticks;
            long secs = (ticks / 10000000);
            return secs;
        }
    }

    // ********************************************************************
    /// <summary>
    /// class with utilities to work with enums
    /// </summary>
    public static class EnumUtils
    {
        // ********************************************************************
        /// <summary>
        /// Method to get the number of elements in an enum
        /// IMPORTANT NOTE: this has not been tested at all. Not guearanteed to 
        /// work!!!!!!
        /// </summary>
        /// <param name="EnumName">string containing the enum name</param>
        /// <returns>number of elements in the enum name</returns>
        public static int GetNumberElements(string EnumName)
        {
            try
            {
                Type enumType = Type.GetType(EnumName);
                int numElementsInEnum = Enum.GetValues(enumType).Length;

                return numElementsInEnum;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // ********************************************************************
        /// <summary>
        /// Fill the items in a combobox with the elements of an enum
        /// </summary>
        /// <param name="enumType">Type of enum</param>
        /// <param name="cb">cb is the combobox to fill</param>
        public static void FillComboBoxWithEnum(Type enumType, ComboBox cb)
        {
            try
            {
                string[] x = Enum.GetNames(enumType);

                cb.Items.Clear();
                foreach (string name in x)
                {
                    cb.Items.Add(name);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // ********************************************************************
        /// <summary>
        /// Retrieve the description on the enum, e.g.
        /// [Description("Bright Pink")]
        /// BrightPink = 2,
        /// Then when you pass in the enum, it will retrieve the description
        /// </summary>
        /// <param name="en">The Enumeration</param>
        /// <returns>A string representing the friendly name</returns>
        public static string GetDescription(Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)                
                {
                    return ((DescriptionAttribute)attrs[0]).Description;                
                }
            }

            return en.ToString();
        }

        // ********************************************************************
        /// <summary>
        /// Get an array of descriptions from a enumeration
        /// </summary>
        /// <param name="enumType">enumeration type to get the descriptions for</param>
        /// <returns>Array of strings containg the descriptions</returns>
        public static string[] GetDescriptions(Type enumType)
        {
            List<string> res = new List<string>();

            string[] enumnames = Enum.GetNames(enumType);

            foreach(string enumname in enumnames)
            {
                MemberInfo[] memInfo = enumType.GetMember(enumname);

                if (memInfo != null && memInfo.Length > 0)
                {
                    object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                    if (attrs != null && attrs.Length > 0)                
                    {
                        res.Add(((DescriptionAttribute)attrs[0]).Description);
                    }
                    else
                    {
                        res.Add(enumname);
                    }
                }
                else
                {
                    res.Add(enumname);
                }
            }
            return res.ToArray();
        }

        // ******************************************************************************
        /// <summary>
        /// Fill the items in a combobox with the description attributes of an enum
        /// </summary>
        /// <param name="enumType">The enum type</param>
        /// <param name="cb">The combobox</param>
        public static void FillComboBoxWithEnumDescriptions(Type enumType, ComboBox cb)
        {
            try
            {
                string[] x = GetDescriptions(enumType);

                cb.Items.Clear();
                foreach (string name in x)
                {
                    cb.Items.Add(name);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Populate the COmbobox with the enum type descriptions and select the
        /// current index based on the enum
        /// </summary>
        /// <param name="cb">Combobox to populate</param>
        /// <param name="en">enum value to use for combobox</param>
        public static void SetupComboBox(ComboBox cb, Enum en)
        {
            Type type = en.GetType();
            FillComboBoxWithEnumDescriptions(type,cb);

            //string curidxstr = Enum.
            //int idx = 
            //cb.SelectedIndex = idx;            
        }
    }

    // ********************************************************************
    /// <summary>
    /// various error handling methods
    /// </summary>
    public static class Error
    {
        // ********************************************************************
        /// <summary>
        /// ErrorModeType has the settings that can be applied to the way an error is displayed
        /// </summary>
        [Serializable]
        public enum ErrorModeType : int 
        {
            /// <summary>
            /// DisplayFullMessage can be used to display all error codes with the full exception context
            /// </summary>
            DisplayFullMessage = 0,

            /// <summary>
            /// DisplayShortMessage is used to display an error, but without the full exception context
            /// </summary>
            DisplayShortMessage = 1
        }

        // ********************************************************************
        /// <summary>
        /// ErrorMode controls the way errors are displayed currently
        /// </summary>
        public static ErrorModeType ErrorMode = ErrorModeType.DisplayFullMessage;

        // ********************************************************************
        /// <summary>
        /// Show a dialog to choose the error mode
        /// </summary>
        /// <returns>Returns the user's selection (ie OK or cancel)</returns>
        public static DialogResult ChooseErrorMode()
        {
            SelectErrorModeForm fm = new SelectErrorModeForm();

            fm.ErrorMode = ErrorMode;
            return fm.ShowDialog();
        }

        // ********************************************************************
        /// <summary>
        /// Show a dialog to choose the error mode
        /// </summary>
        /// <param name="errmode">reference to an error mode variable</param>
        /// <returns>Returns the user's selection (ie OK or cancel)</returns>
        public static DialogResult ChooseErrorMode(ref int errmode)
        {
            ErrorModeType x = (ErrorModeType)errmode;
            SelectErrorModeForm fm = new SelectErrorModeForm();

            fm.ErrorMode = x;
            DialogResult t = fm.ShowDialog();
            x = fm.ErrorMode;
            errmode = (int)x;
            return t;
        }

        // ********************************************************************
        /// <summary>
        /// Show Error in a messagebox - shows exception text
        /// </summary>
        /// <param name="e">Exception handler</param>
        public static void Show(Exception e)
        {
            try
            {
                if (e == null)
                {
                    MessageBox.Show("Possible internal problem! neolibs.General.Error.Show called with null parameter!",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ErrorMode == ErrorModeType.DisplayFullMessage)
                {
                    MessageBox.Show(e.ToString(), "Error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (e is NeoException)
                    {
                        NeoException te = e as NeoException;
                        MessageBox.Show(te.LastError, "Error occured.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An exception occured.", "Error occured.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Internal error: unable to display Exception error", "Internal error occured",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ********************************************************************
        /// <summary>
        /// Show Error in a messagebox with a specific message in addition to exception text
        /// </summary>
        /// <param name="msg">This is the user text message</param>
        /// <param name="e">This is the exception to display</param>
        public static void Show(string msg,Exception e)
        {
            if (ErrorMode == ErrorModeType.DisplayFullMessage)
            {
                MessageBox.Show(msg + " - " + e.ToString(), "Error occurred.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(msg, "Error occurred.", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    // ********************************************************************
    /// <summary>
    /// TypeUtils contains various static methods to do type conversions and to extract
    /// data from other types.
    /// </summary>
    public class TypeUtils
    {
        // ********************************************************************
        /// <summary>
        /// Get the Low byte of a short value
        /// </summary>
        /// <param name="value">short int</param>
        /// <returns>lowest byte</returns>
        public static byte GetLowByte(short value)
        {
            byte temp = (byte)(value & 0xFF);
            return temp;
        }

        // ********************************************************************
        /// <summary>
        /// Get the high byte of a short int
        /// </summary>
        /// <param name="value">short int</param>
        /// <returns>highest byte</returns>
        public static byte GetHighByte(short value)
        {
            byte temp = (byte)((value >> 8) & 0xFF);
            return temp;
        }

        // ********************************************************************
        /// <summary>
        /// GetLowestByte returns the least signifacant of all 4 the bytes in an uint
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte GetLowestByte(uint value)
        {
            byte temp = (byte)(value & 0xFF);
            return temp;
        }

        // ********************************************************************
        /// <summary>
        /// GetLowerByte returns the second least signifacant of all 4 the bytes in an uint
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte GetLowerByte(uint value)
        {
            byte temp = (byte)((value >> 8) & 0xFF);
            return temp;
        }

        // ********************************************************************
        /// <summary>
        /// GetHigherByte returns the second most signifacant of all 4 the bytes in an uint
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte GetHigherByte(uint value)
        {
            byte temp = (byte)((value >> 16) & 0xFF);
            return temp;
        }

        // ********************************************************************
        /// <summary>
        /// GetHigherByte returns the most signifacant of all 4 the bytes in an uint
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte GetHighestByte(uint value)
        {
            byte temp = (byte)((value >> 24) & 0xFF);
            return temp;
        }
    }

    // ********************************************************************
    /// <summary>
    /// General Serialcomms functions
    /// </summary>
    public class SerialComms
    {
        /// <summary>
        /// Baudrate flags
        /// </summary>
        [Flags]
        public enum BaudFlags : uint
        {
            /// <summary>75 bps</summary>
            BAUD_075    = 0x00000001, // 75 bps

            /// <summary>110 bps</summary>
            BAUD_110    = 0x00000002, // 110 bps

            /// <summary>134.5 bps</summary>
            BAUD_134_5  = 0x00000004, // 134.5 bps

            /// <summary>150 bps</summary>
            BAUD_150    = 0x00000008, // 150 bps

            /// <summary>300 bps</summary>
            BAUD_300    = 0x00000010, // 300 bps

            /// <summary>600 bps</summary>
            BAUD_600    = 0x00000020, // 600 bps

            /// <summary>1200 bps</summary>
            BAUD_1200   = 0x00000040, // 1200 bps

            /// <summary>1800 bps</summary>
            BAUD_1800   = 0x00000080, // 1800 bps

            /// <summary>2400 bps</summary>
            BAUD_2400   = 0x00000100, // 2400 bps

            /// <summary>4800 bps</summary>
            BAUD_4800   = 0x00000200, // 4800 bps

            /// <summary>7200 bps</summary>
            BAUD_7200   = 0x00000400, // 7200 bps

            /// <summary>9600 bps</summary>
            BAUD_9600   = 0x00000800, // 9600 bps

            /// <summary>14400 bps</summary>
            BAUD_14400  = 0x00001000, // 14400 bps

            /// <summary>19200 bps</summary>
            BAUD_19200  = 0x00002000, // 19200 bps

            /// <summary>38400 bps</summary>
            BAUD_38400  = 0x00004000, // 38400 bps

            /// <summary>56000 bps</summary>
            BAUD_56K    = 0x00008000, // 56K bps

            /// <summary>57600 bps</summary>
            BAUD_57600  = 0x00040000, // 57600 bps

            /// <summary>115200 bps</summary>
            BAUD_115200 = 0x00020000, // 115200 bps

            /// <summary>128 kbps</summary>
            BAUD_128K   = 0x00010000, // 128K bps

            /// <summary>User bps</summary>
            BAUD_USER   = 0x10000000  // Programmable baud rate.
        }

        // ********************************************************************
        /// <summary>
        /// GetMaxBaudrate determines the maximum baudrate for portName
        /// </summary>
        /// <param name="portName">Name of com port</param>
        /// <returns>Maximum Buadrate or -1 if an error occurred</returns>
        public static int GetMaxBaudrate(string portName)
        {
            Int32 bv;

            try
            {
                 SerialPort _port = new SerialPort(portName);
                 _port.Open();
                object p = _port.BaseStream.GetType().GetField("commProp", 
                    BindingFlags.Instance | 
                    BindingFlags.NonPublic).GetValue(_port.BaseStream);
                bv = (Int32)p.GetType().GetField("dwSettableBaud", 
                    BindingFlags.Instance | 
                    BindingFlags.NonPublic | BindingFlags.Public).GetValue(p);
                _port.Close();
            }
            catch
            {
                bv = -1;
            }
            return bv;
        }

        // ********************************************************************
        /// <summary>
        /// Convert a baudrate mask to a string to display
        /// </summary>
        /// <param name="x">x = baudrate capability mask</param>
        /// <returns>string containing available baudrates</returns>
        public static string BuadrateMaskToString(int x)
        {
            BaudFlags t = (BaudFlags)x;
            StringBuilder s = new StringBuilder(2048);
            
            if ((t & BaudFlags.BAUD_075) != 0)    s.Append("75 bps, ");
            if ((t & BaudFlags.BAUD_110) != 0)    s.Append("110 bps, ");
            if ((t & BaudFlags.BAUD_134_5) != 0)  s.Append("134.5 bps, ");
            if ((t & BaudFlags.BAUD_150) != 0)    s.Append("150 bps, ");
            if ((t & BaudFlags.BAUD_300) != 0)    s.Append("300 bps, ");
            if ((t & BaudFlags.BAUD_600) != 0)    s.Append("600 bps, ");
            if ((t & BaudFlags.BAUD_1200) != 0)   s.Append("1200 bps, "); 
            if ((t & BaudFlags.BAUD_1800) != 0)   s.Append("1800 bps, ");
            if ((t & BaudFlags.BAUD_2400) != 0)   s.Append("2400 bps, ");
            if ((t & BaudFlags.BAUD_4800) != 0)   s.Append("4800 bps, ");
            if ((t & BaudFlags.BAUD_7200) != 0)   s.Append("7200 bps, ");
            if ((t & BaudFlags.BAUD_9600) != 0)   s.Append("9600 bps, ");
            if ((t & BaudFlags.BAUD_14400) != 0)  s.Append("14400 bps, ");
            if ((t & BaudFlags.BAUD_19200) != 0)  s.Append("19200 bps, ");
            if ((t & BaudFlags.BAUD_38400) != 0)  s.Append("38400 bps, ");
            if ((t & BaudFlags.BAUD_56K) != 0)    s.Append("56 kbps, ");
            if ((t & BaudFlags.BAUD_57600) != 0)  s.Append("57600 bps, ");
            if ((t & BaudFlags.BAUD_115200) != 0) s.Append("115200 bps, ");
            if ((t & BaudFlags.BAUD_128K) != 0)   s.Append("128 kbps, ");
            if ((t & BaudFlags.BAUD_USER) != 0)   s.Append("User bps, ");

            return s.ToString();
        }
    }

    // ********************************************************************
    /// <summary>
    /// Command lines utilities class
    /// </summary>
    public static class Commandline
    {
        static Commandline()
        {
            Application.ApplicationExit += new EventHandler(ApplicationExit);
        }

        /// <summary>
        /// Handler for when the application exits
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args object</param>
        static void ApplicationExit(object sender, EventArgs e)
        {
            if (LegacyCommandLine)
            {
                MessageBox.Show("Warning: some legacy command line methods were called in this application.",
                    "Warning: legacy methods",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
                
        private static bool m_LegacyCommandLine = false;

        /// <summary>
        /// indicator of legacy command line methods (ie command line methods without proper descriptions)
        /// </summary>
        public static bool LegacyCommandLine
        {
            get {return m_LegacyCommandLine; }
            set {m_LegacyCommandLine = value; }
        }

        private struct CmdLineHelpLine
        {
            /// <summary>
            /// The command line option format
            /// </summary>
            public string cmdlineopt;

            /// <summary>
            /// A description of the command line
            /// </summary>
            public string Descr;

            /// <summary>
            /// struct constructor
            /// </summary>
            /// <param name="x">command line format</param>
            /// <param name="y">command line description</param>
            public CmdLineHelpLine(string x, string y)
            {
                cmdlineopt = x;
                Descr = y;
            }
        }
        private static List<CmdLineHelpLine> cmdlinehelp = new List<CmdLineHelpLine>();

        /// <summary>
        /// Method to construct a command line help file
        /// </summary>
        /// <returns></returns>
        public static string CommandLineHelp()
        {
            StringBuilder x = new StringBuilder(10240);

            x.AppendLine(Environment.NewLine + 
                "Command line help: "+FileUtils.General.GetApplicationFilename()+
                Environment.NewLine + Environment.NewLine);

            int maxlen = 0;
            foreach(CmdLineHelpLine cl in cmdlinehelp)
            {
                if (cl.cmdlineopt.Length > maxlen) maxlen = cl.cmdlineopt.Length;
            }
            maxlen++;

            foreach(CmdLineHelpLine cl in cmdlinehelp)
            {
                string clopt = neolibs.StringUtils.FillToLength(cl.cmdlineopt,' ',maxlen);
                x.AppendLine(clopt+cl.Descr+Environment.NewLine);
            }

            return x.ToString();
        }

        /// <summary>
        /// Add a command line help description
        /// </summary>
        /// <param name="cmdlineopt">the command line option</param>
        /// <param name="Descr">Description of commandline option</param>
        public static void AddCmdLineHelpLine(string cmdlineopt, string Descr)
        {
            CmdLineHelpLine x = new CmdLineHelpLine(cmdlineopt,Descr);

            foreach(CmdLineHelpLine t in cmdlinehelp)
            {
                if (t.cmdlineopt == cmdlineopt) return; // do not add if already there
            }
            cmdlinehelp.Add(x);
        }

        /// *******************************************************************
        /// <summary>
        /// See how many command line params contain a specified string
        /// </summary>
        /// <param name="x">string to check for</param>
        /// <returns>number of parameters that contain the string</returns>
        public static int FindParam(string x)
        {
            string[] args = Environment.GetCommandLineArgs();
            int      result = 0;

            for (int i=0; i<=args.GetUpperBound(0); i++)
            {
                if (args[i].Contains(x))
                {
                    result++;
                }
            }

            return result;
        }

        /// *******************************************************************
        /// <summary>
        /// See how many command line params is equal to a specified string
        /// </summary>
        /// <param name="x">string to check for</param>
        /// <returns>number of parameters that is equal to the string</returns>
        public static int FindParamExact(string x)
        {
            LegacyCommandLine = true;
            return FindParamExact(x,"No Help available");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public static int FindParamExact(string x, string Description)
        {
            string[] args = Environment.GetCommandLineArgs();
            int      result = 0;

            for (int i=0; i<=args.GetUpperBound(0); i++)
            {
                if (args[i] == x)
                {
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// check if a command line parameter value was passed and replace val with the value (if found)
        /// </summary>
        /// <param name="param">command line parameter to look for (eg --logfile, to look for --logfile=somefilename.txt)</param>
        /// <param name="val">ref value to be override by command line value if found</param>
        /// <param name="Description">Description of the command line parameter</param>
        /// <returns>true if value was changed, false if not</returns>
        public static bool SetStringParam(string param, ref string val, string Description)
        {
            string t = FindParamValue(param);
            
            AddCmdLineHelpLine(param+"=parameter",Description);

            if (t != "") 
            {
                val = t;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return a string for a command line parameter of the --[parameter]=value
        /// </summary>
        /// <param name="x">command line paramater text</param>
        /// <returns></returns>
        public static string FindParamValue(string x)
        {
            string   param = x + "=";
            string[] args = Environment.GetCommandLineArgs();
            string   result = "";

            for (int i=0; i<=args.GetUpperBound(0); i++)
            {
                if (args[i].Contains(x))
                {                    
                    result = args[i];
                    result = result.Replace(param,"");
                }
            }
            return result;
        }
    }

    /// <summary>
    /// General application utilities
    /// </summary>
    public static class AppUtils
    {
        /// <summary>
        /// Show a dialog to confirm if the user wants to quit
        /// </summary>
        /// <returns>True if app can quit, false if not</returns>
        public static bool ConfirmQuit()
        {
            if (MessageBox.Show("Are you sure to exit the application?","Please confirm.",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// Utility class for reflection
    /// </summary>
    public static class ReflectionUtils
    {
        /// <summary>
        /// Get a method's parameters
        /// </summary>
        /// <returns></returns>
        public static string[] GetMethodParameters()
        {
            throw new NotImplementedException("GetMethodParameters() is not implemented!");
        }
    }

    /// <summary>
    /// BCD utilities
    /// </summary>
    public static class BCDutils
    {
        /// <summary>
        /// Convert a value to a BCD (4 digits)
        /// </summary>
        /// <param name="val">Integer to convert to BCD</param>
        /// <returns>byte array (2 bytes)</returns>
        public static byte[] Int2Bcd4(int val)
        {
            if (val < 0 || val > 9999) throw new ArgumentException();
            int bcd = 0;
            for (int digit = 0; digit < 4; ++digit)
            {
                int nibble = val % 10;
                bcd |= nibble << (digit * 4);
                val /= 10;
            }
            return new byte[] { (byte)((bcd >> 8) & 0xff), (byte)(bcd & 0xff) };
        }
    }
}
