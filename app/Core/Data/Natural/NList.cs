//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    partial class Reify
    {

        /// <summary>
        /// Defines an immutable list whose length is specified via a typenat
        /// </summary>
        public readonly struct NList<N,T> : Listed<N,T>
            where N : TypeNat
        {
            readonly IReadOnlyList<T> data;
            
            public int length {get;}

            int IReadOnlyCollection<T>.Count 
                => data.Count;

            T IReadOnlyList<T>.this[int index] 
                => data[index];

            public NList(IEnumerable<T> src)
            {
                this.data = src.ToList();
                this.length = natcheck<N>(data.Count);
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
                => data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => data.GetEnumerator();
        }
    }
}