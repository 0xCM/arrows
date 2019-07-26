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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    public static partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> subs(in Vec128<byte> lhs, in Vec128<byte> rhs)        
            => SubtractSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> subs(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)        
            => SubtractSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> subs(in Vec128<short> lhs, in Vec128<short> rhs)        
            => SubtractSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> subs(in Vec128<ushort> lhs, in Vec128<ushort> rhs)        
            => SubtractSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> subs(in Vec256<byte> lhs, in Vec256<byte> rhs)        
            => SubtractSaturate(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<sbyte> subs(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)        
            => SubtractSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> subs(in Vec256<short> lhs, in Vec256<short> rhs)        
            => SubtractSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> subs(in Vec256<ushort> lhs, in Vec256<ushort> rhs)        
            => SubtractSaturate(lhs,rhs);
    }

}