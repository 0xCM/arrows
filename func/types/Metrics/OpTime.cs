//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Linq;


    public readonly struct OpTime
    {
        public static readonly OpTime Zero = new OpTime(0, Duration.Zero);
        
        public static implicit operator (long OpCount, Duration WorkTime)(OpTime src)
            => (src.OpCount, src.WorkTime);

        public static implicit operator OpTime((long OpCount, Duration WorkTime) src)
            => Define(src.OpCount, src.WorkTime);        
        public static OpTime Define(long OpCount, Duration WorkTime)
            => new OpTime(OpCount, WorkTime);

        public static OpTime operator +(OpTime lhs, OpTime rhs)
            => new OpTime(lhs.OpCount + rhs.OpCount, lhs.WorkTime + rhs.WorkTime);

        public OpTime(long OpCount, Duration WorkTime)
        {
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }
            
        public readonly long OpCount {get;}

        public readonly Duration WorkTime {get;}


        public override string ToString()
            => $"{OpCount} ops".PadRight(20) + $"| {WorkTime.Ticks} ticks".PadRight(20) + $" | {WorkTime.Ms} ms";
    }
}