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
        public static sbyte min(params sbyte[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static byte min(params byte[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static short min(params short[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static ushort min(params ushort[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static int min(params int[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static uint min(params uint[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static long min(params long[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static ulong min(params ulong[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static float min(params float[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static double min(params double[] src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static sbyte min(ReadOnlySpan<sbyte> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static byte min(ReadOnlySpan<byte> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static short min(ReadOnlySpan<short> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static ushort min(ReadOnlySpan<ushort> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static int min(ReadOnlySpan<int> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static uint min(ReadOnlySpan<uint> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static long min(ReadOnlySpan<long> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static ulong min(ReadOnlySpan<ulong> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static float min(ReadOnlySpan<float> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

        [MethodImpl(NotInline)]
        public static double min(ReadOnlySpan<double> src)
        {
            if(src.Length == 0)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
            {
                var candidate = src[i];
                if(lt(candidate, result))
                    result = candidate;
            }

            return result;
        }

    }
}