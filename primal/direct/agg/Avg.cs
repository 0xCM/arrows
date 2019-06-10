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

        public static sbyte avg(ReadOnlySpan<sbyte> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        public static byte avg(ReadOnlySpan<byte> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        public static short avg(ReadOnlySpan<short> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        public static ushort avg(ReadOnlySpan<ushort> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (ushort)(sum/(ulong)src.Length);
            }
        }
   
        public static int avg(ReadOnlySpan<int> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }
   
        public static uint avg(ReadOnlySpan<uint> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (uint)(sum/(ulong)src.Length);
            }
        }

        public static long avg(ReadOnlySpan<long> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return sum/src.Length;
            }
        }

        public static ulong avg(ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return sum/(ulong)src.Length;
            }
        }

        public static float avg(ReadOnlySpan<float> src)
        {
            checked
            {
                var sum = default(double);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (float)(sum/(float)src.Length);
            }
        }

        public static double avg(ReadOnlySpan<double> src)
        {
            checked
            {
                var sum = default(double);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return sum/(double)src.Length;
            }
        }
    }
}