//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static zfunc;    
    

    partial class math
    {
        public static sbyte min(ReadOnlySpan<sbyte> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static byte min(ReadOnlySpan<byte> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static short min(ReadOnlySpan<short> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static ushort min(ReadOnlySpan<ushort> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static int min(ReadOnlySpan<int> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static uint min(ReadOnlySpan<uint> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static long min(ReadOnlySpan<long> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static ulong min(ReadOnlySpan<ulong> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static float min(ReadOnlySpan<float> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }

        public static double min(ReadOnlySpan<double> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] < result)
                    result = src[i];

            return result;
        }
    }
}