//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;
    using static primops;

    public enum OpSet
    {
        
        All, 
        
        Primal, // PrimalAtomic & PrimalFused
        
        Intrisic,   // IntricFused & IntrinsicAtomic
        
        Fused,      //IntrinsicFused & PrimalFused

        Atomic    //IntrinsicAtomic & PrimalAtomic
        
    }

    public enum OpKind
    {

        Eq,

        
        Gt,
        
        GtEq,
        
        Lt,
        
        LtEq,

        Add,

        Sub,
        
        Div,
        
        Mul,

        Mod,

        Abs,

        Or,

        XOr,

        And,

        Flip,

        Sum,

        Avg
    }

    public static class OpKinds
    {
        public static IEnumerable<OpKind> All
            => type<OpKind>().GetEnumValues().AsQueryable().Cast<OpKind>();
    }

 
}