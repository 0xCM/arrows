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

    /// <summary>
    /// Defines the value of a point within an interval
    /// </summary>
    public readonly struct IntervalPoint<T>  
        where T : struct  
    {                    
        public static IntervalPoint<T> Define(in Interval<T> src, in T value)
        {
            if(!src.Contains(value))
                throw new Exception($"The value {value} is not contained within {src}");
            return new IntervalPoint<T>(src, value);
        }
        
        IntervalPoint(in Interval<T> source, in T value)
        {
            this.Source = source;
            this.Value = value;
        }
        
        public readonly Interval<T> Source;

        public readonly T Value {get;}
    }

}