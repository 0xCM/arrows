//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using Root;
    using C = Contracts;

    using static corefunc;


    /// <summary>
    /// Encapsulates two oriented values, 
    /// a left-value of one type and a right-value
    /// of another type
    /// </summary>
    public readonly struct Pair<A,B> : C.Pair<A,B>
    {        
        public A left {get;}

        public B right {get;}

        public Pair(A left, B right)
        {
            this.left = left;
            this.right = right;
        }
    }

    /// <summary>
    /// Encapsulates exactly one value,
    /// a left-value of one type or a right value
    /// of another type
    /// </summary>
    public readonly struct Copair<A,B> : C.Copair<A, B>
    {

        /// <summary>
        /// The potential left value
        /// </summary>
        public Option<A> left {get;}

        /// <summary>
        /// The potential right value
        /// </summary>
        public Option<B> right {get;}

        public Copair(A left)
        {
            this.left = some(left);
            this.right = none<B>();
        }

        public Copair(B right)
        {
            this.left = none<A>();
            this.right = some(right);
        }
    }

    /// <summary>
    /// Defines pair-related functions
    /// </summary>
    public static class Pair
    {
        public static Pair<A,B> define<A,B>(A a, B b)
            => new Pair<A,B>(a,b);

    }

    /// <summary>
    /// Defines pair-related extensions
    /// </summary>
    public static class PairX
    {

        public static bool IsLeft<A,B>(this Copair<A,B> cp)
            => cp.left.exists;

        public static bool IsRight<A,B>(this Copair<A,B> cp)
            => cp.right.exists;
    }

}