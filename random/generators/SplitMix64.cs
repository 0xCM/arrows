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
    class SplitMix64 : IRandomSource<ulong>, IRandomSource
    {
        const ulong X1 = 0x9E3779B97F4A7C15;
        
        const ulong X2 = 0xBF58476D1CE4E5B9;
        
        const ulong X3 = 0x94D049BB133111EB;

        readonly ulong Seed;
        
        ulong State;


        Polyrand PR;

        public SplitMix64(ulong Seed)
        {
            this.Seed = Seed;
            this.State = Seed;
            this.PR = new Polyrand(PointSource);    

        }

        [MethodImpl(Inline)]
        public static ulong Next(ulong state)
        {
            ulong z = state + X1;
            z = (z ^ (z >> 30)) * X2;
            z = (z ^ (z >> 27)) * X3;
            return z ^ (z >> 31);
        }

        [MethodImpl(Inline)]
        public ulong Next()
        {
            var next = Next(State);
            State += X1;
            return next;
        }

        IRandomSource<ulong> PointSource
            => this;

        ulong IRandomSource.NextUInt64()
            => PR.Next<ulong>();
 
        ulong IRandomSource.NextUInt64(ulong max)
            => PR.Next(max);   

        int IRandomSource.NextInt32(int max)
            => PR.NextInt32(max);

        double IRandomSource.NextDouble()
            => PR.Next<double>();

    }
}