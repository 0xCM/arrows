//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public readonly struct OpMeasure
    {
        public static OpMeasure Define(long OpCount, Duration WorkTime)
            => (OpCount, WorkTime);

        public static implicit operator OpMeasure((long OpCount, Duration WorkTime) src)
            => new OpMeasure(src.OpCount, src.WorkTime);

        public static implicit operator (long OpCount, Duration WorkTime)(OpMeasure src)
            => (src.OpCount, src.WorkTime);

        public static (long OpCount, Duration WorkTime) Deconstruct(OpMeasure src)
            => (src.OpCount, src.WorkTime);

        public OpMeasure(long OpCount, Duration WorkTime)
        {
            Claim.nonzero(OpCount);
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }
        
        public readonly long OpCount;

        public readonly Duration WorkTime;
    }
}