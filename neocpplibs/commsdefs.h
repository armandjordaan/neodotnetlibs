#ifndef COMMSDEFS_H_INCLUDED
#define COMMSDEFS_H_INCLUDED

#include "typedef.h"

#ifdef __cplusplus
namespace neolibs {
namespace CPP {
namespace Comms {
namespace Serial {

	using namespace neolibs::Typedef;

#endif

#ifndef S_COMMS_MAX_DATA
#define S_COMMS_MAX_DATA (128)
#endif

#ifndef S_PIC_COMMS_MAX_DATA
#define S_PIC_COMMS_MAX_DATA (64u)
#endif

#ifndef S_COMMS_MAX_NUM_KEYS
#define S_COMMS_MAX_NUM_KEYS (10)
#endif

#define S_SYNC_BYTE          (0x55u)
#define S_IR_WAKEUP_RESPONSE (0xAAu)

#define S_COMMS_MAX_READ_LEN  (S_COMMS_MAX_DATA)
#define S_COMMS_MAX_WRITE_LEN (S_COMMS_MAX_DATA-8)

#define S_COMMS_POS_RESP (0x80)

#define S_COMMS_RESET_MODE_GENERAL (0x00)

typedef struct {
	S_u8	u8ResetMode;
} S_TResetReq;

typedef struct {
	S_u32	u32Addr;
	S_u32   u32Len;
} S_TReadMemReq;

typedef struct {
	S_u32	u32Addr;
	S_u32   u32Len;
} S_TAutoReadMemReq;

typedef struct {
	S_u8	u8Data[S_COMMS_MAX_READ_LEN];
} S_TReadMemResp;

typedef struct {
	S_u32 u32Addr;
	S_u32 u32Len;
	S_u8  u8Data[S_COMMS_MAX_WRITE_LEN];
} S_TWriteMemReq;

typedef struct {
	S_u32 u32Addr;
} S_TEraseMemoryRequest;

typedef struct {
	S_u32	u32Mode;
	S_u32 u32Count;
} S_TRequestAutoMode1;

typedef struct {
	S_u8	u8Data[S_COMMS_MAX_READ_LEN];
} S_TGetsDebugResponse;

typedef struct {
	S_u8    u8NumKeys;
	S_u8	u8Data[S_COMMS_MAX_NUM_KEYS-4];
} S_TGetkeyboardBuffer;

typedef union {
	S_TReadMemResp			ReadMemResp;
	S_TReadMemReq			ReadMemReq;
	S_TWriteMemReq			WriteMemReq;
	S_TEraseMemoryRequest	EraseMemoryRequest;
	S_TRequestAutoMode1		RequestAutoMode1;
	S_TResetReq             ResetReq;
    S_TGetsDebugResponse    GetsDebugResponse;
    S_TGetkeyboardBuffer    GetkeyboardBuffer;
	S_TAutoReadMemReq       AutoReadMemReq;

	S_u8 u8Data[S_COMMS_MAX_DATA];
} S_TBody;

#define S_GENCOMMS_OVERHEAD_BYTES (1 + 2 + 1 + 1)
#define S_PICCOMMS_OVERHEAD_BYTES (4)
typedef struct {
	S_u16   u16Len; // excludes checksum and cmd
	S_u8    u8Cmd;
	S_TBody unBody;
	S_u8    u8Chk;
} S_TCommsBuf;

typedef struct {
    S_u32 Data[3];
} S_TAutoData1;

typedef union {
    S_TAutoData1 stDat;
    S_u8         u8Buf[sizeof(S_TAutoData1)];
} S_TAutoData1Buf;

#ifdef __cplusplus
#pragma pack(push,1)
#endif

typedef struct {
	S_u16 u16Addr;
	S_u8  u8Len;
} S_TPICReadData_Req;

typedef struct {
	S_u8 u8Data[S_PIC_COMMS_MAX_DATA];
} S_TPICReadData_Resp;

typedef struct {
	S_u16 u16Addr;
	S_u8  u8Data[S_PIC_COMMS_MAX_DATA - sizeof(S_u32)];
} S_TPICWriteData_Req;

typedef struct {
	S_u32 u32Addr;
	S_u8  u8Len;
} S_TPICReadEEData_Req;

typedef struct {
	S_u8 u8Data[S_PIC_COMMS_MAX_DATA];
} S_TPICReadEEData_Resp;

typedef struct {
	S_u32 u32Addr;
	S_u8  u8Data[S_PIC_COMMS_MAX_DATA - sizeof(S_u32)];
} S_TPICWriteEEData_Req;

typedef struct {
    S_u16 u16Year;
    S_u8  u8Month;
    S_u8  u8Day;
    S_u8  u8Hour;
    S_u8  u8Minutes;
    S_u8  u8Seconds;
} S_TPICSetTime;

typedef union {
	S_u8 u8Data[S_PIC_COMMS_MAX_DATA];

	S_TPICReadData_Req    ReadDataReq;
	S_TPICReadData_Resp   ReadDataResp;

	S_TPICReadEEData_Req  ReadEEDataReq;
    S_TPICReadEEData_Resp ReadEEDataResp;

	S_TPICWriteData_Req   WriteDataReq;
	S_TPICWriteEEData_Req WriteEEDataReq;

    S_TPICSetTime         SetTime;
} S_TPICReqBody;

typedef struct {
	S_u8 u8Command;
	S_TPICReqBody B;
} S_TPICCommsBody;

typedef struct {
	S_u8 u8Len;
	S_TPICCommsBody M;
    S_u8 u8Chk; // placeholder for checksum
} S_TPICCommsBuf;
#ifdef __cplusplus
#pragma pack(pop)
#endif

#define S_COMMS_CMD_READ_XDATA      (0x01)
#define S_COMMS_CMD_WRITE_XDATA     (0x02)
#define S_COMMS_CMD_READ_IDATA      (0x03)
#define S_COMMS_CMD_WRITE_IDATA     (0x04)
#define S_COMMS_CMD_READ_DDATA      (0x05)
#define S_COMMS_CMD_WRITE_DDATA     (0x06)
#define S_COMMS_CMD_READ_CODE       (0x07)
#define S_COMMS_CMD_WRITE_CODE      (0x08)
#define S_COMMS_CMD_READ_STAT       (0x09)
#define S_COMMS_CMD_WRITE_STAT      (0x0A)
#define S_COMMS_CMD_READ_EEPROM     (0x0B)
#define S_COMMS_CMD_WRITE_EEPROM    (0x0C)
#define S_COMMS_CMD_READ_FLASH      (0x0D)
#define S_COMMS_CMD_WRITE_FLASH     (0x0E)
#define S_COMMS_CMD_READ_RAM        (0x0F)
#define S_COMMS_CMD_WRITE_RAM       (0x10)
#define S_COMMS_CMD_READ_EPCS       (0x11)
#define S_COMMS_CMD_WRITE_EPCS      (0x12)
#define S_COMMS_CMD_READ_LOGS       (0x13)
#define S_COMMS_CMD_WRITE_LOGS      (0x14)
#define S_COMMS_CMD_READ_LAST_FPS   (0x15)
#define S_COMMS_CMD_WRITE_LAST_FPS  (0x16)
#define S_COMMS_CMD_READ_DEBUG_TXT  (0x15)
#define S_COMMS_CMD_WRITE_DEBUG_TXT (0x16)
#define S_COMMS_CMD_ERASE_FLASH     (0x20)
#define S_COMMS_CMD_ERASE_EEPROM    (0x21)
#define S_COMMS_CMD_ERASE_EPCS      (0x22)
#define S_COMMS_CMD_ERASE_LOGS      (0x23)
#define S_COMMS_CMD_DEBUG_GETS      (0x24)
#define S_COMMS_CMD_GET_KEYBOARD    (0x25)
#define S_COMMS_CMD_GET_TIME        (0x26)
#define S_COMMS_CMD_SET_TIME        (0x27)
#define S_COMMS_CMD_AUTOTX_LASTFPS  (0x30)
#define S_COMMS_CMD_RESET           (0x40)
#define S_COMMS_CMD_PING            (0x41)
#define S_COMMS_CMD_BOOTLOAD_ENTER  (0x42)
#define S_COMMS_CMD_AUTO_STAT1      (0x50) // start automatic transmission of status
#define S_COMMS_CMD_FIRST           (S_COMMS_CMD_READ_XDATA)
#define S_COMMS_CMD_LAST            (S_COMMS_CMD_AUTO_STAT1)

#ifdef __cplusplus
} // end namespace Serial
} // end namespace Comms
} // end namespace CPP
} // end namespace neolibs
#endif

#endif // COMMSDEFS_H_INCLUDED
