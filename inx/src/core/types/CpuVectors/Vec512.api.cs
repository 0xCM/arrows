//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static zfunc;    
    using static As;

    public static class Vec512
    {
        /// <summary>
        /// Constructs a 512-bit vector from four 128-bit vectors
        /// </summary>
        /// <param name="v00">The least signficant vector</param>
        /// <param name="v01">The second vector</param>
        /// <param name="v10">The third vector</param>
        /// <param name="v11">The most signficant vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec512<T> FromParts<T>(Vec128<T> v00, Vec128<T> v01, Vec128<T> v10, Vec128<T> v11)        
            where T : struct
        {
            Vec256<T> lo = ginx.set(v00,v01);            
            Vec256<T> hi = ginx.set(v10,v11);
            return new Vec512<T>(in lo, in hi);
        }

        /// <summary>
        /// Constructs a 512-bit vector from two 256-bit vectors
        /// </summary>
        /// <param name="lo">The least signficant vector</param>
        /// <param name="hi">The second vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec512<T> FromParts<T>(in Vec256<T> lo, in Vec256<T> hi)        
            where T : struct
                => new Vec512<T>(lo, hi);

        /// <summary>
        /// Constructs a 512-bit vector from two 256-bit vectors
        /// </summary>
        /// <param name="lo">The least signficant vector</param>
        /// <param name="hi">The second vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec512<T> FromParts<T>(in Vector256<T> lo, in Vector256<T> hi)        
            where T : struct
                => new Vec512<T>(lo, hi);

        /// <summary>
        /// Verifies that segment specification parameters are valid
        /// </summary>
        /// <param name="offset">A zero-based cell index</param>
        /// <param name="len">The number of components included in the extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        static void CheckSegment<T>(int offset, int len)
            where T : struct
        {
            var offsetBytes = offset * Vec512<T>.CellSize;
            var wantedBytes = len * Vec512<T>.CellSize;
            var haveBytes = Vec512<T>.ByteCount - offsetBytes;
            if(wantedBytes > haveBytes)
                throw Errors.TooManyBytes(wantedBytes, haveBytes);
        }

        /// <summary>
        /// Extracts a contiguous component sequence from a source vector as 
        /// determined by a componet-relative offset and a component count
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">A zero-based cell index</param>
        /// <param name="len">The number of components included in the extract</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> Segment<T>(this ref Vec512<T> src, int offset, int len)
            where T : struct
        {
            CheckSegment<T>(offset,len);
            return new Span<T>(pvoid(ref Unsafe.Add(ref src, offset)),len);
        }
    }
}