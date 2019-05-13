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
        public static bool divides(sbyte lhs, sbyte rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(byte lhs, byte rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(short lhs, short rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(ushort lhs, ushort rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(int lhs, int rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(uint lhs, uint rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(long lhs, long rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(ulong lhs, ulong rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(float lhs, float rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool divides(double lhs, double rhs)
            => mod(rhs, lhs) == 0;


    }

}