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
        public static sbyte max(params sbyte[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static byte max(params byte[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static short max(params short[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static ushort max(params ushort[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static int max(params int[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static uint max(params uint[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static long max(params long[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static ulong max(params ulong[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static float max(params float[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static double max(params double[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(gt(candidate, result))
                    result = candidate;
            }

            return result;
        }


    }
}