//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class DivTest<S,T> : InXBinOpTest<S,T>
        where S : DivTest<S,T>
        where T : struct, IEquatable<T>
    {        
        
        protected DivTest(Interval<T>? domain = null, int? sampleSize = null)
            : base(P.add, domain, sampleSize)        
        {

        }

        protected override Vec128BinOp<T> VecOp {get;} 
            = Vec128Ops.div;

        protected override IndexBinOp<T> IndexOp {get;} 
            = PrimOps.div;
    
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