//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    using static Constants;
    
    partial class math
    {
        // See https://stackoverflow.com/questions/101439/the-most-efficient-way-to-implement-an-integer-based-power-function-powint-int
        public static sbyte ipow(sbyte b, sbyte exp)
        {
            if(exp < 0)
                return 0;

            var result = (sbyte)1;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;                
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static byte ipow(byte b, byte exp)
        {
            var result = (byte)1;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static short ipow(short b, short exp)
        {
            if(exp < 0)
                return 0;

            var result = (short)1;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;                
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static ushort ipow(ushort b, ushort exp)
        {
            var result = (ushort)1;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;                
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static int ipow(int b, int exp)
        {
            if(exp < 0)
                return 0;

            var result = 1;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;                
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static uint ipow(uint b, uint exp)
        {
            var result = 1u;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static long ipow(long b, long exp)
        {
            if(exp < 0)
                return 0;
            
            var result = 1L;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }

        public static ulong ipow(ulong b, ulong exp)
        {
            var result = 1ul;
            while(true)
            {
                if((exp & 1) != 0)
                    result *= b;
                exp >>= 1;
                if(exp == 0)
                    break;
                b *= b;
            }
            return result;
        }
 
        [MethodImpl(Inline)]
        public static ref sbyte ipow(ref sbyte src, sbyte exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte ipow(ref byte src, byte exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short ipow(ref short src, short exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort ipow(ref ushort src, ushort exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int ipow(ref int src, int exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint ipow(ref uint src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long ipow(ref long src, long exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong ipow(ref ulong src, ulong exp)
        {
            src = ipow(src,exp);
            return ref src;
        }


        public static Span<sbyte> ipow(Span<sbyte> b, ReadOnlySpan<sbyte> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<byte> ipow(Span<byte> b, ReadOnlySpan<byte> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<short> ipow(Span<short> b, ReadOnlySpan<short> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<ushort> ipow(Span<ushort> b, ReadOnlySpan<ushort> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<int> ipow(Span<int> b, ReadOnlySpan<int> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<uint> ipow(Span<uint> b, ReadOnlySpan<uint> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<long> ipow(Span<long> b, ReadOnlySpan<long> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<ulong> ipow(Span<ulong> b, ReadOnlySpan<ulong> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<sbyte> ipow(Span<sbyte> b, sbyte exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<byte> ipow(Span<byte> b, byte exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<short> ipow(Span<short> b, short exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<ushort> ipow(Span<ushort> b, ushort exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<int> ipow(Span<int> b, int exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<uint> ipow(Span<uint> b, uint exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<long> ipow(Span<long> b, long exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<ulong> ipow(Span<ulong> b, ulong exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }


    }
}