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

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> shiftr(in Vec128<short> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shiftr(in Vec128<ushort> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftr(in Vec128<int> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftr(in Vec128<uint> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftr(in Vec128<long> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftr(in Vec128<ulong> src, byte count)
            => ShiftRightLogical(src, count);
        
        [MethodImpl(Inline)]
        public static Vec256<short> shiftr(in Vec256<short> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> shiftr(in Vec256<ushort> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> shiftr(in Vec256<int> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftr(in Vec256<uint> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftr(in Vec256<long> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftr(in Vec256<ulong> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftr(in Vec128<int> src, in Vec128<uint> count)
            => ShiftRightLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftr(in Vec128<uint> src, in Vec128<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftr(in Vec128<long> src, in Vec128<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftr(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> shiftr(in Vec256<int> src, in Vec256<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftr(in Vec256<uint> src, in Vec256<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftr(in Vec256<long> src, in Vec256<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftr(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts); 
  
        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<int> lhs, in Vec128<uint> rhs, ref int dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<long> lhs, in Vec128<ulong> rhs, ref long dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<int> lhs, in Vec256<uint> rhs, ref int dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<long> lhs, in Vec256<ulong> rhs, ref long dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void shiftr(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        public static Span128<int> shiftr(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> shiftr(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, in  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> shiftr(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> shiftr(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> shiftr(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> shiftr(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> shiftr(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> shiftr(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
       }
 
        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<short> lhs, byte count, ref short dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<ushort> lhs, byte count, ref ushort dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<int> lhs, byte count, ref int dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<uint> lhs, byte count, ref uint dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<long> lhs, byte count, ref long dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<short> lhs, byte count, ref short dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<int> lhs, byte count, ref int dst)
            => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<uint> lhs, byte count, ref uint dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<long> lhs, byte count, ref long dst)
           => store(shiftr(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftr(in Vec256<ulong> lhs, byte count, ref ulong dst)
           => store(shiftr(lhs,count), ref dst);

        public static Span128<short> shiftr(ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ushort> shiftr(ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<int> shiftr(ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<uint> shiftr(ReadOnlySpan128<uint> lhs, byte count, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<long> shiftr(ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ulong> shiftr(ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<short> shiftr(ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ushort> shiftr(ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<int> shiftr(ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<uint> shiftr(ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<long> shiftr(ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ulong> shiftr(ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
       }
    }
}