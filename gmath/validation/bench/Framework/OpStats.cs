//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    public readonly struct OpStats
    {
        public static OpStats Define(OpId Op, Duration ExecTime, int Cycles, long OpCount)
            => new OpStats(Op,ExecTime,Cycles,OpCount);

        public OpStats(OpId Op, Duration ExecTime, int Cycles, long OpCount)
        {
            this.Op = Op;
            this.ExecTime = ExecTime;
            this.OpCount = OpCount;
            this.Cycles = Cycles;
        }

        public readonly OpId Op;
        
        public readonly Duration ExecTime;
        
        public readonly int Cycles;
        public readonly long OpCount;
    }


}