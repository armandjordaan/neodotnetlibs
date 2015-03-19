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
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Web.UI;

using neolibs;

namespace neolibs.FileUtils
{
    /// <summary>
    /// Neo Systems's HTML writer class (to write html to a file)
    /// </summary>
    public class HtmlFileWriter : HtmlTextWriter
    {
        private string m_HMTLFilename;

        /// <summary>
        /// Stringbuilder instance for HTMLFIleWriter
        /// </summary>
        public StringBuilder  SB;

        /// <summary>
        /// StringWriter instance for  HTMLFIleWriter
        /// </summary>
        public StringWriter   SW;

        /// <summary>
        /// Filename to write HTML to
        /// </summary>
        public string HMTLFilename
        {
            get {return m_HMTLFilename;}
            set {m_HMTLFilename = value;}
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="tw">TextWriter to use</param>
        private HtmlFileWriter(TextWriter tw) : base (tw)
        {            
        }


        /// <summary>
        /// Write the HTML to file
        /// </summary>
        public void WriteToFile()
        {
            StringWriter sw = this.InnerWriter as StringWriter;
            File.WriteAllText(HMTLFilename,sw.ToString());
        }

        /// <summary>
        /// Use this static function to get a new HTMLFilewriter class instance
        /// </summary>
        /// <param name="filename">filename to write to</param>
        /// <returns>HtmlFileWriter class instance</returns>
        public static HtmlFileWriter NewHtmlFileWriter(string filename)
        {
            StringBuilder  SB;
            StringWriter   SW;
            HtmlFileWriter HFW;

            SB = new StringBuilder();
            SW = new StringWriter(SB);
            HFW = new HtmlFileWriter(SW);
            HFW.HMTLFilename = filename;

            HFW.SB = SB;
            HFW.SW = SW;

            return HFW;
        }
    }

    // ************************************************************************
    /// <summary>
    /// General file utilities
    /// </summary>
    public class General
    {
        /// <summary>
        /// Delegate method for repeated performing an operation on files
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns>true if success, false if error occured</returns>
        public delegate bool DoForFile(string Filename);

        // ************************************************************************
        /// <summary>
        /// Repeat df for all files matching the pattern
        /// </summary>
        /// <param name="FolderPath">Folder to search for files</param>
        /// <param name="pattern">Pattern of files to look for</param>
        /// <param name="df">delegate to call</param>
        /// <param name="RecurseSubDirs">option to look in subfolders</param>
        public static void DoForAllFiles(string FolderPath, string pattern, DoForFile df, bool RecurseSubDirs = false)
        {
            SearchOption s;
            if (RecurseSubDirs)
            {
                s = SearchOption.AllDirectories;
            }
            else
            {
                s = SearchOption.TopDirectoryOnly;
            }

            string[] FileArray = Directory.GetFiles(FolderPath,pattern,s);
            //string[] DirArray = Directory.GetDirectories(FolderPath,"*.*",s);

            foreach(string file in FileArray)
            {
                df(file);
            }

            /*
            if (RecurseSubDirs)
            {
                foreach(string dir in DirArray)
                {
                    DoForAllFiles(FolderPath + Path.DirectorySeparatorChar + dir, pattern, df, RecurseSubDirs);
                }
            }*/
        }

        // ************************************************************************
        /// <summary>
        /// Get a unique filename based on the time and date
        /// </summary>
        /// <returns>a unique string usable as a filename</returns>
        public static string GetUniqueFilename()
        {
            string temp = DateTime.Now.ToString();
            temp = temp.Replace('/', '_');
            temp = temp.Replace(' ', '_');
            temp = temp.Replace(':', '_');
            return temp;
        }

        // ************************************************************************
        /// <summary>
        /// Asks the user if a file should be overriden
        /// </summary>
        /// <param name="Filename">string containing the filename to ask about</param>
        /// <returns>True if overwrite is OK, false if not to be overwritten.</returns>
        public static bool AskFileOverwrite(string Filename)
        {
            if (MessageBox.Show("The file \"" + Filename + "\" already exists. Overwrite?", "Please confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // ************************************************************************
        /// <summary>
        /// Get the default name for the settings file of this application
        /// </summary>
        /// <returns>string = filename</returns>
        public static string GetSettingsFilename()
        {
            return (Application.UserAppDataPath + Path.DirectorySeparatorChar + "settings.xml");
        }

        // ************************************************************************
        /// <summary>
        /// Get a default logger filename
        /// </summary>
        /// <returns>string = filename</returns>
        public static string GetLoggerFilename()
        {
            return (Application.UserAppDataPath + Path.DirectorySeparatorChar + "log.txt");
        }

        // ************************************************************************
        /// <summary>
        /// Method to get easy access to the current users my Documents
        /// </summary>
        /// <returns>Folder path to current user's "My Documents"</returns>
        public static string GetUserPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        // ************************************************************************
        /// <summary>
        /// Get the user data path for this app. If it does not exist then it is created
        /// </summary>
        /// <param name="AppPath">Name of the folder used to store files for the application</param>
        /// <returns>The full folder path is returned.</returns>
        public static string GetUserAppDataPath(string AppPath)
        {
            string path = GetUserPath();
            //path = path + "\\" + AppPath;
            path = path + Path.DirectorySeparatorChar + AppPath;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        /// <summary>
        /// returns the application filename
        /// </summary>
        /// <returns>filename of application</returns>
        public static string GetApplicationFilename()
        {
            return Process.GetCurrentProcess().MainModule.FileName;
        }

        /// <summary>
        /// Append text to any file
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="text"></param>
        public static void AppendTextToFile(string filename,string text)
        {
            // This text is always added, making the file longer over time 
            // if it is not deleted. 
            using (StreamWriter sw = File.AppendText(filename)) 
            {
                sw.Write(text);
            }
        }
    }

    // ************************************************************************
    /// <summary>
    /// Various XML tools
    /// </summary>
    public class Xml<T>
    {
        // ************************************************************************
        /// <summary>
        /// Stream an object to an XML file.
        /// Note that this method might not work for derived classes
        /// </summary>
        /// <param name="o">Object reference</param>
        /// <param name="filename">File to save to</param>
        public static void SaveToXml(object o, string filename)
        {
            XmlSerializer writer = new XmlSerializer(o.GetType());
            StreamWriter file = new StreamWriter(filename);
            writer.Serialize(file, o);
            file.Close();
        }

        /// *******************************************************************
        /// <summary>
        /// Load the settings
        /// Note that this method might not work for derived classes
        /// </summary>
        /// <param name="t">Object reference (type T)</param>
        /// <param name="filename">File to save to</param>
        /// *******************************************************************
        public static void LoadFromXml(ref T t, string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StreamReader reader = new StreamReader(filename);

                // serialize the object to disk
                t = (T)(serializer.Deserialize(reader));

                // close the writer to release the file resource
                reader.Close();
            }
            catch
            {
                SaveToXml(t, filename);
                MessageBox.Show("No config file was found. A new one was created.","No config file found",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }

    // ************************************************************************
    /// <summary>
    /// CSVWriter is based on StreamWriter and is used to write simple CSV files
    /// </summary>
    public class CSVWriter : StreamWriter
    {
        private char FSeparationCharacter;

        // ************************************************************************
        /// <summary>
        /// SeparationCharacter is the CSV separation character
        /// </summary>
        public char SeparationCharacter
        {
            get
            {
                return FSeparationCharacter;
            }
            set
            {
                FSeparationCharacter = value;
            }
        }

        // ************************************************************************
        /// <summary>
        /// Constructor for CSVWrite class to write to a CSV file
        /// </summary>
        /// <param name="path">filename to write to</param>
        public CSVWriter(string path)
            : base(path)
        {
            SeparationCharacter = ',';
        }

        // ************************************************************************
        /// <summary>
        /// Write a string value - the separation character will be added automatically
        /// </summary>
        /// <param name="x"></param>
        public void WriteField(string x)
        {
            Write(x + SeparationCharacter);
        }

        // ************************************************************************
        /// <summary>
        /// Write a newline to the CSV file
        /// </summary>
        public void WriteNewLine()
        {
            Write(Environment.NewLine);
        }
    }

    /// <summary>
    /// A simple logger class to log application events
    /// </summary>
    public static class SimpleLogger
    {
        /// <summary>
        /// LogLevel defines the different levels of logging (eg DEBUG, INFO etc)
        /// </summary>
        [Flags]
        public enum LogLevel : uint
        {
            /// <summary>
            /// No logging
            /// </summary>
            None        = 1,

            /// <summary>
            /// Log information 
            /// </summary>
            Information = 2,

            /// <summary>
            /// Log Warnings
            /// </summary>
            Warnings    = 4,

            /// <summary>
            /// Log Errors
            /// </summary>
            Errors      = 8,

            /// <summary>
            /// Log Debug info
            /// </summary>
            Debug       = 16,

            /// <summary>
            /// Log Critical info
            /// </summary>
            Critical    = 32,

            /// <summary>
            /// Log Trace information
            /// </summary>
            Trace       = 64,

            /// <summary>
            /// Log All
            /// </summary>
            All         = 0xFFFFFFFF 
        }
           
        private static LogLevel m_Level = LogLevel.Trace | LogLevel.Errors;
        private static string m_Filename = FileUtils.General.GetLoggerFilename();

        /// <summary>
        /// Current logger level property 
        /// </summary>
        public static LogLevel Level
        {
            get { return m_Level; }
            set { m_Level = value; }
        }

        /// <summary>
        /// Current logger filename property
        /// </summary>
        public static string Filename
        {
            get { return m_Filename; }
            set { m_Filename = value; }
        }

        private static Mutex mut = new Mutex();

        /// <summary>
        /// Simple logger static constructor 
        /// </summary>
        static SimpleLogger()
        {
            neolibs.General.Commandline.SetStringParam("--logfile",ref m_Filename,
                "Set the logger filename");
        }

        private static int m_MethodStrWidth   = 0;
        private static int m_FilenameStrWidth = 0;
        private static int m_lineNumStrWidth  = 0;

        /// <summary>
        /// Log data to the current log file
        /// </summary>
        /// <param name="l">Loglevel to log this message</param>
        /// <param name="s">message to log</param>
        public static void Log(LogLevel l, string s)
        {
            if ((Level & l) == 0) return;

            mut.WaitOne();
    
            StackTrace stackTrace = new StackTrace(true);
            StackFrame sf = stackTrace.GetFrame(1);

            string Methodstr   = sf.GetMethod().ToString();
            string Filenamestr = sf.GetFileName();
            string Linenumstr  = sf.GetFileLineNumber().ToString();

            if (Methodstr.Length > m_MethodStrWidth) m_MethodStrWidth       = Methodstr.Length;
            if (Filenamestr.Length > m_FilenameStrWidth) m_FilenameStrWidth = Filenamestr.Length;
            if (Linenumstr.Length > m_lineNumStrWidth) m_lineNumStrWidth    = Linenumstr.Length;

            Methodstr   = StringUtils.FillToLength(Methodstr,   ' ', m_MethodStrWidth);
            Filenamestr = StringUtils.FillToLength(Filenamestr, ' ', m_FilenameStrWidth);
            Linenumstr  = StringUtils.FillToLength(Linenumstr,  ' ', m_lineNumStrWidth);

            StreamWriter sw = new StreamWriter(Filename,true);            
            sw.WriteLine("M:" + Methodstr + "\tF:" +
                Filenamestr + "\tL:" +
                Linenumstr + "\tD:" + 
                DateTime.Now.ToShortDateString() + " " + 
                DateTime.Now.ToLongTimeString() + "\tT:" +
                s);
            sw.Close();

            mut.ReleaseMutex();
        }
    }
}
