#ifndef PACKED_STRUCT_START_H_INCLUDED
#define PACKED_STRUCT_START_H_INCLUDED

#ifdef _MSC_VER
#pragma pack(push,1)
//#pragma pack(1)
#define PACKED_STRUCT_START typedef struct {
#define PACKED_STRUCT_END(x) } x;
#endif

#ifdef __GNUC__
#define PACKED_STRUCT_START typedef struct __attribute__ ((packed)) {
#define PACKED_STRUCT_END(x) } x;
#endif

#endif // PACKED_STRUCT_START_H_INCLUDED
