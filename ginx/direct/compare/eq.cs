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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    
    partial class dinx
    {   
        public static Span<Bit> eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
        {
            var len = Vec128<byte>.Length;
            Span<byte> src = stackalloc byte[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
        {
            var len = Vec128<sbyte>.Length;
            Span<sbyte> src = stackalloc sbyte[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<short> lhs, in Vec128<short> rhs)
        {
            var len = Vec128<short>.Length;
            Span<short> src = stackalloc short[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
        {
            var len = Vec128<ushort>.Length;
            Span<ushort> src = stackalloc ushort[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<int> lhs, in Vec128<int> rhs)
        {
            var len = Vec128<int>.Length;
            Span<int> src = stackalloc int[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
        {
            var len = Vec128<uint>.Length;
            Span<uint> src = stackalloc uint[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<long> lhs, in Vec128<long> rhs)
        {
            var len = Vec128<long>.Length;
            Span<long> src = stackalloc long[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }
        public static Span<Bit> eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
        {
            var len = Vec128<ulong>.Length;
            Span<ulong> src = stackalloc ulong[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec128<float> lhs, in Vec128<float> rhs)
        {
            var len = Vec128<uint>.Length;
            Span<uint> src = stackalloc uint[len];
            store(CompareEqual(lhs, rhs).AsUInt32(), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }
            
        
        public static Span<Bit> eq(in Vec128<double> lhs, in Vec128<double> rhs)
        {
            var len = Vec128<ulong>.Length;
            Span<ulong> src = stackalloc ulong[len];
            store(CompareEqual(lhs, rhs).AsUInt64(), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
        {
            var len = Vec256<byte>.Length;
            Span<byte> src = stackalloc byte[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
        {
            var len = Vec256<sbyte>.Length;
            Span<sbyte> src = stackalloc sbyte[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        // {
        //     var result = CompareEqual(lhs, rhs);
        //     var x0 = extract(result, 0);
        //     var x1 = extract(result, 1);
        //     var dst = new Bit[32];
            
        //     for(byte i = 0; i< 16; i++)
        //         dst[i] = extract(x0, i);

        //     for(byte j = 0; j< 16; j++)
        //         dst[16 + j] = extract(x0, j);
            
        //     return dst;
        // }

        public static Span<Bit> eq(in Vec256<short> lhs, in Vec256<short> rhs)
        {
            var len = Vec256<short>.Length;
            Span<short> src = stackalloc short[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }


        public static Span<Bit> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
        {
            var len = Vec256<ushort>.Length;
            Span<ushort> src = stackalloc ushort[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec256<int> lhs, in Vec256<int> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract (result, 1);
            return new Bit[]{
                extract(x0, 0), extract(x0, 1), extract(x0, 2), extract(x0, 3),
                extract(x1, 0), extract(x1, 1), extract(x1, 2), extract(x1, 3)};
        }


        public static Span<Bit> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            var x0 = extract(result, 0);
            var x1 = extract (result, 1);
            return new Bit[]{            
                extract(x0, 0), extract(x0, 1), extract(x0, 2), extract(x0, 3),
                extract(x1, 0), extract(x1, 1), extract(x1, 2), extract(x1, 3)};                                              
        }

        public static Span<Bit> eq(in Vec256<long> lhs, in Vec256<long> rhs)
        {
            var len = Vec256<long>.Length;
            Span<long> src = stackalloc long[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
        {
            var len = Vec256<ulong>.Length;
            Span<ulong> src = stackalloc ulong[len];
            store(CompareEqual(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

    }
}