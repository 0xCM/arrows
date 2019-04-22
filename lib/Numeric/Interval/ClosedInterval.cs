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

    partial class Traits
    {   
        /// <summary>
        /// Characterizes an interval that contains its endpoints
        /// </summary>
        public interface ClosedInterval<T> : LeftClosedInterval<T>, RightClosedInterval<T> 
            where T : struct, IEquatable<T>
        {

        }

        public interface ClosedInterval<S,T> : ClosedInterval<T>, Interval<S,T>
            where S : ClosedInterval<S,T>, new()
            where T : struct, IEquatable<T>
        {

        }


    }

    public readonly struct ClosedInterval<T> : Traits.ClosedInterval<T>
        where T : struct, IEquatable<T>

    {

        public static implicit operator Interval<T>(ClosedInterval<T> x)
            => x.canonical();

        public ClosedInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => true;

        public T right {get;}
            

        public bool rightclosed 
            => true;

        public IntervalKind kind
            => IntervalKind.Closed;

        public Interval<T> canonical()
            => new Interval<T>(left,leftclosed, right,rightclosed);

        public string format()
            => canonical().format();
        
        public override string ToString()
            => format();                    
    }

}