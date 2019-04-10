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


    public abstract class IntGUnaryOpTest<T> : IntGTest<T>
        where T : struct, IEquatable<T>            
    {
        
        protected readonly IReadOnlyList<T> PrimSrc;

        protected readonly IReadOnlyList<intg<T>> IntSrc;

        

        protected IntGUnaryOpTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {
            this.IntSrc = reals(MinPrimVal,MaxPrimVal);
            this.PrimSrc = IntSrc.Unwrap();

        }

        [Repeat(5)]
        public abstract IReadOnlyList<T> Baseline();

        [Repeat(5)]
        public abstract IReadOnlyList<intg<T>> Applied();

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Unwrap();            
            iter((int)SampleSize, i => Claim.equals(expect[i], actual[i]));
        }

    }



}