//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using static corefunc;

    partial class Traits
    {

        public interface Copair<A,B>
        {
            /// <summary>
            /// The potential left value
            /// </summary>
            Option<A> left {get;}

            /// <summary>
            /// The potential right value
            /// </summary>
            Option<B> right {get;}
            
        }

        public interface Pair<A,B>
        {
            A left {get;}

            B right {get;}
        }    

        public interface Cotriple<A,B,C>
        {
            Option<A> left {get;}

            Option<C> center {get;}
            
            Option<B> right {get;}

        }

        public interface Triple<A,B,C>
        {
            A left {get;}

            C center {get;}
            
            B right {get;}

        }

    }
    
    partial class Reify
    {

        /// <summary>
        /// Encapsulates two oriented values, 
        /// a left-value of one type and a right-value
        /// of another type
        /// </summary>
        public readonly struct Pair<A,B> : Traits.Pair<A,B>
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
        public readonly struct Copair<A,B> : Traits.Copair<A, B>
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
    }

    /// <summary>
    /// Defines pair-related extensions
    /// </summary>
    public static class PairX
    {

        public static bool IsLeft<A,B>(this Traits.Copair<A,B> cp)
            => cp.left.exists;

        public static bool IsRight<A,B>(this Traits.Copair<A,B> cp)
            => cp.right.exists;
    }



}


