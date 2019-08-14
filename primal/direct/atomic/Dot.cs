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
        public static sbyte dot(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(sbyte);
            for(var i = 0; i< len; i++)
                dst += (sbyte)(lhs[i] * rhs[i]);
            return dst;                
        }

        public static byte dot(ReadOnlySpan<byte> lhs,ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(byte);
            for(var i = 0; i< len; i++)
                dst += (byte)(lhs[i] * rhs[i]);
            return dst;                
        }

        public static short dot(ReadOnlySpan<short> lhs,ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(short);
            for(var i = 0; i< len; i++)
                dst += (short)(lhs[i] * rhs[i]);
            return dst;                
        }

        public static ushort dot(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ushort);
            for(var i = 0; i< len; i++)
                dst += (ushort)(lhs[i] * rhs[i]);
            return dst;                
        }

        public static int dot(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(int);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static uint dot(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(uint);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static long dot(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(long);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static ulong dot(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(ulong);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static float dot(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(float);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

        public static double dot(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            var dst = default(double);
            for(var i = 0; i< len; i++)
                dst += lhs[i] * rhs[i];
            return dst;                
        }

    }

}