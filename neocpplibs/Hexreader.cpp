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
#include "Hexreader.h"

namespace Sema {
namespace CPP {

	using namespace System::Windows::Forms;
    using namespace System;

// ***********************************************************
// get the intel Hex record length from a string
// ***********************************************************
int THexUtils::GetHexRecordLen(String^ x)
{
	return Convert::ToInt32(x->Substring(1,2),16);
}

// ***********************************************************
// get the intel Hex record type from a string
// ***********************************************************
int THexUtils::GetHexRecordType(String^ x)
{
	return Convert::ToInt32(x->Substring(7,2),16);
}

// ***********************************************************
// get the intel Hex load offset from a string
// ***********************************************************
int THexUtils::GetHexRecordOffset(String ^x)
{
	return Convert::ToInt32(x->Substring(3,4),16);
}

// ***********************************************************
// Add intel HEX checksum to string
// ***********************************************************
String^ THexUtils::AddHexChecksum(String^ x)
{
	int Chk;
	int i;
	String^ Result = "";

	Chk = 0;
	for (i=1;  i<=(x->Length / 2); i++)
	{
		Chk = Chk + Convert::ToInt32(x->Substring(i*2 - 1,2),16);
	}
	Chk = Chk & 0xFF;
	Chk = Chk ^ 0xFF;
	Chk = Chk + 1;
	Chk = Chk & 0xFF;
	Result = x + Chk.ToString("X02");

	return Result;

}

// ***********************************************************
// get the intel Hex checksum from a string
// ***********************************************************
bool THexUtils::ChkHexRecordChecksum(String ^ x)
{
	int Chk;
	int TempChk;
	int i;
	bool fResult;

	fResult = false;

	TempChk = Convert::ToInt32(x->Substring(x->Length-2,2),16);

	Chk = 0;
	for (i = 1; i <= ((x->Length-2)/2); i++)
	{
		Chk = Chk + Convert::ToInt32(x->Substring(i*2-1,2),16);
	}

	Chk = Chk & 0xFF;
	Chk = Chk ^ 0xFF;
	Chk = Chk + 1;
	Chk = Chk & 0xFF;

	if (Chk == TempChk)
	{
		fResult = true;
	}

	return fResult;
}

// ***********************************************************
// get the intel Hex checksum from a string
// ***********************************************************
unsigned int THexUtils::GetHexExtLinAddr(String^ x)
{
	return Convert::ToInt32(x->Substring(9,4),16);
}


// ***********************************************************
// Create method
// ***********************************************************
THexUtils::THexUtils(String^ FN)
{
   if (!OpenFile(FN)) 
   {
	   MessageBox::Show("THexUtils: Error opening file "+FN,"Error",
		   MessageBoxButtons::OK,MessageBoxIcon::Error,MessageBoxDefaultButton::Button1);
   }
}

// ***********************************************************
// Destroy method
// ***********************************************************
THexUtils::~THexUtils(void)
{
   CloseFile();
}

// ***********************************************************
// Open the hex file
// ***********************************************************
bool THexUtils::OpenFile(String^ inf)
{
	if (!File::Exists(inf)) return false;

	IFH = gcnew StreamReader(inf);

	CurBase     = 0;
	EndOfFile   = false;
	HighestAddr = 0;

	return true;
}

// ***********************************************************
// Open the hex file
// ***********************************************************
void THexUtils::CloseFile(void)
{
	IFH->Close();
}

// ***********************************************************
// Hex to bin conversion
// retuns true if error or end of file
// ***********************************************************
bool THexUtils::LoadFile(array<unsigned char>^ x)
{
   String^ TempStr = "";
   int     i;
   int     Addr = 0;
   int     cnt = 0;

   LowestAddress   = 0x7FFFFFFF;
   HighestAddress  = 0;

   while (IFH->Peek() >= 0)
   {
	   TempStr = IFH->ReadLine();

		if ((TempStr[0] == ':') && (ChkHexRecordChecksum(TempStr)))
		{
			// RecLen  := GetHexRecordLen(TempStr);
			recType = GetHexRecordType(TempStr);
			recOffs = GetHexRecordOffset(TempStr);

			switch (recType)
			{
				case 0x00 :	// Data record
						{
							i = 10;
							while(i<(TempStr->Length-2))
							{
								Addr = CurBase + recOffs;
                                if (Addr < LowestAddress)  LowestAddress  = Addr;
                                if (Addr > HighestAddress) HighestAddress = Addr;

								x[Addr+(i - 10) / 2] = Convert::ToInt32(TempStr->Substring(i-1,2),16);
								cnt = ((i - 10) / 2);
								i = i + 2;
							}
						}
						break;

				case 0x01 :	// end of file record
						EndOfFile = true;
						break;

				case 0x02 :	
						CurBase = GetHexExtLinAddr(TempStr) << 4;
						break;

				case 0x03 :	
						CurBase = (GetHexExtLinAddr(TempStr) << 4) +
							Convert::ToInt32(TempStr->Substring(13,4),16);
						break;

				case 0x04 :	
						CurBase = GetHexExtLinAddr(TempStr) << 16;
						break;

				case 0x05 :	
						CurBase = Convert::ToInt32(TempStr->Substring(9,8));
						break;
				default:
						break;
			}
		}
		else
		{
			/*MessageDlg('Hex file Fail',mtWarning,[mbok],0);} old pascal*/
            IFH->Close();
			return false;
		}
   }
   IFH->Close();
   return true;
}

// ***********************************************************
// Method:  THexWriter::WriteFile
// Inputs:  None
// Outputs: None
// Descr:   Writes an Intel HEX file
// ***********************************************************
bool THexUtils::WriteFile(String^ Filename,array<Byte>^ Buffer,
            int StartAddr, int EndAddr,
            ToolStripProgressBar^ tspbProgress,
            ProgressBar^ pbProgress)
{
    try
    {
        bool UpdateRequired = false;

        int CurBase,j;
        String^ temp = "";

        if (StartAddr >= EndAddr) return false;

        StreamWriter^ sw = gcnew StreamWriter(Filename);

        CurBase = 0xFFFFFFFF;

        if (tspbProgress != nullptr)
        {
            tspbProgress->Minimum = StartAddr;
            tspbProgress->Maximum = EndAddr;
            tspbProgress->Value   = StartAddr;
            tspbProgress->Visible = true;
        }
        if (pbProgress != nullptr)
        {
            pbProgress->Minimum = StartAddr;
            pbProgress->Maximum = EndAddr;
            pbProgress->Value   = StartAddr;
            pbProgress->Visible = true;
        }
        for(int i=StartAddr; i<=EndAddr; i+=16)
        {
            UpdateRequired = false;
            if (tspbProgress != nullptr)
            {
                tspbProgress->Value   = i;
                UpdateRequired = true;
            }
            if (pbProgress != nullptr)
            {
                pbProgress->Value   = i;
                UpdateRequired = true;
            }
            if (UpdateRequired)
            {
                UpdateRequired = false;
                Application::DoEvents();
            }
            if ((i & 0xFFFF0000) != CurBase)
            {
                CurBase = (i & 0xFFFF0000);

                // write the new base
                temp = ":02000004"+(CurBase >> 16).ToString("X04");
                temp = AddHexChecksum(temp);
                sw->WriteLine(temp);
            }

            //write this hex line
            temp = "";
            for (j=0; (j<16) && ((i+j)<=EndAddr); j++)
            {
                temp += Buffer[i+j].ToString("X02");
            }
            temp = ":"+ j.ToString("X02") + (i & 0xFFFF).ToString("X04") + "00" + temp;
            temp = AddHexChecksum(temp);
            sw->WriteLine(temp);
        }

        // write the final record
        sw->WriteLine(":00000001FF");

        sw->Close();

        return true;
    }
    catch(Exception^ e)
    {
		throw gcnew neolibs::NeoException("Problem with THexUtils::WriteFile",e);
    }
}



} // namespace definition CPP
} // namespace definition Sema

