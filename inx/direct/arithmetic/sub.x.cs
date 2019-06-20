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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;
    using static dinx;

    partial class dinxx
    {
        public static Span128<sbyte> sub(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<byte> sub(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<short> sub(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<ushort> sub(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<int> sub(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<uint> sub(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<long> sub(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<ulong> sub(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<float> sub(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<double> sub(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec128(block),rhs.ToVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<sbyte> sub(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<byte> sub(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<short> sub(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<ushort> sub(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<int> sub(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<uint> sub(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<long> sub(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<ulong> sub(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<float> sub(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<double> sub(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.ToVec256(block),rhs.ToVec256(block)), ref dst[block]);            
            return dst;            
        }


    }
}