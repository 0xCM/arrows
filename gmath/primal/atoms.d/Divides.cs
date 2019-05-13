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
        public static bool Divides(sbyte lhs, sbyte rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(byte lhs, byte rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(short lhs, short rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(ushort lhs, ushort rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(int lhs, int rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(uint lhs, uint rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(long lhs, long rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(ulong lhs, ulong rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(float lhs, float rhs)
            => mod(rhs, lhs) == 0;

        [MethodImpl(Inline)]
        public static bool Divides(double lhs, double rhs)
            => mod(rhs, lhs) == 0;


    }

}