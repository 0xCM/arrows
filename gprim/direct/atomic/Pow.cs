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
    }
}