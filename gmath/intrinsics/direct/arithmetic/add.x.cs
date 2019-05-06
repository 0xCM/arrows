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
        public static Span128<byte> InXAdd(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span128<ushort> InXAdd(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span128<short> InXAdd(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span128<int> InXAdd(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs)
            => dinx.add(lhs,rhs);


        [MethodImpl(Inline)]
        public static Span128<uint> InXAdd(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs)
            => dinx.add(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static Span128<long> InXAdd(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span128<ulong> InXAdd(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
            => dinx.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span128<float> InXAdd(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
            => dinx.add(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static Span<double> InXAdd(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
            => dinx.add(lhs,rhs);
    }
}