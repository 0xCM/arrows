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

        [MethodImpl(Inline)]
        public static bool neq(in sbyte lhs, in sbyte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in byte lhs, in byte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in short lhs, in short rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in ushort lhs, in ushort rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in int lhs, in int rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in uint lhs, in uint rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in long lhs, in long rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in ulong lhs, in ulong rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in float lhs, in float rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(in double lhs, in double rhs)
            => lhs != rhs;

      
    }


}