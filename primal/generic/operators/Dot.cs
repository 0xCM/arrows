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
        public static T dot<T>(in ReadOnlySpan<T> lhs, in ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dot(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dot(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dot(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dot(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dot(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dot(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dot(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dot(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dot(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dot(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }
 
        static sbyte dot(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(sbyte);
            for(var i = 0; i< len; i++)
                dst += (sbyte)(lhs[i] * rhs[i]);
            return dst;                
        }

        static byte dot(ReadOnlySpan<byte> lhs,ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(byte);
            for(var i = 0; i< len; i++)
                dst += (byte)(lhs[i] * rhs[i]);
            return dst;                
        }

        static short dot(ReadOnlySpan<short> lhs,ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(short);
            for(var i = 0; i< len; i++)
                dst += (short)(lhs[i] * rhs[i]);
            return dst;                
        }

        static ushort dot(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ushort);
            for(var i = 0; i< len; i++)
                dst += (ushort)(lhs[i] * rhs[i]);
            return dst;                
        }

        static int dot(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(int);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        static uint dot(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(uint);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        static long dot(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(long);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        static ulong dot(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ulong);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        static float dot(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(float);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        static double dot(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(double);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

    }

}