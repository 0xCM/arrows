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

    public abstract class IntGBinOpTest<C,T> : IntGTest<C,T>
        where C : IntGBinOpTest<C,T>
        where T : struct, IEquatable<T>            
    {
        protected readonly IReadOnlyList<T> LeftPrimSrc;
        
        protected readonly IReadOnlyList<T> RightPrimSrc;
        
        protected readonly IReadOnlyList<intg<T>> LeftIntSrc;

        protected readonly IReadOnlyList<intg<T>> RightIntSrc;

        protected IntGBinOpTest(Interval<T> domain, Func<T,bool> filter = null, int? sampleSize = null)
            : base(domain,filter,sampleSize)
        {
            LeftPrimSrc = sample();
            RightPrimSrc = sample();
            LeftIntSrc = map(LeftPrimSrc, x => intg(x));
            RightIntSrc = map(RightPrimSrc, x => intg(x));
        }

        [Repeat(Defaults.Reps)]
        public abstract IReadOnlyList<T> Baseline();

        [Repeat(Defaults.Reps)]
        public abstract IReadOnlyList<intg<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)SampleSize, i => Claim.eq(expect[i], actual[i]));
        }
    }
}