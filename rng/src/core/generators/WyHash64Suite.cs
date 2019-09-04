//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;
    using System;

    using System.Runtime.CompilerServices;

    class WyHash64Suite<N> : IPointSource<N, ulong>
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