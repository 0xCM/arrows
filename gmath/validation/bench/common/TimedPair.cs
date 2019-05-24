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
        public static implicit operator (long OpCount, Duration WorkTime)(OpTime src)
            => (src.OpCount, src.WorkTime);

        public static implicit operator OpTime((long OpCount, Duration WorkTime) src)
            => Define(src.OpCount, src.WorkTime);

        public static OpTime Define(long OpCount, Duration WorkTime)
            => new OpTime(OpCount, WorkTime);
        public OpTime(long OpCount, Duration WorkTime)
        {
            this.OpCount = OpCount;
            this.WorkTime = WorkTime;
        }
            
        public readonly long OpCount {get;}

        public readonly Duration WorkTime {get;}
    }


    public readonly struct TimedPair
    {
        public static readonly TimedPair Zero = Define(Duration.Zero, Duration.Zero);
        
        public static implicit operator TimedPair((Duration left, Duration right) src)
            => Define(src.left, src.right);

        public static TimedPair Define(Duration Left, Duration Right)
            => new TimedPair(Left,Right);

        public static (Duration left, Duration right) Deconstruct(TimedPair src)
            => (src.Left, src.Right);

        public TimedPair(Duration Left, Duration Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        public readonly Duration Left;

        public readonly Duration Right;
    }

}