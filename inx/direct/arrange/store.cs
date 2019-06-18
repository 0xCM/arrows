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
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, ref sbyte dst)
            => Store(pint8(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, ref byte dst)
            => Store(puint8(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, ref short dst)
            => Store(pint16(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, ref ushort dst)
            => Store(puint16(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, ref int dst)
            => Store(pint32(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, ref uint dst)
            => Store(puint32(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, ref long dst)
            => Store(pint64(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, ref ulong dst)
            => Store(puint64(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, ref float dst)
            => Store(pfloat32(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, ref double dst)
            => Store(As.pfloat64(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<sbyte> src, ref sbyte dst)
            => Store(As.pint8(ref dst), src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<byte> src, ref byte dst)
            => Store(As.puint8(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<short> src, ref short dst)
            => Store(As.pint16(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ushort> src, ref ushort dst)
            => Store(As.puint16(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<int> src, ref int dst)
            => Store(As.pint32(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<uint> src, ref uint dst)
            => Store(As.puint32(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<long> src, ref long dst)
            => Store(As.pint64(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<ulong> src, ref ulong dst)
            => Store(As.puint64(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<float> src, ref float dst)
            => Store(As.pfloat32(ref dst),src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec256<double> src, ref double dst)
            => Store(As.pfloat64(ref dst),src);            
    }

}