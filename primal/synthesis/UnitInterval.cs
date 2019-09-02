//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct UnitInterval<T> : IInterval<T>
        where T : struct
    {
        static readonly T LowerBound = gmath.zero<T>();

        static readonly T UpperBound = gmath.one<T>();

        internal static readonly UnitInterval<T> TheOnly = default;
        
        public static implicit operator Interval<T>(UnitInterval<T> src)
            => new Interval<T>(src.Left, true, src.Right, true);
        
        public T Left 
        {
            [MethodImpl(Inline)]
            get => LowerBound;
        }

        public T Right 
        {
            [MethodImpl(Inline)]
            get => UpperBound;
        }

        public bool LeftClosed 
            => true;

        public bool RightClosed 
            => true;

        public IntervalKind Kind 
            => IntervalKind.Closed;
    }

}