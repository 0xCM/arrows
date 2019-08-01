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

    partial class dinxx
    {

        public static Span128<int> ShiftR(this ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> ShiftR(this ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, in  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> ShiftR(this ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> ShiftR(this ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> ShiftR(this ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> ShiftR(this ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> ShiftR(this ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> ShiftR(this ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
       }

        public static Span128<short> ShiftR(this ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ushort> ShiftR(this ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<int> ShiftR(this ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<uint> ShiftR(this ReadOnlySpan128<uint> lhs, byte count, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<long> ShiftR(this ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ulong> ShiftR(this ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<short> ShiftR(this ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ushort> ShiftR(this ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<int> ShiftR(this ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<uint> ShiftR(this ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<long> ShiftR(this ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ulong> ShiftR(this ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                dinx.store(dinx.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
       }

    }

}