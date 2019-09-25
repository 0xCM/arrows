//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {

        [MethodImpl(Inline)]
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);

        [MethodImpl(Inline)]
        public static ref float pow(ref float src, float exp)
        {
            src = MathF.Pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double pow(ref double src, double exp)
        {
            src = Math.Pow(src,exp);
            return ref src;
        }


    }

}