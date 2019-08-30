//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {

        [MethodImpl(Inline)]
        public static float floor(float src)
            => MathF.Floor(src);

        [MethodImpl(Inline)]
        public static double floor(double src)
            => Math.Floor(src);

        [MethodImpl(Inline)]
        public static float ceil(float src)
            => MathF.Ceiling(src);

        [MethodImpl(Inline)]
        public static double ceil(double src)
            => Math.Ceiling(src);

    }

}