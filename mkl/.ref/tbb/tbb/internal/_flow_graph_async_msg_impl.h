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

#ifndef __TBB__flow_graph_async_msg_impl_H
#define __TBB__flow_graph_async_msg_impl_H

#ifndef __TBB_flow_graph_H
#error Do not #include this internal file directly; use public TBB headers instead.
#endif

namespace internal {

template <typename T>
class async_storage {
public:
    typedef receiver<T> async_storage_client;

    async_storage() : my_graph(nullptr) {
        my_data_ready.store<tbb::relaxed>(false);
    }

    ~async_storage() {
        // Release reference to the graph if async_storage
        // was destructed before set() call
        if (my_graph) {
            my_graph->release_wait();
            my_graph = nullptr;
        }
    }

    template<typename C>
    async_storage(C&& data) : my_graph(nullptr), my_data( std::forward<C>(data) ) {
        using namespace tbb::internal;
        __TBB_STATIC_ASSERT( (is_same_type<typename strip<C>::type, typename strip<T>::type>::value), "incoming type must be T" );

        my_data_ready.store<tbb::relaxed>(true);
    }

    template<typename C>
    bool set(C&& data) {
        using namespace tbb::internal;
        __TBB_STATIC_ASSERT( (is_same_type<typename strip<C>::type, typename strip<T>::type>::value), "incoming type must be T" );

        {
            tbb::spin_mutex::scoped_lock locker(my_mutex);

            if (my_data_ready.load<tbb::relaxed>()) {
                __TBB_ASSERT(false, "double set() call");
                return false;
            }

            my_data = std::forward<C>(data);
            my_data_ready.store<tbb::release>(true);
        }

        // Thread sync is on my_data_ready flag
        for (typename subscriber_list_type::iterator it = my_clients.begin(); it != my_clients.end(); ++it) {
            (*it)->try_put(my_data);
        }

        // Data was sent, release reference to the graph
        if (my_graph) {
            my_graph->release_wait();
            my_graph = nullptr;
        }

        return true;
    }

    task* subscribe(async_storage_client& client, graph& g) {
        if (! my_data_ready.load<tbb::acquire>())
        {
            tbb::spin_mutex::scoped_lock locker(my_mutex);

            if (! my_data_ready.load<tbb::relaxed>()) {
#if TBB_USE_ASSERT
                for (typename subscriber_list_type::iterator it = my_clients.begin(); it != my_clients.end(); ++it) {
                    __TBB_ASSERT(*it != &client, "unexpected double subscription");
                }
#endif // TBB_USE_ASSERT

                // Increase graph lifetime
                my_graph = &g;
                my_graph->reserve_wait();

                // Subscribe
                my_clients.push_back(&client);
                return SUCCESSFULLY_ENQUEUED;
            }
        }

        __TBB_ASSERT(my_data_ready.load<tbb::relaxed>(), "data is NOT ready");
        return client.try_put_task(my_data);
    }

private:
    graph* my_graph;
    tbb::spin_mutex my_mutex;
    tbb::atomic<bool> my_data_ready;
    T my_data;
    typedef std::vector<async_storage_client*> subscriber_list_type;
    subscriber_list_type my_clients;
};

} // namespace internal

template <typename T>
class async_msg {
    template< typename > friend class receiver;
    template< typename, typename > friend struct internal::async_helpers;
public:
    typedef T async_msg_data_type;

    async_msg() : my_storage(std::make_shared< internal::async_storage<T> >()) {}

    async_msg(const T& t) : my_storage(std::make_shared< internal::async_storage<T> >(t)) {}

    async_msg(T&& t) : my_storage(std::make_shared< internal::async_storage<T> >( std::move(t) )) {}

    virtual ~async_msg() {}

    void set(const T& t) {
        my_storage->set(t);
    }

    void set(T&& t) {
        my_storage->set( std::move(t) );
    }

protected:
    // Can be overridden in derived class to inform that 
    // async calculation chain is over
    virtual void finalize() const {}

private:
    typedef std::shared_ptr< internal::async_storage<T> > async_storage_ptr;
    async_storage_ptr my_storage;
};

#endif  // __TBB__flow_graph_async_msg_impl_H
