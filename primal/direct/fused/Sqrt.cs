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
        public static Span<sbyte> sqrt(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<byte> sqrt(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;
        }

        public static Span<short> sqrt(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<ushort> sqrt(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<int> sqrt(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<uint> sqrt(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<long> sqrt(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<ulong> sqrt(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<float> sqrt(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<double> sqrt(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<sbyte> sqrt(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<byte> sqrt(Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<short> sqrt(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<ushort> sqrt(Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<int> sqrt(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<uint> sqrt(Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<long> sqrt(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<ulong> sqrt(Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<float> sqrt(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

        public static Span<double> sqrt(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return io;
        }

    }
}