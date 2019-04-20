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
    
    using static zcore;

    public readonly struct For
    {
        [MethodImpl(Inline)]
        public static For define(int upper, int lower = 0, int step = 1)
            => new For(upper,lower,step);
        
        public readonly int lower;

        public readonly int step;

        public readonly int upper;

        [MethodImpl(Inline)]
        public For(in int upper, in int lower = 0, in int step = 1)
        {
            this.upper = upper;
            this.lower = lower;
            this.step = step;
        }

        [MethodImpl(Inline)]
        public void execute(Action<int> receiver)
        {
            for(var i = lower; i < upper; i += step)
                receiver(i);
        }
    
    }
}