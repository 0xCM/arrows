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

    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    using static System.Runtime.Intrinsics.X86.Sse41;
     
    using static zfunc;
    using static dinx;

    partial class dinxx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> ToVec128Int16(this in Vec128<sbyte> src)
            => convert(src, out Vec128<short> dst);

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128Int32(this in Vec128<sbyte> src)
            => convert(src, out Vec128<int> dst);

        [MethodImpl(Inline)]
        public static Vec128<long> ToVec128Int64(this in Vec128<sbyte> src)
            => convert(src, out Vec128<long> dst);

        [MethodImpl(Inline)]
        public static Vec128<short> ToVec128Int16(this in Vec128<byte> src)
            => convert(src, out Vec128<short> dst);

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128Int32(this in Vec128<byte> src)
            => convert(src, out Vec128<int> dst);

        [MethodImpl(Inline)]
        public static Vec128<long> ToVec128Int64(this in Vec128<byte> src)
            => convert(src, out Vec128<long> dst);

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128Int32(this in Vec128<short> src)
            => convert(src, out Vec128<int> dst);

        [MethodImpl(Inline)]
        public static Vec128<long> ToVec128Int64(this in Vec128<short> src)
            => convert(src, out Vec128<long> dst);

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128Int32(this in Vec128<ushort> src)
            => convert(src, out Vec128<int> dst);

        [MethodImpl(Inline)]
        public static Vec128<long> ToVec128Int64(this in Vec128<ushort> src)
            => convert(src, out Vec128<long> dst);

    }
}