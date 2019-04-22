
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
        /// Characterizes an interval that does not contain its upper bound
        /// </summary>
        public interface RightOpenInterval<T> : Interval<T> 
            where T : struct, IEquatable<T>
        {

        }

        /// <summary>
        /// Characterizes an interval that contains its lower bound
        /// </summary>
        public interface LeftClosedInterval<T> : Interval<T> 
            where T : struct, IEquatable<T>
        {

        }

    }

    public readonly struct LeftClosedInterval<T> : Traits.LeftClosedInterval<T>, Traits.RightOpenInterval<T> 
        where T : struct, IEquatable<T>

    {

        public static implicit operator Interval<T>(LeftClosedInterval<T> x)
            => x.canonical();

        public LeftClosedInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => true;


        public T right {get;}
            

        public bool rightclosed 
            => false;

        public IntervalKind kind
            => IntervalKind.LeftClosed;

        public Interval<T> canonical()
            =>new Interval<T>(left,leftclosed, right,rightclosed);

       public string format()
            => canonical().format();
        
       public override string ToString()
            => format();
                     
    }




}