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


    public static partial class dinxx
    {
        
        [MethodImpl(Inline)]
        public static unsafe sbyte[] InXAdd(this sbyte[] lhs, sbyte[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe byte[] InXAdd(this byte[] lhs, byte[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe short[] InXAdd(this short[] lhs, short[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe ushort[] InXAdd(this ushort[] lhs, ushort[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe int[] InXAdd(this int[] lhs, int[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe uint[] InXAdd(this uint[] lhs, uint[] rhs)
            => dinx.add(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe long[] InXAdd(this long[] lhs, long[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe ulong[] InXAdd(this ulong[] lhs, ulong[] rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe float[] InXAdd(this float[] lhs, float[] rhs)
            => dinx.add(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static unsafe double[] InXAdd(this double[] lhs, double[] rhs)
            => dinx.add(lhs,rhs);
    }
}