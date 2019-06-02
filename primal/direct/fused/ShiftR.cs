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
        public static Span<sbyte> shiftr(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> shiftr(ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<short> shiftr(ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ushort> shiftr(ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<int> shiftr(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<uint> shiftr(ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<long> shiftr(ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ulong> shiftr(ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs[i]);
            return dst;                
        }
 
         public static Span<sbyte> shiftr(ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<byte> shiftr(ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<short> shiftr(ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<ushort> shiftr(ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<int> shiftr(ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<uint> shiftr(ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<long> shiftr(ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<ulong> shiftr(ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = shiftr(lhs[i], rhs);
            return dst;                
        }


        public static Span<sbyte> shiftr(Span<sbyte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<byte> shiftr(Span<byte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<short> shiftr(Span<short> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<ushort> shiftr(Span<ushort> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<int> shiftr(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<uint> shiftr(Span<uint> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<long> shiftr(Span<long> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<ulong> shiftr(Span<ulong> lhs, int rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

 
         public static Span<sbyte> shiftr(Span<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<byte> shiftr(Span<byte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<short> shiftr(Span<short> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<ushort> shiftr(Span<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<int> shiftr(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<uint> shiftr(Span<uint> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<long> shiftr(Span<long> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<ulong> shiftr(Span<ulong> lhs, ReadOnlySpan<int> rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

    }
}