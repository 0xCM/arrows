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


    using source = System.Double;
    using target = System.Int32;

    public abstract class ClrConverterTest<B,S,T> : UnitTest<B>
        where B : ClrConverterTest<B,S,T>
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
    {
        protected const uint VectorSize = Pow2.T14;
                
        protected S MinPrimVal {get;}

        protected S MaxPrimVal {get;}

        protected Index<S> Src; 

        protected Index<S> source(S min, S max)
            =>  Randomizer.Random<S>().stream(min,max).Freeze(VectorSize);

        protected ClrConverterTest(Interval<S>? bounds = null)
        {
            this.MinPrimVal = (bounds ?? SampleDefaults.get<S>().SampleDomain).Left;
            this.MaxPrimVal = (bounds ?? SampleDefaults.get<S>().SampleDomain).Right;
            this.Src = source(MinPrimVal,MaxPrimVal);
        }
      
        public abstract Index<T> Compute();
      
        public abstract Index<T> Baseline();        

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Compute();            
            iter((int)VectorSize, i => Claim.eq(expect[i], actual[i]));
        }
    }
}