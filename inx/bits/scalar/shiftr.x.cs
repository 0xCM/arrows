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
    
    public static partial class ShiftX
    {
        public static Span<sbyte> ShiftR(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> ShiftR(this ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<short> ShiftR(this ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ushort> ShiftR(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<int> ShiftR(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<uint> ShiftR(this ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<long> ShiftR(this ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ulong> ShiftR(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }
 
         public static Span<sbyte> ShiftR(this ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<byte> ShiftR(this ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<short> ShiftR(this ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<ushort> ShiftR(this ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<int> ShiftR(this ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<uint> ShiftR(this ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<long> ShiftR(this ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<ulong> ShiftR(this ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }


        public static Span<sbyte> ShiftR(this Span<sbyte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<byte> ShiftR(this Span<byte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<short> ShiftR(this Span<short> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<ushort> ShiftR(this Span<ushort> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<int> ShiftR(this Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<uint> ShiftR(this Span<uint> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<long> ShiftR(this Span<long> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<ulong> ShiftR(this Span<ulong> lhs, int rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

 
         public static Span<sbyte> ShiftR(this Span<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<byte> ShiftR(this Span<byte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<short> ShiftR(this Span<short> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<ushort> ShiftR(this Span<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<int> ShiftR(this Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<uint> ShiftR(this Span<uint> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<long> ShiftR(this Span<long> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<ulong> ShiftR(this Span<ulong> lhs, ReadOnlySpan<int> rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

    }
}