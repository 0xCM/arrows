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
        
    using static As;
    using static zfunc;

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float round(float src, int scale)
            => MathF.Round(src, scale);

        [MethodImpl(Inline)]
        public static double round(double src, int scale)
            => Math.Round(src, scale);

        [MethodImpl(Inline)]
        public static ref float round(ref float src, int scale)
        {
            src = MathF.Round(src, scale);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double round(ref double src, int scale)
        {
            src = Math.Round(src, scale);
            return ref src;
        }
    }
}