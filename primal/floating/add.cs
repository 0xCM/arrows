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
        public static float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public static ref float add(ref float lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double add(ref double lhs, double rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static float add(float lhs, float rhs, out float dst)
            => dst = lhs + rhs;

        [MethodImpl(Inline)]
        public static double add(double lhs, double rhs, out double dst)
            => dst = lhs + rhs;


    }

}