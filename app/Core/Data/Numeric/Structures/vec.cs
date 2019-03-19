//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static corefunc;

    using C = Contracts;
    using System.Collections;
    

    public readonly struct vec<N, T> : C.Vector<N, T> , C.Additive<vec<N,T>,T>
        where N : C.TypeNat        
    {
        public IReadOnlyList<T> data {get;}

        [MethodImpl(Inline)]   
        public vec(params T[] src)
            => data = natcheck<N,T>(src);

        [MethodImpl(Inline)]   
        public vec(IEnumerable<T> src)
            => data = natcheck<N,T>(src.ToList());

        public T this[int index] 
            => data[index];

        public int length 
            => data.Count;

        int IReadOnlyCollection<T>.Count 
            => data.Count;


        public vec<N, T> add(vec<N, T> rhs)
            =>throw new Exception();

        IEnumerator IEnumerable.GetEnumerator()
            => data.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => data.GetEnumerator();

    }

}