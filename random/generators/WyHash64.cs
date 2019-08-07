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
    class WyHash64 : IRandomSource<ulong>
    {
        readonly ulong Seed;
        
        ulong State;
        
        public WyHash64(ulong Seed)
        {
            this.State = Seed;
            this.Seed = Seed;
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
    }

    class WyHash64Suite<N> : IRandomSource<N, ulong>
        where N : ITypeNat, new()

    {
        static readonly int MemberCount = (int)new N().value;
        
        readonly WyHash64[] Generators = new WyHash64[MemberCount];


        public WyHash64Suite(Span<N,ulong> Seed)
        {
            for(var i=0; i<MemberCount; i++)
                Generators[i] = new WyHash64(Seed[i]);
        }
        
        public Span<N, ulong> Next()
        {
            var dst = NatSpan.Alloc<N,ulong>();
            var next = Generators.Mapi((index ,g) => (index, value: g.Next()));
            foreach(var item in next)
                dst[item.index] = item.value;
            return dst;
            
        }
    }

}
