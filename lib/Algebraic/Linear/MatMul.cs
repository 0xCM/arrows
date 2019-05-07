//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using static zcore;
    using static Traits;

    public readonly struct MatMul<M,N,P,T> 
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where P : ITypeNat, new()
        where T : struct, Operative.Semiring<T>, IEquatable<T>
    {
        
        readonly Matrix<M,N,T> lhs;
        
        public MatMul(Matrix<M,N,T> lhs)
            => this.lhs = lhs;
        
        [MethodImpl(Inline)]
        public Matrix<M, P, T> mul(Matrix<N, P, T> rhs)
        {            
            var m = Prove.claim<M>(rhs.dim().i);
            var p = Prove.claim<P>(rhs.dim().j);
            var product = new T[m*p];
            for(var i = 0u; i< m; i++)
                for(var j =0u; j< p; j++)
                    product[i] = Covector.apply(lhs.covector(i), rhs.vector(j));
            return Matrix.define<M,P,T>(product);
        }
    }



}
