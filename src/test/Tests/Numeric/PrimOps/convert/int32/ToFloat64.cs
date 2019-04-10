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
    
    using source = System.Int32;
    using target = System.Double;
    using P = Paths;

    [DisplayName(Path)]
    public class FromInt32ToFloat64 : ClrConverterTest<source,target>
    {
        public const string Path = P.primconv + P.int32 + P.float64;

        public FromInt32ToFloat64()
            : base(-250000, 250000)
            {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<target> Baseline()
            => map(Src, x => (target)x);

    
        [Repeat(RepeatCount)]
        public IReadOnlyList<target> SystemConvert()
            => map(Src, Convert.ToDouble);

        public override IReadOnlyList<target> Vectorized()
            => convert<source,target>(Src);

        public override IReadOnlyList<target> Discretized()
            => map(Src, convert<source,target>);
            
    }

}