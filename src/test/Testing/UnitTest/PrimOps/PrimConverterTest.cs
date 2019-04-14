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

    using source = System.Double;
    using target = System.Int32;

    public abstract class ClrConverterTest<B,S,T> : UnitTest<B>
        where B : ClrConverterTest<B,S,T>
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
    {
        protected const uint VectorSize = Defaults.BigVector;
                
        protected S MinPrimVal {get;}

        protected S MaxPrimVal {get;}

        protected IReadOnlyList<S> Src; 

        protected static IReadOnlyList<S> source(S min, S max)
            =>  Context.Random<S>().stream(min,max).Freeze(VectorSize);

        protected ClrConverterTest(Interval<S> bounds)
        {
            this.MinPrimVal = bounds.left;
            this.MaxPrimVal = bounds.right;
            this.Src = source(MinPrimVal,MaxPrimVal);
        }
      
        [Repeat(Defaults.Reps)]
        public abstract IReadOnlyList<T> Compute();
      
        [Repeat(Defaults.Reps)]
        public abstract IReadOnlyList<T> Baseline();        

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Compute();            
            iter((int)VectorSize, i => Claim.eq(expect[i], actual[i]));
        }
    }
}