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
using System.Windows.Forms;

using neolibs.ControlUtils;

namespace neolibs
{
    // ************************************************************************
    /// <summary>
    /// Exception thrown when text on a control cannot be set
    /// </summary>
    public class InstrumentationTextFailed : NeoException
    {
        private Control c;
        private string  Text;
        private bool    Valid;

        // ********************************************************************
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reason">Text description of error</param>
        public InstrumentationTextFailed(string reason) : base (reason)
        {
            c = null;
            Text = "";
            Valid = false;
        }

        // ********************************************************************
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reason">Text description of error</param>
        /// <param name="e">Inner exception</param>
        public InstrumentationTextFailed(string reason, Exception e) : base (reason,e)
        {
            c = null;
            Text = "";
            Valid = false;
        }

        // ********************************************************************
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reason">Text description of error</param>
        /// <param name="e">Inner exception</param>
        /// <param name="control">Control that was used</param>
        /// <param name="TextString">Text that was passed to write to control</param>
        /// <param name="ValidValue">Value was valid</param>
        public InstrumentationTextFailed(string reason, Exception e, Control control,
                                            string TextString, bool ValidValue) : base (reason,e)
        {
            c = control;
            Text = TextString;
            Valid = ValidValue;
        }

        // ********************************************************************
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reason">Text description of error</param>
        /// <param name="control">Control that was used</param>
        /// <param name="TextString">Text that was passed to write to control</param>
        /// <param name="ValidValue">Value was valid</param>
        public InstrumentationTextFailed(string reason, Control control,
                                            string TextString, bool ValidValue) : base (reason)
        {
            c = control;
            Text = TextString;
            Valid = ValidValue;
        }
    }

    // ************************************************************************
    /// <summary>
    /// Instrumentation class - contains various methods used to display values for telemetry
    /// </summary>
    public class Instrumentation
    {
        private static string FInvalidDisplayString = "------";

        // ********************************************************************
        /// <summary>
        /// Text used to indicate that a display is invalid
        /// </summary>
        public static string InvalidDisplayString
        {
            get
            {
                return FInvalidDisplayString;
            }
            set
            {
                FInvalidDisplayString = value;
            }
        }

        // ********************************************************************
        /// <summary>
        /// Set the text of a control for telemetry
        /// </summary>
        /// <param name="ctrl">Control of which the text is to be set</param>
        /// <param name="txt">Text to use</param>
        /// <param name="Valid">Is the display valid or not?</param>
        public static void SetControlText(Control ctrl, string txt, bool Valid)
        {
            try
            {
                if (Valid)
                {
                    ctrl.Text = txt;
                }
                else
                {
                    ctrl.Text = InvalidDisplayString;
                }
            }
            catch(Exception e)
            {
                throw new InstrumentationTextFailed("Cannot set text for control.",
                    e,ctrl,txt,Valid);
            }
        }

        // ********************************************************************
        /// <summary>
        /// Set control text to a number
        /// </summary>
        /// <param name="ctrl">Control to display in</param>
        /// <param name="num">value to display</param>
        /// <param name="Valid">Is the display valid or not?</param>
        public static void SetControlText(Control ctrl, ushort num, bool Valid)
        {
            try
            {
                SetControlText(ctrl, num.ToString(), Valid);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Set the text of an object (if possible). Note that if SetObjectText is called with an object inherited from the Control
        /// class, then SetControlText will be called from SetObjectText to perform the task.
        /// </summary>
        /// <param name="x">Object of which to set the text</param>
        /// <param name="txt">Text to set to</param>
        /// <param name="Valid">Is the display valid or not?</param>
        public static void SetObjectText(object x, string txt, bool Valid)
        {
            string temp;

            try
            {
                if (Valid)
                {
                    temp = txt;
                }
                else
                {
                    temp = InvalidDisplayString;
                }

                if (x is Control) SetControlText(x as Control, txt, Valid);
                else if (x is ListViewItem.ListViewSubItem) (x as ListViewItem.ListViewSubItem).Text = temp;
            }
            catch (Exception e)
            {
                throw new NeoException("SetObjectText Failed.", e);
            }
        }

        // ********************************************************************
        /// <summary>
        /// Shows the flags of a uint value in a listview
        /// </summary>
        /// <param name="lv">Listview object</param>
        /// <param name="value">Value to display</param>
        /// <param name="numflags">Number of flags (assuming all flags are right aligned, ie start at LSB)</param>
        /// <param name="Valid">Flag to indicate if value is valid or not</param>
        public static void ShowFlagsInListview(ListView lv, uint value, int numflags, bool Valid)
        {
            if (Valid)
            {
                ListViewUtils.ShowFlagsInListview(lv, value, numflags);
                lv.Enabled = true;
            }
            else
            {
                ListViewUtils.ShowFlagsInListview(lv, 0, numflags);
                lv.Enabled = false;
            }
        }

        // ********************************************************************
        /// <summary>
        /// Show the values from a float array in a listview column
        /// </summary>
        /// <param name="lv">Listview to show int</param>
        /// <param name="values">array of values to show</param>
        /// <param name="col">column to display in</param>
        /// <param name="fValid">flag to indicate if the values are valid or not</param>
        /// <param name="fmtstr">formatting string</param>
        public static void ShowValuesInListviewColumn(ListView lv, float[] values, int col, bool fValid, string fmtstr = "")
        {
            try
            {
                for(int i=0; i<=values.GetUpperBound(0); i++)
                {
                    if (fValid)
                    {
                        if (fmtstr == "")
                        {
                            lv.Items[i].SubItems[col].Text = values[i].ToString();
                        }
                        else
                        {
                            lv.Items[i].SubItems[col].Text = values[i].ToString(fmtstr);
                        }
                    }
                    else
                    {
                        lv.Items[i].SubItems[col].Text = InvalidDisplayString;
                    }
                }
            }
            catch (Exception e)
            {
                throw new NeoException("Cannot show float values in ShowValuesInListviewColumn", e);
            }
        }

        // ********************************************************************
        /// <summary>
        /// Show the values from a float array in a listview column 
        /// </summary>
        /// <param name="lv">Listview to show in</param>
        /// <param name="values">array of integers</param>
        /// <param name="col">column number toshow in</param>
        /// <param name="fValid">flag to indicate if the values are valid or not</param>
        /// <param name="fmtstr">format string</param>
        public static void ShowValuesInListviewColumn(ListView lv, int[] values, int col, bool fValid,  string fmtstr = "")
        {
            try
            {
                for(int i=0; i<=values.GetUpperBound(0); i++)
                {
                    if (fValid)
                    {
                        if (fmtstr == "")
                        {
                            lv.Items[i].SubItems[col].Text = values[i].ToString();
                        }
                        else
                        {
                            lv.Items[i].SubItems[col].Text = values[i].ToString(fmtstr);
                        }
                    }
                    else
                    {
                        lv.Items[i].SubItems[col].Text = InvalidDisplayString;
                    }
                }
            }
            catch (Exception e)
            {
                throw new NeoException("Cannot show int values in ShowValuesInListviewColumn", e);
            }
        }

        // ********************************************************************
        /// <summary>
        /// Assign a value to the SelectedIndex of a ComboBox
        /// </summary>
        /// <param name="cb">ComboBox to use</param>
        /// <param name="value">value to assign</param>
        /// <param name="Min">minimum value to accept</param>
        /// <param name="Max">maximum value to accept</param>
        /// <param name="Default">Default in case of error</param>
        public static void SetComboBoxSelectedIndex(ComboBox cb, int value, int Min, int Max, int Default)
        {
            try
            {
                if ((value <= Max) && (value >= Min))
                {
                    cb.SelectedIndex = value;
                }
            }
            catch
            {
                try
                {
                    cb.SelectedIndex = Default;
                }
                catch (Exception e)
                {
                    throw new NeoException("Cannot set Combobox SelectedIndex", e);
                }
            }
        }

        // ********************************************************************
        /// <summary>
        /// Generic routine to show progress in a number of different controls
        /// </summary>
        /// <param name="c">Control to use</param>
        /// <param name="min">minimum value</param>
        /// <param name="max">maximum value</param>
        /// <param name="value">progress value</param>
        public static void ShowProgress(Control c, int min, int max, int value)
        {
            try
            {
                if (c is ProgressBar)
                {
                    ProgressBar p = c as ProgressBar;
                    p.Minimum = min;
                    p.Maximum = max;
                    p.Value = value;
                }
            }
            catch(Exception e)
            {
                throw new NeoException("Error in progress update", e);
            }
        }

        // ********************************************************************
        /// <summary>
        /// Generic routine to show progress in a number of different controls
        /// </summary>
        /// <param name="c">Control to use</param>
        /// <param name="min">minimum value</param>
        /// <param name="max">maximum value</param>
        /// <param name="value">progress value</param>
        public static void ShowProgress(ToolStripItem c, int min, int max, int value)
        {
            try
            {
                if (c is ToolStripProgressBar)
                {
                    ToolStripProgressBar p = c as ToolStripProgressBar;
                    p.Minimum = min;
                    p.Maximum = max;
                    p.Value = value;
                }
            }
            catch (Exception e)
            {
                throw new NeoException("Error in progress update", e);
            }
        }
    }

    // ************************************************************************
    /// <summary>
    /// Connects data to some display
    /// WARNING: class not complete - to be developed
    /// </summary>
    public class InstrumentConnectorBase
    {
        // private void* Data;

        /// <summary>
        /// InstrumentConnectorBase constructor
        /// </summary>
        public InstrumentConnectorBase()
        {
            
        }
    }
}
