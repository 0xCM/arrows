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
    
    
    using static mfunc;


    public static partial class dinxx
    {
        
        [MethodImpl(Inline)]
        public static Span128<byte> Add(this Span128<byte> lhs, ReadOnlySpan128<byte> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<ushort> Add(this Span128<ushort> lhs, ReadOnlySpan128<ushort> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<short> Add(this Span128<short> lhs, ReadOnlySpan128<short> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<int> Add(this Span128<int> lhs, ReadOnlySpan128<int> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<uint> Add(this Span128<uint> lhs, ReadOnlySpan128<uint> rhs)
            => dinx.add(lhs,rhs, ref lhs);
        
        [MethodImpl(Inline)]
        public static Span128<long> Add(this Span128<long> lhs, ReadOnlySpan128<long> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<ulong> Add(this Span128<ulong> lhs, ReadOnlySpan128<ulong> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span128<float> Add(this Span128<float> lhs, ReadOnlySpan128<float> rhs)
            => dinx.add(lhs,rhs, ref lhs);
 
        [MethodImpl(Inline)]
        public static Span128<double> Add(this Span128<double> lhs, ReadOnlySpan128<double> rhs)
            => dinx.add(lhs,rhs, ref lhs);
            
         [MethodImpl(Inline)]
        public static Span256<byte> Add(this Span256<byte> lhs, ReadOnlySpan256<byte> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<ushort> Add(this Span256<ushort> lhs, ReadOnlySpan256<ushort> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<short> Add(this Span256<short> lhs, ReadOnlySpan256<short> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<int> Add(this Span256<int> lhs, ReadOnlySpan256<int> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<uint> Add(this Span256<uint> lhs, ReadOnlySpan256<uint> rhs)
            => dinx.add(lhs,rhs, ref lhs);
        
        [MethodImpl(Inline)]
        public static Span256<long> Add(this Span256<long> lhs, ReadOnlySpan256<long> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<ulong> Add(this Span256<ulong> lhs, ReadOnlySpan256<ulong> rhs)
            => dinx.add(lhs,rhs, ref lhs);

        [MethodImpl(Inline)]
        public static Span256<float> Add(this Span256<float> lhs, ReadOnlySpan256<float> rhs)
            => dinx.add(lhs,rhs, ref lhs);
 
        [MethodImpl(Inline)]
        public static Span256<double> Add(this Span256<double> lhs, ReadOnlySpan256<double> rhs)
            => dinx.add(lhs,rhs, ref lhs);
 
 
    }
}