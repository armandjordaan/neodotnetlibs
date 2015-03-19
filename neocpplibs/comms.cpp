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
#include "comms.h"
#include <string.h>

namespace neolibs {
namespace CPP {
namespace Comms {
namespace Serial {

	using namespace System::Threading;
	using namespace neolibs;
	using namespace System;
	using namespace System::Windows::Forms;
	using namespace System::Text;
	using namespace HIDClass;

// ****************************************************************************
// Method:  SerialCommsException::SerialCommsException
// Inputs:  String^ str
// outputs: None
// Descr:   SerialCommsException constructor
// ****************************************************************************
SerialCommsException::SerialCommsException(String^ msg) : NeoException(msg)
{
}

// ****************************************************************************
// Method:  SerialCommsException::SerialCommsException
// Inputs:  None
// outputs: None
// Descr:   SerialCommsException constructor
// ****************************************************************************
SerialCommsException::SerialCommsException(void) : NeoException("General serial comms exception - maybe not implemented?")
{

}

// ****************************************************************************
// Method:  TSerialCommsPrimitive::TSerialCommsPrimitive
// Inputs:  None
// outputs: None
// Descr:   TCustomSerialComms constructor
// ****************************************************************************
TSerialCommsPrimitive::TSerialCommsPrimitive()
{
    propComport = gcnew SerialPort();

	DebugTextBox         = nullptr;
	RS485WakeupByte      = 0;
	RS485WakeupByteCount = 0;
	ReadTimeout          = 500;
	WriteTimeout         = 200;
	ResetTimeout         = 200;
	EraseTimeout         = 2000;

	propComport->ReadBufferSize = 65536;

	MessageRetryCount = 1;
}

// ****************************************************************************
// Method:  TSerialCommsPrimitive::~TSerialCommsPrimitive
// Inputs:  None
// outputs: None
// Descr:   TSerialCommsPrimitive destructor
// ****************************************************************************
TSerialCommsPrimitive::~TSerialCommsPrimitive()
{
    CloseComm();
}

// ****************************************************************************
// Method:  TSerialCommsPrimitive::Buadrate::get
// Inputs:  None
// outputs: Current buadrate
// ****************************************************************************
void TSerialCommsPrimitive::Baudrate::set(int value)
{
    try
    {
        comport->BaudRate = value;
    }
    catch(Exception^ e)
    {
		throw gcnew NeoException("TSerialCommsPrimitive::Baudrate::set - called with invalid baudrate. ",e);
    }
}

/* ***************************************************************************************
* Method:  TGeneralSerialComms::SendMessage
* Inputs:  int NumBytesExpected, int Timeout. 
* Outputs: TSerialCommsResults = status code
* Descr:   Send a message
* *************************************************************************************** */
TSerialCommsResults TGeneralSerialComms::SendMessage(int NumBytesExpected, int Timeout)
{
	try
	{
        TSerialCommsResults StatusCode = TSerialCommsResults::COM_GEN_ERR;

		for (int retry=3; (retry != 0) && (StatusCode != TSerialCommsResults::COM_SUCCESS); retry--)
		{
		    comport->DiscardInBuffer();
		    comport->DiscardOutBuffer();

			if (TransmitMessage() == TSerialCommsResults::COM_SUCCESS)
			{
				StatusCode = ReceiveMessage(NumBytesExpected,Timeout);
			}
			else
			{
				StatusCode = TSerialCommsResults::COM_TX_ERR;
			}
		}

		return StatusCode;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("TCustomSerialComms::SendMessage - unable to transmit a message.",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsPrimitive::AutoGetData
// Inputs:  None
// outputs: Status code
// Descr:   to request a large block of data to be TX'ed autoamtically,
//          without checksums and headers
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::AutoGetData(int NumBytesExpected, S_u8* Buf, int timeout)
{
	try
	{
        TSerialCommsResults StatusCode = TSerialCommsResults::COM_GEN_ERR;

	    comport->DiscardInBuffer();
	    comport->DiscardOutBuffer();

		if (TransmitMessage() == TSerialCommsResults::COM_SUCCESS)
		{
			StatusCode = ReceiveBlock(NumBytesExpected,Buf,timeout);
		}

		return StatusCode;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("TCustomSerialComms::SendMessage - unable to transmit a message.",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsPrimitive::AutoGetData
// Inputs:  None
// outputs: Status code
// Descr:   to request a large block of data to be TX'ed autoamtically,
//          without checksums and headers
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::AutoGetData(int NumBytesExpected, array<S_u8>^ Buf, int timeout)
{
	try
	{
        TSerialCommsResults StatusCode = TSerialCommsResults::COM_GEN_ERR;

	    comport->DiscardInBuffer();
	    comport->DiscardOutBuffer();

		if (TransmitMessage() == TSerialCommsResults::COM_SUCCESS)
		{
			StatusCode = ReceiveBlock(NumBytesExpected,Buf,timeout);
		}

		return StatusCode;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("TCustomSerialComms::SendMessage - unable to transmit a message.",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsPrimitive::OpenComm
// Inputs:  None
// outputs: Current buadrate
// Descr:   Opens the com port
// ****************************************************************************
TSerialCommsResults TSerialCommsPrimitive::OpenComm(String^ portname)
{
    try
    {
		if (comport->IsOpen)
		{
			comport->Close();
		}
        comport->PortName    = portname;
		comport->StopBits    = StopBits::One;
		comport->Parity      = Parity::None;
		comport->DataBits    = 8;
        comport->ReadTimeout = 100;

		comport->Open();
    }
    catch(Exception^ e)
    {
        throw gcnew NeoException("TSerialCommsPrimitive::OpenComm - port cannot be opened.",e);
    }
    return TSerialCommsResults::COM_SUCCESS;
}


// ****************************************************************************
// Method:  TSerialCommsPrimitive::CloseComm
// Inputs:  None
// outputs: NOne
// Descr:   Closes the com port
// ****************************************************************************
TSerialCommsResults TSerialCommsPrimitive::CloseComm(void)
{
    try
    {
        comport->Close();
    }
    catch(Exception^ e)
    {
        throw gcnew NeoException("TSerialCommsPrimitive::CloseComm error.",e);
    }
    return TSerialCommsResults::COM_SUCCESS;
}
        
// ****************************************************************************
// Method:  TSerialCommsResults::TransmitMessage
// Inputs:  None
// outputs: NOne
// Descr:   Sends a message
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::TransmitMessage(void)
{
	static S_u8 test = 0;
	try
	{		
		TXCommsBuf->u8Chk =	0;
		TXCommsBuf->u8Chk ^=	S_HI(TXCommsBuf->u16Len);
		TXCommsBuf->u8Chk ^=	S_LO(TXCommsBuf->u16Len);
		TXCommsBuf->u8Chk ^=	TXCommsBuf->u8Cmd;

		for (int i=0; i<TXCommsBuf->u16Len; i++)
		{
			TXCommsBuf->u8Chk ^= TXCommsBuf->unBody.u8Data[i];
		}

		for (int j=0; j<RS485WakeupByteCount; j++)
		{
			RawTXBuf[j] = RS485WakeupByte;
		}
        RawTXBuf[RS485WakeupByteCount+0] = S_SYNC_BYTE;
		RawTXBuf[RS485WakeupByteCount+1] = S_LO(TXCommsBuf->u16Len);
		RawTXBuf[RS485WakeupByteCount+2] = S_HI(TXCommsBuf->u16Len);
		RawTXBuf[RS485WakeupByteCount+3] = TXCommsBuf->u8Cmd;
		for(int i=0; i<TXCommsBuf->u16Len; i++)
		{
			RawTXBuf[RS485WakeupByteCount+4+i] = TXCommsBuf->unBody.u8Data[i];
		}
		RawTXBuf[RS485WakeupByteCount+4+TXCommsBuf->u16Len] = TXCommsBuf->u8Chk;

		//for (int i=0; i<100; i++) RawTXBuf[i] = 0x55;
		//comport->Write(RawTXBuf,0,100);

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("TX: ");
			for(int i=0; i<(RS485WakeupByteCount + S_GENCOMMS_OVERHEAD_BYTES + TXCommsBuf->u16Len); i++)
			{
				str->Append(RawTXBuf[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}
		comport->Write(RawTXBuf,0,RS485WakeupByteCount + S_GENCOMMS_OVERHEAD_BYTES + TXCommsBuf->u16Len);
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot Transmit message. ",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::ReceiveBlock
// Inputs:  int NumBytesExpected, pointer to byte buffer, int Timeout.
// outputs: TSerialCommsResults
// Descr:   Receive a block of bytes
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReceiveBlock(int NumBytesExpected,S_u8* Buf,int Timeout)
{
	try
	{
		array<S_u8>^ TempBuf = gcnew array<S_u8>(NumBytesExpected);

		volatile SerialPort^ test = comport;
        int progress = 0;
        int ComTimeout = Timeout;
        while((ComTimeout) && 
              (comport->BytesToRead < NumBytesExpected) )
        {
            Thread::Sleep(1);
            ComTimeout--;
        }

		/* if (comport->BytesToRead != NumBytesExpected)
		{
			MessageBox::Show("Failed because "+NumBytesExpected.ToString() + " bytes was expected, but"+
				" only "+comport->BytesToRead.ToString() + " was received","Error",
				MessageBoxButtons::OK,MessageBoxIcon::Information);
		}*/

		volatile int preread_bytestoread = comport->BytesToRead;
        comport->Read(TempBuf,0,comport->BytesToRead);
        if ((ComTimeout == 0) && (comport->BytesToRead < NumBytesExpected)) 
		{
			volatile int bytestoread = comport->BytesToRead;
            return TSerialCommsResults::COM_TIMEOUT;
		}

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("RX: ");
			for(int i=0; i<NumBytesExpected; i++)
			{
				str->Append(TempBuf[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}

		for(int i=0; i<NumBytesExpected; i++)
		{
			Buf[i] = TempBuf[i];
		}

		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ ex)
	{
		throw ex;
	}

}

// ****************************************************************************
// Method:  TSerialCommsResults::ReceiveBlock
// Inputs:  int NumBytesExpected, pointer to byte buffer, int Timeout.
// outputs: TSerialCommsResults
// Descr:   Receive a block of bytes
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReceiveBlock(int NumBytesExpected, array<S_u8>^ Buf, int Timeout)
{
	try
	{
		array<S_u8>^ TempBuf = gcnew array<S_u8>(NumBytesExpected);

		volatile SerialPort^ test = comport;
        int progress = 0;
        int ComTimeout = Timeout;
        while((ComTimeout) && 
              (comport->BytesToRead < NumBytesExpected) )
        {
            Thread::Sleep(10);
            ComTimeout--;
        }

		/* if (comport->BytesToRead != NumBytesExpected)
		{
			MessageBox::Show("Failed because "+NumBytesExpected.ToString() + " bytes was expected, but"+
				" only "+comport->BytesToRead.ToString() + " was received","Error",
				MessageBoxButtons::OK,MessageBoxIcon::Information);
		}*/

		volatile int preread_bytestoread = comport->BytesToRead; 
        comport->Read(TempBuf,0,comport->BytesToRead);
        if ((ComTimeout == 0) && (comport->BytesToRead < NumBytesExpected)) 
		{
			volatile int bytestoread = comport->BytesToRead;
            return TSerialCommsResults::COM_TIMEOUT;
		}

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("RX: ");
			for(int i=0; i<NumBytesExpected; i++)
			{
				str->Append(TempBuf[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}

		for(int i=0; i<NumBytesExpected; i++)
		{
			Buf[i] = TempBuf[i];
		}

		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ ex)
	{
		throw ex;
	}

}

// ****************************************************************************
// Method:  TSerialCommsResults::ReceiveMessage
// Inputs:  int NumBytesExpected,int Timeout.
// outputs: NOne
// Descr:   Checks if a message has been received
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReceiveMessage(int NumBytesExpected,int Timeout)
{
	try
	{
		volatile SerialPort^ test = comport;
        int progress = 0;
        int ComTimeout = Timeout;
        while((ComTimeout) && 
              (comport->BytesToRead < NumBytesExpected) )
        {
            Thread::Sleep(1);
            ComTimeout--;
        }

		/* if (comport->BytesToRead != NumBytesExpected)
		{
			MessageBox::Show("Failed because "+NumBytesExpected.ToString() + " bytes was expected, but"+
				" only "+comport->BytesToRead.ToString() + " was received","Error",
				MessageBoxButtons::OK,MessageBoxIcon::Information);
		}*/

		volatile int preread_bytestoread = comport->BytesToRead; 
        comport->Read(RawRXBuf,0,comport->BytesToRead);
        if ((ComTimeout == 0) && (comport->BytesToRead < NumBytesExpected)) 
		{
			volatile int bytestoread = comport->BytesToRead;
            return TSerialCommsResults::COM_TIMEOUT;
		}

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("RX: ");
			for(int i=0; i<NumBytesExpected; i++)
			{
				str->Append(RawRXBuf[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}


		S_BYTE bTemp=0;
        int  idx = 0;

		bTemp = RawRXBuf[idx++]; 
		if (bTemp != S_SYNC_BYTE) return TSerialCommsResults::COM_RX_ERR;

		RXCommsBuf->u16Len =  RawRXBuf[idx];
		bTemp = RawRXBuf[idx++];

		RXCommsBuf->u16Len |= ((S_WORD)RawRXBuf[idx]) << 8; 
		bTemp ^= RawRXBuf[idx++];
		if (RXCommsBuf->u16Len > sizeof(S_TBody)) return TSerialCommsResults::COM_RX_ERR;

		RXCommsBuf->u8Cmd = RawRXBuf[idx++];
		bTemp ^= RXCommsBuf->u8Cmd;
		if ((RXCommsBuf->u8Cmd < (S_COMMS_CMD_FIRST | S_COMMS_POS_RESP)) || 
			(RXCommsBuf->u8Cmd > (S_COMMS_CMD_LAST | S_COMMS_POS_RESP))  ||
			(RXCommsBuf->u8Cmd != (TXCommsBuf->u8Cmd | S_COMMS_POS_RESP))) return TSerialCommsResults::COM_RX_ERR;

		for (int i=0; i<RXCommsBuf->u16Len; i++)
		{
			RXCommsBuf->unBody.u8Data[i] = RawRXBuf[idx++];
			bTemp ^= RXCommsBuf->unBody.u8Data[i];
		}

		RXCommsBuf->u8Chk = RawRXBuf[idx]; idx++;
		if (bTemp != RXCommsBuf->u8Chk) return TSerialCommsResults::COM_RX_ERR;

		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot receive message.",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::ReadMemory
// Inputs:  TMemArea MemArea = type of memory to read from,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to store data
// outputs: TSerialCommsResults
// Descr:   Read memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData)
{
	return ReadMemory(MemArea,StartAddr,len,bData,nullptr);
}

///<summary>
// ****************************************************************************
// Method:  TSerialCommsResults::CloseComm
// Inputs:  TMemArea MemArea = type of memory to read from,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to store data, Control = forms control to report progress
// outputs: NOne
// Descr:   Closes the com port
// ****************************************************************************
///</summary>
TSerialCommsResults TGeneralSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress)
{
    try
	{
		int  ptr     = 0;
		int  reqlen  = 0;
        bool failed  = false;

		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}

		while(ptr < len)
		{
			switch (MemArea)
			{
				case TMemArea::xdata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_CODE;       break;
				case TMemArea::status:       TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_DEBUG_TXT;  break;
				default: failed = true; break;
			}
			
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->unBody.ReadMemReq.u32Addr = ptr+StartAddr;

			if ((len - ptr) < S_COMMS_MAX_READ_LEN)	
				reqlen = len-ptr;
			else
				reqlen = S_COMMS_MAX_READ_LEN;

			TXCommsBuf->unBody.ReadMemReq.u32Len = (S_u32)reqlen;

			TXCommsBuf->u16Len = sizeof(TXCommsBuf->unBody.ReadMemReq);
			StatusCode      = SendMessage(S_GENCOMMS_OVERHEAD_BYTES+reqlen,ReadTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}

			for(int i=0; i<reqlen; i++)
			{
				bData[ptr + i] = RXCommsBuf->unBody.ReadMemResp.u8Data[i];
			}

			ptr += reqlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}

		}

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot do Readmemory. ",e);
	}
}

// ****************************************************************************
// Method:  TGeneralSerialComms::TGeneralSerialComms
// Inputs:  None
// outputs: NOne
// Descr:   Constructor
// ****************************************************************************
TGeneralSerialComms::TGeneralSerialComms()
{
	TXCommsBuf =  new S_TCommsBuf;
	RXCommsBuf =  new S_TCommsBuf;

    RawRXBuf = gcnew array<S_BYTE>(sizeof(S_TCommsBuf) + 10);
    RawTXBuf = gcnew array<S_BYTE>(sizeof(S_TCommsBuf) + 10);
}

// ****************************************************************************
// Method:  TGeneralSerialComms::~TGeneralSerialComms
// Inputs:  None
// outputs: NOne
// Descr:   Destructor
// ****************************************************************************
TGeneralSerialComms::~TGeneralSerialComms()
{
	//delete TXCommsBuf;
	//delete RXCommsBuf;
}

// ****************************************************************************
// Method:  TSerialCommsResults::ReadMemory
// Inputs:  TMemArea MemArea = type of memory to read from,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to store data
// outputs: NOne
// Descr:   readmemory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData)
{
	return ReadMemory(MemArea,StartAddr,len,bData,nullptr,0);
}

// ****************************************************************************
// Method:  TSerialCommsResults::ReadMemory
// Inputs:  TMemArea MemArea = type of memory to read from,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to store data
// outputs: NOne
// Descr:   readmemory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs)
{
	return ReadMemory(MemArea,StartAddr,len,bData,nullptr,arrayofs);
}

// ****************************************************************************
// Method:  TSerialCommsResults::CloseComm
// Inputs:  TMemArea MemArea = type of memory to read from,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to store data, Control = forms control to report progress
// outputs: NOne
// Descr:   Closes the com port
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress)
{
	return ReadMemory(MemArea,StartAddr,len,bData,progress,0);
}

// ****************************************************************************
// Method:  TSerialCommsResults::CloseComm
// Inputs:  TMemArea MemArea = type of memory to read from,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to store data, Control = forms control to report progress
// outputs: NOne
// Descr:   Closes the com port
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs)
{
    try
	{
		int  ptr     = 0;
		int  reqlen  = 0;
        bool failed  = false;

		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}

		while(ptr < len)
		{
			switch (MemArea)
			{
				case TMemArea::xdata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_CODE;       break;
				case TMemArea::status:       TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->u8Cmd = S_COMMS_CMD_READ_DEBUG_TXT;  break;

				default: failed = true; break;
			}
			
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->unBody.ReadMemReq.u32Addr = ptr+StartAddr;

			if ((len - ptr) < S_COMMS_MAX_READ_LEN)	
				reqlen = len-ptr;
			else
				reqlen = S_COMMS_MAX_READ_LEN;

			TXCommsBuf->unBody.ReadMemReq.u32Len = (S_u32)reqlen;

			TXCommsBuf->u16Len = sizeof(TXCommsBuf->unBody.ReadMemReq);
			StatusCode      = SendMessage(S_GENCOMMS_OVERHEAD_BYTES+reqlen,ReadTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}

			for(int i=0; i<reqlen; i++)
			{
				bData[arrayofs + ptr + i] = RXCommsBuf->unBody.ReadMemResp.u8Data[i];
			}

			ptr += reqlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}
		}

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot do Readmemory. ",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::WriteMemory
// Inputs:  TMemArea MemArea = type of memory to write to,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to get data, Control = forms control to report progress
// outputs: TSerialCommsResults
// Descr:   Write to memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData)
{
	return WriteMemory(MemArea,StartAddr,len,bData,nullptr);
}


// ****************************************************************************
// Method:  TSerialCommsResults::WriteMemory
// Inputs:  TMemArea MemArea = type of memory to write to,
//          int StartAddr = address where to start, 
//          int len = number of bytes, 
//          array<S_BYTE>^ bData = array where to get data, Control = forms control to report progress
// outputs: TSerialCommsResults
// Descr:   Write to memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress)
{
	try
	{
		int  ptr    = 0;
		int  reqlen = 0;
        bool failed = false;
		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}
		while(ptr < len)
		{
			switch (MemArea)
			{
				case TMemArea::xdata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_CODE;       break;
				case TMemArea::status:       TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_DEBUG_TXT;  break;

				default: failed = true; break;
			}
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->unBody.WriteMemReq.u32Addr = StartAddr + ptr;

			if ((len - ptr) < S_COMMS_MAX_WRITE_LEN)	
				reqlen = len-ptr;
			else
				reqlen = S_COMMS_MAX_WRITE_LEN;

			TXCommsBuf->unBody.WriteMemReq.u32Len = reqlen;
			TXCommsBuf->u16Len                    = sizeof(TXCommsBuf->unBody.ReadMemReq) + (S_WORD)reqlen;
			for(int i=0; i<reqlen; i++)
			{
				TXCommsBuf->unBody.WriteMemReq.u8Data[i] = bData[ptr + i];
			}

			StatusCode      = SendMessage(S_GENCOMMS_OVERHEAD_BYTES,WriteTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}
			ptr += reqlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}
		}

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot do Writememory. ",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData
// outputs: NOne
// Descr:   Write memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData)
{
	return WriteMemory(MemArea,StartAddr,len,bData,nullptr,0);
}

// ****************************************************************************
// Method:  TSerialCommsResults::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData
// outputs: NOne
// Descr:   Write memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs)
{
	return WriteMemory(MemArea,StartAddr,len,bData,nullptr,arrayofs);
}

// ****************************************************************************
// Method:  TSerialCommsResults::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData
// outputs: NOne
// Descr:   Write memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress)
{
	return WriteMemory(MemArea,StartAddr,len,bData,progress,0);
}

// ****************************************************************************
// Method:  TSerialCommsResults::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData
// outputs: NOne
// Descr:   Write memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs)
{
	try
	{
		int  ptr    = 0;
		int  reqlen = 0;
        bool failed = false;
		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}
		while(ptr < len)
		{
			switch (MemArea)
			{
				case TMemArea::xdata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_CODE;       break;
				case TMemArea::status:       TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->u8Cmd = S_COMMS_CMD_WRITE_DEBUG_TXT;  break;

				default: failed = true; break;
			}
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->unBody.WriteMemReq.u32Addr = StartAddr + ptr;

			if ((len - ptr) < S_COMMS_MAX_WRITE_LEN)	
				reqlen = len-ptr;
			else
				reqlen = S_COMMS_MAX_WRITE_LEN;

			TXCommsBuf->unBody.WriteMemReq.u32Len = reqlen;
			TXCommsBuf->u16Len                    = sizeof(TXCommsBuf->unBody.ReadMemReq) + (S_WORD)reqlen;
			for(int i=0; i<reqlen; i++)
			{
				TXCommsBuf->unBody.WriteMemReq.u8Data[i] = bData[arrayofs + ptr + i];
			}

			StatusCode      = SendMessage(S_GENCOMMS_OVERHEAD_BYTES,WriteTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}
			ptr += reqlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}
		}

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot do Writememory. ",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::EraseFlash
// Inputs:  TMemArea MemArea, int address
// outputs: Statuscode (TSerialCommsResults)
// Descr:   Erase device memory
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::EraseFlash(TMemArea MemArea, int address)
{
	try
	{
		bool failed = false;

		switch (MemArea)
		{
			case TMemArea::eeprom:       TXCommsBuf->u8Cmd = S_COMMS_CMD_ERASE_EEPROM;     break;
			case TMemArea::flash:        TXCommsBuf->u8Cmd = S_COMMS_CMD_ERASE_FLASH;      break;
			case TMemArea::epcs:         TXCommsBuf->u8Cmd = S_COMMS_CMD_ERASE_EPCS;       break;
			case TMemArea::logmem:       TXCommsBuf->u8Cmd = S_COMMS_CMD_ERASE_LOGS;       break;

			default: failed = true; break;
		}
        if (failed == true) return TSerialCommsResults::COM_INV_MEM;

		TXCommsBuf->unBody.EraseMemoryRequest.u32Addr = address;
		TXCommsBuf->u16Len = sizeof(TXCommsBuf->unBody.EraseMemoryRequest);

		return SendMessage(S_GENCOMMS_OVERHEAD_BYTES,EraseTimeout);
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot erase FLASH memory. ",e);
	}
}

// ****************************************************************************
// Method:  TGeneralSerialComms::SetAutoComms
// Inputs:  int millisecs - time for the test
//          S_u8 ID - ID of autodata to send
// Outputs: None
// Descr:   Start sending automatic data (by ID) for millisecs duration
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::SetAutoComms(int millisecs, S_u8 ID)
{
	try
	{
		TXCommsBuf->u8Cmd = S_COMMS_CMD_AUTO_STAT1;

		// LATER: setting, because some gyros can work in 500Hz, others in 1Khz
		//       This should actually be fixed in the application code. Leave for the future when
		//       the Gyro code will be updated
		TXCommsBuf->unBody.RequestAutoMode1.u32Count = millisecs/2; 
		TXCommsBuf->unBody.RequestAutoMode1.u32Mode  = (S_u32)ID;
		TXCommsBuf->u16Len = sizeof(TXCommsBuf->unBody.RequestAutoMode1);

		return SendMessage(S_GENCOMMS_OVERHEAD_BYTES,EraseTimeout);
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot set auto comms",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::CloseComm
// Inputs:  None (no parameter means resetmode zero - implicitly)
// outputs: NOne
// Descr:   Closes the com port
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::Reset(void)
{
	try
	{
		TXCommsBuf->u8Cmd = S_COMMS_CMD_RESET;

		TXCommsBuf->u16Len = 1;
		TXCommsBuf->unBody.ResetReq.u8ResetMode = 0;

		return SendMessage(S_GENCOMMS_OVERHEAD_BYTES,ReadTimeout);
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot Reset device",e);
	}
}
    
// ****************************************************************************
// Method:  TSerialCommsResults::Ping
// Inputs:  None
// outputs: NOne
// Descr:   Simple ping command
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::Ping(void)
{
	try
	{
		TXCommsBuf->u8Cmd = S_COMMS_CMD_PING;

		TXCommsBuf->u16Len = 0;

		return SendMessage(S_GENCOMMS_OVERHEAD_BYTES,ReadTimeout);
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot ping device",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::EnterBootloader
// Inputs:  None
// outputs: NOne
// Descr:   Enter into the bootloader mode
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::EnterBootloader(void)
{
	try
	{
		TXCommsBuf->u8Cmd = S_COMMS_CMD_BOOTLOAD_ENTER;

		TXCommsBuf->u16Len = 0;

		return SendMessage(S_GENCOMMS_OVERHEAD_BYTES,ReadTimeout);
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot Enter bootloader",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::GetDebugText
// Inputs:  None
// outputs: NOne
// Descr:   Get Debug text from the device buffer
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::GetDebugText(S_u8* Buf)
{
	try
	{
		TXCommsBuf->u8Cmd = S_COMMS_CMD_DEBUG_GETS;

		TXCommsBuf->u16Len = 0;
		TSerialCommsResults x = SendMessage(S_GENCOMMS_OVERHEAD_BYTES+S_COMMS_MAX_READ_LEN,ReadTimeout);

		if (x == TSerialCommsResults::COM_SUCCESS)
		{
			for(int i=0; i<S_COMMS_MAX_READ_LEN; i++)
			{
				Buf[i] = RXCommsBuf->unBody.GetsDebugResponse.u8Data[i];
			}
		}

		return x;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot do gets from debug buffer",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::GetKeys
// Inputs:  None
// outputs: NOne
// Descr:   Get Keys from device keyboard
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::GetKeys(int& numkeys, S_u8* Buf)
{
	try
	{
		TXCommsBuf->u8Cmd = S_COMMS_CMD_GET_KEYBOARD;

		TXCommsBuf->u16Len = 0;
		TSerialCommsResults x = SendMessage(S_GENCOMMS_OVERHEAD_BYTES+S_COMMS_MAX_NUM_KEYS,ReadTimeout);

		if (x == TSerialCommsResults::COM_SUCCESS)
		{
			numkeys = (int)RXCommsBuf->unBody.GetkeyboardBuffer.u8NumKeys;

			memset(Buf,0,S_COMMS_MAX_NUM_KEYS);
			for(int i=0; i<RXCommsBuf->unBody.GetkeyboardBuffer.u8NumKeys; i++)
			{
				Buf[i] = RXCommsBuf->unBody.GetkeyboardBuffer.u8Data[i];
			}
		}

		return x;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot get keys from keyboard buffer",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::SetTimeToNow
// Inputs:  None
// outputs: None
// Descr:   Set the time to now (not implemented)
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::AutoGetLastFPS(int offset, int size, S_u8* Buf)
{
	try
	{
		TSerialCommsResults StatusCode;

		TXCommsBuf->u8Cmd = S_COMMS_CMD_AUTOTX_LASTFPS;
        TXCommsBuf->unBody.ReadMemReq.u32Addr = offset;
		TXCommsBuf->unBody.ReadMemReq.u32Len = size;
	    TXCommsBuf->u16Len = sizeof(TXCommsBuf->unBody.ReadMemReq);

		StatusCode      = AutoGetData(size,Buf,5000); // TODO: get better timeout calcs here

		return StatusCode;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Unable to get last FPS",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::SetTimeToNow
// Inputs:  None
// outputs: None
// Descr:   Set the time to now (not implemented)
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::AutoGetLastFPS(int offset, int size, array<S_u8>^ Buf)
{
	try
	{
		TSerialCommsResults StatusCode;

		TXCommsBuf->u8Cmd = S_COMMS_CMD_AUTOTX_LASTFPS;
		TXCommsBuf->unBody.AutoReadMemReq.u32Addr = offset;
		TXCommsBuf->unBody.AutoReadMemReq.u32Len = size;
	    TXCommsBuf->u16Len = sizeof(TXCommsBuf->unBody.ReadMemReq);

		StatusCode      = AutoGetData(size,Buf,5000); // TODO: get better timeout calcs here

		return StatusCode;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Unable to get last FPS",e);
	}
}

// ****************************************************************************
// Method:  TSerialCommsResults::SetTimeToNow
// Inputs:  None
// outputs: NOne
// Descr:   Set the time to now (not implemented)
// ****************************************************************************
TSerialCommsResults TGeneralSerialComms::SetTimeToNow(void)
{
	throw gcnew NeoException("TGeneralSerialComms::SetTimeToNow not implemented");
}

// ****************************************************************************
// Method:  TPICSerialComms::TPICSerialComms
// Inputs:  None
// outputs: NOne
// Descr:   PIC serial comms constructor
// ****************************************************************************
TPICSerialComms::TPICSerialComms()
{
	TXCommsBuf =  new S_TPICCommsBuf;
	RXCommsBuf =  new S_TPICCommsBuf;

    RawRXBuf = gcnew array<S_BYTE>(sizeof(S_TPICCommsBuf) + 10);
    RawTXBuf = gcnew array<S_BYTE>(sizeof(S_TPICCommsBuf) + 10);
}

// ****************************************************************************
// Method:  TPICSerialComms::TPICSerialComms
// Inputs:  None
// outputs: NOne
// Descr:   PIC serial comms destructor
// ****************************************************************************
TPICSerialComms::~TPICSerialComms()
{
}

// ****************************************************************************
// Method:  TPICSerialComms::ReadMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, S_BYTE *bData
// outputs: TSerialCommsResults
// Descr:   ReadMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress)
{
	try
	{
		int  ptr     = 0;
		int  reqlen  = 0;
        bool failed  = false;

		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}

		while(ptr < len)
		{
			switch (MemArea)
			{
			    case TMemArea::xdata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_CODE;       break;
				case TMemArea::status:       TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_DEBUG_TXT;  break;
				default: failed = true; break;
			}
			
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->M.B.ReadDataReq.u16Addr = (S_u16)(ptr+StartAddr);

			if ((len - ptr) < S_PIC_COMMS_MAX_DATA)	
				reqlen = len-ptr;
			else
				reqlen = S_PIC_COMMS_MAX_DATA;

			TXCommsBuf->M.B.ReadDataReq.u8Len = (S_u8)reqlen;

			TXCommsBuf->u8Len = 2 + sizeof(TXCommsBuf->M.B.ReadDataReq);
			StatusCode      = SendMessage(S_PICCOMMS_OVERHEAD_BYTES+reqlen,ReadTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}

			for(int i=0; i<reqlen; i++)
			{
				bData[ptr + i] = RXCommsBuf->M.B.ReadDataResp.u8Data[i];
			}

			ptr += reqlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}
		}

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;		
	}
	catch(Exception^ ex)
	{
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::ReadMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData
// outputs: TSerialCommsResults
// Descr:   ReadMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress)
{
	try
	{
		int  ptr     = 0;
		int  reqlen  = 0;
        bool failed  = false;

		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}

		while(ptr < len)
		{
			switch (MemArea)
			{
			    case TMemArea::xdata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_CODE;       break;
				case TMemArea::status:       TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->M.u8Command = S_COMMS_CMD_READ_DEBUG_TXT;  break;
				default: failed = true; break;
			}
			
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->M.B.ReadDataReq.u16Addr = (S_u16)(ptr+StartAddr);

			if ((len - ptr) < S_PIC_COMMS_MAX_DATA)	
				reqlen = len-ptr;
			else
				reqlen = S_PIC_COMMS_MAX_DATA;

			TXCommsBuf->M.B.ReadDataReq.u8Len = (S_u8)reqlen;

			TXCommsBuf->u8Len = 2 + sizeof(TXCommsBuf->M.B.ReadDataReq);
			StatusCode      = SendMessage(S_PICCOMMS_OVERHEAD_BYTES+reqlen,ReadTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}

			for(int i=0; i<reqlen; i++)
			{
				bData[ptr + i] = RXCommsBuf->M.B.ReadDataResp.u8Data[i];
			}

			ptr += reqlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}
		}

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;		
	}
	catch(Exception^ ex)
	{
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::ReadMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs
// outputs: TSerialCommsResults
// Descr:   ReadMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::ReadMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress
// outputs: TSerialCommsResults
// Descr:   ReadMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData)
{
	try
	{
		return ReadMemory(MemArea,StartAddr,len,bData,nullptr);
	}
	catch(Exception^ ex)
	{
		throw ex;
	}

}

// ****************************************************************************
// Method:  TPICSerialComms::ReadMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress
// outputs: TSerialCommsResults
// Descr:   ReadMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData)
{
	try
	{
		return ReadMemory(MemArea,StartAddr,len,bData);
	}
	catch(Exception^ ex)
	{
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::ReadMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs
// outputs: TSerialCommsResults
// Descr:   ReadMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, S_BYTE *bData
// outputs: TSerialCommsResults
// Descr:   WriteMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress)
{

	try
	{
		int  ptr     = 0;
		int  wrlen  = 0;
        bool failed  = false;

		TSerialCommsResults StatusCode;

		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr);
			Application::DoEvents();
		}

		while(ptr < len)
		{
			switch (MemArea)
			{
			    case TMemArea::xdata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_XDATA;      break;
				case TMemArea::idata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_IDATA;      break;
				case TMemArea::ddata:        TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_DDATA;      break;
				case TMemArea::code:         TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_CODE;       break;
				case TMemArea::status:       TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_STAT;       break;
				case TMemArea::eeprom:       TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_EEPROM;     break;
				case TMemArea::flash:        TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_FLASH;      break;
				case TMemArea::ram:          TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_RAM;        break;
				case TMemArea::epcs:         TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_EPCS;       break;
				case TMemArea::logmem:       TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_LOGS;       break;
				case TMemArea::lastfps:      TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_LAST_FPS;   break;
				case TMemArea::debugtxt:     TXCommsBuf->M.u8Command = S_COMMS_CMD_WRITE_DEBUG_TXT;  break;
				default: failed = true; break;
			}
			
            if (failed == true) return TSerialCommsResults::COM_INV_MEM;

			TXCommsBuf->M.B.WriteDataReq.u16Addr = (S_u16)(ptr+StartAddr);

			if ((len - ptr) < S_PIC_COMMS_MAX_DATA)	
				wrlen = len-ptr;
			else
				wrlen = S_PIC_COMMS_MAX_DATA;

			for(int j=0; j<wrlen; j++)
			{
				TXCommsBuf->M.B.WriteDataReq.u8Data[j] = bData[ptr+j];
			}
			
			TXCommsBuf->u8Len = 2 + sizeof(TXCommsBuf->M.B.WriteDataReq.u16Addr) + wrlen;
			StatusCode      = SendMessage(S_PICCOMMS_OVERHEAD_BYTES+wrlen+2,ReadTimeout);

			if (StatusCode != TSerialCommsResults::COM_SUCCESS)
			{
				return StatusCode;
			}

			ptr += wrlen;
			if (progress != nullptr)
			{
				Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr + ptr);
				Application::DoEvents();
			}
		}
		if (progress != nullptr)
		{
			Instrumentation::ShowProgress(progress,StartAddr,StartAddr+len,StartAddr+len);
			Application::DoEvents();
		}
		return TSerialCommsResults::COM_SUCCESS;		
		
	}
	catch(Exception^ ex)
	{
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData
// outputs: TSerialCommsResults
// Descr:   WriteMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arraysofs
// outputs: TSerialCommsResults
// Descr:   WriteMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arraysofs)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress
// outputs: TSerialCommsResults
// Descr:   WriteMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData)
{
	try
	{
		return WriteMemory(MemArea,StartAddr,len,bData,nullptr);
	}
	catch(Exception^ ex)
	{
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress
// outputs: TSerialCommsResults
// Descr:   WriteMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::WriteMemory
// Inputs:  TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs
// outputs: TSerialCommsResults
// Descr:   WriteMemory
// ****************************************************************************
TSerialCommsResults TPICSerialComms::WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs)
{
	throw gcnew SerialCommsException();
}


// ****************************************************************************
// Method:  TPICSerialComms::EraseFlash
// Inputs:  TMemArea MemArea, int address
// outputs: TSerialCommsResults
// Descr:   EraseFlash
// ****************************************************************************
TSerialCommsResults TPICSerialComms::EraseFlash(TMemArea MemArea, int address)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::SetAutoComms
// Inputs:  int millisecs, S_u8 ID
// outputs: TSerialCommsResults
// Descr:   SetAutoComms
// ****************************************************************************
TSerialCommsResults TPICSerialComms::SetAutoComms(int millisecs, S_u8 ID)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::Reset
// Inputs:  None
// outputs: TSerialCommsResults
// Descr:   Reset
// ****************************************************************************
TSerialCommsResults TPICSerialComms::Reset(void)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::Ping
// Inputs:  None
// outputs: TSerialCommsResults
// Descr:   Ping
// ****************************************************************************
TSerialCommsResults TPICSerialComms::Ping(void)
{
	try
	{
		TXCommsBuf->u8Len = 2;
		TXCommsBuf->M.u8Command = S_COMMS_CMD_PING;

		return SendMessage(4,500);
	}
	catch(Exception^ ex)
	{
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::EnterBootloader
// Inputs:  None
// outputs: TSerialCommsResults
// Descr:   EnterBootloader
// ****************************************************************************
TSerialCommsResults TPICSerialComms::EnterBootloader(void)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::GetDebugText
// Inputs:  S_u8* Buf
// outputs: TSerialCommsResults
// Descr:   GetDebugText
// ****************************************************************************
TSerialCommsResults TPICSerialComms::GetDebugText(S_u8* Buf)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::GetKeys
// Inputs:  int& numkeys, S_u8* Buf
// outputs: TSerialCommsResults
// Descr:   GetKeys
// ****************************************************************************
TSerialCommsResults TPICSerialComms::GetKeys(int& numkeys, S_u8* Buf)
{
	throw gcnew SerialCommsException();
}

// ****************************************************************************
// Method:  TPICSerialComms::TransmitMessage
// Inputs:  None
// outputs: TSerialCommsResults
// Descr:   Transmit message
// ****************************************************************************
TSerialCommsResults TPICSerialComms::TransmitMessage(void)
{
	try
	{
		S_u8 Chk = 0;

		for (int j=0; j<RS485WakeupByteCount; j++)
		{
			RawTXBuf[j] = RS485WakeupByte;
		}

		RawTXBuf[RS485WakeupByte+0] = S_SYNC_BYTE;

		for(int i=0; i<(int)(TXCommsBuf->u8Len); i++)
		{
			RawTXBuf[RS485WakeupByte+1+i] = ((S_u8*)(&(TXCommsBuf->u8Len)))[i];
			Chk ^= RawTXBuf[RS485WakeupByte+1+i];
		}
		RawTXBuf[RS485WakeupByte+TXCommsBuf->u8Len+1] = Chk;

		comport->Write(RawTXBuf,0,RS485WakeupByteCount + S_PICCOMMS_OVERHEAD_BYTES + TXCommsBuf->u8Len - 2);
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot receive message.",e);
	}

}

// ****************************************************************************
// Method:  TPICSerialComms::SendIRWakeup
// Inputs:  None
// outputs: TSerialCommsResults
// Descr:   Wakeup the IR device
// ****************************************************************************
TSerialCommsResults TPICSerialComms::SendIRWakeup(void)
{
	int retry = 10;
    int baudsave    = comport->BaudRate;
	int timeoutsave = comport->ReadTimeout;

	try
	{
		comport->BaudRate = 300;

		while(retry)
		{
			array<S_u8>^ arr = gcnew array<S_u8>(2);
			arr[0] = 0;
			comport->Write(arr,0,1);

			comport->ReadTimeout = 500;
			int ret = comport->ReadByte();
			if (ret == S_IR_WAKEUP_RESPONSE)
			{
				return TSerialCommsResults::COM_SUCCESS;
			}
		}
		comport->BaudRate = baudsave;
		comport->ReadTimeout = timeoutsave;
		return TSerialCommsResults::COM_TIMEOUT;
	}
	catch(Exception^ ex)
	{
		comport->BaudRate = baudsave;
		comport->ReadTimeout = timeoutsave;
		throw ex;
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::SendMessage
// Inputs:  int NumBytesExpected, int Timeout
// outputs: TSerialCommsResults
// Descr:   SendMessage
// ****************************************************************************
TSerialCommsResults TPICSerialComms::SendMessage(int NumBytesExpected, int Timeout)
{
	try
	{
        TSerialCommsResults StatusCode = TSerialCommsResults::COM_GEN_ERR;

		if (!IRAwake && IRWakeupEnable)
		{
			if (SendIRWakeup() == TSerialCommsResults::COM_SUCCESS)
			{
				IRAwake = true;
			}
			else
			{
				return TSerialCommsResults::COM_IR_WAKEUP_ERR;
			}
		}
		for (int retry=3; (retry != 0) && (StatusCode != TSerialCommsResults::COM_SUCCESS); retry--)
		{
		    comport->DiscardInBuffer();
		    comport->DiscardOutBuffer();

			if (TransmitMessage() == TSerialCommsResults::COM_SUCCESS)
			{
				StatusCode = ReceiveMessage(NumBytesExpected,Timeout);
			}
			else
			{
				StatusCode = TSerialCommsResults::COM_TX_ERR;
			}
		}

		if (StatusCode != TSerialCommsResults::COM_SUCCESS)
		{
			IRAwake = false;
		}
		return StatusCode;
	}
	catch(Exception^ e)
	{
		IRAwake = false;
		throw gcnew NeoException("TCustomSerialComms::SendMessage - unable to transmit a message.",e);
	}
}

// ****************************************************************************
// Method:  TPICSerialComms::ReceiveMessage
// Inputs:  int NumBytesExpected, int Timeout
// outputs: TSerialCommsResults
// Descr:   ReceiveMessage
// ****************************************************************************
TSerialCommsResults TPICSerialComms::ReceiveMessage(int NumBytesExpected,int Timeout)
{
	try
	{
		volatile SerialPort^ test = comport;
        int progress = 0;
        int ComTimeout = Timeout;
        while((ComTimeout) && 
              (comport->BytesToRead < NumBytesExpected) )
        {
            Thread::Sleep(1);
            ComTimeout--;
        }

		/* if (comport->BytesToRead != NumBytesExpected)
		{
			MessageBox::Show("Failed because "+NumBytesExpected.ToString() + " bytes was expected, but"+
				" only "+comport->BytesToRead.ToString() + " was received","Error",
				MessageBoxButtons::OK,MessageBoxIcon::Information);
		}*/

		volatile int preread_bytestoread = comport->BytesToRead; 
        comport->Read(RawRXBuf,0,comport->BytesToRead);
        if ((ComTimeout == 0) && (comport->BytesToRead < NumBytesExpected)) 
		{
			volatile int bytestoread = comport->BytesToRead;
            return TSerialCommsResults::COM_TIMEOUT;
		}

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("RX: ");
			for(int i=0; i<NumBytesExpected; i++)
			{
				str->Append(RawRXBuf[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}


		S_BYTE bTemp=0;
        int  idx = 0;

		bTemp = RawRXBuf[idx++]; 
		if (bTemp != S_SYNC_BYTE) 
			return TSerialCommsResults::COM_RX_ERR;

        bTemp = RawRXBuf[idx++];
		RXCommsBuf->u8Len =  bTemp;

		//bTemp ^= RawRXBuf[idx++];
		if (RXCommsBuf->u8Len > (S_PIC_COMMS_MAX_DATA+2)) return TSerialCommsResults::COM_RX_ERR;

		RXCommsBuf->M.u8Command = RawRXBuf[idx++];
		bTemp ^= RXCommsBuf->M.u8Command;
		if ((RXCommsBuf->M.u8Command < (S_COMMS_CMD_FIRST | S_COMMS_POS_RESP)) || 
			(RXCommsBuf->M.u8Command > (S_COMMS_CMD_LAST | S_COMMS_POS_RESP))  ||
			(RXCommsBuf->M.u8Command != (TXCommsBuf->M.u8Command | S_COMMS_POS_RESP))) 
				return TSerialCommsResults::COM_RX_ERR;

		for (int i=0; i<(RXCommsBuf->u8Len - 2); i++)
		{
			RXCommsBuf->M.B.u8Data[i] = RawRXBuf[idx++];
			bTemp ^= RXCommsBuf->M.B.u8Data[i];
		}

		if (bTemp != RawRXBuf[idx]) 
			return TSerialCommsResults::COM_RX_ERR;

		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot receive message.",e);
	}

}

// ****************************************************************************
// Method:  TPICSerialComms::AutoGetLastFPS
// Inputs:  int offset, int size, S_u8* Buf
// outputs: TSerialCommsResults
// Descr:   not implemented yet
// ****************************************************************************
TSerialCommsResults TPICSerialComms::AutoGetLastFPS(int offset, int size, S_u8* Buf)
{
	throw gcnew Exception("TPICSerialComms::AutoGetLastFPS Not implemented");
}

// ****************************************************************************
// Method:  TPICSerialComms::AutoGetLastFPS
// Inputs:  int offset, int size, S_u8* Buf
// outputs: TSerialCommsResults
// Descr:   not implemented yet
// ****************************************************************************
TSerialCommsResults TPICSerialComms::AutoGetLastFPS(int offset, int size, array<S_u8>^ Buf)
{
	throw gcnew Exception("TPICSerialComms::AutoGetLastFPS Not implemented");
}

// ****************************************************************************
// Method:  TPICSerialComms::SetTimeToNow
// Inputs:  int NumBytesExpected, int Timeout
// outputs: TSerialCommsResults
// Descr:   set the tieme to now
// ****************************************************************************
TSerialCommsResults TPICSerialComms::SetTimeToNow(void)
{
	try
	{
		DateTime^ dt = DateTime::Now;

		TXCommsBuf->u8Len = 2 + sizeof(S_TPICSetTime);
		TXCommsBuf->M.u8Command = S_COMMS_CMD_SET_TIME;
		TXCommsBuf->M.B.SetTime.u16Year   = (S_u16)dt->Year;
		TXCommsBuf->M.B.SetTime.u8Month   = (S_u8)dt->Month;
		TXCommsBuf->M.B.SetTime.u8Day     = (S_u8)dt->Day;
		TXCommsBuf->M.B.SetTime.u8Hour    = (S_u8)dt->Hour;
		TXCommsBuf->M.B.SetTime.u8Minutes = (S_u8)dt->Minute;
		TXCommsBuf->M.B.SetTime.u8Seconds = (S_u8)dt->Second;

		return SendMessage(4,500);		
	}
	catch(...)
	{
		throw gcnew SerialCommsException("Cannot set the time!");
	}
}

// ****************************************************************************
// Method:  TGeneralPICUSBComms::TGeneralPICUSBComms
// Inputs:  void
// outputs: None
// Descr:   TGeneralPICUSBComms transmit 
// ****************************************************************************
TSerialCommsResults TGeneralPICUSBComms::TransmitMessage(void)
{
	unsigned char buf[64];

	static S_u8 test = 0;
	try
	{		
		TXCommsBuf->u8Chk =	0;
		TXCommsBuf->u8Chk ^=	S_HI(TXCommsBuf->u16Len);
		TXCommsBuf->u8Chk ^=	S_LO(TXCommsBuf->u16Len);
		TXCommsBuf->u8Chk ^=	TXCommsBuf->u8Cmd;

		for (int i=0; i<TXCommsBuf->u16Len; i++)
		{
			TXCommsBuf->u8Chk ^= TXCommsBuf->unBody.u8Data[i];
		}

		buf[0] = S_LO(TXCommsBuf->u16Len);
		buf[1] = S_HI(TXCommsBuf->u16Len);
		buf[2] = TXCommsBuf->u8Cmd;
		for(int i=0; i<TXCommsBuf->u16Len; i++)
		{
			buf[3+i] = TXCommsBuf->unBody.u8Data[i];
		}
		buf[4+TXCommsBuf->u16Len] = TXCommsBuf->u8Chk;

		//for (int i=0; i<100; i++) RawTXBuf[i] = 0x55;
		//comport->Write(RawTXBuf,0,100);

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("TX: ");
			for(int i=0; i<(S_GENCOMMS_OVERHEAD_BYTES + TXCommsBuf->u16Len); i++)
			{
				str->Append(buf[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}
		MCHPHIDClass::USBHIDWriteReport (buf, S_GENCOMMS_OVERHEAD_BYTES + TXCommsBuf->u16Len);
		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot Transmit message. ",e);
	}
}

// ****************************************************************************
// Method:  TGeneralPICUSBComms::TGeneralPICUSBComms
// Inputs:  void
// outputs: None
// Descr:   TGeneralPICUSBComms sendmessage
// ****************************************************************************
TSerialCommsResults TGeneralPICUSBComms::SendMessage(int NumBytesExpected, int Timeout)
{
	try
	{
        TSerialCommsResults StatusCode = TSerialCommsResults::COM_GEN_ERR;

		for (int retry=3; (retry != 0) && (StatusCode != TSerialCommsResults::COM_SUCCESS); retry--)
		{
			if (TransmitMessage() == TSerialCommsResults::COM_SUCCESS)
			{
				StatusCode = ReceiveMessage(NumBytesExpected,Timeout);
			}
			else
			{
				StatusCode = TSerialCommsResults::COM_TX_ERR;
			}
		}

		return StatusCode;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("TCustomSerialComms::SendMessage - unable to transmit a message.",e);
	}
}

// ****************************************************************************
// Method:  TGeneralPICUSBComms::TGeneralPICUSBComms
// Inputs:  void
// outputs: None
// Descr:   TGeneralPICUSBComms receive message
// ****************************************************************************
TSerialCommsResults TGeneralPICUSBComms::ReceiveMessage(int NumBytesExpected,int Timeout)
{
	unsigned char InputPacketBuffer[64];

	try
	{
		MCHPHIDClass::USBHIDReadReport (InputPacketBuffer);

		if (DebugTextBox != nullptr)
		{
			StringBuilder^ str = gcnew StringBuilder(1024);
			
			str->Append("RX: ");
			for(int i=0; i<NumBytesExpected; i++)
			{
				str->Append(InputPacketBuffer[i].ToString("X2") + " ");
			}
			str->Append(Environment::NewLine);
			DebugTextBox->AppendText(str->ToString());
		}


		S_BYTE bTemp=0;
        int  idx = 0;

		RXCommsBuf->u16Len =  InputPacketBuffer[idx];
		bTemp = RawRXBuf[idx++];

		RXCommsBuf->u16Len |= ((S_WORD)InputPacketBuffer[idx]) << 8; 
		bTemp ^= RawRXBuf[idx++];
		if (RXCommsBuf->u16Len > sizeof(S_TBody)) return TSerialCommsResults::COM_RX_ERR;

		RXCommsBuf->u8Cmd = InputPacketBuffer[idx++];
		bTemp ^= RXCommsBuf->u8Cmd;
		if ((RXCommsBuf->u8Cmd < (S_COMMS_CMD_FIRST | S_COMMS_POS_RESP)) || 
			(RXCommsBuf->u8Cmd > (S_COMMS_CMD_LAST | S_COMMS_POS_RESP))  ||
			(RXCommsBuf->u8Cmd != (TXCommsBuf->u8Cmd | S_COMMS_POS_RESP))) return TSerialCommsResults::COM_RX_ERR;

		for (int i=0; i<RXCommsBuf->u16Len; i++)
		{
			RXCommsBuf->unBody.u8Data[i] = InputPacketBuffer[idx++];
			bTemp ^= RXCommsBuf->unBody.u8Data[i];
		}

		RXCommsBuf->u8Chk = InputPacketBuffer[idx]; idx++;
		if (bTemp != RXCommsBuf->u8Chk) return TSerialCommsResults::COM_RX_ERR;

		return TSerialCommsResults::COM_SUCCESS;
	}
	catch(Exception^ e)
	{
		throw gcnew NeoException("Cannot receive message.",e);
	}

}

// ****************************************************************************
// Method:  TSimplePICUSBComms::TSimplePICUSBComms
// Inputs:  void
// outputs: None
// Descr:   TSimplePICUSBComms constructor
// ****************************************************************************
TGeneralPICUSBComms::TGeneralPICUSBComms(void)
{
	MCHPHIDClass::USBHIDClassInit(0x4D8, 0x003F, 64);
}

// ****************************************************************************
// Method:  TSimplePICUSBComms::~TSimplePICUSBComms
// Inputs:  void
// outputs: None
// Descr:   TSimplePICUSBComms destructor
// ****************************************************************************
TGeneralPICUSBComms::~TGeneralPICUSBComms(void)
{
	// 
}

} // end namespace Serial
} // end namespace Comms
} // end namespace CPP
} // end namespace Sema