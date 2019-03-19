//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using C = Contracts;

    using static corefunc;

    public readonly struct Uniform<T> : C.Uniform<T>
        where T : new()
    {
        public T min {get;}

        public T max {get;}
    }
}