//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        /// <summary>
        /// Characterizes a *finitely generated* free semigroup over a set
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        public interface FreeSemigroup<T> : Semigroup<T>
        {
            FiniteSet<T> generators {get;}
        }

        public interface FreeSemigroup<H,T> : Semigroup<T>,  TypeClass<H>
            where H : FreeSemigroup<H,T>,new()
        {

        }

        /// <summary>
        /// Characterizes a finitely generated free monoid
        /// </summary>
        /// <typeparam name="T">The individual type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid </remarks>
        public interface FreeMonoid<T> : Monoid<T>, FreeSemigroup<T>
        {
            
        }

        public interface FreeMonoid<H,T> : TypeClass<H>, FreeMonoid<T>
            where H : FreeMonoid<H,T>, new()
        {


        }

        public interface FreeAbelianGroup<T> : GroupA<T>, FreeMonoid<T>
        {
            
        }

        public interface FreeAbelianGroup<H,T> : TypeClass<H> ,FreeAbelianGroup<T>
            where H : FreeAbelianGroup<H,T>, new()
        {
            
        }


        public interface FreeGroup<T> : Group<T>, FreeMonoid<T>
        {

        }

        public interface FreeGroup<H,T> : TypeClass<T>, FreeGroup<T>
            where T : FreeGroup<H,T>, new()
        {
            
        }


    }

    partial class Struct
    {


    }
}