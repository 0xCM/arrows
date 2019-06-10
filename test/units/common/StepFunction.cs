//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static zfunc;

    public static class UniformStepFunction
    {
        public static StepFunction<T> Define<T>(IEnumerable<(T x, T y)> points)
           where T : struct
            => new StepFunction<T>(points);
    }

    public readonly struct StepFunction<T>
        where T : struct
    {
        public StepFunction(IEnumerable<(T x, T y)> points)
        {
            var left = points.Select(point => point.x).Min();
            var right = points.Select(point => point.x).Max(); 
            this.Domain = closed(left, right);
            this.Values = points.ToDictionary();
        }
        
        IReadOnlyDictionary<T,T> Values {get;}

        

        public Interval<T> Domain {get;}

    }

}