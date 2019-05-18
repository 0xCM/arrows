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
    
    using static mfunc;

    partial class math
    {
        [MethodImpl(Inline)]
        public static float pow(float src, uint exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, uint exp)
            => Math.Pow(src,exp);

        [MethodImpl(Inline)]
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);

        [MethodImpl(Inline)]
        public static sbyte pow(sbyte src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (sbyte)result;

        }

        [MethodImpl(Inline)]
        public static byte pow(byte src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (byte)result;
        }

        [MethodImpl(Inline)]
        public static short pow(short src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (short)result;
        }

        [MethodImpl(Inline)]
        public static ushort pow(ushort src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return (ushort)result;
        }

        [MethodImpl(Inline)]
        public static int pow(int src, uint exp)
        {
            var result = 1;
            for(var i = 1; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static uint pow(uint src, uint exp)
        {
            var result = 1u;
            for(var i = 1u; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static long pow(long src, uint exp)
        {
            var result = 1L;
            for(var i = 1u; i< exp; i++)
                result = result*i;
            return result;
        }

        [MethodImpl(Inline)]
        public static ulong pow(ulong src, uint exp)
        {
            var result = 1ul;
            for(var i = 1u; i< exp; i++)
                result = result*i;            
            return result;
        }
    }
}