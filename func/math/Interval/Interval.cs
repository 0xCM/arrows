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
    
    using static zfunc;
    using static As;

    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within
    /// left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints,
    /// enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : IInterval<T>
        where T : struct
    {
        /// <summary>
        /// Specifies the canonical unit interval over the underlying primitive
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public static readonly Interval<T> Unit 
            = new Interval<T>(PrimalInfo.zero<T>(), true, PrimalInfo.one<T>(), true);

        /// <summary>
        /// Specifies the interval where the left boundary is the smallest value within the range of the type
        /// and the right boundary is the largest value within the range of the type.
        /// <typeparam name="T">The primal type</typeparam>
        public static readonly Interval<T> Full 
            = new Interval<T>(PrimalInfo.minval<T>(), true, PrimalInfo.maxval<T>(), true);

        [MethodImpl(Inline)]
        public static implicit operator Interval<T>((T left, T right) x)
            => new Interval<T>(x.left, true, x.right, true);

        [MethodImpl(Inline)]
        public static implicit operator (T left, T right)(Interval<T> x)
            => (x.Left, x.Right);


        [MethodImpl(Inline)]
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            if(left.Equals(right))
                throw new Exception($"Interval with left = {left} and right = {right} is ill-defined");

            this.Left = left;
            this.LeftClosed = leftclosed;
            this.Right = right;
            this.RightClosed = rightclosed;
        }
        
        public readonly T Left;

        public bool LeftClosed {get;}

        public readonly T Right;

        public bool RightClosed {get;}

        // public ulong Width
        // {
        //     [MethodImpl(Inline)]
        //     get
        //     {
        //         if(typeof(T) == typeof(ulong))
        //             return uint64(Right) - uint64(Left);
        //         else
        //         {
        //             var l = Math.Abs(convert<T,long>(Left));
        //             var r = Math.Abs(convert<T,long>(Right));
        //             return (ulong)(r - l);
        //         }
        //     }
        // }
        public bool Open
        {
            [MethodImpl(Inline)]
            get => !LeftClosed && !RightClosed;
        }

        public bool Closed
        {
            [MethodImpl(Inline)]
            get => LeftClosed && RightClosed;
        }

        public bool RightOpen
        {
            [MethodImpl(Inline)]
            get => !RightClosed;
        }

        public bool LeftOpen
        {
            [MethodImpl(Inline)]
            get => !LeftClosed;
        }

        public IntervalKind Kind 
            => Closed ? IntervalKind.Closed
            :  Open ? IntervalKind.Open
            :  LeftClosed && !RightClosed ? IntervalKind.LeftClosed
            :  IntervalKind.RightClosed;

        T IInterval<T>.Left 
            => Left;

        T IInterval<T>.Right 
            => Right;

        public Interval<T> ToOpen()
            => Interval.open(Left, Right);

        public Interval<T> ToLeftOpen()
            => Interval.leftopen(Left, Right);

        public Interval<T> ToLeftClosed()
            => Interval.leftclosed(Left, Right);

        public Interval<T> ToClosed()
            => Interval.closed(Left, Right);

        /// <summary>
        /// Converts the left and right underlying values
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public Interval<U> Convert<U>()
            where U : struct
                => new Interval<U>(
                    convert(Left, out U x), LeftClosed, 
                    convert(Right, out U y), RightClosed
                    );

        [MethodImpl(Inline)]
        public Interval<U> As<U>()
            where U : struct
                => new Interval<U>(
                    AsIn.generic<T,U>(in Left), LeftClosed, 
                    AsIn.generic<T,U>(in Right), RightClosed
                    );

        public Interval<T> WithEndpoints(T Left, T Right)
            => new Interval<T>(Left, LeftClosed, Right, RightClosed);

        public string Format()
            => concat(
                LeftClosed ? "[": "(", 
                Left.ToString(), ",", Right.ToString(), 
                RightClosed ? "]" : ")"
                );

        public override string ToString()
            => Format();        
    }

    public enum IntervalKind
    {
        Closed = 0,
        
        Open = 1,
        
        LeftClosed = 4,        
        
        RightClosed = 8,
        
        LeftOpen = RightClosed,
        
        RightOpen = LeftClosed
    }


}