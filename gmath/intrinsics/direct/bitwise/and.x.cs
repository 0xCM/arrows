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
    
    using static zcore;
    using static inxfunc;


    partial class dinxx
    {
        
        [MethodImpl(Inline)]
        public static unsafe sbyte[] InXAnd(this sbyte[] lhs, sbyte[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe byte[] InXAnd(this byte[] lhs, byte[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe short[] InXAnd(this short[] lhs, short[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe ushort[] InXAnd(this ushort[] lhs, ushort[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe int[] InXAnd(this int[] lhs, int[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe uint[] InXAnd(this uint[] lhs, uint[] rhs)
            => dinx.and(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe long[] InXAnd(this long[] lhs, long[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe ulong[] InXAnd(this ulong[] lhs, ulong[] rhs)
            => dinx.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe float[] InXAnd(this float[] lhs, float[] rhs)
            => dinx.and(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static unsafe double[] InXAnd(this double[] lhs, double[] rhs)
            => dinx.and(lhs,rhs);

    }
}