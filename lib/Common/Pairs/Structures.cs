//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zcore;
    using static zfunc;


    /// <summary>
    /// Encapsulates two oriented values, 
    /// a left-value of one type and a right-value
    /// of another type
    /// </summary>
    public readonly struct Pair<A,B> : IPair<A,B>
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
    public readonly struct Copair<A,B> : ICopair<A, B>
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

}

