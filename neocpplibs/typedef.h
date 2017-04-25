// ****************************************************************************
// File: typedef.h
// purpose: Contains generic typedefs for all used CPUs and compilers
// ****************************************************************************


#ifndef TYPEDEF_DEFINED
#define TYPEDEF_DEFINED

// ****************************************************************************
#ifdef __cplusplus
	namespace neolibs {
	namespace Typedef {
#endif // __cplusplus
// ****************************************************************************

// compiler enum values
#define S_MSVCPP   (1)
#define S_GNUGCC   (2)
#define S_DSPIC30  (3)
#define S_PICC18   (4)

// **********************************************************************************
// Microsoft Visual C++ compiler
// **********************************************************************************	
#ifdef _MSC_VER

#define UNREFERENCED_PARAMETER(x) (void)(x)
#define S_COMPILER S_MSVCPP
#define S_VOID                void
typedef unsigned char       S_BYTE;
typedef signed char         S_SBYTE;
typedef unsigned short      S_WORD;
typedef short               S_INT;
typedef float               S_FLOAT;
typedef unsigned int        S_ULONG;
typedef int                 S_LONG;
typedef unsigned short int  S_UINT;
typedef S_BYTE              S_BYTEBOOL;
typedef unsigned char       S_CHAR;

typedef unsigned char       S_u8;
typedef signed char         S_s8;
typedef unsigned short      S_u16;
typedef short               S_s16;
typedef unsigned int        S_u32;
typedef int                 S_s32;
typedef unsigned long long  S_u64;
typedef long long           S_s64;
typedef S_BYTE              S_BOOL;
typedef S_BYTE              S_bool;

typedef unsigned char       S_U8;
typedef signed char         S_S8;
typedef unsigned short      S_U16;
typedef short               S_S16;
typedef unsigned int        S_U32;
typedef int                 S_S32;
typedef unsigned long long  S_U64;
typedef long long           S_S64;

typedef S_BYTE              boolean;

// **********************************************************************************
// Other types
// **********************************************************************************
typedef union  { S_WORD word; S_BYTE byte[2]; } S_WB;
typedef union  { S_ULONG ulong; S_WORD word[2]; S_BYTE byte[4]; } S_LB;
typedef union  { float f; S_u32 u; } S_float_u32;

#endif // _MSC_VER
// ****************************************************************************

// **********************************************************************************
// GNU C Compiler - (PIC24 & dsPIC30)
// **********************************************************************************
#if defined(__dsPIC30) && !defined(S_COMPILER)
#define S_COMPILER S_DSPIC30
#define S_VOID              void
typedef unsigned char       S_BYTE;
typedef signed char         S_SBYTE;
typedef unsigned short int  S_WORD;
typedef short int           S_INT;
typedef float               S_FLOAT;
typedef unsigned long int   S_ULONG;
typedef long int            S_LONG;
typedef unsigned short int  S_UINT;
typedef S_BYTE              S_BYTEBOOL;
typedef unsigned char       S_CHAR;

typedef unsigned char       S_u8;
typedef signed char         S_s8;
typedef unsigned short int  S_u16;
typedef short int           S_s16;
typedef unsigned long int   S_u32;
typedef long int            S_s32;
typedef unsigned long long  S_u64;
typedef long long int       S_s64;
typedef unsigned char       S_BOOL;
typedef unsigned char       S_bool;

typedef unsigned char       S_U8;
typedef signed char         S_S8;
typedef unsigned short int  S_U16;
typedef short int           S_S16;
typedef unsigned long int   S_U32;
typedef long int            S_S32;
typedef unsigned long long  S_U64;
typedef long long int       S_S64;

typedef S_BYTE              boolean;

// **********************************************************************************
// Other types
// **********************************************************************************
typedef union  { S_WORD word; S_BYTE byte[2]; } S_WB;
typedef union  { S_ULONG ulong; S_WORD word[2]; S_BYTE byte[4]; } S_LB;
#endif // __dsPIC30

//hoer
//hoer

// **********************************************************************************
// GNU C Compiler - (PIC18)
// **********************************************************************************
#if defined(__18CXX) && !defined(S_COMPILER)
#define S_COMPILER S_PICC18
#define S_VOID              void

typedef unsigned char       S_BYTE;
typedef signed char         S_SBYTE;
typedef unsigned short int  S_WORD;
typedef short int           S_INT;
typedef float               S_FLOAT;
typedef unsigned long int   S_ULONG;
typedef long int            S_LONG;
typedef unsigned short int  S_UINT;
typedef S_BYTE              S_BYTEBOOL;
typedef unsigned char       S_CHAR;

typedef unsigned char       S_u8;
typedef signed char         S_s8;
typedef unsigned short int  S_u16;
typedef short int           S_s16;
typedef unsigned long int   S_u32;
typedef long int            S_s32;
typedef unsigned char       S_BOOL;
typedef unsigned char       S_bool;

typedef unsigned char       S_U8;
typedef signed char         S_S8;
typedef unsigned short int  S_U16;
typedef short int           S_S16;
typedef unsigned long int   S_U32;
typedef long int            S_S32;

typedef S_BYTE              boolean;

// **********************************************************************************
// Other types
// **********************************************************************************
typedef union  { S_WORD word; S_BYTE byte[2]; } S_WB;
typedef union  { S_ULONG ulong; S_WORD word[2]; S_BYTE byte[4]; } S_LB;
#endif // __dsPIC18

// **********************************************************************************
// GNU C Compiler - (can be used with ARM, x86, NIOS)
// **********************************************************************************
#if defined(__GNUC__)  && !defined(S_COMPILER)
#define S_COMPILER S_GNUGCC
#define S_VOID                void
typedef unsigned char       S_BYTE;
typedef signed char         S_SBYTE;
typedef unsigned short      S_WORD;
typedef short               S_INT;
typedef float               S_FLOAT;
typedef unsigned int        S_ULONG;
typedef int                 S_LONG;
typedef unsigned short int  S_UINT;
typedef S_BYTE              S_BYTEBOOL;
typedef unsigned char       S_CHAR;

typedef unsigned char       S_u8;
typedef signed char         S_s8;
typedef unsigned short      S_u16;
typedef short               S_s16;
typedef unsigned int        S_u32;
typedef int                 S_s32;
typedef unsigned short long S_u24;
typedef unsigned long long  S_u64;
typedef long long           S_s64;
typedef unsigned char       S_BOOL;
typedef unsigned char       S_bool;

typedef unsigned char       S_U8;
typedef signed char         S_S8;
typedef unsigned short      S_U16;
typedef short               S_S16;
typedef unsigned short long S_U24;
typedef unsigned int        S_U32;
typedef int                 S_S32;
typedef unsigned long long  S_U64;
typedef long long           S_S64;

typedef S_BYTE              boolean;

// **********************************************************************************
// Other types
// **********************************************************************************
typedef union  { S_WORD word; S_BYTE byte[2]; } S_WB;
typedef union  { S_ULONG ulong; S_WORD word[2]; S_BYTE byte[4]; } S_LB;
#endif // __GNUC__

// **********************************************************************************
// From here on only generic defs that are common to all
// **********************************************************************************
// **********************************************************************************

#define S_HI(W)   ( (S_BYTE)((W)>>8) )
#define S_LO(W)   ( (S_BYTE)((W)) )

#define S_HIWORD(W)   ( (S_WORD)((S_ULONG)W>>16) )
#define S_LOWORD(W)   ( (S_WORD)(W) )

#define S_MAX_ULONG   (0xFFFFFFFF)
#define S_MIN_ULONG   (0x0)

#define S_BIT_0  0x0001u
#define S_BIT_1  0x0002u
#define S_BIT_2  0x0004u
#define S_BIT_3  0x0008u
#define S_BIT_4  0x0010u
#define S_BIT_5  0x0020u
#define S_BIT_6  0x0040u
#define S_BIT_7  0x0080u
#define S_BIT_8  0x0100u
#define S_BIT_9  0x0200u
#define S_BIT_10 0x0400u
#define S_BIT_11 0x0800u
#define S_BIT_12 0x1000u
#define S_BIT_13 0x2000u
#define S_BIT_14 0x4000u
#define S_BIT_15 0x8000u

#define S_BIT_16 0x00010000UL
#define S_BIT_17 0x00020000UL
#define S_BIT_18 0x00040000UL
#define S_BIT_19 0x00080000UL
#define S_BIT_20 0x00100000UL
#define S_BIT_21 0x00200000UL
#define S_BIT_22 0x00400000UL
#define S_BIT_23 0x00800000UL
#define S_BIT_24 0x01000000UL
#define S_BIT_25 0x02000000UL
#define S_BIT_26 0x04000000UL
#define S_BIT_27 0x08000000UL
#define S_BIT_28 0x10000000UL
#define S_BIT_29 0x20000000UL
#define S_BIT_30 0x40000000UL
#define S_BIT_31 0x80000000UL

#define S_SETBIT_0 0x01
#define S_SETBIT_1 0x02
#define S_SETBIT_2 0x04
#define S_SETBIT_3 0x08
#define S_SETBIT_4 0x10
#define S_SETBIT_5 0x20
#define S_SETBIT_6 0x40
#define S_SETBIT_7 0x80

#define S_CLRBIT_0  (0xFFFFu^(S_BIT_0))
#define S_CLRBIT_1  (0xFFFFu^(S_BIT_1))
#define S_CLRBIT_2  (0xFFFFu^(S_BIT_2))
#define S_CLRBIT_3  (0xFFFFu^(S_BIT_3))
#define S_CLRBIT_4  (0xFFFFu^(S_BIT_4))
#define S_CLRBIT_5  (0xFFFFu^(S_BIT_5))
#define S_CLRBIT_6  (0xFFFFu^(S_BIT_6))
#define S_CLRBIT_7  (0xFFFFu^(S_BIT_7))
#define S_CLRBIT_8  (0xFFFFu^(S_BIT_8))
#define S_CLRBIT_9  (0xFFFFu^(S_BIT_9))
#define S_CLRBIT_10 (0xFFFFu^(S_BIT_10))
#define S_CLRBIT_11 (0xFFFFu^(S_BIT_11))
#define S_CLRBIT_12 (0xFFFFu^(S_BIT_12))
#define S_CLRBIT_13 (0xFFFFu^(S_BIT_13))
#define S_CLRBIT_14 (0xFFFFu^(S_BIT_14))
#define S_CLRBIT_15 (0xFFFFu^(S_BIT_15))

#define S_ClrBit(x) (x = x & x##_CLR)
#define S_SetBit(x) (x = x | x##_SET)
#define S_ChgBit(x) (x = x ^ x##_CHG)

#ifndef S_TRUE
#define S_TRUE  1
#endif

#ifndef S_FALSE
#define S_FALSE 0
#endif

#define S_LOW   0
#define S_HIGH  -1

#define S_SIGNED_FFFF   (-1)
#define S_UNSIGNED_FFFF (0xFFFFu)

#define S_sizeoflist(x) (sizeof(x)/sizeof(x[0]))
#define S_sizeofarray(x) (sizeof(x)/sizeof(x[0])) // gives number of items in an array x

#define S_addrof(x)     ((ULONG)(&(x)))
#define S_swap(x)       ((x >> 8) | ((x & 0x00FF) << 8))

// **********************************************************************************
// Various macros
// **********************************************************************************
#define S_SwapW(x) ((HI((x))) | ((LO((x))) << 8))
#define S_SwapL(x) ((ULONG)SwapW(HIWORD((x))) | (((ULONG)SwapW(LOWORD((x)))) << 16))

#ifndef S_DEF_STRLEN
#define S_DEF_STRLEN (80)
#endif

// **********************************************************************************
// various frequently used function pointers
// **********************************************************************************
typedef void (S_TVoidFunc)(void);
typedef S_TVoidFunc* S_TVoidFuncPtr;    /* Pointer to a void function */

#ifdef __DUMP_COMPILER_TYPEDEF_INFO__
#if S_COMPILER == S_MSVCPP
#pragma message("Microsoft Visual C++ Compiler")
#elif S_COMPILER == S_DSPIC30
//#pragma message("Microchip dsPIC30/PIC24 C Compiler")
#elif S_COMPILER == S_PICC18
#pragma message("Microchip PIC18 C Compiler")
#elif S_COMPILER == S_GNUGCC
#pragma message("GNU GCC compiler")
#else
#pragma message("Unknown compiler")
#endif

#endif

// **********************************************************************************
#ifdef __cplusplus
	} // end namespace Typedef
	} // end namespace neolibs
#endif
// **********************************************************************************

#endif // TYPEDEF_DEFINED


