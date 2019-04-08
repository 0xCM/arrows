//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    using static zcore;
    using static ztest;
    using source = System.Double;
    using target = System.Int32;

    [DisplayName("convert:double -> int")]
    public class ClrFloat64ToInt32Test : ClrConverterTest<source,target>
    {
        public ClrFloat64ToInt32Test()
            : base(-250000, 250000)
            {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<target> Baseline()
            => map(Src, x => (target)x);

    
        [Repeat(RepeatCount)]
        public IReadOnlyList<target> SystemConvert()
            => map(Src, Convert.ToInt32);

        public override IReadOnlyList<target> Vectorized()
            => ClrConvert.apply<source,target>(Src);

        public override IReadOnlyList<target> Discretized()
            => map(Src, ClrConvert.apply<source,target>);
            
    }

}