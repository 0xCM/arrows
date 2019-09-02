//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;
    using System;

    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    /// <summary>
    /// Implements a 64-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://github.com/lemire/testingRNG/blob/master/source/splitmix64.h</remarks>
    class SplitMix64 : IPointSource<ulong>//, IRandomSource
    {
        const ulong X1 = 0x9E3779B97F4A7C15;
        
        const ulong X2 = 0xBF58476D1CE4E5B9;
        
        const ulong X3 = 0x94D049BB133111EB;

        readonly ulong Seed;
        
        ulong State;

        public SplitMix64(ulong Seed)
        {
            this.Seed = Seed;
            this.State = Seed;

        }

        [MethodImpl(Inline)]
        static ulong NextState(ulong state)
        {
            ulong z = state + X1;
            z = (z ^ (z >> 30)) * X2;
            z = (z ^ (z >> 27)) * X3;
            return z ^ (z >> 31);
        }

        [MethodImpl(Inline)]
        public ulong Next()
        {
            var next = NextState(State);
            State += X1;
            return next;
        }

        public ulong Next(ulong max)
            => Next().Contract(max);

        public ulong Next(ulong min, ulong max)
            => min + Next().Contract(max - min);

        IPointSource<ulong> PointSource
            => this;


    }
}