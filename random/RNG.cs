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
        static IRandomSource Entropic = new XOrShift1024(Seed1024.Entropic);

        public static IRandomSource Default
            => Entropic;
            
        public static IRandomSource XOrShift1024(ulong[] seed = null)
            => new XOrShift1024(seed ?? Seed1024.Default);

        public static IRandomSource XOrStarStar256(ulong[] seed = null)
            => new XOrStarStar256(seed ?? Seed256.Default);
 
        public static Pcg32 Pcg32(ulong s0, ulong? index = null)
            => Z0.Pcg32.Define(s0, index);        

        public static Pcg64 Pcg64(ulong s0, ulong? index = null)
            => Z0.Pcg64.Define(s0, index);     

        public static IRandomSource FromConfig(RngConfig config)               
        {
            switch(config.RngId)
            {
                case RngKind.Pcg32:
                case RngKind.Pcg64:
                    var s0 =  BitConverter.ToUInt64(config.Seed,0);
                    var index = config.Seed.Length >= 16 ? (ulong?)BitConverter.ToUInt64(config.Seed,8) : null;
                    return config.RngId == RngKind.Pcg32 
                        ? Pcg32(s0, index) as IRandomSource 
                        : Pcg64(s0, index) as IRandomSource;
                // case RngKind.XOr256:
                //     return XOrStarStar256(config.Seed);

                default:
                    throw unsupported(config.RngId);
            }
        }

    }

}