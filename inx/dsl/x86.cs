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
        static Vector128<sbyte> v8i(m128i src)
            => (Vector128<sbyte>)src;

        [MethodImpl(Inline)]
        static Vector128<byte> v8u(m128i src)
            => (Vector128<byte>)src;

        [MethodImpl(Inline)]
        static Vector128<short> v16i(m128i src)
            => (Vector128<short>)src;

        [MethodImpl(Inline)]
        static Vector128<ushort> v16u(m128i src)
            => (Vector128<ushort>)src;

        [MethodImpl(Inline)]
        static Vector128<int> v32i(m128i src)
            => (Vector128<int>)src;

        [MethodImpl(Inline)]
        static Vector128<uint> v32u(m128i src)
            => (Vector128<uint>)src;

        [MethodImpl(Inline)]
        static Vector128<long> v64i(m128i src)
            => (Vector128<long>)src;

        [MethodImpl(Inline)]
        static Vector128<ulong> v64u(m128i src)
            => (Vector128<ulong>)src;


        [MethodImpl(Inline)]
        static Vector256<sbyte> v8i(m256i src)
            => (Vector256<sbyte>)src;

        [MethodImpl(Inline)]
        static Vector256<byte> v8u(m256i src)
            => (Vector256<byte>)src;

        [MethodImpl(Inline)]
        static Vector256<short> v16i(m256i src)
            => (Vector256<short>)src;

        [MethodImpl(Inline)]
        static Vector256<ushort> v16u(m256i src)
            => (Vector256<ushort>)src;

        [MethodImpl(Inline)]
        static Vector256<int> v32i(m256i src)
            => (Vector256<int>)src;

        [MethodImpl(Inline)]
        static Vector256<uint> v32u(m256i src)
            => (Vector256<uint>)src;

        [MethodImpl(Inline)]
        static Vector256<long> v64i(m256i src)
            => (Vector256<long>)src;

        [MethodImpl(Inline)]
        static Vector256<ulong> v64u(m256i src)
            => (Vector256<ulong>)src;

        [MethodImpl(Inline)]
        static Vector256<float> v32f(m256 src)
            => src;

        [MethodImpl(Inline)]
        static Vector256<double> v32d(m256d src)
            => src;
    }



}