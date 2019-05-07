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
    using static System.Runtime.Intrinsics.X86.Avx;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> upcast(in Vec128<sbyte> src, out Vec128<short> dst)
            => dst = Avx2.ConvertToVector128Int16(src);
        
        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in Vec128<sbyte> src, out Vec128<int> dst)
            => dst = Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<sbyte> src, out Vec128<long> dst)
            => dst = Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<short> upcast(in Vec128<byte> src, out Vec128<short> dst)
            =>  dst = Avx2.ConvertToVector128Int16(src);

        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in Vec128<byte> src, out Vec128<int> dst)
            => dst = Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<byte> src, out Vec128<long> dst)
            => dst = Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in  Vec128<short> src, out Vec128<int> dst)
            => dst = Avx2.ConvertToVector128Int32(src);


        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<short> src, out Vec128<long> dst)
            => dst = Avx2.ConvertToVector128Int64(src);


        [MethodImpl(Inline)]
        public static Vec128<int> upcast(in Vec128<ushort> src, out Vec128<int> dst)
            => dst = Avx2.ConvertToVector128Int32(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<ushort> src, out Vec128<long> dst)
            => dst = Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<int> src, out Vec128<long> dst)
            => dst = Avx2.ConvertToVector128Int64(src);

        [MethodImpl(Inline)]
        public static Vec128<long> upcast(in Vec128<uint> src, out Vec128<long> dst)
            => dst = Avx2.ConvertToVector128Int64(src);


        #region 256


        [MethodImpl(Inline)]
        public static Vec256<short> upcast(in Vec128<sbyte> src, out Vec256<short> dst)
            => dst = Avx2.ConvertToVector256Int16(src);

        [MethodImpl(Inline)]
        public static Vec256<int> upcast(in Vec128<sbyte> src, out Vec256<int> dst)
            => dst = Avx2.ConvertToVector256Int32(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<sbyte> src, out Vec256<long> dst)
            => dst = Avx2.ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> upcast(in Vec128<byte> src, out Vec256<ushort> dst)
            =>  dst = Avx2.ConvertToVector256UInt16(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> upcast(in Vec128<byte> src, out Vec256<uint> dst)
            =>  dst = Avx2.ConvertToVector256UInt32(src);

        [MethodImpl(Inline)]
        public static Vec256<ulong> upcast(in Vec128<byte> src, out Vec256<ulong> dst)
            =>  dst = Avx2.ConvertToVector256UInt64(src);


        [MethodImpl(Inline)]
        public static Vec256<int> upcast(in Vec128<short> src, out Vec256<int> dst)
            => dst = Avx2.ConvertToVector256Int32(src);


        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<short> src, out Vec256<long> dst)
            => dst = Avx2.ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> upcast(in Vec128<ushort> src, out Vec256<uint> dst)
            => dst = Avx2.ConvertToVector256UInt32(src);

        [MethodImpl(Inline)]
        public static Vec256<ulong> upcast(in Vec128<ushort> src, out Vec256<ulong> dst)
            => dst = Avx2.ConvertToVector256UInt64(src);

        [MethodImpl(Inline)]
        public static Vec256<long> upcast(in Vec128<int> src, out Vec256<long> dst)
            => dst = Avx2.ConvertToVector256Int64(src);

        [MethodImpl(Inline)]
        public static Vec256<ulong> upcast(in Vec128<uint> src, out Vec256<ulong> dst)
            => dst = Avx2.ConvertToVector256UInt64(src);


       #endregion
    }

}