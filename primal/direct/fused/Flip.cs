//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
        
    using static zfunc;

    partial class math
    {
        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static Span<byte> flip(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;
        }

        public static Span<short> flip(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static Span<ushort> flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static Span<int> flip(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static Span<uint> flip(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static Span<long> flip(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static Span<ulong> flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = flip(src[i]);
            return dst;                
        }

        public static ref Span<sbyte> flip(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<byte> flip(ref Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<short> flip(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<ushort> flip(ref Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<int> flip(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<uint> flip(ref Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<long> flip(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        public static ref Span<ulong> flip(ref Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                flip(ref io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<byte> flip(ReadOnlySpan<byte> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<short> flip(ReadOnlySpan<short> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<ushort> flip(ReadOnlySpan<ushort> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<int> flip(ReadOnlySpan<int> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<uint> flip(ReadOnlySpan<uint> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<long> flip(ReadOnlySpan<long> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<ulong> flip(ReadOnlySpan<ulong> src)
        {
            var dst = src.Replicate();
            return flip(ref dst);            
        }
    }
}