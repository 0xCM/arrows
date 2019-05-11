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
        public static bool eq(sbyte lhs, sbyte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(byte lhs, byte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(float lhs, float rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(double lhs, double rhs)
            => lhs == rhs;


    }


}