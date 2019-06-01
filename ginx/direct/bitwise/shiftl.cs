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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static Spans;
    
    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> shiftl(in Vec128<short> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> shiftl(in Vec128<ushort> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> shiftl(in Vec128<int> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftl(in Vec128<uint> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftl(in Vec128<long> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftl(in Vec128<ulong> src, byte count)
            => ShiftLeftLogical(src, count);

        
        [MethodImpl(Inline)]
        public static Vec256<short> shiftl(in Vec256<short> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> shiftl(in Vec256<ushort> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> shiftl(in Vec256<int> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftl(in Vec256<uint> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftl(in Vec256<long> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftl(in Vec256<ulong> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<short> lhs, byte count, ref short dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<ushort> lhs, byte count, ref ushort dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<int> lhs, byte count, ref int dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<uint> lhs, byte count, ref uint dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<long> lhs, byte count, ref long dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<short> lhs, byte count, ref short dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void  shiftl(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<int> lhs, byte count, ref int dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<uint> lhs, byte count, ref uint dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<long> lhs, byte count, ref long dst)
            => store(shiftl(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void shiftl(in Vec256<ulong> lhs, byte count, ref ulong dst)
            => store(shiftl(lhs,count), ref dst);

        public static Span128<short> shiftl(ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<ushort> shiftl(ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<int> shiftl(ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<uint> shiftl(ReadOnlySpan128<uint> lhs, byte count,  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<long> shiftl(ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<ulong> shiftl(ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<short> shiftl(ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<ushort> shiftl(ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<int> shiftl(ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<uint> shiftl(ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<long> shiftl(ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<ulong> shiftl(ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                shiftl(lhs.VLoad(i), count, ref dst[i]);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static Vec128<int> shiftl(in Vec128<int> src, in Vec128<uint> count)
            => ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> shiftl(in Vec128<uint> src, in Vec128<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> shiftl(in Vec128<long> src, in Vec128<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> shiftl(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> shiftl(in Vec256<int> src, in Vec256<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> shiftl(in Vec256<uint> src, in Vec256<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> shiftl(in Vec256<long> src, in Vec256<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> shiftl(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts); 
  
        public static Span128<int> shiftl(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> shifts, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;
        }

        public static Span128<uint> shiftl(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> shifts, in Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;
        }

        public static Span128<long> shiftl(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> shifts, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;
        }

        public static Span128<ulong> shiftl(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> shifts, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;
        }

        public static Span256<int> shiftl(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> shifts, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> shiftl(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> shifts, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> shiftl(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> shifts, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> shiftl(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> shifts, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                dinx.store(dinx.shiftl(lhs.VLoad(i),shifts.VLoad(i)), ref dst[i]);            
            return dst;            
       }
 
    }
}