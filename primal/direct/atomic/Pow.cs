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
        public static sbyte pow(sbyte b, sbyte exp)
        {
            if(exp < 0)
                return 0;

            var result = I8One;
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

        public static byte pow(byte b, byte exp)
        {
            var result = U8One;
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

        public static short pow(short b, short exp)
        {
            if(exp < 0)
                return 0;

            var result = I16One;
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

        public static ushort pow(ushort b, ushort exp)
        {
            var result = U16One;
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

        public static int pow(int b, int exp)
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

        public static uint pow(uint b, uint exp)
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

        public static long pow(long b, long exp)
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

        public static ulong pow(ulong b, ulong exp)
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
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);
 
        public static Span<sbyte> pow(Span<sbyte> b, ReadOnlySpan<sbyte> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<byte> pow(Span<byte> b, ReadOnlySpan<byte> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<short> pow(Span<short> b, ReadOnlySpan<short> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<ushort> pow(Span<ushort> b, ReadOnlySpan<ushort> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<int> pow(Span<int> b, ReadOnlySpan<int> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<uint> pow(Span<uint> b, ReadOnlySpan<uint> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<long> pow(Span<long> b, ReadOnlySpan<long> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<ulong> pow(Span<ulong> b, ReadOnlySpan<ulong> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<float> pow(Span<float> b, ReadOnlySpan<float> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<double> pow(Span<double> b, ReadOnlySpan<double> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<sbyte> pow(Span<sbyte> b, sbyte exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<byte> pow(Span<byte> b, byte exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<short> pow(Span<short> b, short exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<ushort> pow(Span<ushort> b, ushort exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<int> pow(Span<int> b, int exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<uint> pow(Span<uint> b, uint exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<long> pow(Span<long> b, long exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<ulong> pow(Span<ulong> b, ulong exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<float> pow(Span<float> b, float exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<double> pow(Span<double> b, double exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

    }
}