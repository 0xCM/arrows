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
        public static ref sbyte abs(ref sbyte src)
        {
            src = Math.Abs(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short abs(ref short src)
        {
            src = Math.Abs(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int abs(ref int src)
        {
            src = Math.Abs(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long abs(ref long src)
        {
            src = Math.Abs(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float abs(ref float src)
        {
            src = MathF.Abs(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double abs(ref double src)
        {
            src = Math.Abs(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static sbyte abs(sbyte src)
            => Math.Abs(src);

        [MethodImpl(Inline)]
        public static short abs(short src)
            => Math.Abs(src);

        [MethodImpl(Inline)]
        public static int abs(int src)
            => Math.Abs(src);

        [MethodImpl(Inline)]
        public static long abs(long src)
            => Math.Abs(src);

        [MethodImpl(Inline)]
        public static float abs(float src)
            => MathF.Abs(src);

        [MethodImpl(Inline)]
        public static double abs(double src)
            => Math.Abs(src);
    }

}