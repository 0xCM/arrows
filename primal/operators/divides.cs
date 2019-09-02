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
        public static bool divides(sbyte lhs, sbyte rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(byte lhs, byte rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(short lhs, short rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(ushort lhs, ushort rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(int lhs, int rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(uint lhs, uint rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(long lhs, long rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(ulong lhs, ulong rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(float lhs, float rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        public static bool divides(double lhs, double rhs)
            => rhs % lhs == 0;


    }

}