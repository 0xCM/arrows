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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
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


    }
}