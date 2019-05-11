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

    partial class math
    {

        [MethodImpl(NotInline)]
        public static Span<sbyte> add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<byte> add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = (byte)(lhs[i] + rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<short> add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<int> add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<uint> add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<long> add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
            {
                dst[i] = add(lhs[i], rhs[i]);
            }
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<float> add(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<double> add(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = add(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<sbyte> add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => add(lhs,rhs,span<sbyte>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<byte> add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => add(lhs,rhs,span<byte>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<short> add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => add(lhs,rhs,span<short>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<ushort> add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => add(lhs,rhs,span<ushort>(length(lhs,rhs)));
   
        [MethodImpl(NotInline)]
        public static Span<int> add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => add(lhs,rhs,span<int>(length(lhs,rhs)));
   
        [MethodImpl(NotInline)]
        public static Span<uint> add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => add(lhs,rhs,span<uint>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<long> add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => add(lhs,rhs,span<long>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<ulong> add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => add(lhs,rhs,span<ulong>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<float> add(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => add(lhs,rhs,span<float>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<double> add(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => add(lhs,rhs,span<double>(length(lhs,rhs)));
 
 
        [MethodImpl(Inline)]
        public static Span<sbyte> add(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => add(lhs,rhs,lhs);
 
        [MethodImpl(Inline)]
        public static Span<byte> add(Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => add(lhs,rhs,lhs);
 
        [MethodImpl(Inline)]
        public static Span<short> add(Span<short> lhs, ReadOnlySpan<short> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<ushort> add(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<int> add(Span<int> lhs, ReadOnlySpan<int> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<uint> add(Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<long> add(Span<long> lhs, ReadOnlySpan<long> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<ulong> add(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<float> add(Span<float> lhs, ReadOnlySpan<float> rhs)
            => add(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<double> add(Span<double> lhs, ReadOnlySpan<double> rhs)
            => add(lhs,rhs,lhs);


    }
}