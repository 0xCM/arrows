//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Fatory for RNG's
    /// </summary>
    public static class RNG
    {

        public static IRandomSource XOrShift1024(ulong[] seed = null)
            => new XOrShift1024(seed ?? Seed1024.Default);

        public static IRandomizer XOrStarStar256(ulong[] seed = null)
            => new XOrStarStar256(seed ?? Seed256.Default);

    }

}