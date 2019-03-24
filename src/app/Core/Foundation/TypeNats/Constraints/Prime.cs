//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static corefunc;

    partial class Traits
    {

        /// <summary>
        /// Requires n:T => n is prime
        /// </summary>
        /// <typeparam name="P">A prime nat type</typeparam>
        public interface Prime<P> : NatConstraint<P>
            where P : TypeNat, new()
        {
            
        }

        /// <summary>
        /// Requires n:T =>  n = p^m for some prime number p and and integer m
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface PrimePower<T> : NatConstraint<T>
            where T : TypeNat, new()
        {

        }

        /// <summary>
        /// Requires m:T =>  m = p^n for some prime number p and and natural n
        /// </summary>
        /// <typeparam name="P">The prime type</typeparam>
        /// <typeparam name="N">The power type</typeparam>
        public interface PrimePower<P,N> : NatConstraint<P,N>
            where P : TypeNat, Prime<P>,new()
            where N : TypeNat, new()
        {

        }

    }

    public readonly struct Prime<P> : Traits.Prime<P>
        where P : TypeNat, new()
    {

    }

}