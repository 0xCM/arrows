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
        public static bool lteq(sbyte lhs, sbyte rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(byte lhs, byte rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(short lhs, short rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(ushort lhs, ushort rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(int lhs, int rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(uint lhs, uint rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(long lhs, long rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(ulong lhs, ulong rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(float lhs, float rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(double lhs, double rhs)
            => lhs <= rhs;

        
    }

}