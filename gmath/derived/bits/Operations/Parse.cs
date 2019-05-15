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
        public static byte parse(string bitstring, int offset, out byte dst)
        {
            var max = Math.Min(8, bitstring.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bitstring[i] != '0')
                    set(ref dst, pos);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        public static sbyte parse(string bitstring, int offset, out sbyte dst)
        {
            parse(bitstring, offset, out byte x);
            dst = (sbyte)x;
            return dst;
            

        }

        [MethodImpl(NotInline)]
        public static ushort parse(string bitstring, int offset, out ushort dst)
        {
            var max = Math.Min(16, bitstring.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bitstring[i] != '0')
                    set(ref dst, pos);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        public static short parse(string bitstring, int offset, out short dst)
        {
            parse(bitstring, offset, out short x);
            dst = (short)x;
            return dst;
            
        }

        [MethodImpl(NotInline)]
        public static uint parse(string bitstring, int offset, out uint dst)
        {
            var max = Math.Min(32, bitstring.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bitstring[i] != '0')
                    set(ref dst, pos);            
            return dst;                                                
        }

        [MethodImpl(NotInline)]
        public static int parse(string bitstring, int offset, out int dst)
        {
            parse(bitstring, offset, out int x);
            dst = (int)x;
            return dst;            
        }

        [MethodImpl(NotInline)]
        public static ulong parse(string bitstring, int offset, out ulong dst)
        {
            var max = Math.Min(64, bitstring.Length);            
            var pos = max - 1;
            dst = 0;
            for(var i = offset; i< max; i++, pos--)
                if(bitstring[i] != '0')
                    set(ref dst, pos);            
            return dst;                                                

        }

        [MethodImpl(NotInline)]
        public static long parse(string bitstring, int offset, out long dst)
        {
            parse(bitstring, offset, out long x);
            dst = (long)x;
            return dst;
        }

    }
}