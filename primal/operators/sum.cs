//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class math
    {
        public static sbyte sum(ReadOnlySpan<sbyte> src)
        {
            checked
            {
                var result = default(sbyte);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static byte sum(ReadOnlySpan<byte> src)
        {
            checked
            {
                var result = default(byte);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static short sum(ReadOnlySpan<short> src)
        {
            checked
            {
                var result = default(short);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static ushort sum(ReadOnlySpan<ushort> src)
        {
            checked
            {            
                var result = default(ushort);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }
   
        public static int sum(ReadOnlySpan<int> src)
        {
            checked
            {            
                var result = default(int);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }
   
        public static uint sum(ReadOnlySpan<uint> src)
        {
            checked
            {
                var result = default(uint);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static long sum(ReadOnlySpan<long> src)
        {
            checked
            {
                var result = default(long);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static ulong sum(ReadOnlySpan<ulong> src)
        {
            checked
            {
                var result = default(ulong);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static float sum(ReadOnlySpan<float> src)
        {
            checked
            {
                var result = default(float);
                for(var i=0; i< src.Length; i++)
                    result += src[i];
                return result;
            }
        }

        public static double sum(ReadOnlySpan<double> src)
        {
            checked
            {
                var result = default(double);
                for(var i=0; i<src.Length; i++)
                    result += src[i];
                return result;
            }
        }
    }
}