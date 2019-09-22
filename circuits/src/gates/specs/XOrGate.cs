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

    public readonly struct XOrGate : IBinaryBitGate
    {
        internal static readonly XOrGate Gate = default;        
        
        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => (x ^ y);
    }

}