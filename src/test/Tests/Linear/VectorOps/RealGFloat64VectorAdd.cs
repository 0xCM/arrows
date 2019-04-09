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


    [DisplayName("vector/dot/double")]
    public class RealGFloat64VectorAdd : VectorAdd<N8,double>
    {
    
        public RealGFloat64VectorAdd()
            : base(-250000.00,250000.00)
        {}

            
        public override IReadOnlyList<Vector<N8,double>> Raw()
        {
            
            var dst = array<Vector<N8,double>>(VectorCount);
            for(var i = 0; i< VectorCount; i++)
            {
                var v1 = LeftPrimVecSrc[i];
                var v2 = RightPrimVecSrc[i];
                var v3 = array<double>(VectorLength);
                for(var j = 0; j < VectorLength; j++)
                    v3[j] = v1[j] * v2[j];
                dst[i] = vector<N8,double>(v3);
                
            }
            return dst;

        }
            
        public override IReadOnlyList<Vector<N8,double>> Baseline()        
            => fuse(LeftPrimVecSrc,RightPrimVecSrc, (v1,v2) =>
                    v1.fuse(v2, (x,y) => x + y));

        
        public override IReadOnlyList<Vector<N8,real<double>>> Applied()        
            => fuse(LeftRealVecSrc,RightRealVecSrc, (v1,v2) =>
                    v1.fuse(v2, (x,y) => x + y));

    }

}