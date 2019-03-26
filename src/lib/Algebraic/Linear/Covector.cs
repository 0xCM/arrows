//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;


    /// <summary>
    /// Strutural represention of the dual of an N-dimensional vector
    /// </summary>
    public readonly struct Covector<N, T> : Traits.Covector<N, T>
        where N : TypeNat, new()        
    {
        /// <summary>
        /// Vector => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Slice<N,T>(Covector<N,T> src)
            => src.cells;

        /// <summary>
        /// Slice => Vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Covector<N,T>(Slice<N,T> src)
            => new Covector<N,T>(src.cells);

        /// <summary>
        /// The underlying data
        /// </summary>
        public Slice<N,T> cells {get;}

        [MethodImpl(Inline)]   
        public Covector(params T[] src)
            => cells = natcheck<N,T>(src);

        [MethodImpl(Inline)]   
        public Covector(Slice<N,T> src)
            => cells = src;

        [MethodImpl(Inline)]   
        public Covector(IEnumerable<T> src)
            => cells = natcheck<N,T>(src.ToArray());

        [MethodImpl(Inline)]   
        public Covector(IReadOnlyList<T> src)
            => cells = new Slice<N,T>(natcheck<N,T>(src));

        public T this[int index] 
            => cells[index];

        public uint length 
            => cells.length;

        public Vector<N,T> tranpose()
            => new Vector<N,T>(cells);

        public override string ToString()
            => cells.ToString();
    }

}