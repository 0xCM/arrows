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

    using static mfunc;
    using static zfunc;

    partial class math
    {

        [MethodImpl(NotInline)]
        public static Span<sbyte> dec(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<byte> dec(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<short> dec(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> dec(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<int> dec(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<uint> dec(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<long> dec(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> dec(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<float> dec(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<double> dec(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;                
        }


        [MethodImpl(NotInline)]
        public static ref Span<sbyte> dec(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<byte> dec(ref Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<short> dec(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ushort> dec(ref Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<int> dec(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<uint> dec(ref Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<long> dec(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ulong> dec(ref Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

       [MethodImpl(NotInline)]
        public static ref Span<float> dec(ref Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<double> dec(ref Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return ref io;
        }


    }
}