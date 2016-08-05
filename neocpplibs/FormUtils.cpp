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

#include "stdafx.h"
#include "formutils.h"

#if 0 // only used for linux
 #pragma warning(disable:4483)
 void __clrcall __identifier(".cctor")()
 {
 }
#endif


namespace neolibs {
namespace CPP {

    using namespace neolibs;
    using namespace System;
	using namespace System::Windows::Forms;

/* ***************************************************************************************
* Method:  DataGridViewUtils::PopulateColumns
* Inputs:  array<unsigned char>^ Buf, TextBox^ tbDisplay
* Outputs: None
* Descr:   Display a buffer in a text edit box
* *************************************************************************************** */
void DataGridViewUtils::PopulateColumns(char *Labels,
					DataGridView^ dgv,
					int count, int strlength)
{
	try
	{
		dgv->Columns->Clear();

		for (int i=0; i<count; i++)
		{
			dgv->Columns->Add(gcnew String("Column")+i.ToString(), gcnew String(Labels));
			Labels += strlength;
		}

	}
	catch(Exception^ e)
	{
		throw gcnew Exception("Cannot initialise DataGridView columns because - (" + e->ToString() + ")");
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::PopulateTable
* Inputs:  array<unsigned char>^ Buf, TextBox^ tbDisplay
* Outputs: None
* Descr:   Display a buffer in a text edit box
* *************************************************************************************** */
void DataGridViewUtils::PopulateTable(S_BYTE* sbData, DataGridView^ dgv, int count)
{
	try
	{
		dgv->Rows->Clear();
		dgv->Rows->Add();
		dgv->AllowUserToAddRows = false;

		for (int i=0; i<count; i++)
		{
			dgv->Rows[0]->Cells[i]->Value = sbData[i].ToString();
		}

	}
	catch(Exception^ e)
	{
		throw gcnew Exception("Cannot initialise DataGridView columns because - (" + e->ToString() + ")");
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::PopulateTable
* Inputs:  array<unsigned char>^ Buf, TextBox^ tbDisplay
* Outputs: None
* Descr:   Display a buffer in a text edit box
* *************************************************************************************** */
void DataGridViewUtils::PopulateTable(S_SBYTE* sbData, DataGridView^ dgv, int count)
{
	try
	{
		dgv->Rows->Clear();
		dgv->Rows->Add();
		dgv->AllowUserToAddRows = false;

		for (int i=0; i<count; i++)
		{
			dgv->Rows[0]->Cells[i]->Value = sbData[i].ToString();
		}

	}
	catch(Exception^ e)
	{
		throw gcnew Exception("Cannot initialise DataGridView columns because - (" + e->ToString() + ")");
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::UpdateTable
* Inputs:  S_BYTE* sbData, DataGridView^ dgv, int count
* Outputs: None
* Descr:   Update the table contents from memory
* *************************************************************************************** */
void DataGridViewUtils::UpdateTable(S_BYTE* sbData, DataGridView^ dgv, int count, bool fValid)
{
	try
	{
		for (int i=0; i<count; i++)
		{
			if (fValid)
			{
				dgv->Rows[0]->Cells[i]->Value = sbData[i].ToString();
			}
			else
			{
				dgv->Rows[0]->Cells[i]->Value = "----";
			}
		}

	}
	catch(Exception^ e)
	{
		throw gcnew Exception("Cannot update DataGridView columns because - (" + e->ToString() + ")");
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::UpdateTable
* Inputs:  S_SBYTE* sbData, DataGridView^ dgv, int count
* Outputs: None
* Descr:   Update the table contents from memory
* *************************************************************************************** */
void DataGridViewUtils::UpdateTable(S_SBYTE* sbData, DataGridView^ dgv, int count, bool fValid)
{
	try
	{
		for (int i=0; i<count; i++)
		{
			if (fValid)
			{
				dgv->Rows[0]->Cells[i]->Value = sbData[i].ToString();
			}
			else
			{
				dgv->Rows[0]->Cells[i]->Value = "----";
			}
		}

	}
	catch(Exception^ e)
	{
		throw gcnew Exception("Cannot update DataGridView columns because - (" + e->ToString() + ")");
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::CopyTableText
* Inputs:  DataGridView^ dgvsrc, DataGridView^ dgvdest
* Outputs: None
* Descr:   Copy the text from one table to another
* *************************************************************************************** */
void DataGridViewUtils::CopyTableText(DataGridView^ dgvsrc, DataGridView^ dgvdest)
{
	try
	{
		for(int i=0; (i<dgvsrc->ColumnCount) && (i<dgvdest->ColumnCount); i++)
		{
			dgvdest->Rows[0]->Cells[i]->Value = dgvsrc->Rows[0]->Cells[i]->Value;			
		}
	}
	catch(Exception^ e)
	{
		throw gcnew Exception("Cannot copy DataGridView text because - (" + e->ToString() + ")");
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::GetTableData
* Inputs:  S_BYTE* sbData = pointer to data, DataGridView^ dgv = datagridview to use, 
*          int count = number of elements in the table, S_BYTE Min = minimum value to accept, 
*          S_BYTE Max = maximum value to accept, S_BYTE Default value where errors occur
* Outputs: None
* Descr:   Convert the DataGridView Entries to a S_BYTE array
* *************************************************************************************** */
void DataGridViewUtils::GetTableData(S_BYTE* sbData, DataGridView^ dgv, int count, S_BYTE Min, S_BYTE Max, S_BYTE Default)
{
	try
	{
		for(int i=0; (i<count) && (i<dgv->ColumnCount); i++)
		{
			String^ t = (String^)dgv->Rows[0]->Cells[i]->Value;
			sbData[i] = neolibs::Calibration::Convert::TextToUInt8(t,Min,Max,Default);
		}
	}
	catch(Exception^ e)
	{
		throw gcnew neolibs::NeoException("Error in table conversion.",e);
	}
}

/* ***************************************************************************************
* Method:  DataGridViewUtils::GetTableData
* Inputs:  S_SBYTE* sbData = pointer to data, DataGridView^ dgv = datagridview to use, 
*          int count = number of elements in the table, S_SBYTE Min = minimum value to accept, 
*          S_SBYTE Max = maximum value to accept, S_SBYTE Default value where errors occur
* Outputs: None
* Descr:   Convert the DataGridView Entries to a S_SBYTE array
* *************************************************************************************** */
void DataGridViewUtils::GetTableData(S_SBYTE* sbData, DataGridView^ dgv, int count, S_SBYTE Min, S_SBYTE Max, S_SBYTE Default)
{
	try
	{
		for(int i=0; (i<count) && (i<dgv->ColumnCount); i++)
		{
			String^ t = (String^)dgv->Rows[0]->Cells[i]->Value;
			sbData[i] = neolibs::Calibration::Convert::TextToInt8(t,Min,Max,Default);
		}
	}
	catch(Exception^ e)
	{
		throw gcnew neolibs::NeoException("Error in table conversion.",e);
	}
}

/* ***************************************************************************************
* Method:  TextBoxUtils::ShowMemBuffer
* Inputs:  array<unsigned char>^ Buf, TextBox^ tbDisplay
* Outputs: None
* Descr:   Display a buffer in a text edit box
* *************************************************************************************** */
void TextBoxUtils::ShowMemBuffer(S_BYTE* Buf, 
                              TextBox^ tbDisplay,
                              ToolStripProgressBar^ tspbProgress,
                              ProgressBar^ pbProgress,
                              int StartAddr,
                              int EndAddr)
{
	array<S_BYTE>^ HexBuf = gcnew array<S_BYTE>(EndAddr + 1024) ;

	for(int i=0; i<EndAddr; i++)
	{
		HexBuf[i] = Buf[i];
	}

	ShowMemBuffer(HexBuf,tbDisplay,tspbProgress,pbProgress,StartAddr,EndAddr);
}

/* ***************************************************************************************
* Method:  TextBoxUtils::ShowMemBuffer
* Inputs:  array<unsigned char>^ Buf, TextBox^ tbDisplay
* Outputs: None
* Descr:   Display a buffer in a text edit box
* *************************************************************************************** */
void TextBoxUtils::ShowMemBuffer(array<unsigned char>^ Buf, 
                              TextBox^ tbDisplay,
                              ToolStripProgressBar^ tspbProgress,
                              ProgressBar^ pbProgress,
                              int StartAddr,
                              int EndAddr)
{
    try
    {
		System::Text::StringBuilder^ temp = gcnew System::Text::StringBuilder( 6*(EndAddr-StartAddr+1));

        bool    fUpdateRequired = false;

        tbDisplay->Text = "";

        for(int i=StartAddr; i<=EndAddr; i+=16)
        {
            temp->Append(i.ToString("X08"));

            for (int j=0; (j<16) && ((i+j)<=EndAddr); j++)
            {
                temp->Append(" " + Buf[i+j].ToString("X02"));
                if (j==7) temp->Append(" ");
            }
            temp->Append("  ");
            for (int j=0; (j<16) && ((i+j)<=EndAddr); j++)
            {
                if (Buf[i+j] < 32)
                {
                    temp->Append(".");
                }
                else
                {
                    temp->Append(Convert::ToChar(Buf[i+j]));
                }
            }
            temp->Append(Environment::NewLine);

            fUpdateRequired = false;
            if (pbProgress != nullptr)
            {
				Instrumentation::ShowProgress(pbProgress,StartAddr,EndAddr,i);
                fUpdateRequired   = true;
            }
            if (tspbProgress != nullptr)
            {
				Instrumentation::ShowProgress(tspbProgress,StartAddr,EndAddr,i);
                fUpdateRequired   = true;
            }
            if (fUpdateRequired)
            {
                Application::DoEvents();
            }
        }
		tbDisplay->Text = temp->ToString();
    }
    catch(Exception^ e)
    {
        throw gcnew Exception("Cannot display buffer in Textbox because - (" + e->ToString() + ")");
    }
}

/* ***************************************************************************************
* Method:  ListViewUtils::PopulateListView
* Inputs:  char **Strings, ListView^ lv
* Outputs: None
* Descr:   Populate the listview text items with values from a character **
* *************************************************************************************** */
void ListViewUtils::PopulateListView(char *Strings, ListView^ lv, int count, int strlength)
{
	try
	{
		lv->Items->Clear();

		for (int i=0; i<count; i++)
		{
			lv->Items->Add(gcnew String(Strings));
			Strings += strlength;
		}
	}
	catch (Exception^ e) 
	{
		throw gcnew NeoException(gcnew String("PopulateListView Error occurred in ")+lv->Name,e);
	}
}

/* ***************************************************************************************
* Method:  ListViewUtils::PopulateListView
* Inputs:  char **Strings, ListView^ lv
* Outputs: None
* Descr:   Populate the listview text items with values from a character **
* *************************************************************************************** */
void ListViewUtils::PopulateListView(char *Strings, ListView^ lv, int count, int strlength, int numsubitems)
{
	try
	{
		ListViewItem^ temp;

		lv->Items->Clear();

		for (int i=0; i<count; i++)
		{
			temp = lv->Items->Add(gcnew String(Strings));
			Strings += strlength;
	
			for(int j = 0; j<numsubitems; j++)
			{
				temp->SubItems->Add("");
			}
		}
	}
	catch (Exception^ e) 
	{
		throw gcnew NeoException(gcnew String("PopulateListView Error occurred in ")+lv->Name,e);
	}
}

/* ***************************************************************************************
* Method:  ListViewUtils::GetFlagsFromListView
* Inputs:  ListView^ object
* Outputs: None
* Descr:   Get the flags from a listview object
* *************************************************************************************** */
S_u32 ListViewUtils::GetFlagsFromListView(ListView^ lv)
{
	try
	{
		S_u32 t = 0;

		for(int i=0; i<lv->Items->Count; i++)
		{
			if (lv->Items[i]->Checked)
			{
				t |= (0x00000001uL << i);
			}
		}
		return t;
	}
	catch(Exception^ e)
	{
		throw gcnew neolibs::NeoException("Error in getting flags from listview.",e);
	}
}

/* ***************************************************************************************
* Method:  ComboBoxUtils::Populate
* Inputs:  char *Strings = ptr to c style declared string lits, ComboBox^ cb = ref to comboboc, 
*          int count = number of items to add, int strlength = length of each c style declared string
* Outputs: None
* Descr:   Populate the listview text items with values from a character **
* *************************************************************************************** */
void ComboBoxUtils::Populate(char *Strings, ComboBox^ cb, int count, int strlength)
{
	try
	{
		cb->Items->Clear();
		cb ->DropDownStyle = ComboBoxStyle::DropDownList;

		for (int i=0; i<count; i++)
		{
			cb->Items->Add(gcnew String(Strings));
			Strings += strlength;
		}

		neolibs::ControlUtils::ComboBoxUtils::OptimumDropDownWidth(cb,10);
	}
	catch (Exception^ e) 
	{
<<<<<<< HEAD
		throw gcnew neolibs::NeoException(gcnew String("ComboBoxUtils::Populate Error occurred in ")+cb->Name,e);
=======
		throw gcnew NeoException(gcnew String("ComboBoxUtils::Populate Error occurred in ")+cb->Name,e);
>>>>>>> develop
	}
}

/* ***************************************************************************************
* Method:  CheckedListBoxUtils::Populate
* Inputs:  char *Strings = ptr to c style declared string lits, CheckedListBox^ cb = ref to CheckedListBox, 
*          int count = number of items to add, int strlength = length of each c style declared string
* Outputs: None
* Descr:   Populate the CheckedListBox text items with values from a character **
* *************************************************************************************** */
void CheckedListBoxUtils::Populate(char *Strings, CheckedListBox^ cb, int count, int strlength)
{
	try
	{
		cb->Items->Clear();

		for (int i=0; i<count; i++)
		{
			cb->Items->Add(gcnew String(Strings),false);
			Strings += strlength;
		}
	}
	catch (Exception^ e) 
	{
		throw gcnew NeoException(gcnew String("ComboBoxUtils::Populate Error occurred in ")+cb->Name,e);
	}
}

/* ***************************************************************************************
* Method:  CheckedListBoxUtils::CopyTicks
* Inputs:  CheckedListBox^ cbSrc, CheckedListBox^ cbDest
* Outputs: None
* Descr:   Copy the checked status from one checkedlistbox to another
* *************************************************************************************** */
void CheckedListBoxUtils::CopyTicks(CheckedListBox^ cbSrc, CheckedListBox^ cbDest)
{
	try
	{
		for(int i=0; (i<cbSrc->Items->Count) && (i<cbDest->Items->Count); i++)
		{
			cbDest->SetItemCheckState(i,cbSrc->GetItemCheckState(i));
		}
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException(gcnew String("CheckedListBoxUtils::CopyTicks Error occurred in ")+cbDest->Name +"/" + cbSrc->Name,e);
	}
}

/* ***************************************************************************************
* Method:  CheckedListBoxUtils::ClearAllTicks
* Inputs:  CheckedListBox^ cb
* Outputs: None
* Descr:   Clear all checkboxes in ChecxkedListBox
* *************************************************************************************** */
void CheckedListBoxUtils::ClearAllTicks(CheckedListBox^ cb)
{
	try
	{
		for(int i=0; (i<cb->Items->Count); i++)
		{
			cb->SetItemChecked(i,false);
		}
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException(gcnew String("CheckedListBoxUtils::CopyTicks Error occurred in ")+cb->Name,e);
	}
}

/* ***************************************************************************************
* Method:  CheckedListBoxUtils::GetFlagsFromCheckListBox
* Inputs:  CheckedListBox^ cb
* Outputs: None
* Descr:   Convert the ticks into u32 flags
* *************************************************************************************** */
S_u32 CheckedListBoxUtils::GetFlagsFromCheckListBox(CheckedListBox^ cb)
{
	try
	{
		S_u32 t = 0;

		for(int i=0; i<cb->Items->Count; i++)
		{
			if (cb->GetItemCheckState(i) == CheckState::Checked)
			{
				t |= (0x00000001uL << i);
			}
		}
		return t;
	}
	catch(Exception^ e)
	{
		throw gcnew neolibs::NeoException("Error in getting flags from checkbox.",e);
	}
}

/* ***************************************************************************************
* Method:  CheckedListBoxUtils::SetFlagsInCheckListBox
* Inputs:  CheckedListBox^ cb, S_u32 value
* Outputs: None
* Descr:   Set the flags in the CheckedListBox
* *************************************************************************************** */
void  CheckedListBoxUtils::SetFlagsInCheckListBox(CheckedListBox^ cb, S_u32 value)
{
	try
	{
		for(int i=0; i<cb->Items->Count; i++)
		{
			if ((value & (1uL << i)) != 0)
			{
				cb->SetItemChecked(i,true);
			}
			else
			{
				cb->SetItemChecked(i,false);
			}
		}
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot set checkboxes",e);
	}
}

} // end namespace neolibs
} // end namespace CPP
