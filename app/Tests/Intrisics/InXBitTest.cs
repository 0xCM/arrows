//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    


    public abstract class InXBitTest<S,T> : InXTest<S,T>
        where T : struct, IEquatable<T>
        where S : InXBitTest<S,T>
    {

        protected InXBitTest(Interval<T>? domain = null, int? streamlen = null)
            : base(OpKind.TestBit.Vec128OpId<T>(), domain, streamlen)        
        {

        }
    }

    public class InXBitTestInt32 : InXBitTest<InXBitTestInt32,uint>
    {
        public void TestAllOn()
        {
            var v1 = Vec128.define(uint.MaxValue, uint.MaxValue,uint.MaxValue,uint.MaxValue);
            Claim.@true(dinx.allOn(v1));

            var v2 = Vec128.define(uint.MaxValue, uint.MaxValue - 1,uint.MaxValue,uint.MaxValue);
            Claim.@false(dinx.allOn(v2));                
        }     
    }
}