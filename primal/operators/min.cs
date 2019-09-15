//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte min(sbyte lhs, sbyte rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static byte min(byte lhs, byte rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static short min(short lhs, short rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ushort min(ushort lhs, ushort rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static int min(int lhs, int rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static uint min(uint lhs, uint rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static long min(long lhs, long rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ulong min(ulong lhs, ulong rhs)
            => lhs < rhs ? lhs : rhs;


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

        [MethodImpl(Inline)]
        public static float min(float lhs, float rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double min(double lhs, double rhs)
            => lhs < rhs ? lhs : rhs;

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