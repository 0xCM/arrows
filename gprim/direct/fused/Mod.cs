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
        [MethodImpl(NotInline)]
        public static Span<sbyte> mod(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
            return dst;                
        }


        [MethodImpl(NotInline)]
        public static Span<byte> mod(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        [MethodImpl(NotInline)]
        public static void mod(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }




    }
}