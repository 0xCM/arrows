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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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

        [MethodImpl(NotInline)]
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


        [MethodImpl(NotInline)]
        public static sbyte max(ReadOnlySpan<sbyte> src)
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

        [MethodImpl(NotInline)]
        public static byte max(ReadOnlySpan<byte> src)
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

        [MethodImpl(NotInline)]
        public static short max(ReadOnlySpan<short> src)
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

        [MethodImpl(NotInline)]
        public static ushort max(ReadOnlySpan<ushort> src)
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

        [MethodImpl(NotInline)]
        public static int max(ReadOnlySpan<int> src)
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

        [MethodImpl(NotInline)]
        public static uint max(ReadOnlySpan<uint> src)
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

        [MethodImpl(NotInline)]
        public static long max(ReadOnlySpan<long> src)
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

        [MethodImpl(NotInline)]
        public static ulong max(ReadOnlySpan<ulong> src)
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

        [MethodImpl(NotInline)]
        public static float max(ReadOnlySpan<float> src)
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

        [MethodImpl(NotInline)]
        public static double max(ReadOnlySpan<double> src)
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