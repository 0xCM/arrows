//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using static Registers;

    public class App : TestApp<App>
    {            
        public static void Main(params string[] args)
            => Run(args);
    }

    public static class AppX
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                =>  new RandomStream<T>(rng,src);

        [MethodImpl(Inline)]
        public static XMM Xmm<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVec128().ToRegister();

        [MethodImpl(Inline)]
        public static XMM Xmm<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVec128().ToRegister();

        [MethodImpl(Inline)]
        public static XMM Xmm<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span128<T>(1, (min,max), filter).LoadVec128().ToRegister();

        [MethodImpl(Inline)]
        public static IEnumerable<XMM> XmmStream<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
        {
            IEnumerable<XMM> produce()
            {
                while(true)            
                    yield return random.Xmm(domain,filter);
            }

            return stream(produce(),random.RngKind);
        }

        [MethodImpl(Inline)]
        public static YMM Ymm<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVec256().ToRegister();

        [MethodImpl(Inline)]
        public static YMM Ymm<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVec256().ToRegister();

        [MethodImpl(Inline)]
        public static YMM Ymm<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span256<T>(1, (min,max), filter).LoadVec256().ToRegister();

        [MethodImpl(Inline)]
        public static IEnumerable<YMM> YmmStream<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
        {
            IEnumerable<YMM> produce()
            {
                while(true)            
                    yield return random.Ymm(domain,filter);
            }

            return stream(produce(),random.RngKind);
        }

    }
}