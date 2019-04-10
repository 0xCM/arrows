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

    public abstract class ClrConverterTest<S,T>
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
    {
        protected const uint VectorSize = Pow2.T20;
    
        protected const int RepeatCount = 5;
            
        protected S MinPrimVal {get;}

        protected S MaxPrimVal {get;}

        protected IReadOnlyList<S> Src; 


        protected static T[] target() => array<T>(VectorSize);
        
        protected static IReadOnlyList<S> source(S min, S max)
            => Rand.primal(min,max).Freeze(VectorSize);

        protected ClrConverterTest(S MinPrimVal, S MaxPrimVal)
        {
            this.MinPrimVal = MinPrimVal;
            this.MaxPrimVal = MaxPrimVal;
            this.Src = source(MinPrimVal,MaxPrimVal);
        }

        [Repeat(5)]
        public virtual IReadOnlyList<T> Discretized() 
            => new T[]{};
      
        [Repeat(5)]
        public abstract IReadOnlyList<T> Vectorized();
      
        [Repeat(5)]
        public abstract IReadOnlyList<T> Baseline();        

        public virtual void Verify()
        {
            var expect = Baseline();
            var actual = Vectorized();            
            iter((int)VectorSize, i => Claim.equals(expect[i], actual[i]));
        }

    }

}