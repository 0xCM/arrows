//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;


    public readonly struct NotGate : ILogicGate<NotGate,Bit,Bit>
    {
        public static readonly NotGate G = default;
        
        [MethodImpl(Inline)]
        public Bit Send(Bit input)
            => !input;    
    }


}