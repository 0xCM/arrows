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

// TODO: revise by comparing with mac_ppc.h

#if !defined(__TBB_machine_H) || defined(__TBB_machine_ibm_aix51_H)
#error Do not #include this internal file directly; use public TBB headers instead.
#endif

#define __TBB_machine_ibm_aix51_H

#define __TBB_WORDSIZE 8
#define __TBB_ENDIANNESS __TBB_ENDIAN_BIG // assumption based on operating system

#include <stdint.h>
#include <unistd.h>
#include <sched.h>

extern "C" {
int32_t __TBB_machine_cas_32 (volatile void* ptr, int32_t value, int32_t comparand);
int64_t __TBB_machine_cas_64 (volatile void* ptr, int64_t value, int64_t comparand);
void __TBB_machine_flush ();
void __TBB_machine_lwsync ();
void __TBB_machine_isync ();
}

// Mapping of old entry point names retained for the sake of backward binary compatibility
#define __TBB_machine_cmpswp4 __TBB_machine_cas_32
#define __TBB_machine_cmpswp8 __TBB_machine_cas_64

#define __TBB_Yield() sched_yield()

#define __TBB_USE_GENERIC_PART_WORD_CAS                     1
#define __TBB_USE_GENERIC_FETCH_ADD                         1
#define __TBB_USE_GENERIC_FETCH_STORE                       1
#define __TBB_USE_GENERIC_HALF_FENCED_LOAD_STORE            1
#define __TBB_USE_GENERIC_RELAXED_LOAD_STORE                1
#define __TBB_USE_GENERIC_SEQUENTIAL_CONSISTENCY_LOAD_STORE 1

#if __GNUC__
    #define __TBB_control_consistency_helper() __asm__ __volatile__( "isync": : :"memory")
    #define __TBB_acquire_consistency_helper() __asm__ __volatile__("lwsync": : :"memory")
    #define __TBB_release_consistency_helper() __asm__ __volatile__("lwsync": : :"memory")
    #define __TBB_full_memory_fence()          __asm__ __volatile__(  "sync": : :"memory")
#else
    // IBM C++ Compiler does not support inline assembly
    // TODO: Since XL 9.0 or earlier GCC syntax is supported. Replace with more
    //       lightweight implementation (like in mac_ppc.h)
    #define __TBB_control_consistency_helper() __TBB_machine_isync ()
    #define __TBB_acquire_consistency_helper() __TBB_machine_lwsync ()
    #define __TBB_release_consistency_helper() __TBB_machine_lwsync ()
    #define __TBB_full_memory_fence()          __TBB_machine_flush ()
#endif
