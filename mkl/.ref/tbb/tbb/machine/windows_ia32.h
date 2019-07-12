/*
    Copyright 2005-2019 Intel Corporation.

    This software and the related documents are Intel copyrighted materials, and your
    use of them is governed by the express license under which they were provided to
    you ("License"). Unless the License provides otherwise, you may not use, modify,
    copy, publish, distribute, disclose or transmit this software or the related
    documents without Intel's prior written permission.

    This software and the related documents are provided as is, with no express or
    implied warranties, other than those that are expressly stated in the License.



*/

#if !defined(__TBB_machine_H) || defined(__TBB_machine_windows_ia32_H)
#error Do not #include this internal file directly; use public TBB headers instead.
#endif

#define __TBB_machine_windows_ia32_H

#if defined(_MSC_VER) && !defined(__INTEL_COMPILER)
    // Workaround for overzealous compiler warnings in /Wp64 mode
    #pragma warning (push)
    #pragma warning (disable: 4244 4267)
#endif

#include "msvc_ia32_common.h"

#define __TBB_WORDSIZE 4
#define __TBB_ENDIANNESS __TBB_ENDIAN_LITTLE

extern "C" {
    __int64 __TBB_EXPORTED_FUNC __TBB_machine_cmpswp8 (volatile void *ptr, __int64 value, __int64 comparand );
    __int64 __TBB_EXPORTED_FUNC __TBB_machine_fetchadd8 (volatile void *ptr, __int64 addend );
    __int64 __TBB_EXPORTED_FUNC __TBB_machine_fetchstore8 (volatile void *ptr, __int64 value );
    void __TBB_EXPORTED_FUNC __TBB_machine_store8 (volatile void *ptr, __int64 value );
    __int64 __TBB_EXPORTED_FUNC __TBB_machine_load8 (const volatile void *ptr);
}

#if !__TBB_MSVC_PART_WORD_INTERLOCKED_INTRINSICS_PRESENT

#define __TBB_MACHINE_DEFINE_ATOMICS(S,T,U,A,C) \
static inline T __TBB_machine_cmpswp##S ( volatile void * ptr, U value, U comparand ) { \
    T result; \
    volatile T *p = (T *)ptr; \
    __asm \
    { \
       __asm mov edx, p \
       __asm mov C , value \
       __asm mov A , comparand \
       __asm lock cmpxchg [edx], C \
       __asm mov result, A \
    } \
    return result; \
} \
\
static inline T __TBB_machine_fetchadd##S ( volatile void * ptr, U addend ) { \
    T result; \
    volatile T *p = (T *)ptr; \
    __asm \
    { \
        __asm mov edx, p \
        __asm mov A, addend \
        __asm lock xadd [edx], A \
        __asm mov result, A \
    } \
    return result; \
}\
\
static inline T __TBB_machine_fetchstore##S ( volatile void * ptr, U value ) { \
    T result; \
    volatile T *p = (T *)ptr; \
    __asm \
    { \
        __asm mov edx, p \
        __asm mov A, value \
        __asm lock xchg [edx], A \
        __asm mov result, A \
    } \
    return result; \
}


__TBB_MACHINE_DEFINE_ATOMICS(1, __int8, __int8, al, cl)
__TBB_MACHINE_DEFINE_ATOMICS(2, __int16, __int16, ax, cx)
__TBB_MACHINE_DEFINE_ATOMICS(4, ptrdiff_t, ptrdiff_t, eax, ecx)

#undef __TBB_MACHINE_DEFINE_ATOMICS

#endif /* __TBB_MSVC_PART_WORD_INTERLOCKED_INTRINSICS_PRESENT */

//TODO: Check if it possible and profitable for IA-32 architecture on (Linux and Windows)
//to use of 64-bit load/store via floating point registers together with full fence
//for sequentially consistent load/store, instead of CAS.
#define __TBB_USE_FETCHSTORE_AS_FULL_FENCED_STORE           1
#define __TBB_USE_GENERIC_HALF_FENCED_LOAD_STORE            1
#define __TBB_USE_GENERIC_RELAXED_LOAD_STORE                1
#define __TBB_USE_GENERIC_SEQUENTIAL_CONSISTENCY_LOAD_STORE 1


#if defined(_MSC_VER) && !defined(__INTEL_COMPILER)
    #pragma warning (pop)
#endif // warnings 4244, 4267 are back
