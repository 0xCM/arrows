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
        public static Span<sbyte> or(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<byte> or(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<short> or(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> or(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<int> or(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<uint> or(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<long> or(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> or(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = or(lhs[i], rhs[i]);
            return dst;                
        }
    }
}