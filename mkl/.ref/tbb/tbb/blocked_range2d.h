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

#ifndef __TBB_blocked_range2d_H
#define __TBB_blocked_range2d_H

#include "tbb_stddef.h"
#include "blocked_range.h"

namespace tbb {

//! A 2-dimensional range that models the Range concept.
/** @ingroup algorithms */
template<typename RowValue, typename ColValue=RowValue>
class blocked_range2d {
public:
    //! Type for size of an iteration range
    typedef blocked_range<RowValue> row_range_type;
    typedef blocked_range<ColValue> col_range_type;

private:
    row_range_type my_rows;
    col_range_type my_cols;

public:

    blocked_range2d( RowValue row_begin, RowValue row_end, typename row_range_type::size_type row_grainsize,
                     ColValue col_begin, ColValue col_end, typename col_range_type::size_type col_grainsize ) :
        my_rows(row_begin,row_end,row_grainsize),
        my_cols(col_begin,col_end,col_grainsize)
    {}

    blocked_range2d( RowValue row_begin, RowValue row_end,
                     ColValue col_begin, ColValue col_end ) :
        my_rows(row_begin,row_end),
        my_cols(col_begin,col_end)
    {}

    //! True if range is empty
    bool empty() const {
        // Range is empty if at least one dimension is empty.
        return my_rows.empty() || my_cols.empty();
    }

    //! True if range is divisible into two pieces.
    bool is_divisible() const {
        return my_rows.is_divisible() || my_cols.is_divisible();
    }

    blocked_range2d( blocked_range2d& r, split ) :
        my_rows(r.my_rows),
        my_cols(r.my_cols)
    {
        split split_obj;
        do_split(r, split_obj);
    }

#if __TBB_USE_PROPORTIONAL_SPLIT_IN_BLOCKED_RANGES
    //! Static field to support proportional split
    static const bool is_splittable_in_proportion = true;

    blocked_range2d( blocked_range2d& r, proportional_split& proportion ) :
        my_rows(r.my_rows),
        my_cols(r.my_cols)
    {
        do_split(r, proportion);
    }
#endif /* __TBB_USE_PROPORTIONAL_SPLIT_IN_BLOCKED_RANGES */

    //! The rows of the iteration space
    const row_range_type& rows() const {return my_rows;}

    //! The columns of the iteration space
    const col_range_type& cols() const {return my_cols;}

private:

    template <typename Split>
    void do_split( blocked_range2d& r, Split& split_obj )
    {
        if( my_rows.size()*double(my_cols.grainsize()) < my_cols.size()*double(my_rows.grainsize()) ) {
            my_cols.my_begin = col_range_type::do_split(r.my_cols, split_obj);
        } else {
            my_rows.my_begin = row_range_type::do_split(r.my_rows, split_obj);
        }
    }
};

} // namespace tbb

#endif /* __TBB_blocked_range2d_H */
