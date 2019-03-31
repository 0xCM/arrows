//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zcore;

    partial class xcore
    {

        /// <summary>
        /// Partitons a finite sequence of items via an equivalence relation
        /// </summary>
        /// <param name="relation">The partitioning relation</param>
        /// <param name="items">The items to partition</param>
        /// <typeparam name="T">The item type</typeparam>
        public static IEnumerable<Reify.FiniteEquivalenceClass<T>> Partition<T>(this Operative.Equivalence<T> relation, IEnumerable<T> items)
            where T : Operative.Equatable<T>, new()

        {
            var classes = cindex<T, ConcurrentBag<T>>();
            foreach(var item in items)
            {
                classes.FirstKey(k => relation.related(item,k))
                       .OnNone(() => classes.TryAdd(item, k => cbag(k)))
                       .OnSome(k => classes[k].Add(item));
            }

            return classes.KeyedValues.Select(kvp => new Reify.FiniteEquivalenceClass<T>(kvp.key,relation, kvp.value ));
        }


        class Komparer<T> : IComparer<T>
        {
            Operative.Ordered<T> ordered {get;}                

            public Komparer(Operative.Ordered<T> ordered)
                => this.ordered = ordered;
            public int Compare(T x, T y)
            {
                if(ordered.lt(x,y))
                    return - 1;
                else if(ordered.gt(x, y))
                    return 1;
                else
                    return 0;
                

            }
        }

        public static IComparer<T> ToComparer<T>(this Operative.Ordered<T> order)
            => new Komparer<T>(order);


    }    
}
