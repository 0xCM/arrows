//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
                => gmath.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, in T rhs)
            where T : struct
               => ref gmath.and(ref lhs, in rhs);
     
        [MethodImpl(Inline)]
        public static ref T and<T>(in T lhs, in T rhs, ref T dst)
            where T : struct
                => ref gmath.and(in lhs, in rhs, ref dst);


        /// <summary>
        /// Computes the bitwise or of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
                => gmath.or(lhs,rhs);

        /// <summary>
        /// Computes the bitwise or of two primal operands and stores the
        /// result in the left operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, in T rhs)
            where T : struct
                => ref gmath.or(ref lhs, in rhs);

        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
                => gmath.flip(src);

        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
                => ref gmath.flip(ref src);

        [MethodImpl(Inline)]
        public static ref T flip<T>(in T src, ref T dst)
            where T : struct
                => ref gmath.flip(in src, ref dst);

 
        /// <summary>
        /// Computes the bitwise XOR between memory spands of potentially different lengths
        /// </summary>
        /// <param name="lhs">The left cells</param>
        /// <param name="rhs">The right cells</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> and<T>(in MemorySpan<T> lhs, in MemorySpan<T> rhs)
            where T : unmanaged
        {
            var dst = MemorySpan.Alloc<T>(math.max(lhs.Length, rhs.Length));
            var len = math.min(lhs.Length, rhs.Length);
            for(var i=0; i<len; i++)
                and(in lhs[i],in rhs[i], ref dst[i]);
            return dst;
        }

        /// <summary>
        /// Flips the bits
        /// </summary>
        /// <param name="src">The left cells</param>
        /// <param name="rhs">The right cells</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> flip<T>(in MemorySpan<T> src)
            where T : unmanaged
        {
            var dst = src.Replicate(true);
            for(var i=0; i<dst.Length; i++)
                flip(in src[i], ref dst[i]);
            return dst;
        }

   }

    
}