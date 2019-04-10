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

    using static zcore;
    using static ztest;
    using operand = System.Int64;


    [DisplayName("vector/add/long")]
    public class RealGInt64VectorAdd : VectorAdd<N8,operand>
    {
    
        public RealGInt64VectorAdd()
            : base(-250000,250000)
        {}

        public override void Verify()
            => base.Verify();

        public override IReadOnlyList<Vector<N8,operand>> Raw()
        {
            
            var dst = array<Vector<N8,operand>>(VectorCount);
            for(var i = 0; i< VectorCount; i++)
            {
                var v1 = LeftPrimVecSrc[i];
                var v2 = RightPrimVecSrc[i];
                var v3 = array<operand>(VectorLength);
                for(var j = 0; j < VectorLength; j++)
                    v3[j] = v1[j] * v2[j];
                dst[i] = vector<N8,operand>(v3);
                
            }
            return dst;

        }
            
        public override IReadOnlyList<Vector<N8,operand>> Baseline()        
            => fuse(LeftPrimVecSrc,RightPrimVecSrc, (v1,v2) =>
                    v1.fuse(v2, (x,y) => x + y));

        
        public override IReadOnlyList<Vector<N8,real<operand>>> Applied()        
            => fuse(LeftRealVecSrc,RightRealVecSrc, (v1,v2) =>
                    v1.fuse(v2, (x,y) => x + y));
    }

}