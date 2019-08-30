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
        public static sbyte max(sbyte lhs, sbyte rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static byte max(byte lhs, byte rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static short max(short lhs, short rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ushort max(ushort lhs, ushort rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static int max(int lhs, int rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static uint max(uint lhs, uint rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static long max(long lhs, long rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ulong max(ulong lhs, ulong rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static float max(float lhs, float rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double max(double lhs, double rhs)
            => lhs > rhs ? lhs : rhs;

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