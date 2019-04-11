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


    public abstract class IntGUnaryOpTest<C,T> : IntGTest<C,T>
        where C : IntGUnaryOpTest<C,T>
        where T : struct, IEquatable<T>            
    {
        
        protected readonly IReadOnlyList<T> PrimSrc;

        protected readonly IReadOnlyList<intg<T>> IntSrc;

        


        protected IntGUnaryOpTest(Interval<T> bounds, Func<T,bool> filter = null)
            : base(bounds, filter)
        {
            this.PrimSrc = sample();
            this.IntSrc = map(PrimSrc, x => intg(x));

        }

        [Repeat(Defaults.Reps)]
        public abstract IReadOnlyList<T> Baseline();

        [Repeat(Defaults.Reps)]
        public abstract IReadOnlyList<intg<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)SampleSize, i => Claim.equals(expect[i], actual[i]));
        }

    }



}