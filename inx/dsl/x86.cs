//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;    

    public static partial class x86
    {
        [MethodImpl(Inline)]
        static Vector128<sbyte> v8i(in m128i src)
            => (Vector128<sbyte>)src;

        [MethodImpl(Inline)]
        static Vector128<byte> v8u(in m128i src)
            => (Vector128<byte>)src;

        [MethodImpl(Inline)]
        static Vector128<short> v16i(in m128i src)
            => (Vector128<short>)src;

        [MethodImpl(Inline)]
        static Vector128<ushort> v16u(in m128i src)
            => (Vector128<ushort>)src;

        [MethodImpl(Inline)]
        static Vector128<int> v32i(in m128i src)
            => (Vector128<int>)src;

        [MethodImpl(Inline)]
        static Vector128<uint> v32u(in m128i src)
            => (Vector128<uint>)src;

        [MethodImpl(Inline)]
        static Vector128<long> v64i(in m128i src)
            => (Vector128<long>)src;

        [MethodImpl(Inline)]
        static Vector128<ulong> v64u(in m128i src)
            => (Vector128<ulong>)src;


        [MethodImpl(Inline)]
        static Vector256<sbyte> v8i(in m256i src)
            => (Vector256<sbyte>)src;

        [MethodImpl(Inline)]
        static Vector256<byte> v8u(in m256i src)
            => (Vector256<byte>)src;

        [MethodImpl(Inline)]
        static Vector256<short> v16i(in m256i src)
            => (Vector256<short>)src;

        [MethodImpl(Inline)]
        static Vector256<ushort> v16u(in m256i src)
            => (Vector256<ushort>)src;

        [MethodImpl(Inline)]
        static Vector256<int> v32i(in m256i src)
            => (Vector256<int>)src;

        [MethodImpl(Inline)]
        static Vector256<uint> v32u(in m256i src)
            => (Vector256<uint>)src;

        [MethodImpl(Inline)]
        static Vector256<long> v64i(in m256i src)
            => (Vector256<long>)src;

        [MethodImpl(Inline)]
        static Vector256<ulong> v64u(in m256i src)
            => (Vector256<ulong>)src;

        [MethodImpl(Inline)]
        static Vector256<float> v32f(in m256 src)
            => src;

        [MethodImpl(Inline)]
        static Vector256<double> v32d(in m256d src)
            => src;

        [MethodImpl(Inline)]
        static m256i lo(in m512i src)
            => src.v0;

        [MethodImpl(Inline)]
        static m256i hi(in m512i src)
            => src.v1;

        [MethodImpl(Inline)]
        static m512i pack(in m256i lo, in m256i hi)
            => new m512i(lo,hi);


    }



}