//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {
        /// <summary>
        /// Applies an action to each member of the collection
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to enumerate</param>
        /// <param name="action">The action to apply</param>
        /// <param name="pll">Indicates whether the action should be applied concurrently</param>
        [MethodImpl(Inline)]
        public static void Iterate<T>(this IEnumerable<T> items, Action<T> action, bool pll = false)
        {
            if (pll)
                items.AsParallel().ForAll(action);
            else
                foreach (var item in items)
                    action(item);
        }

       /// <summary>
        /// Attaches a 0-based integer sequence to the input value sequence and
        /// yield the paired sequence elements
        /// </summary>
        /// <param name="i">The index of the paired value</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<(int i, T value)> Iteri<T>(this IEnumerable<T> items)
            => iteri(items);

 

    }
}


