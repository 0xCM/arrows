//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Defines missing Take(stream,n:uint) method
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="count">The number of elements to remove from the from of the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> Take<T>(this IEnumerable<T> src, uint count)
            => src.Take((int)count);

        [MethodImpl(Inline)]
        public static IEnumerable<(T left,T right)> Enumerate<T>(this (IEnumerable<T> left, IEnumerable<T> right) src)
        {        
            var lenum = src.left.GetEnumerator();
            var renum = src.right.GetEnumerator();
            var lnext = lenum.MoveNext();
            var rnext = renum.MoveNext();
            while(lnext && rnext)
            {
                yield return (lenum.Current, renum.Current);
                lnext = lenum.MoveNext();
                rnext = renum.MoveNext();
            }
        }
    }
}