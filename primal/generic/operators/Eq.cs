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
    
    
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(lhs) == int8(rhs);
            else if(typeof(T) == typeof(byte))
                return uint8(lhs) == uint8(rhs);
            else if(typeof(T) == typeof(short))
                return int16(lhs) == int16(rhs);
            else if(typeof(T) == typeof(ushort))
                return uint16(lhs) == uint16(rhs);
            else if(typeof(T) == typeof(int))
                return int32(lhs) == int32(rhs);
            else if(typeof(T) == typeof(uint))
                return uint32(lhs) == uint32(rhs);
            else if(typeof(T) == typeof(long))
                return int64(lhs) == int64(rhs);
            else if(typeof(T) == typeof(ulong))
                return uint64(lhs) == uint64(rhs);
            else if(typeof(T) == typeof(float))
                return float32(lhs) == float32(rhs);
            else if(typeof(T) == typeof(double))
                return float64(lhs) == float64(rhs);
            else            
                throw unsupported<T>();
        }

        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return eq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return eq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return eq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return eq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return eq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return eq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return eq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return eq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return eq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return eq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => eq(lhs,rhs,span<bool>(length(lhs,rhs)));

        static Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        static Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

    }
}