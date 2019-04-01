//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using Z0;
    using static zcore;

    partial class xcore
    {
        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<intg<T>> src)
            => src.Select(x => x.data).ToList();

        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> Unwrap<T>(this IEnumerable<real<T>> src)
            => src.Select(x => x.data).ToList();

        [MethodImpl(Inline)]
        public static T SumG<T>(this IEnumerable<T> src)
            where T : Structure.Additive<T>, new()
                => fold(src, (x,y) => x.add(y));

        [MethodImpl(Inline)]
        public static T MaxG<T>(this IEnumerable<T> src)
            where T : struct, Structure.OrderedNumber<T>
        {
            T max = src.FirstOrDefault();
            foreach(var item in src)
                max = item.gt(max) ? item : max;
            return max;
        }

        public static real<T> AvgG<T>(this IEnumerable<real<T>> src) 
        {
            var result = default(real<T>);
            var count = default(real<T>);
            foreach(var val in src)
            {
                result += val;
                ++count;
            }
            return count.nonzero() ? result/count : result;

        }


   }
}