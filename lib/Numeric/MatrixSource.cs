//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static nfunc;

    public interface RandomMatrixSource<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : struct

    {
        IEnumerable<Matrix<M,N,T>> stream(T min, T max);
    }

    public readonly struct MatrixSource<M,N,T> : RandomMatrixSource<M,N,T>
        where N : ITypeNat, new()
        where M : ITypeNat, new()
        where T : struct
    {
        public static MatrixSource<M,N,T> Inhabitant = default;

        static readonly Dim<M,N> dim = Dim.define<M,N>();

        static readonly int datalen = (int)dim.volume();

        readonly IRandomizer rand;
        
        public MatrixSource(IRandomizer rand)
        {
            this.rand = rand;
        }

        /// <summary>
        /// Constructs a stream of random matrices
        /// </summary>
        /// <param name="dim">The dimension value; exits as a type inference aid</param>
        /// <param name="bounds">The interval constraining the entries</param>
        /// <typeparam name="M">The natural row count</typeparam>
        /// <typeparam name="N">The natural colun count</typeparam>
        /// <typeparam name="T">The entry type</typeparam>
        public IEnumerable<Matrix<M, N,T>> stream(T min, T max)
        {
            var len = natu<M>() * natu<N>();
            var primitives = rand.Random<T>().stream(min,max);
            while(true)
                yield return Matrix.define(dim, primitives.Take((int)len));                
        }  

    }

}

