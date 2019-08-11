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


    public enum ScalarComparisonKind
    {
        Eq,
        
        NEq,

        Lt,
        
        LtEq,

        Gt,
        
        GtEq
    }

    public readonly struct ScalarComparison<T>
        where T : struct
    {
        
        public ScalarComparison(T Param, ScalarComparisonKind Comparison)
        {
            this.Param = Param;
            this.Comparison = Comparison;
        }
        
        public readonly T Param;

        public readonly ScalarComparisonKind Comparison;

    }


}