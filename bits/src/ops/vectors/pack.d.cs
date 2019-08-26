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
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static As;
    using static zfunc;
 
    partial class Bits
    {        
        [MethodImpl(Inline)]
        public static Vec128<sbyte> pack(in Vec128<short> lhs, in Vec128<short> rhs)
            => PackSignedSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> pack(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => PackUnsignedSaturate(lhs.As<short>(),rhs.As<short>());

        [MethodImpl(Inline)]
        public static Vec128<short> pack(in Vec128<int> lhs, in Vec128<int> rhs)
            => PackSignedSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> pack(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => PackUnsignedSaturate(lhs.As<int>(),rhs.As<int>());

        [MethodImpl(Inline)]
        public static Vec256<sbyte> pack(in Vec256<short> lhs, in Vec256<short> rhs)
            => PackSignedSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> pack(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => PackUnsignedSaturate(lhs.As<short>(),rhs.As<short>());

        [MethodImpl(Inline)]
        public static Vec256<short> pack(in Vec256<int> lhs, in Vec256<int> rhs)
            => PackSignedSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> pack(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => PackUnsignedSaturate(lhs.As<int>(),rhs.As<int>());
    }

}