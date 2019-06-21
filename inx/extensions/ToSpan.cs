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

    public static class ToSpanX
    {
        /// <summary>
        /// Sends the components of the vector to a blocked span that is 
        /// returned to the caller
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan<T>(this in Vec128<T> src)
            where T : struct     
        {
            var dst = Span128.alloc<T>(1);
            Vec128.store(in src, ref dst[0]);
            return dst;
        }                       

        /// <summary>
        /// Sends the components of the vector to a blocked span that is 
        /// returned to the caller
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan<T>(this in Vec256<T> src)
            where T : struct            
        {
            var dst = Span256.alloc<T>(1);
            Vec256.store(in src, ref dst[0]);
            return dst;
        }                       

        [MethodImpl(Inline)]
        public static Span<T> Extract<T>(this in Vec128<T> src)
            where T : struct            
                => src.ToSpan().Unblock();

        [MethodImpl(Inline)]
        public static Span<T> Extract<T>(this in Vec256<T> src)
            where T : struct            
                => src.ToSpan().Unblock();

    }
}