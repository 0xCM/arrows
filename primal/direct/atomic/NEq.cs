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
        public static bool neq(sbyte lhs, sbyte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(byte lhs, byte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(short lhs, short rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(ushort lhs, ushort rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(int lhs, int rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(uint lhs, uint rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(long lhs, long rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(ulong lhs, ulong rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(float lhs, float rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(double lhs, double rhs)
            => lhs != rhs;
        
    }


}