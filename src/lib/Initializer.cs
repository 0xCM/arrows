//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Numerics;

    using static zcore;

    public sealed class Initalizer : SysInit<Initalizer>
    {
        protected override void ExecInit()
        {
            var classes = TypeClassAttribute.Find<Initalizer>();
            iter(classes, c => Resolver.define(c.operand, c.reifier));                    
        }
    }

}

