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
    public class FromInt32ToFloat64 : ClrConverterTest<FromInt32ToFloat64,source,target>
    {
        public const string Path = P.primconv + P.int32 + P.float64;

        public FromInt32ToFloat64()
            : base(Defaults.Int32Domain)
            {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<target> Baseline()
            => map(Src, x => (target)x);

        [Repeat(Defaults.Reps)]
        public IReadOnlyList<target> SystemConvert()
            => map(Src, Convert.ToDouble);

        public override IReadOnlyList<target> Compute()
            => convert<source,target>(Src);
            
    }

}