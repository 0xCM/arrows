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
        public static unsafe Span<byte> InXAdd(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Span<ushort> InXAdd(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Span<short> InXAdd(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe Span<int> InXAdd(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => dinx.add(lhs,rhs);


        [MethodImpl(Inline)]
        public static unsafe uint[] InXAdd(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => dinx.add(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static unsafe long[] InXAdd(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe ulong[] InXAdd(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe float[] InXAdd(this ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => dinx.add(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static Span<double> InXAdd(this ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => dinx.add(lhs,rhs);
    }
}