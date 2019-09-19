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
        public static sbyte ipow(sbyte b, uint exp)
        {
            if(exp == 0)
                return 1;

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

        public static byte ipow(byte b, uint exp)
        {
            if(exp == 0)
                return 1;
            
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

        public static short ipow(short b, uint exp)
        {
            if(exp == 0)
                return 1;

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

        public static ushort ipow(ushort b, uint exp)
        {
            if(exp == 0)
                return 1;

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

        public static int ipow(int b, uint exp)
        {
            if(exp == 0)
                return 1;

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
            if(exp == 0)
                return 1;

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

        public static long ipow(long b, uint exp)
        {
            if(exp == 0)
                return 1;
            
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

        public static ulong ipow(ulong b, uint exp)
        {
            if(exp == 0)
                return 1;
            
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
        public static ref sbyte ipow(ref sbyte src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte ipow(ref byte src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short ipow(ref short src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort ipow(ref ushort src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int ipow(ref int src, uint exp)
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
        public static ref long ipow(ref long src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong ipow(ref ulong src, uint exp)
        {
            src = ipow(src,exp);
            return ref src;
        }


        public static Span<sbyte> ipow(Span<sbyte> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<byte> ipow(Span<byte> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<short> ipow(Span<short> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<ushort> ipow(Span<ushort> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<int> ipow(Span<int> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<uint> ipow(Span<uint> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<long> ipow(Span<long> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<ulong> ipow(Span<ulong> b, ReadOnlySpan<uint> exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp[i]);
            return b;
        }

        public static Span<sbyte> ipow(Span<sbyte> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<byte> ipow(Span<byte> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<short> ipow(Span<short> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<b.Length; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<ushort> ipow(Span<ushort> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<int> ipow(Span<int> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<uint> ipow(Span<uint> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<long> ipow(Span<long> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }

        public static Span<ulong> ipow(Span<ulong> b, uint exp)
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = ipow(b[i], exp);
            return b;
        }


    }
}