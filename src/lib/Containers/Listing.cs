//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;


    /// <summary>
    /// Characterizes an enumerable with a known length as specified
    /// by a natural type parameter
    /// </summary>
    public interface Enumerable<N,I> : IEnumerable<I>
        where N : TypeNat, new()
    {

        /// <summary>
        /// The value of the natural parameter
        /// </summary>
        uint length {get;}
    }

    /// <summary>
    /// Characterizes an immutable list whose length is specified via a typenat
    /// </summary>
    public interface Listed<N,T> : Enumerable<N,T>, IReadOnlyList<T>
        where N : TypeNat, new()
    {
    
    }

    /// <summary>
    /// Defines an immutable list whose length is specified via a typenat
    /// </summary>
    public readonly struct Listing<N,T> : Listed<N,T>
        where N : TypeNat, new()
    {
        readonly IReadOnlyList<T> data;
        
        public uint length {get;}

        int IReadOnlyCollection<T>.Count 
            => data.Count;

        T IReadOnlyList<T>.this[int index] 
            => data[index];

        public Listing(IEnumerable<T> src)
        {
            this.data = src.ToList();
            this.length = Prove.claim<N>(data.Length());
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => data.GetEnumerator();
    }

}