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
        [MethodImpl(Inline)]
        public static ref ulong ilog2(ref ulong dst, ref ulong x, ulong power)
        {
            if(x >= 1ul << (int)power)
            {
                x >>= (int)power;
                dst |= power;
            }
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ulong ilog2(ulong src)
        {
            var x = 0ul;
            var y = src;
            ilog2(ref x, ref y, Pow2.T05);
            ilog2(ref x, ref y, Pow2.T04);
            ilog2(ref x, ref y, Pow2.T03);
            ilog2(ref x, ref y, Pow2.T02);
            ilog2(ref x, ref y, Pow2.T01);
            
            if(y >= 1 << 1)
                x |= 1;
            return x;
        }

        [MethodImpl(Inline)]
        public static ulong ilog2(int src)
            => ilog2((ulong)src);

        [MethodImpl(Inline)]
        public static ulong ilog2(uint src)
            => ilog2((ulong)src);

        [MethodImpl(Inline)]
        public static sbyte log2(sbyte src)
            => (sbyte)MathF.Log2(src);


        [MethodImpl(Inline)]
        public static int log2(int src)
            => (int)MathF.Log2(src);


        [MethodImpl(Inline)]
        public static long log2(long src)
            => (long)Math.Log2(src);

        [MethodImpl(Inline)]
        public static ulong log2(ulong src)
            => (ulong)Math.Log2(src);


        [MethodImpl(Inline)]
        public static sbyte ln(sbyte src)
            => (sbyte)Math.Log(src);

        [MethodImpl(Inline)]
        public static byte ln(byte src)
            => (byte)Math.Log(src);

        [MethodImpl(Inline)]
        public static short ln(short src)
            => (short)Math.Log(src);

        [MethodImpl(Inline)]
        public static ushort ln(ushort src)
            => (ushort)Math.Log(src);

        [MethodImpl(Inline)]
        public static int ln(int src)
            => (int)Math.Log(src);

        [MethodImpl(Inline)]
        public static uint ln(uint src)
            => (uint)Math.Log(src);

        [MethodImpl(Inline)]
        public static long ln(long src)
            => (long)Math.Log(src);

        [MethodImpl(Inline)]
        public static ulong ln(ulong src)
            => (ulong)Math.Log(src);


        [MethodImpl(Inline)]
        public static sbyte log(sbyte src, sbyte? @base = null)
            => (sbyte)MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static byte log(byte src, byte? @base = null)
            => (byte)MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static short log(short src, short? @base = null)
            => (short)MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static ushort log(ushort src, ushort? @base = null)
            => (ushort)MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static int log(int src, int? @base = null)
            => (int)MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static uint log(uint src, uint? @base = null)
            => (uint)MathF.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static long log(long src, long? @base = null)
            => (long)Math.Log(src, @base ?? 10);

        [MethodImpl(Inline)]
        public static ulong log(ulong src, ulong? @base = null)
            => (ulong)Math.Log(src, @base ?? 10);


    }

}