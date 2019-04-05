//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using MathNet.Numerics.Random;
    using MathNet.Numerics.Distributions;

    using static zcore;


    public static class RandomVariable
    {
        public static RandomVariable<T> define<T>(Traits.Distribution<T> dist)
            => new RandomVariable<T>(); 
    }

    public readonly struct RandomVariable<T>
    {


    }

}