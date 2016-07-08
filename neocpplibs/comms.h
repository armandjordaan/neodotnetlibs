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

#include "typedef.h"
#include "commsdefs.h"

#pragma once

#ifndef NEO_CPP_COMMS_SERIAL_COMMS_H
#define NEO_CPP_COMMS_SERIAL_COMMS_H


namespace neolibs {
namespace CPP {
namespace Comms {
namespace Serial {


    using namespace System;
    using namespace System::IO::Ports;
    using namespace neolibs::Typedef;
	using namespace System::Windows::Forms;

    public enum class TSerialCommsResults {
		COM_SUCCESS       = 0,
		COM_TX_ERR        = 1,
		COM_RX_ERR        = 2,
		COM_GEN_ERR       = 3,
		COM_INV_MEM       = 4, // invalid memory
		COM_ERASE_BUSY    = 5,
		COM_ERASE_FAIL    = 6,
		COM_ERASE_OK      = 7,
        COM_TIMEOUT       = 8,
        COM_CANCELLED     = 9,
		COM_IR_WAKEUP_ERR = 10
    };
   
    public enum class TMemArea {
        // not all areas will always be applicable - it will depend on the derived class
        // to determine which are used
        xdata  = 0,
        idata  = 1,
        ddata  = 2,
        code   = 3,
        status = 4,
        eeprom = 5,
        flash  = 6,
        ram    = 7,
		epcs   = 8,
		logmem = 9,
		lastfps = 10, // last fingerprint image buffer
		debugtxt = 11
    };

    // ************************************************************************
	public ref class SerialCommsException : NeoException {
	public: 
		SerialCommsException(String^ msg);
		SerialCommsException(void);
	};

    // ************************************************************************
	public interface class TGeneralSerialCommsInterface {      
    
	public:
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs);

        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs);

        virtual TSerialCommsResults Reset(void);
		virtual TSerialCommsResults Ping(void);
		virtual TSerialCommsResults EnterBootloader(void);
		virtual TSerialCommsResults GetDebugText(S_u8* Buf);
		virtual TSerialCommsResults GetKeys(int& numkeys, S_u8* Buf);
		virtual TSerialCommsResults AutoGetLastFPS(int offset, int size, S_u8* Buf);

		virtual TSerialCommsResults SetTimeToNow(void);
    };

    // ************************************************************************
    public ref class TSerialCommsPrimitive {      
    private:         
		TextBox^    propDebugTextBox;
        SerialPort^ propComport;
		bool        propRS485WakeupByte;
		int         propRS485WakeupByteCount;
	    int         propReadTimeout;
		int		    propWriteTimeout;
		int		    propResetTimeout;
		int         propEraseTimeout;
		int         propSetAutoModeTimeout;
		int         propMessageRetryCount;
        bool        propIRWakeupEnable;
        bool        propIRAwake;

    public:
        TSerialCommsPrimitive();
        ~TSerialCommsPrimitive();

		property TextBox^ DebugTextBox
		{
			TextBox^ get() {return propDebugTextBox; };
			void set(TextBox^  value) {propDebugTextBox = value;};
		}

		property bool RS485WakeupByte
		{
			bool get() {return propRS485WakeupByte; };
			void set(bool value) {propRS485WakeupByte = value;};
		}

		property int RS485WakeupByteCount
		{
			int get() {return propRS485WakeupByteCount; };
			void set(int value) {propRS485WakeupByteCount = value;};
		}

		property int ReadTimeout
		{
			int get() {return propReadTimeout;};
			void set(int value) {propReadTimeout = value;};
		}

		property int WriteTimeout
		{
			int get() {return propWriteTimeout; };
			void set(int value) {propWriteTimeout = value;};
		}

		property int EraseTimeout
		{
			int get() {return propEraseTimeout; };
			void set(int value) {propEraseTimeout = value;};
		}

		property int SetAutoModeTimeout
		{
			int get() {return propSetAutoModeTimeout; };
			void set(int value) {propSetAutoModeTimeout = value;};
		}

		property int ResetTimeout
		{
			int get() {return propResetTimeout; };
			void set(int value) {propResetTimeout = value; };
		}

		property int MessageRetryCount
		{
			int get() {return propMessageRetryCount;};
			void set(int value) {propMessageRetryCount = value;};
		}
        property SerialPort^ comport
        {
            SerialPort^ get() {return propComport; };
        }

        property int Baudrate
        {
            int get() {return comport->BaudRate; };
            void set(int value);
        }

        property bool IRWakeupEnable
        {
            bool get() {return propIRWakeupEnable; };
			void set(bool value) {propIRWakeupEnable = value;};
        }

        property bool IRAwake
        {
            bool get() {return propIRAwake; };
			void set(bool value) {propIRAwake = value;};
        }
		

        virtual TSerialCommsResults OpenComm(String^ portname);
        virtual TSerialCommsResults CloseComm(void);
	};
   
    // ************************************************************************
    public ref class TGeneralSerialComms : public TSerialCommsPrimitive , public TGeneralSerialCommsInterface {
    private:
        TSerialCommsResults TransmitMessage(void);
		TSerialCommsResults SendMessage(int NumS_BYTEsExpected, int Timeout);
        TSerialCommsResults ReceiveMessage(int NumS_BYTEsExpected,int Timeout);
		TSerialCommsResults AutoGetData(int size, S_u8* Buf, int timeout);
		TSerialCommsResults AutoGetData(int NumBytesExpected, array<S_u8>^ Buf, int timeout);
		TSerialCommsResults ReceiveBlock(int NumBytesExpected,S_u8* Buf,int Timeout);
		TSerialCommsResults ReceiveBlock(int NumBytesExpected, array<S_u8>^ Buf, int Timeout);


	protected:
		S_TCommsBuf* TXCommsBuf;
		S_TCommsBuf* RXCommsBuf;
		array<S_BYTE>^ RawRXBuf;
		array<S_BYTE>^ RawTXBuf;


    public:

		TGeneralSerialComms();
		~TGeneralSerialComms();

		///<summary>
		/// ReadMemory
		///</summary>
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs);

        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arraysofs);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs);

		virtual TSerialCommsResults EraseFlash(TMemArea MemArea, int address);
		virtual TSerialCommsResults SetAutoComms(int millisecs, S_u8 ID);     // enter gyro automatic transmission mode
        virtual TSerialCommsResults Reset(void);
        virtual TSerialCommsResults Ping(void);
		virtual TSerialCommsResults EnterBootloader(void);
		virtual TSerialCommsResults GetDebugText(S_u8* Buf);
		virtual TSerialCommsResults GetKeys(int& numkeys, S_u8* Buf);
		virtual TSerialCommsResults AutoGetLastFPS(int offset, int size, S_u8* Buf);
		virtual TSerialCommsResults AutoGetLastFPS(int offset, int size, array<S_u8>^ Buf);
		virtual TSerialCommsResults SetTimeToNow(void);
    };

    // ************************************************************************
    public ref class TPICSerialComms : public TSerialCommsPrimitive , public TGeneralSerialCommsInterface {
    private:
        TSerialCommsResults TransmitMessage(void);
		TSerialCommsResults SendMessage(int NumBytesExpected, int Timeout);
        TSerialCommsResults ReceiveMessage(int NumBytesExpected,int Timeout);
		TSerialCommsResults SendIRWakeup(void);

	protected:
		S_TPICCommsBuf* TXCommsBuf;
		S_TPICCommsBuf* RXCommsBuf;
		array<S_BYTE>^ RawRXBuf;
		array<S_BYTE>^ RawTXBuf;


    public:

		TPICSerialComms();
		~TPICSerialComms();

		///<summary>
		/// ReadMemory
		///</summary>
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arrayofs);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress);
        virtual TSerialCommsResults ReadMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs);

        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, int arraysofs);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, S_BYTE *bData, Control^ progress);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress);
        virtual TSerialCommsResults WriteMemory(TMemArea MemArea, int StartAddr, int len, array<S_BYTE>^ bData, Control^ progress, int arrayofs);

		virtual TSerialCommsResults EraseFlash(TMemArea MemArea, int address);
		virtual TSerialCommsResults SetAutoComms(int millisecs, S_u8 ID);     // enter gyro automatic transmission mode
        virtual TSerialCommsResults Reset(void);
        virtual TSerialCommsResults Ping(void);
		virtual TSerialCommsResults EnterBootloader(void);
		virtual TSerialCommsResults GetDebugText(S_u8* Buf);
		virtual TSerialCommsResults GetKeys(int& numkeys, S_u8* Buf);
		virtual TSerialCommsResults AutoGetLastFPS(int offset, int size, S_u8* Buf);
		virtual TSerialCommsResults AutoGetLastFPS(int offset, int size, array<S_u8>^ Buf);

		virtual TSerialCommsResults SetTimeToNow(void);

    };

    // ************************************************************************
    public ref class TGeneralPICUSBComms : public TGeneralSerialComms {
    private:
        TSerialCommsResults TransmitMessage(void);
		TSerialCommsResults SendMessage(int NumS_BYTEsExpected, int Timeout);
        TSerialCommsResults ReceiveMessage(int NumS_BYTEsExpected,int Timeout);

    public:

		TGeneralPICUSBComms();
		~TGeneralPICUSBComms();
    };

} // end namespace Serial
} // end namespace Comms
} // end namespace CPP
} // end namespace neolibs

#endif //NEO_CPP_COMMS_SERIAL_COMMS_H


