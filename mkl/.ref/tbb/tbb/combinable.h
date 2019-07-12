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

#ifndef __TBB_combinable_H
#define __TBB_combinable_H

#include "enumerable_thread_specific.h"
#include "cache_aligned_allocator.h"

namespace tbb {
/** \name combinable
    **/
//@{
//! Thread-local storage with optional reduction
/** @ingroup containers */
    template <typename T>
    class combinable {

    private:
        typedef typename tbb::cache_aligned_allocator<T> my_alloc;
        typedef typename tbb::enumerable_thread_specific<T, my_alloc, ets_no_key> my_ets_type;
        my_ets_type my_ets;

    public:

        combinable() { }

        template <typename finit>
        explicit combinable( finit _finit) : my_ets(_finit) { }

        //! destructor
        ~combinable() { }

        combinable( const combinable& other) : my_ets(other.my_ets) { }

#if __TBB_ETS_USE_CPP11
        combinable( combinable&& other) : my_ets( std::move(other.my_ets)) { }
#endif

        combinable & operator=( const combinable & other) {
            my_ets = other.my_ets;
            return *this;
        }

#if __TBB_ETS_USE_CPP11
        combinable & operator=( combinable && other) {
            my_ets=std::move(other.my_ets);
            return *this;
        }
#endif

        void clear() { my_ets.clear(); }

        T& local() { return my_ets.local(); }

        T& local(bool & exists) { return my_ets.local(exists); }

        // combine_func_t has signature T(T,T) or T(const T&, const T&)
        template <typename combine_func_t>
        T combine(combine_func_t f_combine) { return my_ets.combine(f_combine); }

        // combine_func_t has signature void(T) or void(const T&)
        template <typename combine_func_t>
        void combine_each(combine_func_t f_combine) { my_ets.combine_each(f_combine); }

    };
} // namespace tbb
#endif /* __TBB_combinable_H */
