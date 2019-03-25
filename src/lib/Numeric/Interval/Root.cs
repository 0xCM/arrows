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

    using static corefunc;


    /// <summary>
    /// Defines a contiguous segment of values between left and right numeric bounds
    /// </summary>
    public readonly struct Interval<T> : Traits.Interval<T>
        where T : Traits.OrderedNumber<T>
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

        public override string ToString()
            => concat(
                leftclosed ? AsciSym.LBracket: AsciSym.LParen, 
                format(left), AsciSym.Colon, format(right), 
                rightclosed ? AsciSym.RBracket : AsciSym.RParen
                );
    }



}