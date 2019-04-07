//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;


    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : Traits.Interval<Interval<T>,T>
    {
        
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            this.left = left;
            this.leftclosed = leftclosed;

            this.right = right;
            this.rightclosed = rightclosed;
        }
        
        public T left {get;}

        public T right {get;}

        public bool leftclosed {get;}

        public bool rightclosed {get;}

        public Interval<T> canonical()
            => this;

        public string format()
            => append(
                leftclosed ? AsciSym.LBracket: AsciSym.LParen, 
                zcore.format(left), AsciSym.Comma, zcore.format(right), 
                rightclosed ? AsciSym.RBracket : AsciSym.RParen
                );

        public override string ToString()
            => format();
    }



}