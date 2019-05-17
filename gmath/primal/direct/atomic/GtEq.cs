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
        public static bool gteq(sbyte lhs, sbyte rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(byte lhs, byte rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(short lhs, short rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(ushort lhs, ushort rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(int lhs, int rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(uint lhs, uint rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(long lhs, long rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(ulong lhs, ulong rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(float lhs, float rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(double lhs, double rhs)
            => lhs >= rhs;

        
    }


}