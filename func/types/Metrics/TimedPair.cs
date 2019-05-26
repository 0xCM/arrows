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
        public static readonly TimedPair Zero = Define(OpTime.Zero, OpTime.Zero);
        
        public static implicit operator TimedPair((OpTime left, OpTime right) src)
            => Define(src.left, src.right);

        public static TimedPair Define(OpTime Left, OpTime Right)
            => new TimedPair(Left,Right);

        public TimedPair(OpTime Left, OpTime Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        
        public readonly OpTime Left;

        public readonly OpTime Right;

        public override string ToString()
            => $"{Left} | {Left} || Right | {Right}";
            
    }

}