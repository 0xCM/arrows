//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;
    using static Reify;



    public static class FreeMonoid
    {
        public static FreeMonoid<T> define<T>(params T[] generators)
            where T :  IFreeMonoid<T>, new()
                => new FreeMonoid<T>(generators);

        public static IEnumerable<T> generate<T>(IFreeMonoidOps<T> fm, IEnumerable<T> generators)
        {
            var level1 = generators;
            foreach(var m in level1)
                yield return m;

            var level2 = from x in generators
                         from y in generators
                         select fm.Concat(x,y);
            foreach(var s in level2)
                yield return s;                         

            var level3 = from x in level1
                         from y in level2 
                         select fm.Concat(x,y);
            foreach(var s in level3)
                yield return s;                         

            var level4 = from x in level1
                         from y in level3
                         select fm.Concat(x,y);
            foreach(var s in level4)
                yield return s;
        }
    }

    public readonly struct FreeMonoid<T> 
        where T : IFreeMonoid<T>, new()
    {

        public FreeMonoid(FiniteSet<T> g)
            => this.generators = g;

        public FreeMonoid(params T[] generators)
            => this.generators = generators.ToFiniteSet();

        public FiniteSet<T> generators {get;}

        public IEnumerable<T> concat(IEnumerable<T> s1, IEnumerable<T> s2)
            => s1.Concat(s2);

    }

}