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