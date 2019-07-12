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

#ifndef __TBB_compat_ppl_H
#define __TBB_compat_ppl_H

#include "../task_group.h"
#include "../parallel_invoke.h"
#include "../parallel_for_each.h"
#include "../parallel_for.h"
#include "../tbb_exception.h"
#include "../critical_section.h"
#include "../reader_writer_lock.h"
#include "../combinable.h"

namespace Concurrency {

#if __TBB_TASK_GROUP_CONTEXT
    using tbb::task_handle;
    using tbb::task_group_status;
    using tbb::task_group;
    using tbb::structured_task_group;
    using tbb::invalid_multiple_scheduling;
    using tbb::missing_wait;
    using tbb::make_task;

    using tbb::not_complete;
    using tbb::complete;
    using tbb::canceled;

    using tbb::is_current_task_group_canceling;
#endif /* __TBB_TASK_GROUP_CONTEXT */

    using tbb::parallel_invoke;
    using tbb::strict_ppl::parallel_for;
    using tbb::parallel_for_each;
    using tbb::critical_section;
    using tbb::reader_writer_lock;
    using tbb::combinable;

    using tbb::improper_lock;

} // namespace Concurrency

#endif /* __TBB_compat_ppl_H */
