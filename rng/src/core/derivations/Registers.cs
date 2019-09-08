//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    partial class RngX
    {        

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