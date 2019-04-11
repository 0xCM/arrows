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

    using operand = System.Int64;
    using P = Paths;

    [DisplayName(Path)]
    public class Int64VectorEq : VectorEquality<Int64VectorEq,N8,operand>
    {
        public const string Path = P.nla + P.vectors + P.primitive + P.int64 + P.eq;        
    
        public Int64VectorEq()
            : base(Defaults.Int64Range)
        {}

        public override void Verify()
            => base.Verify();

            
        public override IReadOnlyList<Vector<N8,bool>> Baseline()        
        {
            var results = array<Vector<N8,bool>>(VectorCount);
            for(var i = 0; i< VectorCount; i++)
            {
                var lhs = LeftPrimVecSrc[i];
                var rhs = LeftPrimVecSrc[i];
                var dst = array<bool>(VectorLength);
                for(var j = 0; j < VectorLength; j++)
                    dst[j] = (lhs[j] == rhs[j]);
                results[i] = vector<N8,bool>(dst);
            }
            return results;
        }
 
        
        public override IReadOnlyList<Vector<N8,bool>> Applied()        
            => fuse(LeftPrimVecSrc,LeftPrimVecSrc, 
                    (v1,v2) => vector<N8,bool>(v1 == v2));
    }


}