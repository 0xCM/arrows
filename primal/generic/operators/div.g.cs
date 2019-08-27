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
        public static T div<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) / int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) / uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) / int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) / uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) / int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) / uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) / int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) / uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(float32(lhs) / float32(rhs));
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(lhs) / float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.div(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.div(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.div(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.div(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.div(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.div(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.div(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.div(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 math.div(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 math.div(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                div(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                div(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                div(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                div(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                div(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                div(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                div(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                div(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                div(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                div(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => div(lhs,rhs, span<T>(length(lhs,rhs)));

        
        [MethodImpl(Inline)]
        public static ref Span<T> div<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                div(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                div(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                div(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                div(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                div(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                div(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                div(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                div(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                div(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                div(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        static Span<sbyte> div(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;                
        }


        static Span<byte> div(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<short> div(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<ushort> div(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<int> div(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<uint> div(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<long> div(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<ulong> div(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<float> div(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<double> div(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        static Span<sbyte> div(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<byte> div(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<short> div(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<ushort> div(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<int> div(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<uint> div(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<long> div(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<ulong> div(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<float> div(Span<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        static Span<double> div(Span<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

    }
}
