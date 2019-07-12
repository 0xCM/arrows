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

#ifndef __TBB_flow_graph_abstractions_H
#define __TBB_flow_graph_abstractions_H

namespace tbb {
namespace flow {
namespace interface10 {

//! Pure virtual template classes that define interfaces for async communication
class graph_proxy {
public:
    //! Inform a graph that messages may come from outside, to prevent premature graph completion
    virtual void reserve_wait() = 0;

    //! Inform a graph that a previous call to reserve_wait is no longer in effect
    virtual void release_wait() = 0;

    virtual ~graph_proxy() {}
};

template <typename Input>
class receiver_gateway : public graph_proxy {
public:
    //! Type of inputing data into FG.
    typedef Input input_type;

    //! Submit signal from an asynchronous activity to FG.
    virtual bool try_put(const input_type&) = 0;
};

} //interfaceX

using interface10::graph_proxy;
using interface10::receiver_gateway;

} //flow
} //tbb
#endif
