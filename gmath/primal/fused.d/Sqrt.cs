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
        public static Span<sbyte> sqrt(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<byte> sqrt(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<short> sqrt(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> sqrt(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<int> sqrt(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<uint> sqrt(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }


        [MethodImpl(NotInline)]
        public static Span<long> sqrt(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> sqrt(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<float> sqrt(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<double> sqrt(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                sqrt(src[i], out dst[i]);
            return dst;                
        }


        [MethodImpl(NotInline)]
        public static ref Span<sbyte> sqrt(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<byte> sqrt(ref Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<short> sqrt(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ushort> sqrt(ref Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<int> sqrt(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<uint> sqrt(ref Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<long> sqrt(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ulong> sqrt(ref Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<float> sqrt(ref Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<double> sqrt(ref Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                sqrt(ref io[i]);
            return ref io;
        }

    }
}