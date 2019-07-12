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

#ifndef __TBB_machine_H
#error Do not #include this internal file directly; use public TBB headers instead.
#endif

#include <sched.h>
#define __TBB_Yield()  sched_yield()

#include <unistd.h>
/* Futex definitions */
#include <sys/syscall.h>

#if defined(SYS_futex)
/* This header file is included for Linux and some other systems that may support futexes.*/

#define __TBB_USE_FUTEX 1

#if defined(__has_include)
#define __TBB_has_include __has_include
#else
#define __TBB_has_include(x) 0
#endif

/*
If available, use typical headers where futex API is defined. While Linux and OpenBSD
are known to provide such headers, other systems might have them as well.
*/
#if defined(__linux__) || __TBB_has_include(<linux/futex.h>)
#include <linux/futex.h>
#elif defined(__OpenBSD__) || __TBB_has_include(<sys/futex.h>)
#include <sys/futex.h>
#endif

#include <limits.h>
#include <errno.h>

/*
Some systems might not define the macros or use different names. In such case we expect
the actual parameter values to match Linux: 0 for wait, 1 for wake.
*/
#if defined(FUTEX_WAIT_PRIVATE)
#define __TBB_FUTEX_WAIT FUTEX_WAIT_PRIVATE
#elif defined(FUTEX_WAIT)
#define __TBB_FUTEX_WAIT FUTEX_WAIT
#else
#define __TBB_FUTEX_WAIT 0
#endif

#if defined(FUTEX_WAKE_PRIVATE)
#define __TBB_FUTEX_WAKE FUTEX_WAKE_PRIVATE
#elif defined(FUTEX_WAKE)
#define __TBB_FUTEX_WAKE FUTEX_WAKE
#else
#define __TBB_FUTEX_WAKE 1
#endif

#ifndef __TBB_ASSERT
#error machine specific headers must be included after tbb_stddef.h
#endif

namespace tbb {

namespace internal {

inline int futex_wait( void *futex, int comparand ) {
    int r = syscall( SYS_futex,futex,__TBB_FUTEX_WAIT,comparand,NULL,NULL,0 );
#if TBB_USE_ASSERT
    int e = errno;
    __TBB_ASSERT( r==0||r==EWOULDBLOCK||(r==-1&&(e==EAGAIN||e==EINTR)), "futex_wait failed." );
#endif /* TBB_USE_ASSERT */
    return r;
}

inline int futex_wakeup_one( void *futex ) {
    int r = ::syscall( SYS_futex,futex,__TBB_FUTEX_WAKE,1,NULL,NULL,0 );
    __TBB_ASSERT( r==0||r==1, "futex_wakeup_one: more than one thread woken up?" );
    return r;
}

inline int futex_wakeup_all( void *futex ) {
    int r = ::syscall( SYS_futex,futex,__TBB_FUTEX_WAKE,INT_MAX,NULL,NULL,0 );
    __TBB_ASSERT( r>=0, "futex_wakeup_all: error in waking up threads" );
    return r;
}

} /* namespace internal */

} /* namespace tbb */

#endif /* SYS_futex */
