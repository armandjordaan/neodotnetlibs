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
using System.Windows.Forms;
using System.IO;

namespace neolibs.ControlUtils
{
    /// <summary>
    /// DoubbleBufferedListView can be used for a listview that does not flicker when updated
    /// </summary>
    public class DoubleBufferedListView : System.Windows.Forms.ListView
    {
        /// <summary>
        /// DoubbleBufferedListView constructor
        /// </summary>
        public DoubleBufferedListView()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }

    /// <summary>
    /// ListviewUtils contains various static methods for use with listviews
    /// </summary>
    public class ListViewUtils
    {
        /// <summary>
        /// Save the contents of a listview to a file (Columns are tab separated)
        /// </summary>
        /// <param name="lv">Listview component</param>
        /// <param name="Filename">Name of file to save to</param>
        public static void SaveListview(ListView lv, String Filename)
        {
            try
            {
                // open a stream for writing and create a StreamWriter to use to implement the stream
                FileStream fs = new FileStream(Filename , FileMode.Create, FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);

                m_streamWriter.Flush();

                // Write to the file using StreamWriter class
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                // write each row of the ListView out to a tab-delimited line in a file
                String temp;
                for (int i = 0; i < lv.Items.Count; i++)
                {
                    temp = "";
                    for (int j=0; j<lv.Items[i].SubItems.Count; j++)
                    {
                        temp += lv.Items[i].SubItems[j].Text + "\t";
                    }
                    m_streamWriter.WriteLine(temp);
                }

                // Close the file
                m_streamWriter.Flush();
                m_streamWriter.Close();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// LoadListview loads the contents of a listview from a file  (Columns are tab separated)
        /// </summary>
        /// <param name="lv">Listview component</param>
        /// <param name="Filename">Name of file to read from</param>
        public static void LoadListview(ListView lv, String Filename)
        {
            try
            {
                FileStream fs = new FileStream(Filename , FileMode.Open, FileAccess.Read);
                StreamReader m_streamReader = new StreamReader(fs); 

                // clear the list
                lv.Items.Clear();

                // Read to the file using StreamReader class
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string strLine = m_streamReader.ReadLine();
                int nStart = 0;

                // Read each line of the stream and parse until last line is reached
                while (strLine != null)
                {
                    int nPos = strLine.IndexOf("\t",nStart);
                    string str1 = strLine.Substring(0, nPos); // get first column string
    
                    nStart = nPos+1;
                    ListViewItem newlvitem = new ListViewItem(str1);
                    while(nPos >= 0)
                    {
                        nPos = strLine.IndexOf("\t", nStart);
                        if (nPos >= 0) str1 = strLine.Substring(nStart, nPos-nStart);
                                  else str1 = strLine;
                        newlvitem.SubItems.Add(str1);
                        nStart = nPos+1;
                    }
                    lv.Items.Add(newlvitem);

                    nStart = 0; // reset
                    strLine = m_streamReader.ReadLine(); // get next line from the stream
                }

                // Close the stream
                m_streamReader.Close();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// ShowFlagsInListview can be used to display a uint flag's values in a listview
        /// </summary>
        /// <param name="lv">Listview object</param>
        /// <param name="value">uint Value to break down</param>
        /// <param name="numflags">Number of flags (assume packed from LSB)</param>
        public static void ShowFlagsInListview(ListView lv, uint value, int numflags)
        {
            for (int i = 0; i < numflags; i++)
            {
                if ((value & (0x00000001 << i)) != 0)
                {
                    lv.Items[i].Checked = true;
                }
                else
                {
                    lv.Items[i].Checked = false;
                }
            }
        }

        /// <summary>
        /// GetFlagsFromListview can be used to pack the checkboxes in a listview into a uint
        /// </summary>
        /// <param name="lv">Listview object</param>
        /// <param name="numflags">Number of flags (will be packed from LSB to MSB)</param>
        /// <returns></returns>
        public static uint GetFlagsFromListview(ListView lv, int numflags)
        {
            uint result = 0;

            for (int i = 0; i < numflags; i++)
            {
                if (lv.Items[i].Checked) result |= ((0x00000001u) << i);
            }
            return result; 
        }

        /// <summary>
        /// Clear all the checkboxes in a listview
        /// </summary>
        /// <param name="lv">Listview object</param>     
        public static void ClearAllFlagsInListview(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].Checked = false;
            }
        }
        
    }
}