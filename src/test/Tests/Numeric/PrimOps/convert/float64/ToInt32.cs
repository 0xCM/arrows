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
    using P = Paths;

    [DisplayName(Path)]
    public class FromFloat64ToInt32 : ClrConverterTest<FromFloat64ToInt32,source,target>
    {
        public const string Path = P.primconv + P.float64 + P.int32;

        public FromFloat64ToInt32()
            : base(Defaults.Float64Range)
            {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<target> Baseline()
            => map(Src, x => (target)x);

    
        [Repeat(Defaults.Reps)]
        public IReadOnlyList<target> SystemConvert()
            => map(Src, Convert.ToInt32);

        public override IReadOnlyList<target> Compute()
            => ClrConverter.convert<source,target>(Src);
            
    }

}