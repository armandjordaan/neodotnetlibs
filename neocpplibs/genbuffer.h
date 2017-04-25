#ifndef GENBUFFER_H_INCLUDED
#define GENBUFFER_H_INCLUDED

#include "typedef.h"

// IMPORTANT NOTE: only use bufsize for values that are a power of 2
#define DECLARE_CIRCBUF(name,bufsize) typedef struct {\
    S_u16 u16Head;\
    S_u16 u16Tail;\
    S_u8  u8Buf[bufsize];\
} T##name;\
T##name name;

#define GENCIRCBUF_Put(name,bufsize,value) if ((##name##.u16Head+1)&(bufsize-1)  != ##name##.u16Tail) \
{\
    ##name##.u8Buf[##name##.u16Head] = value; \
    ##name##.u16Head = (##name##.u16Head + 1)&(bufsize-1);\
}
#define GENCIRCBUF_Get(name,bufsize,value) if (##name##.u16Tail  != ##name##.u16Head) \
{\
    ##name##.u8Buf[##name##.u16Tail] = value; \
    ##name##.u16Tail = (##name##.u16Tail + 1)&(bufsize-1);\
}
#define GENCIRCBUF_Clear(name) name##.u16Tail = ##name##.u16Head = 0
#define GENCIRCBUF_IsEmpty(name) name##.u16Head == ##name##.u16Tail


#endif // GENBUFFER_H_INCLUDED
