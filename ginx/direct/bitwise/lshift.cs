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
    
    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> lshift(in Vec128<short> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> lshift(in Vec128<ushort> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> lshift(in Vec128<int> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> lshift(in Vec128<uint> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> lshift(in Vec128<long> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lshift(in Vec128<ulong> src, byte count)
            => ShiftLeftLogical(src, count);

        
        [MethodImpl(Inline)]
        public static Vec256<short> lshift(in Vec256<short> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> lshift(in Vec256<ushort> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> lshift(in Vec256<int> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> lshift(in Vec256<uint> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> lshift(in Vec256<long> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> lshift(in Vec256<ulong> src, byte count)
            => ShiftLeftLogical(src, count);

        [MethodImpl(Inline)]
        public static void lshift(in Vec128<short> lhs, byte count, ref short dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec128<ushort> lhs, byte count, ref ushort dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec128<int> lhs, byte count, ref int dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec128<uint> lhs, byte count, ref uint dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec128<long> lhs, byte count, ref long dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec256<short> lhs, byte count, ref short dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void  lshift(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec256<int> lhs, byte count, ref int dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec256<uint> lhs, byte count, ref uint dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec256<long> lhs, byte count, ref long dst)
            => store(lshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void lshift(in Vec256<ulong> lhs, byte count, ref ulong dst)
            => store(lshift(lhs,count), ref dst);

        public static ref Span128<short> lshift(ReadOnlySpan128<short> lhs, byte count, ref Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span128<ushort> lshift(ReadOnlySpan128<ushort> lhs, byte count, ref Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span128<int> lshift(ReadOnlySpan128<int> lhs, byte count, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span128<uint> lshift(ReadOnlySpan128<uint> lhs, byte count, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);

            return ref dst;            
        }

        public static ref Span128<long> lshift(ReadOnlySpan128<long> lhs, byte count, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span128<ulong> lshift(ReadOnlySpan128<ulong> lhs, byte count, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span256<short> lshift(ReadOnlySpan256<short> lhs, byte count, ref Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span256<ushort> lshift(ReadOnlySpan256<ushort> lhs, byte count, ref Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span256<int> lshift(ReadOnlySpan256<int> lhs, byte count, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span256<uint> lshift(ReadOnlySpan256<uint> lhs, byte count, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span256<long> lshift(ReadOnlySpan256<long> lhs, byte count, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

        public static ref Span256<ulong> lshift(ReadOnlySpan256<ulong> lhs, byte count, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = lhs.Length;
            for(var i =0; i < cells; i += width)
                lshift(lhs.VLoad(i), count, ref dst[i]);
            
            return ref dst;            
        }

    }
}