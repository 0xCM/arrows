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

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class BitsX
    {
        public static Span128<int> ShiftR(this ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> ShiftR(this ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, in  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> ShiftR(this ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> ShiftR(this ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = Span128.Length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> ShiftR(this ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> ShiftR(this ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> ShiftR(this ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> ShiftR(this ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
       }

        public static Span128<short> ShiftR(this ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ushort> ShiftR(this ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<int> ShiftR(this ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<uint> ShiftR(this ReadOnlySpan128<uint> lhs, byte count, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<long> ShiftR(this ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ulong> ShiftR(this ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<short> ShiftR(this ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ushort> ShiftR(this ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<int> ShiftR(this ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<uint> ShiftR(this ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<long> ShiftR(this ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ulong> ShiftR(this ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.srli(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
       }


        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec128<int> lhs, in Vec128<uint> rhs, ref int dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec128<long> lhs, in Vec128<ulong> rhs, ref long dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec256<int> lhs, in Vec256<uint> rhs, ref int dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec256<long> lhs, in Vec256<ulong> rhs, ref long dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        static unsafe void shiftr(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => vstore(ShiftRightLogicalVariable(lhs, rhs), ref dst);

    }

}