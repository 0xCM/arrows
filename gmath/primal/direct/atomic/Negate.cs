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
        public static ref sbyte negate(ref sbyte lhs)
        {
            lhs = (sbyte) - lhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short negate(ref short lhs)
        {
            lhs = (short) - lhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int negate(ref int lhs)
        {
            lhs = - lhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long negate(ref long lhs)
        {
            lhs = - lhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float negate(ref float lhs)
        {
            lhs = - lhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double negate(ref double lhs)
        {
            lhs = - lhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static sbyte negate(sbyte src)
            => (sbyte)(- src);

        [MethodImpl(Inline)]
        public static short negate(short src)
            => (short)(- src);

        [MethodImpl(Inline)]
        public static int negate(int src)
            => -src;

        [MethodImpl(Inline)]
        public static long negate(long src)
            => -src;

        [MethodImpl(Inline)]
        public static float negate(float src)
            => -src;

        [MethodImpl(Inline)]
        public static double negate(double src)
            => -src;
    }

}