//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    public static partial class UniformRandom
    {        
        internal static Interval<T> TypeBoundDomain<T>()
            where T : struct
        {
            var min = gmath.signed<T>() && !gmath.floating<T>()
                ? gmath.negate(gbits.shiftr(gmath.maxval<T>(), 1)) 
                : gmath.zero<T>();
            
            var max = 
                gmath.signed<T>() && !gmath.floating<T>()
                ? gbits.shiftr(gmath.maxval<T>(), 1)
                : gmath.maxval<T>();
            
            return leftclosed(min,max);

        }
        public static HashSet<uint> TakeSet(this IRandomSource<uint> rng, int count)
            => rng.Stream().Take(count).ToHashSet();
    }
}