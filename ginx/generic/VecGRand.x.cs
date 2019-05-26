//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;    

    public static class VecGRandX
    {

       public static Vec128<T> Vec128<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span128<T>(1, domain, filter).Vector();

        public static Vec256<T> Vec256<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span256<T>(1, domain, filter).Vector();

        public static (Vec128<T> Left, Vec128<T> Right) Vec128Pair<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var left = random.Span128<T>(1, Randomizer.Domain(domain), filter);
            var right = random.Span128<T>(1, Randomizer.Domain(domain), filter);
            return (Z0.Vec128.single(left),Z0.Vec128.single(right));
        }

        public static (Vec256<T> Left, Vec256<T> Right) Vec256Pair<T>(this IRandomizer random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var left = random.Span256<T>(1, Randomizer.Domain(domain), filter);
            var right = random.Span256<T>(1, Randomizer.Domain(domain), filter);
            return (Z0.Vec256.single<T>(left),Z0.Vec256.single<T>(right));
        }



    }

}