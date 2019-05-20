//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                
        [MethodImpl(NotInline)]
        public static byte parse(ReadOnlySpan<char> bs, int offset, out byte dst)
        {
            var max = Math.Min(8, bs.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bs[i] != '0')
                    enable(ref dst, pos);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        public static sbyte parse(ReadOnlySpan<char> bs, int offset, out sbyte dst)
        {
            parse(bs, offset, out byte x);
            dst = (sbyte)x;
            return dst;        
        }

        [MethodImpl(NotInline)]
        public static ushort parse(ReadOnlySpan<char> bs, int offset, out ushort dst)
        {
            var max = Math.Min(16, bs.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bs[i] != '0')
                    enable(ref dst, pos);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        public static short parse(ReadOnlySpan<char> bs, int offset, out short dst)
        {
            parse(bs, offset, out short x);
            dst = (short)x;
            return dst;
            
        }

        [MethodImpl(NotInline)]
        public static uint parse(ReadOnlySpan<char> bs, int offset, out uint dst)
        {
            var max = Math.Min(32, bs.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bs[i] != '0')
                    enable(ref dst, pos);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        public static int parse(ReadOnlySpan<char> bs, int offset, out int dst)
        {
            parse(bs, offset, out int x);
            dst = (int)x;
            return dst;            
        }

        [MethodImpl(NotInline)]
        public static ulong parse(ReadOnlySpan<char> bs, int offset, out ulong dst)
        {
            var max = Math.Min(64, bs.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bs[i] != '0')
                    enable(ref dst, pos);            
            return dst;                                                

        }

        [MethodImpl(NotInline)]
        public static long parse(ReadOnlySpan<char> bs, int offset, out long dst)
        {
            parse(bs, offset, out long x);
            dst = (long)x;
            return dst;
        }

    }
}