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
       [MethodImpl(Inline)]
        public static bool within(byte lhs, byte rhs, byte epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

       [MethodImpl(Inline)]
        public static bool within(sbyte lhs, sbyte rhs, sbyte epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

       [MethodImpl(Inline)]
        public static bool within(short lhs, short rhs, short epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

       [MethodImpl(Inline)]
        public static bool within(ushort lhs, ushort rhs, ushort epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

       [MethodImpl(Inline)]
        public static bool within(int lhs, int rhs, int epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(uint lhs, uint rhs, uint epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

       [MethodImpl(Inline)]
        public static bool within(long lhs, long rhs, long epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

       [MethodImpl(Inline)]
        public static bool within(ulong lhs, ulong rhs, ulong epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(float lhs, float rhs, float epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(double lhs, double rhs, double epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;


        [MethodImpl(Inline)]
        public static byte width(byte lhs, byte rhs)
            =>  (byte)(lhs > rhs ? lhs - rhs : rhs - lhs);

        [MethodImpl(Inline)]
        public static ushort width(sbyte lhs, sbyte rhs)
            => (ushort)(lhs > rhs ? lhs - rhs : rhs - lhs);

        [MethodImpl(Inline)]
        public static uint width(short lhs, short rhs)
            =>  (uint)abs((int)rhs - (int)lhs);

        [MethodImpl(Inline)]
        public static ulong width(int lhs, int rhs)
            => (ulong)abs((long)rhs - (long)lhs);

        [MethodImpl(Inline)]
        public static ulong width(long lhs, long rhs)
            => (ulong)abs(rhs - lhs);

        [MethodImpl(Inline)]
        public static ushort width(ushort lhs, ushort rhs)
            => (ushort)(lhs > rhs ? lhs - rhs : rhs - lhs);

        [MethodImpl(Inline)]
        public static uint width(uint lhs, uint rhs)
            => lhs > rhs ? lhs - rhs : rhs - lhs;

        [MethodImpl(Inline)]
        public static ulong width(ulong lhs, ulong rhs)
            => lhs > rhs ? lhs - rhs : rhs - lhs;
 
        [MethodImpl(Inline)]
        public static double width(float lhs, float rhs)
            => math.abs((double)rhs - (double)lhs);

        [MethodImpl(Inline)]
        public static double width(double lhs, double rhs)
            => math.abs(rhs - lhs);


    }
}