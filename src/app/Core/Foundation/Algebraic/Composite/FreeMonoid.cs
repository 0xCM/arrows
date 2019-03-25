//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    public static class FreeMonoid
    {
        public static FreeMonoid<T> define<T>(params T[] generators)
            where T : IEquatable<T>
                => new FreeMonoid<T>(generators);

        static IEnumerable<T> generate<T>(Traits.FreeMonoid<T> fm, T m, IEnumerable<T> src)
        {
            foreach(var item in src)
                yield return fm.concat(m,item);                    
        }

        static IEnumerable<T> generate<T>(Traits.FreeMonoid<T> fm, IEnumerable<T> m, IEnumerable<IEnumerable<T>> src)
        {
            foreach(var item in src.SelectMany(x => x))
            foreach(var n in m)
                yield return fm.concat(n,item);                    
        }

        static IEnumerable<T> nextlevel<T>(Traits.FreeMonoid<T> fm, IEnumerable<T> src)
            => from m in src
               from n in generate(fm, m, src)
               select n;

        static IEnumerable<T> nextlevel<T>(Traits.FreeMonoid<T> fm, IEnumerable<T> lhs, IEnumerable<T> rhs)
            =>  from x in lhs
                from y in rhs
                select fm.concat(x,y);

        public static IEnumerable<T> generate<T>(Traits.FreeMonoid<T> fm, IEnumerable<T> generators)
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
    
    public readonly struct FreeMonoid<T> : Traits.FreeMonoid<T>
        where T : IEquatable<T>
    {

        static readonly Traits.FreeMonoid<T> Ops = ops<T,Traits.FreeMonoid<T>>();

        public FreeMonoid(IEnumerable<T> generators)
            => this.generators = generators.ToFiniteSet();

        public FreeMonoid(params T[] generators)
            => this.generators = generators.ToFiniteSet();

        public Traits.FiniteSet<T> generators {get;}

        public T empty => Ops.empty;

        public IEnumerable<T> concat(IEnumerable<T> s1, IEnumerable<T> s2)
            => s1.Concat(s2);

        public T concat(T lhs, T rhs)
            => throw new NotSupportedException();

        public bool eq(T lhs, T rhs)
            => Ops.eq(lhs,rhs);         

        public bool neq(T lhs, T rhs)
            => Ops.neq(lhs,rhs);

        public T reduce(IEnumerable<T> src)
            => fold(src, concat, empty);
    }
}