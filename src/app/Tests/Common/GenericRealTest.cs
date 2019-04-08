//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static ztest;
    
    public abstract class GenericNumericTest
    {
        protected const uint VectorSize = Pow2.T20;
    
        protected const int RepeatCount = 5;
        
        protected static IReadOnlyList<T> primal<T>(T min, T max)
            => Rand.primal(min,max).Freeze(VectorSize);
    }

    public abstract class GenericNumericTest<T>
    {
        protected const uint VectorSize = Pow2.T20;
    
        protected const int RepeatCount = 5;

        protected static IReadOnlyList<T> primal(T min, T max)
            => Rand.primal(min,max).Freeze(VectorSize);

        protected T MinPrimVal {get;}

        protected T MaxPrimVal {get;}

        protected GenericNumericTest(T MinPrimVal, T MaxPrimVal)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
        }
    }

    public abstract class GenericBinOpTest<T> : GenericNumericTest<T>
    {


        protected GenericBinOpTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {

        }

    }


}