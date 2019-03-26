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


    public static class Vector
    {
        [MethodImpl(Inline)]
        public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
                where N : TypeNat, new() => Slice.add(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
                where N : TypeNat, new() => Slice.mul(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Vector<N,T> x) 
                where N : TypeNat, new() => Slice.sum(x.cells);

    }

    public readonly struct Vector<N, T> : Traits.Vector<N, T>, IEnumerable<T>
        where N : TypeNat, new()        
    {

        /// <summary>
        /// Vector => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Slice<N,T>(Vector<N,T> src)
            => src.cells;

        /// <summary>
        /// Slice => Vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Vector<N,T>(Slice<N,T> src)
            => new Vector<N,T>(src.cells);

        /// <summary>
        /// The underlying data
        /// </summary>
        public Slice<N,T> cells {get;}

        [MethodImpl(Inline)]   
        public Vector(params T[] src)
            => cells = natcheck<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(IEnumerable<T> src)
            => cells = natcheck<N,T>(src.ToArray());

        [MethodImpl(Inline)]   
        public Vector(IReadOnlyList<T> src)
            => cells = new Slice<N,T>(natcheck<N,T>(src));

        [MethodImpl(Inline)]   
        public Vector(Slice<N,T> src)
            => cells = src;

        public T this[int index] 
            => cells[index];

        public uint length 
            => cells.length;

        [MethodImpl(Inline)]   
        public Covector<N, T> tranpose()
            => new Covector<N,T>(cells);

        public override string ToString()
            => cells.ToString();

        [MethodImpl(Inline)]   
        public IEnumerator<T> GetEnumerator()
            => cells.cells.GetEnumerator();

        [MethodImpl(Inline)]   
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
}

 

}