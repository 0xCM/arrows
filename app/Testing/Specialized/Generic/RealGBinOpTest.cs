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
    using static zfunc;


    using Z0.Testing;

    public abstract class RealGBinOpTest<C,T> : RealGTest<C,T>
        where C : RealGBinOpTest<C,T>
        where T : struct, IEquatable<T>            
    {       
        protected readonly Index<real<T>> LeftRealSrc;
     
        protected readonly Index<real<T>> RightRealSrc;

        protected readonly Index<T> LeftPrimSrc;
        
        protected readonly Index<T> RightPrimSrc;

        protected RealGBinOpTest(Interval<T> bounds, Func<T,bool> filter = null)
            : base(bounds,filter)
        {
            LeftPrimSrc = sample();
            RightPrimSrc = sample();
            LeftRealSrc = LeftPrimSrc.ToReal();
            RightRealSrc = RightPrimSrc.ToReal();
        }

        [Repeat(Defaults.Reps)]
        public abstract Index<T> Baseline();

        [Repeat(Defaults.Reps)]
        public abstract Index<real<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)SampleSize, i => Claim.eq(expect[i], actual[i]));
        }

    }


}