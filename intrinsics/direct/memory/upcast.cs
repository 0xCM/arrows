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

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> upcast(in Vec128<sbyte> src, out Vec128<short> dst)
            => dst = ConvertToVector128Int16(src);
        
        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in Vec128<sbyte> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<sbyte> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<short> upcast(in Vec128<byte> src, out Vec128<short> dst)
            =>  dst =ConvertToVector128Int16(src);

        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in Vec128<byte> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<byte> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in  Vec128<short> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);


        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<short> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);


        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in Vec128<ushort> src, out Vec128<int> dst)
            => dst = ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<ushort> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<int> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<uint> src, out Vec128<long> dst)
            => dst = ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<short> upcast(in Vec128<sbyte> src, out Vec256<short> dst)
            => dst = ConvertToVector256Int16(src);

        [MethodImpl(Inline)]
        public static Vec256<int> upcast(in Vec128<sbyte> src, out Vec256<int> dst)
            => dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<sbyte> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<short> upcast(in Vec128<byte> src, out Vec256<short> dst)
            =>  dst = ConvertToVector256Int16(src);

        [MethodImpl(Inline)]
        public static Vec256<int> upcast(in Vec128<byte> src, out Vec256<int> dst)
            =>  dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<byte> src, out Vec256<long> dst)
            =>  dst =ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<int> upcast(in Vec128<short> src, out Vec256<int> dst)
            => dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<short> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<int> upcast(in Vec128<ushort> src, out Vec256<int> dst)
            => dst = ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<ushort> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<int> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<uint> src, out Vec256<long> dst)
            => dst = ConvertToVector256Int64(src);
    }
}