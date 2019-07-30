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

    partial class ginxs
    {
        /// <summary>
        /// Stores source vector conent in a target span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this in Vec256<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {            
            Vec256.store(src, ref dst[offset]);
            return  dst;
        }

        /// <summary>
        /// Stores source vector conent in a target span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this in Vec128<T> src, Span<T> dst, int offset = 0)
            where T : struct
        {            
            Vec128.store(src, ref dst[offset]);
            return  dst;
        }

        /// <summary>
        /// Sends the components of the vector to a blocked span that is 
        /// returned to the caller
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this in Vec128<T> src)
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
        public static Span256<T> ToSpan256<T>(this in Vec256<T> src)
            where T : struct            
        {
            var dst = Span256.alloc<T>(1);
            Claim.eq(dst.Length, Vec256<T>.Length);
            Vec256.store(in src, ref dst[0]);
            return dst;
        }                       

        /// <summary>
        /// Extracts the components of an intrinsic vector to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this in Vec128<T> src)
            where T : struct            
                => src.ToSpan128().Unblock();

        /// <summary>
        /// Extracts the components of an intrinsic vector to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this in Vec256<T> src)
            where T : struct            
                => src.ToSpan256().Unblock();
 
         [MethodImpl(Inline)]
        public static Num128<T> ToScalar128<T>(this Vec128<T> src, int index)
            where T : struct            
                => Num128.define(src[index]);

        /// <summary>
        /// Loads a scalar vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Num128<T> ToScalar128<T>(this ReadOnlySpan128<T> src, int block = 0)            
            where T : struct            
                => Num128.load(src,block);

    }
}