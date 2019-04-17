//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    public abstract class BitTestTest<S,T> : InXTest<S,T>
        where T : struct, IEquatable<T>
        where S : BitTestTest<S,T>
    {

        protected static readonly InXBitTest<T> InXOp = InXG.bittest<T>();
        
        protected BitTestTest(Interval<T>? domain = null, int? streamlen = null)
            : base(P.bittest, domain, streamlen)        
        {

        }


    }

    public class BitTestTests
    {
        const string BasePath = P.InX128 + P.bittest;        

        [DisplayName(Path)]
        public class BitTestInt32 : BitTestTest<BitTestInt32,uint>
        {
            public const string Path = BasePath + P.uint32;


            public void TestAllOn()
            {
                var v1 = Vec128.define(uint.MaxValue, uint.MaxValue,uint.MaxValue,uint.MaxValue);
                Claim.@true(InXOp.allOn(v1));

                var v2 = Vec128.define(uint.MaxValue, uint.MaxValue - 1,uint.MaxValue,uint.MaxValue);
                Claim.@false(InXOp.allOn(v1));
                
            }     

        }

    }

}