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
        /// Computes the bitwise OR of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T or<T>(T lhs, T rhs)
            where T : struct
                => gmath.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static  T or<T>(in T lhs, in T rhs)
            where T : struct
                => gmath.or(lhs, rhs);

        /// <summary>
        /// Computes the bitwise OR of two primal operands and stores the result in a third operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T or<T>(in T lhs, in T rhs, ref T dst)
            where T : struct
        {
            dst = gmath.or(lhs,rhs);
            return ref dst;
        }
                
        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                or(in lhs[i], in rhs[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                or(in lhs[i], in rhs[i], ref lhs[i]);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            for(var i=0; i<lhs.Length; i++)
                or(in lhs[i], in rhs, ref lhs[i]);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, in T rhs, Span<T> dst)
            where T : struct
        {
            lhs.CopyTo(dst);
            return or(dst,rhs);
        }
    }
}