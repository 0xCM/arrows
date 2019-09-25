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
        public static sbyte pow(sbyte b, uint exp)
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

        public static byte pow(byte b, uint exp)
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

        public static short pow(short b, uint exp)
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

        public static ushort pow(ushort b, uint exp)
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

        public static int pow(int b, uint exp)
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

        public static uint pow(uint b, uint exp)
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

        public static long pow(long b, uint exp)
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

        public static ulong pow(ulong b, uint exp)
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
        public static ref sbyte pow(ref sbyte src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte pow(ref byte src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short pow(ref short src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort pow(ref ushort src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int pow(ref int src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint pow(ref uint src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long pow(ref long src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong ipow(ref ulong src, uint exp)
        {
            src = pow(src,exp);
            return ref src;
        }
    }
}