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

#ifndef __TBB_null_mutex_H
#define __TBB_null_mutex_H

#include "tbb_stddef.h"

namespace tbb {

//! A mutex which does nothing
/** A null_mutex does no operation and simulates success.
    @ingroup synchronization */
class null_mutex : internal::mutex_copy_deprecated_and_disabled {
public:
    //! Represents acquisition of a mutex.
    class scoped_lock : internal::no_copy {
    public:
        scoped_lock() {}
        scoped_lock( null_mutex& ) {}
        ~scoped_lock() {}
        void acquire( null_mutex& ) {}
        bool try_acquire( null_mutex& ) { return true; }
        void release() {}
    };

    null_mutex() {}

    // Mutex traits
    static const bool is_rw_mutex = false;
    static const bool is_recursive_mutex = true;
    static const bool is_fair_mutex = true;
};

}

#endif /* __TBB_null_mutex_H */
