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



    public readonly struct OpenInterval<T> : IOpenInterval<OpenInterval<T>,T>
        where T : struct, IEquatable<T>
    {

        public static implicit operator Interval<T>(OpenInterval<T> x)
            => x.AsCanonical();

        public OpenInterval(T left, T right)
        {
            this.Left = left;

            this.Right = right;
        }

        public T Left {get;}

        public bool LeftClosed 
            => false;

        public T Right {get;}
            

        public bool RightClosed 
            => false;

        public IntervalKind Kind
            => IntervalKind.Open;

        public Interval<T> AsCanonical()
            => new Interval<T>(Left,LeftClosed, Right,RightClosed);

        public string format()
            => AsCanonical().format();
        
        public override string ToString()
            => format();
                    
    }


}