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

#ifndef __TBB_queuing_mutex_H
#define __TBB_queuing_mutex_H

#include <cstring>
#include "atomic.h"
#include "tbb_profiling.h"

namespace tbb {

//! Queuing mutex with local-only spinning.
/** @ingroup synchronization */
class queuing_mutex : internal::mutex_copy_deprecated_and_disabled {
public:
    //! Construct unacquired mutex.
    queuing_mutex() {
        q_tail = NULL;
#if TBB_USE_THREADING_TOOLS
        internal_construct();
#endif
    }

    //! The scoped locking pattern
    /** It helps to avoid the common problem of forgetting to release lock.
        It also nicely provides the "node" for queuing locks. */
    class scoped_lock: internal::no_copy {
        //! Initialize fields to mean "no lock held".
        void initialize() {
            mutex = NULL;
            going = 0;
#if TBB_USE_ASSERT
            internal::poison_pointer(next);
#endif /* TBB_USE_ASSERT */
        }

    public:
        //! Construct lock that has not acquired a mutex.
        /** Equivalent to zero-initialization of *this. */
        scoped_lock() {initialize();}

        //! Acquire lock on given mutex.
        scoped_lock( queuing_mutex& m ) {
            initialize();
            acquire(m);
        }

        //! Release lock (if lock is held).
        ~scoped_lock() {
            if( mutex ) release();
        }

        //! Acquire lock on given mutex.
        void __TBB_EXPORTED_METHOD acquire( queuing_mutex& m );

        //! Acquire lock on given mutex if free (i.e. non-blocking)
        bool __TBB_EXPORTED_METHOD try_acquire( queuing_mutex& m );

        //! Release lock.
        void __TBB_EXPORTED_METHOD release();

    private:
        //! The pointer to the mutex owned, or NULL if not holding a mutex.
        queuing_mutex* mutex;

        //! The pointer to the next competitor for a mutex
        scoped_lock *next;

        //! The local spin-wait variable
        /** Inverted (0 - blocked, 1 - acquired the mutex) for the sake of
            zero-initialization.  Defining it as an entire word instead of
            a byte seems to help performance slightly. */
        uintptr_t going;
    };

    void __TBB_EXPORTED_METHOD internal_construct();

    // Mutex traits
    static const bool is_rw_mutex = false;
    static const bool is_recursive_mutex = false;
    static const bool is_fair_mutex = true;

private:
    //! The last competitor requesting the lock
    atomic<scoped_lock*> q_tail;

};

__TBB_DEFINE_PROFILING_SET_NAME(queuing_mutex)

} // namespace tbb

#endif /* __TBB_queuing_mutex_H */
