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
        public static Span<sbyte> shiftl(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> shiftl(ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<short> shiftl(ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ushort> shiftl(ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<int> shiftl(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<uint> shiftl(ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<long> shiftl(ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ulong> shiftl(ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs[i]);
            return dst;                
        }
 
        public static Span<sbyte> shiftl(ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<byte> shiftl(ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<short> shiftl(ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<ushort> shiftl(ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<int> shiftl(ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<uint> shiftl(ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<long> shiftl(ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<ulong> shiftl(ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {            
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftl(lhs[i], rhs);
            return dst;                
        }

        public static Span<sbyte> shiftl(Span<sbyte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<byte> shiftl(Span<byte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<short> shiftl(Span<short> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<ushort> shiftl(Span<ushort> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<int> shiftl(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<uint> shiftl(Span<uint> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<long> shiftl(Span<long> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<ulong> shiftl(Span<ulong> lhs, int rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        public static Span<sbyte> shiftl(Span<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<byte> shiftl(Span<byte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<short> shiftl(Span<short> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<ushort> shiftl(Span<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<int> shiftl(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<uint> shiftl(Span<uint> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<long> shiftl(Span<long> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        public static Span<ulong> shiftl(Span<ulong> lhs, ReadOnlySpan<int> rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

    }
}