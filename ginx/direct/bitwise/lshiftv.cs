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
    using static Spans;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<int> lshift(in Vec128<int> src, in Vec128<uint> count)
            => ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> lshift(in Vec128<uint> src, in Vec128<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> lshift(in Vec128<long> src, in Vec128<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lshift(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> lshift(in Vec256<int> src, in Vec256<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> lshift(in Vec256<uint> src, in Vec256<uint> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> lshift(in Vec256<long> src, in Vec256<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> lshift(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => ShiftLeftLogicalVariable(src, shifts); 
  
        public static ref Span128<int> lshift(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> shifts, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<uint> lshift(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> shifts, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<long> lshift(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> shifts, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<ulong> lshift(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> shifts, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<int> lshift(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> shifts, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<uint> lshift(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> shifts, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<long> lshift(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> shifts, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<ulong> lshift(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> shifts, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = shifts.VLoad(i);
                dinx.store(dinx.lshift(x,y), ref dst[i]);
            }
            
            return ref dst;            
       }
    }
}