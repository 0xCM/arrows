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

    public abstract class RealGTest : GenericNumericTest
    {
        protected static IReadOnlyList<real<T>> reals<T>(real<T> min, real<T> max)
            => Rand.reals(min,max).Freeze(VectorSize);

    }

    public abstract class RealGTest<T> : RealGTest
    {
        protected static IReadOnlyList<real<T>> realsrc(real<T> min, real<T> max)
            => reals(min,max);

        protected static IReadOnlyList<real<T>> primalsrc(real<T> min, real<T> max)
            => primal(min,max);

    }

    public abstract class RealGBinaryOpTest<T> : RealGTest<T>
    {
        protected T MinPrimVal {get;}

        protected T MaxPrimVal {get;}
        
        protected readonly IReadOnlyList<real<T>> LeftRealSrc;
        protected readonly IReadOnlyList<real<T>> RightRealSrc;

        protected readonly IReadOnlyList<T> LeftPrimSrc;
        protected readonly IReadOnlyList<T> RightPrimSrc;

        protected RealGBinaryOpTest(T MinPrimVal, T MaxPrimVal)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
            this.LeftRealSrc = realsrc(MinPrimVal,MaxPrimVal);
            this.RightRealSrc = realsrc(MinPrimVal,MaxPrimVal);
            this.LeftPrimSrc = LeftRealSrc.Unwrap();
            this.RightPrimSrc = RightRealSrc.Unwrap();

        }

        [Repeat(5)]
        public abstract IReadOnlyList<T> Baseline();

        [Repeat(5)]
        public abstract IReadOnlyList<real<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)VectorSize, i => Claim.equals(expect[i], actual[i]));
        }

    }


}