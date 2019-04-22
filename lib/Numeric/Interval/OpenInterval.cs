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
        /// Characterizes an interval that contains neither  of its endpoints
        /// </summary>
        public interface OpenInterval<T> : LeftOpenInterval<T>, RightOpenInterval<T> 
            where T : struct, IEquatable<T>
        {

        }

        public interface OpenInterval<S,T> : OpenInterval<T>, Interval<S,T>
            where S : OpenInterval<S,T>, new()
            where T : struct, IEquatable<T>
        {

        }


    }

    public readonly struct OpenInterval<T> : Traits.OpenInterval<OpenInterval<T>,T>
        where T : struct, IEquatable<T>
    {

        public static implicit operator Interval<T>(OpenInterval<T> x)
            => x.canonical();

        public OpenInterval(T left, T right)
        {
            this.left = left;

            this.right = right;
        }

        public T left {get;}

        public bool leftclosed 
            => false;

        public T right {get;}
            

        public bool rightclosed 
            => false;

        public IntervalKind kind
            => IntervalKind.Open;

        public Interval<T> canonical()
            => new Interval<T>(left,leftclosed, right,rightclosed);

        public string format()
            => canonical().format();
        
        public override string ToString()
            => format();
                    
    }


}