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

    using static corefunc;



    public static class PrimitiveX
    {

        /// <summary>
        /// Partitons a finite sequence of items via an equivalence relation
        /// </summary>
        /// <param name="relation">The partitioning relation</param>
        /// <param name="items">The items to partition</param>
        /// <typeparam name="T">The item type</typeparam>
        public static IEnumerable<DiscreteEqClass<T>> Partition<T>(this Traits.Equivalence<T> relation, IEnumerable<T> items)
            where T : IEquatable<T>
        {
            var classes = cindex<T, ConcurrentBag<T>>();
            foreach(var item in items)
            {
                classes.FirstKey(k => relation.related(item,k))
                       .OnNone(() => classes.TryAdd(item, k => cbag(k)))
                       .OnSome(k => classes[k].Add(item));
            }

            return classes.KeyedValues.Select(kvp => new DiscreteEqClass<T>(kvp.key,relation, kvp.value ));
        }


    }    
}
