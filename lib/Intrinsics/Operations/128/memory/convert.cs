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

    partial class InX
    {

        [MethodImpl(Inline)]
        public static Vec128<short> toInt16v(Vec128<sbyte> src)
            => Avx2.ConvertToVector128Int16(src);

        [MethodImpl(Inline)]
        public static Vec128<int> toInt32v(Vec128<sbyte> src)
            => Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> toInt64v(Vec128<sbyte> src)
            => Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<short> toInt16v(Vec128<byte> src)
            =>  Avx2.ConvertToVector128Int16(src);

        [MethodImpl(Inline)]
        public static Vec128<int> toInt32v(Vec128<byte> src)
            => Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> toInt64v(Vec128<byte> src)
            => Avx2.ConvertToVector128Int64(src);


        [MethodImpl(Inline)]
        public static Vec128<int> toInt32v(Vec128<short> src)
            => Avx2.ConvertToVector128Int32(src);


        [MethodImpl(Inline)]
        public static Vec128<long> toInt64v(Vec128<short> src)
            => Avx2.ConvertToVector128Int64(src);


        [MethodImpl(Inline)]
        public static Vec128<int> toInt32v(Vec128<ushort> src)
            => Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> toInt64v(Vec128<ushort> src)
            => Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> toInt64v(Vec128<int> src)
            => Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> toInt64v(Vec128<uint> src)
            => Avx2.ConvertToVector128Int64(src);

    }


}