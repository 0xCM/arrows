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
    using static Spans;
    using static As;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> rshift(in Vec128<short> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> rshift(in Vec128<ushort> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> rshift(in Vec128<int> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> rshift(in Vec128<uint> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> rshift(in Vec128<long> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> rshift(in Vec128<ulong> src, byte count)
            => ShiftRightLogical(src, count);
        
        [MethodImpl(Inline)]
        public static Vec256<short> rshift(in Vec256<short> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> rshift(in Vec256<ushort> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> rshift(in Vec256<int> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> rshift(in Vec256<uint> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> rshift(in Vec256<long> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> rshift(in Vec256<ulong> src, byte count)
            => ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> rshift(in Vec128<int> src, in Vec128<uint> count)
            => ShiftRightLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> rshift(in Vec128<uint> src, in Vec128<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> rshift(in Vec128<long> src, in Vec128<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> rshift(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> rshift(in Vec256<int> src, in Vec256<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> rshift(in Vec256<uint> src, in Vec256<uint> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> rshift(in Vec256<long> src, in Vec256<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> rshift(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => ShiftRightLogicalVariable(src, shifts); 
  
        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec128<int> lhs, in Vec128<uint> rhs, ref int dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec128<long> lhs, in Vec128<ulong> rhs, ref long dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec256<int> lhs, in Vec256<uint> rhs, ref int dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec256<long> lhs, in Vec256<ulong> rhs, ref long dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void rshift(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(ShiftRightLogicalVariable(lhs, rhs), ref dst);

        public static unsafe ref Span128<int> rshift(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span128<uint> rshift(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span128<long> rshift(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span128<ulong> rshift(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span256<int> rshift(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span256<uint> rshift(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span256<long> rshift(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
        }

        public static unsafe ref Span256<ulong> rshift(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                rshift(lhs.VLoad(i), rhs.VLoad(i), ref dst[i]);            
            return ref dst;            
       }
    }
}