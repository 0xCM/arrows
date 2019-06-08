//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static MathSym;    
    
    public readonly struct Arrow<S,T> 
    {
        public const char DefaultSymbol = ArrowSym.LongRightArrow;
        
        [MethodImpl(Inline)]
        public Arrow(S Source, T Target)
        {
            this.Source = Source;
            this.Target = Target;
        }

        public readonly S Source;

        public readonly T Target;

        public override string ToString()
            => $"{Source} {DefaultSymbol} {Target}";
    }

}