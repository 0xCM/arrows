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

    partial class Operative
    {
        /// <summary>
        /// Characterizes free moinoidial operations
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid 
        /// and http://localhost:9000/refs/books/Y2007GRAA.pdf#page=39&view=fit</remarks>
        public interface FreeMonoid<T> : Monoid<T>, Concatenable<T>
        {
            T empty {get;}

        }

    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes a free monoidal structure
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface FreeMonoid<S> :  Monoid<S>, Concatenable<S>, Lengthwise<S>, Nullary<S>
            where S : FreeMonoid<S>, new()
        {

        }

        
    }

    public static class FreeMonoid
    {
        public static FreeMonoid<T> define<T>(params T[] generators)
            where T :  Structures.FreeMonoid<T>, new()
                => new FreeMonoid<T>(generators);

        public static IEnumerable<T> generate<T>(Operative.FreeMonoid<T> fm, IEnumerable<T> generators)
        {
            var level1 = generators;
            foreach(var m in level1)
                yield return m;

            var level2 = from x in generators
                         from y in generators
                         select fm.concat(x,y);
            foreach(var s in level2)
                yield return s;                         

            var level3 = from x in level1
                         from y in level2 
                         select fm.concat(x,y);
            foreach(var s in level3)
                yield return s;                         

            var level4 = from x in level1
                         from y in level3
                         select fm.concat(x,y);
            foreach(var s in level4)
                yield return s;
        }

    }

    partial class Reify
    {   
        public readonly struct FreeMonoid<T> 
            where T : Structures.FreeMonoid<T>, new()
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
}