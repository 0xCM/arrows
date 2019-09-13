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
        /// <summary>
        /// Computes the bitwise AND of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
                => gmath.and(lhs,rhs);

        /// <summary>
        /// Computes the bitwise AND of two primal operands and overwrites
        /// the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, in T rhs)
            where T : struct
               => ref gmath.and(ref lhs, in rhs);
     
        /// <summary>
        /// Computes the bitwise AND of two primal operands and stores the 
        /// result in a specified target
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T and<T>(in T lhs, in T rhs, ref T dst)
            where T : struct
                => ref gmath.and(in lhs, in rhs, ref dst);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
                => gmath.flip(src);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// and overwites the operand with the result
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
                => ref gmath.flip(ref src);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// and stores the result in a target operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T flip<T>(in T src, ref T dst)
            where T : struct
                => ref gmath.flip(in src, ref dst);
 
        [MethodImpl(Inline)]
        public static T[] and<T>(T[] lhs, T[] rhs)
            where T : unmanaged
        {            
            var dst = new T[math.max(lhs.Length, rhs.Length)];
            var len = math.min(lhs.Length, rhs.Length);
            for(var i=0; i<len; i++)
                and(in lhs[i],in rhs[i], ref dst[i]);
            return dst;
        }

        /// <summary>
        /// Computes the bitwise AND between memory spans of potentially different lengths
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


   }    
}