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
        public static Span<sbyte> sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<byte> sub(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<short> sub(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> sub(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<int> sub(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<uint> sub(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<long> sub(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> sub(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<float> sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<double> sub(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = sub(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<sbyte> sub(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => sub(lhs,rhs,lhs);
 
        [MethodImpl(Inline)]
        public static Span<byte> sub(Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => sub(lhs,rhs,lhs);
 
        [MethodImpl(Inline)]
        public static Span<short> sub(Span<short> lhs, ReadOnlySpan<short> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<ushort> sub(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<int> sub(Span<int> lhs, ReadOnlySpan<int> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<uint> sub(Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<long> sub(Span<long> lhs, ReadOnlySpan<long> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<ulong> sub(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<float> sub(Span<float> lhs, ReadOnlySpan<float> rhs)
            => sub(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<double> sub(Span<double> lhs, ReadOnlySpan<double> rhs)
            => sub(lhs,rhs,lhs);


    }
}