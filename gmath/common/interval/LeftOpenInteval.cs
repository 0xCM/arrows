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

    

    /// <summary>
    /// Characterizes an interval that does not contain its lower bound
    /// </summary>
    public interface ILeftOpenInterval<T> : IIntervalX<T> 
        where T : struct, IEquatable<T>
    {

    }

    /// <summary>
    /// Characterizes an interval that contains its upper bound
    /// </summary>
    public interface IRightClosedInterval<T> : IIntervalX<T>
        where T : struct, IEquatable<T>
    {

    }


    public readonly struct LeftOpenInterval<T> : ILeftOpenInterval<T>, IRightClosedInterval<T>
        where T : struct, IEquatable<T>
    {

        public static implicit operator Interval<T>(LeftOpenInterval<T> x)
            => x.canonical();

        public LeftOpenInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => false;

        public T right {get;}
            

        public bool rightclosed 
            => true;

        public IntervalKind kind
            => IntervalKind.LeftOpen;

        public Interval<T> canonical()
            => new Interval<T>(left,leftclosed, right,rightclosed);
                    
        public string format()
            => canonical().format();
        
        public override string ToString()
            => format(); 
    }
}