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

#ifndef _FGT_TBB_TRACE_IMPL_H
#define _FGT_TBB_TRACE_IMPL_H

#include "../tbb_profiling.h"

namespace tbb {
    namespace internal {

#if TBB_PREVIEW_ALGORITHM_TRACE
        static inline void fgt_algorithm( string_index t, void *algorithm, void *parent ) {
            itt_make_task_group( ITT_DOMAIN_FLOW, algorithm, ALGORITHM, parent, ALGORITHM, t );
        }
        static inline void fgt_begin_algorithm( string_index t, void *algorithm ) {
            itt_task_begin( ITT_DOMAIN_FLOW, algorithm, ALGORITHM, NULL, FLOW_NULL, t );
        }
        static inline void fgt_end_algorithm( void * ) {
            itt_task_end( ITT_DOMAIN_FLOW );
        }
        static inline void fgt_alg_begin_body( string_index t, void *body, void *algorithm ) {
            itt_task_begin( ITT_DOMAIN_FLOW, body, FLOW_BODY, algorithm, ALGORITHM, t );
        }
        static inline void fgt_alg_end_body( void * ) {
            itt_task_end( ITT_DOMAIN_FLOW );
        }

#else // TBB_PREVIEW_ALGORITHM_TRACE

        static inline void fgt_algorithm( string_index /*t*/, void * /*algorithm*/, void * /*parent*/ ) { }
        static inline void fgt_begin_algorithm( string_index /*t*/, void * /*algorithm*/ ) { }
        static inline void fgt_end_algorithm( void * ) { }
        static inline void fgt_alg_begin_body( string_index /*t*/, void * /*body*/, void * /*algorithm*/ ) { }
        static inline void fgt_alg_end_body( void * ) { }

#endif // TBB_PREVIEW_ALGORITHM_TRACEE

    } // namespace internal
} // namespace tbb

#endif
