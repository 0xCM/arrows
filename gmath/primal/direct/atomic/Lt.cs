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
        public static bool lt(sbyte lhs, sbyte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(byte lhs, byte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(short lhs, short rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(ushort lhs, ushort rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(int lhs, int rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(uint lhs, uint rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(long lhs, long rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(ulong lhs, ulong rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(float lhs, float rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(double lhs, double rhs)
            => lhs < rhs;
        
    }

}