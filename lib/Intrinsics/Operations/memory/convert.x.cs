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

    partial class InXX
    {

        [MethodImpl(Inline)]
        public static Vec128<short> ToInt16Vec(this Vec128<sbyte> src)
            => Avx2.ConvertToVector128Int16(src);

        [MethodImpl(Inline)]
        public static Vec128<int> ToInt32Vec(this Vec128<sbyte> src)
            => Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> ToInt64Vec(this Vec128<sbyte> src)
            => Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<short> toInt16Vec(this Vec128<byte> src)
            =>  Avx2.ConvertToVector128Int16(src);

        [MethodImpl(Inline)]
        public static Vec128<int> ToInt32Vec(this Vec128<byte> src)
            => Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> ToInt64Vec(this Vec128<byte> src)
            => Avx2.ConvertToVector128Int64(src);


        [MethodImpl(Inline)]
        public static Vec128<int> ToInt32Vec(this Vec128<short> src)
            => Avx2.ConvertToVector128Int32(src);


        [MethodImpl(Inline)]
        public static Vec128<long> ToInt64Vec(this Vec128<short> src)
            => Avx2.ConvertToVector128Int64(src);


        [MethodImpl(Inline)]
        public static Vec128<int> ToInt32Vec(this Vec128<ushort> src)
            => Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> ToInt64Vec(this Vec128<ushort> src)
            => Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> ToInt64Vec(this Vec128<int> src)
            => Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> ToInt64Vec(this Vec128<uint> src)
            => Avx2.ConvertToVector128Int64(src);

    }


}