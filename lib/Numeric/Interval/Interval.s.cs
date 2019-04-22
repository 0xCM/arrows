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

    public enum IntervalKind
    {
        Closed = 0,
        
        Open = 1,
        
        LeftClosed = 4,        
        
        RightClosed = 8,
        
        LeftOpen = RightClosed,
        
        RightOpen = LeftClosed
    }

    partial class Traits
    {   
        /// <summary>
        /// Characterizes a contiguous segment of homogenous values that lie within
        /// left and right boundaries 
        /// </summary>
        /// <remarks>
        /// Note that extended real numbers may also serve as endpoints,
        /// enabling representations such as (-∞,3] and (-3, ∞).
        /// </remarks>
        public interface Interval<T> : Formattable
            where T : struct, IEquatable<T>
        {
            
            /// <summary>
            ///  The interval's left endpoint
            /// </summary>
            T left {get;}

            /// <summary>
            ///  Specifies whether the left endpoint itself is contained in the interval
            /// </summary>
            bool leftclosed {get;}
            
            /// <summary>
            ///  The interval's right endpoint
            /// </summary>
            T right {get;}

            /// <summary>
            ///  Specifies whether the right endpoint itself is contained in the interval
            /// </summary>
            bool rightclosed {get;}

            IntervalKind kind {get;}

            /// <summary>
            /// Presents the interval in canonical/general form
            /// </summary>
            Z0.Interval<T> canonical();

        }

        public interface Interval<S,T> : Interval<T>
            where T : struct, IEquatable<T>
                where S : Interval<S,T>, new()
        {

        }
        /// <summary>
        /// Characterizes a discrete interval
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        public interface DiscreteInterval<T> : Interval<T> 
            where T : struct, IEquatable<T>
        {

        }


    }

    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : Traits.Interval<Interval<T>,T>
        where T : struct, IEquatable<T>
    {
        
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            if(!primops.gteq(right,left))
                throw new Exception($"Degenerate or meaningless interval specification: ({left},{right})");

            this.left = left;
            this.leftclosed = leftclosed;

            this.right = right;
            this.rightclosed = rightclosed;
        }
        
        public T left {get;}

        public T right {get;}

        public bool leftclosed {get;}

        public bool rightclosed {get;}

        public IntervalKind kind 
            => leftclosed && rightclosed ? IntervalKind.Closed
            :  not(leftclosed) && not(rightclosed) ? IntervalKind.Open
            : leftclosed && not(rightclosed) ? IntervalKind.LeftClosed
            : IntervalKind.RightClosed;

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