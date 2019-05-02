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

    using static zcore;


    public readonly struct TimedPair
    {
        public static readonly TimedPair Zero = Define(Duration.Zero, Duration.Zero);
        
        public static TimedPair Define(Duration Left, Duration Right)
            => new TimedPair(Left,Right);

        public TimedPair(Duration Left, Duration Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        public readonly Duration Left;

        public readonly Duration Right;
    }


}