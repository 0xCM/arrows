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
        public static sbyte max(ReadOnlySpan<sbyte> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static byte max(ReadOnlySpan<byte> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static short max(ReadOnlySpan<short> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static ushort max(ReadOnlySpan<ushort> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static int max(ReadOnlySpan<int> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static uint max(ReadOnlySpan<uint> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static long max(ReadOnlySpan<long> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static ulong max(ReadOnlySpan<ulong> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static float max(ReadOnlySpan<float> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }

        public static double max(ReadOnlySpan<double> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(src[i] > result)
                    result = src[i];

            return result;
        }
    }
}