//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    using Z0.Testing;

    public abstract class RealGBinOpTest<T> : RealGTest<T>
        where T : struct, IEquatable<T>            
    {       
        protected readonly IReadOnlyList<real<T>> LeftRealSrc;
     
        protected readonly IReadOnlyList<real<T>> RightRealSrc;

        protected readonly IReadOnlyList<T> LeftPrimSrc;
        
        protected readonly IReadOnlyList<T> RightPrimSrc;

        protected RealGBinOpTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {
            this.LeftRealSrc = reals(MinPrimVal,MaxPrimVal);
            this.RightRealSrc = reals(MinPrimVal,MaxPrimVal);
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
            iter((int)SampleSize, i => Claim.equals(expect[i], actual[i]));
        }

    }


}