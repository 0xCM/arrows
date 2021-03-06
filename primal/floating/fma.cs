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
        public static float fma(float x, float y, float z)
            => MathF.FusedMultiplyAdd(x,y,z);

        [MethodImpl(Inline)]
        public static double fma(double x, double y, double z)
            => Math.FusedMultiplyAdd(x, y, z);

        [MethodImpl(Inline)]
        public static ref float fma(ref float x, in float y, in float z)
        {
            x = MathF.FusedMultiplyAdd(x, y, z);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref double fma(ref double x, in double y, in double z)
        {
            x = Math.FusedMultiplyAdd(x, y, z);
            return ref x;
        }
    }

}