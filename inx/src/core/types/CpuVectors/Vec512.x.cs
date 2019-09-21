//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;
    
    using static zfunc;    

    public static class Vec512x
    {
        /// <summary>
        /// Allocates a span and extracts
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this in Vec512<T> src)
            where T : unmanaged            
        {
            var dst = span<T>(Vec512<T>.Length);
            src.ToSpan(dst);
            return dst;
        }                       

        /// <summary>
        /// Extracts the index-identified 128-bit component from the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The component index; either 0, 1, 2 or 3</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Extract128<T>(this Vec512<T> src, byte index)
            where T : unmanaged            
        {
            if(index == 0)
                return ginx.extract128(src.lo,0);
            else if(index == 1)
                return ginx.extract128(src.lo,1);
            if(index == 2)
                return ginx.extract128(src.hi,0);
            else if(index == 3)
                return ginx.extract128(src.hi,1);
            else
                throw unsupported<T>();
        }


        /// <summary>
        /// Copies the source data to a specified span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void ToSpan<T>(this in Vec512<T> src, Span<T> dst)
            where T : unmanaged            
        {
            Vec256.Store(in src.lo, ref dst[0]);
            Vec256.Store(in src.hi, ref dst[Vec256<T>.Length]);
        }       

        /// <summary>
        /// Represents the vector content as a span (Non-allocating)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe Span<T> AsSpan<T>(this ref Vec512<T> src)
            where T : unmanaged            
                => new Span<T>(Unsafe.AsPointer(ref src), Vec512<T>.Length);

        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec512<T> src, int? bwidth = null, char? bsep = null)
            where T : unmanaged
                => src.hi.ToSpan().FormatHexBlocks(bwidth, bsep) 
                    + src.lo.ToSpan().FormatHexBlocks(bwidth, bsep);
    }

}