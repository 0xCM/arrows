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
    using static mfunc;


    partial class dinxx
    {
        
        [MethodImpl(Inline)]
        public static Span128<byte> And(this Span128<byte> lhs, ReadOnlySpan128<byte> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<ushort> And(this Span128<ushort> lhs, ReadOnlySpan128<ushort> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<short> And(this Span128<short> lhs, ReadOnlySpan128<short> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<int> And(this Span128<int> lhs, ReadOnlySpan128<int> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<uint> And(this Span128<uint> lhs, ReadOnlySpan128<uint> rhs)
            => dinx.and(lhs,rhs, ref lhs);
        
        [MethodImpl(Inline)]
        public static Span128<long> And(this Span128<long> lhs, ReadOnlySpan128<long> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<ulong> And(this Span128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<float> And(this Span128<float> lhs, ReadOnlySpan128<float> rhs)
            => dinx.and(lhs,rhs, ref lhs);
 
        [MethodImpl(Inline)]
        public static Span128<double> And(this Span128<double> lhs, ReadOnlySpan128<double> rhs)
            => dinx.and(lhs,rhs, ref lhs);
 
         [MethodImpl(Inline)]
        public static Span256<byte> And(this Span256<byte> lhs, ReadOnlySpan256<byte> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<ushort> And(this Span256<ushort> lhs, ReadOnlySpan256<ushort> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<short> And(this Span256<short> lhs, ReadOnlySpan256<short> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<int> And(this Span256<int> lhs, ReadOnlySpan256<int> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<uint> And(this Span256<uint> lhs, ReadOnlySpan256<uint> rhs)
            => dinx.and(lhs,rhs, ref lhs);
        
        [MethodImpl(Inline)]
        public static Span256<long> And(this Span256<long> lhs, ReadOnlySpan256<long> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<ulong> And(this Span256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
            => dinx.and(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<float> And(this Span256<float> lhs, ReadOnlySpan256<float> rhs)
            => dinx.and(lhs,rhs, ref lhs);
 
        [MethodImpl(Inline)]
        public static Span256<double> And(this Span256<double> lhs, ReadOnlySpan256<double> rhs)
            => dinx.and(lhs,rhs, ref lhs);
 
    }
}