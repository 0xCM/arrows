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

    using Z0.Testing;


    public abstract class IntGTest<T> : GenericNumericTest<T>
        where T : struct, IEquatable<T>            
    {
        protected static IReadOnlyList<intg<T>> reals(intg<T> min, intg<T> max)
            => Rand.integers(min,max).Freeze(VectorSize);

        protected IntGTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {

        }

    }

    public abstract class IntGBinOpTest<T> : IntGTest<T>
        where T : struct, IEquatable<T>            
    {
        
        protected readonly IReadOnlyList<intg<T>> LeftIntSrc;
        protected readonly IReadOnlyList<intg<T>> RightIntSrc;

        protected readonly IReadOnlyList<T> LeftPrimSrc;
        
        protected readonly IReadOnlyList<T> RightPrimSrc;

        protected IntGBinOpTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {
            this.LeftIntSrc = reals(MinPrimVal,MaxPrimVal);
            this.RightIntSrc = reals(MinPrimVal,MaxPrimVal);
            this.LeftPrimSrc = LeftIntSrc.Unwrap();
            this.RightPrimSrc = RightIntSrc.Unwrap();

        }

        [Repeat(5)]
        public abstract IReadOnlyList<T> Baseline();

        [Repeat(5)]
        public abstract IReadOnlyList<intg<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)VectorSize, i => Claim.equals(expect[i], actual[i]));
        }

    }

}