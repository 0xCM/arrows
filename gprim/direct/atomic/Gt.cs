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
        public static bool gt(sbyte lhs, sbyte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(byte lhs, byte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(short lhs, short rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(ushort lhs, ushort rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(int lhs, int rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(uint lhs, uint rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(long lhs, long rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(ulong lhs, ulong rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(float lhs, float rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(double lhs, double rhs)
            => lhs > rhs;

        
    }


}