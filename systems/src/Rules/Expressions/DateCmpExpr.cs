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
    /// Satisfied when a test date is aligned with a reference orientation
    /// </summary>
    public readonly struct DateCmpExpr
    {        
        public DateCmpExpr(TimeMarker reference, VarExpr<Date> param1, VarExpr<Date>? param2 = null)
        {
            this.Kind = reference;
            this.Param1 = param1;
            this.Param2 = param2;
        }

        /// <summary>
        /// The comparison type
        /// </summary>
        public readonly TimeMarker Kind;

        public readonly VarExpr<Date> Param1;

        public readonly VarExpr<Date>? Param2;

    }

}