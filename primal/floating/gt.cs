//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static bool gt(float lhs, float rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(double lhs, double rhs)
            => lhs > rhs;        

        [MethodImpl(Inline)]
        public static bool gteq(float lhs, float rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(double lhs, double rhs)
            => lhs >= rhs;        

    }
}