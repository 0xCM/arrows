//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    public readonly struct LiteralExpr<T> : IRuleExpr<T>
    {
        public LiteralExpr(T Value)
            => this.Value = Value;
        
        public T Value {get;}
    }


}