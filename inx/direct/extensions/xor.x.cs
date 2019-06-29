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
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    using static zfunc;
    using static Span256;
    using static Span128;
    using static dinx;
    partial class dinxx
    {

        public static Span128<sbyte> xor(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<byte> xor(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<short> xor(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<ushort> xor(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<int> xor(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> xor(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> xor(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> xor(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }


        public static Span128<double> xor(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<sbyte> xor(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<byte> xor(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<short> xor(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<ushort> xor(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> xor(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> xor(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> xor(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> xor(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<float> xor(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<double> xor(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec256(i), rhs.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }        

        public static Span128<float> xor(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                store(Xor(lhs.LoadVec128(i), rhs.LoadVec128(i)), ref dst[i]);            
            return dst;            
        }

    }

}