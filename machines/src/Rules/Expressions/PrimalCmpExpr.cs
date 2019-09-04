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
    /// Defines a primal comparison expression
    /// </summary>    
    public readonly struct PrimalCmpExpr<T> : IRuleExpr<T>
        where T : struct
    {        
        public PrimalCmpExpr(T Value, PrimalCmpKind Comparison)
        {
            this.Value = Value;
            this.Kind = Comparison;
        }

        /// <summary>
        /// The value to be compared
        /// </summary>
        public readonly T Value {get;}

        /// <summary>
        /// The type of comparison to apply
        /// </summary>
        public readonly PrimalCmpKind Kind;

    }

}