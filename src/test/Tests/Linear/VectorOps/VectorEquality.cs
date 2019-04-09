//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    using operand = System.Int64;
    using static zcore;


    [DisplayName("vector/equality/long")]
    public class VectorEquality : VectorEquality<N8,operand>
    {
    
        public VectorEquality()
            : base(-250000,250000)
        {}

        public override void Verify()
            => base.Verify();

            
        public override IReadOnlyList<Vector<N8,bool>> Baseline()        
            => fuse(LeftPrimVecSrc, LeftPrimVecSrc, 
                (v1,v2) =>  vector<N8,bool>(v1 == v2));
                    
        
        public override IReadOnlyList<Vector<N8,bool>> Applied()        
            => fuse(LeftPrimVecSrc,LeftPrimVecSrc, 
                    (v1,v2) => vector<N8,bool>(v1 == v2));
    }


}