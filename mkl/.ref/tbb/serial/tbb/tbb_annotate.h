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

#ifndef __TBB_annotate_H
#define __TBB_annotate_H

// Macros used by the Intel(R) Parallel Advisor.
#ifdef __TBB_NORMAL_EXECUTION
    #define ANNOTATE_SITE_BEGIN( site )
    #define ANNOTATE_SITE_END( site )
    #define ANNOTATE_TASK_BEGIN( task )
    #define ANNOTATE_TASK_END( task )
    #define ANNOTATE_LOCK_ACQUIRE( lock )
    #define ANNOTATE_LOCK_RELEASE( lock )
#else
    #include <advisor-annotate.h>
#endif

#endif /* __TBB_annotate_H */
