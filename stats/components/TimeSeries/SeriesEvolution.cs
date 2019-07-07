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

    public static class SeriesEvolution
    {
        public static SeriesEvolution<T> Define<T>(in ulong[] Seed, in Interval<T> Domain, in SeriesTerm<T> FirstTerm, in SeriesTerm<T> FinalTerm, in Duration Time)
            where T : struct
                => new SeriesEvolution<T>(in Seed, in Domain, in FirstTerm, in FinalTerm, in Time);
    }
    
    public readonly struct SeriesEvolution<T>
        where T : struct
    {
        public SeriesEvolution(in ulong[] Seed, in Interval<T> Domain, in SeriesTerm<T> FirstTerm, in SeriesTerm<T> FinalTerm, in Duration Time)
        {
            this.Seed = Seed;
            this.Domain = Domain;
            this.FirstTerm = FirstTerm;
            this.FinalTerm = FinalTerm;
            this.Time = Time;
        }
        public readonly ulong[] Seed;
        
        public readonly Interval<T> Domain; 

        public readonly SeriesTerm<T> FirstTerm;

        public readonly SeriesTerm<T> FinalTerm;

        public readonly Duration Time;
    }
}