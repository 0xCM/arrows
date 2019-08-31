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

    /// <summary>
    /// Identifies a primal comparison operator
    /// </summary>
    public enum PrimalCmpKind
    {
        
        Eq,
        
        NEq,

        Lt,
        
        LtEq,

        Gt,
        
        GtEq
    }


}