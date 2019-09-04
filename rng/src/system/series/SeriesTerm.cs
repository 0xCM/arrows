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

    public readonly struct SeriesTerm<T>
        where T : struct
    {
        public SeriesTerm(long index, T observation)
        {
            this.Index = index;
            this.Observed = observation;
        }

        public readonly long Index;

        public readonly T Observed;

        public string Format()
            => $"({Index}, {Observed})";
    
        public override string ToString()
            => Format();
    }
}