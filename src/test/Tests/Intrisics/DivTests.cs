//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class DivTest<S,T> : InXTest<S,T>
        where S : DivTest<S,T>
        where T : struct, IEquatable<T>
    {        
        protected static readonly InXDiv<T> InXOp = InXG.div<T>();
        
        protected DivTest(Interval<T>? domain = null, int? sampleSize = null)
            : base(P.add, domain, sampleSize)        
        {

        }

        protected IEnumerable<Vec128<T>> Results()
            => Results(InXOp.div);

        public virtual void Verify()
            => Verify(InXOp.div, PrimOps.div);        
    
        public virtual void Apply()
            => Results().ToList();
    }

    public class DivTests
    {
        const string BasePath = P.InX128 + P.div;        

        [DisplayName(Path)]
        public class Float32Div : DivTest<Float32Div, float>
        {
            const string Path = BasePath + P.float32;
            
            public override void Verify()
                => base.Verify();

            [Repeat(50)]
            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class Float64Div : DivTest<Float64Div, double>
        {
            const string Path = BasePath + P.float64;
            
            public override void Verify()
                => base.Verify();

            [Repeat(50)]
            public override void Apply()
                => base.Apply();

        }
    }
}