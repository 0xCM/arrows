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

#ifndef __TBB_range_iterator_H
#define __TBB_range_iterator_H

#include "../tbb_stddef.h"

#if __TBB_CPP11_STD_BEGIN_END_PRESENT && __TBB_CPP11_AUTO_PRESENT && __TBB_CPP11_DECLTYPE_PRESENT
    #include <iterator>
#endif

namespace tbb {
    // iterators to first and last elements of container
    namespace internal {

#if __TBB_CPP11_STD_BEGIN_END_PRESENT && __TBB_CPP11_AUTO_PRESENT && __TBB_CPP11_DECLTYPE_PRESENT
        using std::begin;
        using std::end;
        template<typename Container>
        auto first(Container& c)-> decltype(begin(c))  {return begin(c);}

        template<typename Container>
        auto first(const Container& c)-> decltype(begin(c))  {return begin(c);}

        template<typename Container>
        auto last(Container& c)-> decltype(begin(c))  {return end(c);}

        template<typename Container>
        auto last(const Container& c)-> decltype(begin(c)) {return end(c);}
#else
        template<typename Container>
        typename Container::iterator first(Container& c) {return c.begin();}

        template<typename Container>
        typename Container::const_iterator first(const Container& c) {return c.begin();}

        template<typename Container>
        typename Container::iterator last(Container& c) {return c.end();}

        template<typename Container>
        typename Container::const_iterator last(const Container& c) {return c.end();}
#endif

        template<typename T, size_t size>
        T* first(T (&arr) [size]) {return arr;}

        template<typename T, size_t size>
        T* last(T (&arr) [size]) {return arr + size;}
    } //namespace internal
}  //namespace tbb

#endif // __TBB_range_iterator_H
