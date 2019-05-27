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
    
    using static zfunc;    
    using static Spans;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static void rshift(in Vec128<short> lhs, byte count, ref short dst)
           => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec128<ushort> lhs, byte count, ref ushort dst)
           => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec128<int> lhs, byte count, ref int dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec128<uint> lhs, byte count, ref uint dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec128<long> lhs, byte count, ref long dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec128<ulong> lhs, byte count, ref ulong dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec256<short> lhs, byte count, ref short dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec256<ushort> lhs, byte count, ref ushort dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec256<int> lhs, byte count, ref int dst)
            => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec256<uint> lhs, byte count, ref uint dst)
           => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec256<long> lhs, byte count, ref long dst)
           => store(rshift(lhs,count), ref dst);

        [MethodImpl(Inline)]
        public static void rshift(in Vec256<ulong> lhs, byte count, ref ulong dst)
           => store(rshift(lhs,count), ref dst);

        public static ref Span128<short> rshift(ReadOnlySpan128<short> lhs, byte count, ref Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span128<ushort> rshift(ReadOnlySpan128<ushort> lhs, byte count, ref Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span128<int> rshift(ReadOnlySpan128<int> lhs, byte count, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span128<uint> rshift(ReadOnlySpan128<uint> lhs, byte count, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span128<long> rshift(ReadOnlySpan128<long> lhs, byte count, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span128<ulong> rshift(ReadOnlySpan128<ulong> lhs, byte count, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span256<short> rshift(ReadOnlySpan256<short> lhs, byte count, ref Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span256<ushort> rshift(ReadOnlySpan256<ushort> lhs, byte count, ref Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span256<int> rshift(ReadOnlySpan256<int> lhs, byte count, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span256<uint> rshift(ReadOnlySpan256<uint> lhs, byte count, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span256<long> rshift(ReadOnlySpan256<long> lhs, byte count, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

        public static ref Span256<ulong> rshift(ReadOnlySpan256<ulong> lhs, byte count, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                store(rshift(lhs.VLoad(i), count), ref dst[i]);
            return ref dst;            
        }

    }

}