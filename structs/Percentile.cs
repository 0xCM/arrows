//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    public readonly struct Percentile<T>
        where T : struct
    {
        public Percentile(T Value)
            => this.Value = Value;

        public T Value {get;}
    }


}