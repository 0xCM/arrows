//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    /// <summary>
    /// Represents a number that either 
    /// 1. Lies within the unit interval [0,1] or
    /// 2. Can be bijectively transformed to the unit interval
    /// </summary>
    public readonly struct Probability<T>
        where T : struct
    {
        public Probability(T Value)
            => this.Value = Value;

        public T Value {get;}
    }


}