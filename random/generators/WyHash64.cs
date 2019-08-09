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
    /// <remarks>Algorithms take from https://github.com/lemire/testingRNG/blob/master/source/wyhash.h</remarks>
    class WyHash64 : IRandomSource<ulong>, IRandomSource
    {
        readonly ulong Seed;
        
        ulong State;

        Polyrand PR;

        [MethodImpl(Inline)]
        public WyHash64(ulong Seed)
        {
            this.State = Seed;
            this.Seed = Seed;
            this.PR = new Polyrand(PointSource);    
        }

        const ulong X1 = 0x60bee2bee120fc15;
        
        const ulong X2 = 0xa3b195354a39b70d;
        
        const ulong X3 = 0x1b03738712fad5c9;
        
        public ulong Next()
        {
            State += X1;
            State.UMul128(X2, out UInt128 a);
            var m1 = a.hi ^ a.lo;
            m1.UMul128(X3, out UInt128 b);
            var m2 = b.hi ^ b.lo;
            return m2;
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
