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


    public abstract class IntGBinOpTest<C,T> : IntGTest<C,T>
        where C : IntGBinOpTest<C,T>
        where T : struct, IEquatable<T>            
    {
        protected readonly Index<T> LeftPrimSrc;
        
        protected readonly Index<T> RightPrimSrc;
        
        protected readonly Index<intg<T>> LeftIntSrc;

        protected readonly Index<intg<T>> RightIntSrc;

        protected IntGBinOpTest(Interval<T> domain, Func<T,bool> filter = null, int? sampleSize = null)
            : base(domain,filter,sampleSize)
        {
            LeftPrimSrc = sample();
            RightPrimSrc = sample();
            LeftIntSrc = map(LeftPrimSrc, x => intg(x));
            RightIntSrc = map(RightPrimSrc, x => intg(x));
        }

        [Repeat(Defaults.Reps)]
        public abstract Index<T> Baseline();

        [Repeat(Defaults.Reps)]
        public abstract Index<intg<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)SampleSize, i => Claim.eq(expect[i], actual[i]));
        }
    }
}