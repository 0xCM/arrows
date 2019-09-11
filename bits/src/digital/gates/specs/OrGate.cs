//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct OrGate : IBinaryBitGate
    {
        internal static readonly OrGate Gate = default;        
        
        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => (x | y);
    }

}