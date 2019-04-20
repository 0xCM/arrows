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
    public readonly struct Covector<N, T> : Equatable<Covector<N,T>>, IEnumerable<T>, Formattable, Lengthwise
        where N : TypeNat, new() 
        where T : struct, IEquatable<T>    
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
            => new Covector<N,T>(src.data);

        /// <summary>
        /// The underlying data
        /// </summary>
        public Slice<N,T> cells {get;}

        [MethodImpl(Inline)]   
        public Covector(params T[] src)
            => cells = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Covector(Slice<N,T> src)
            => cells = src;

        [MethodImpl(Inline)]   
        public Covector(IEnumerable<T> src)
            => cells = slice<N,T>(src); 

        [MethodImpl(Inline)]   
        public Covector(IReadOnlyList<T> src)
            => cells = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public T cell(uint index) 
            => cells[(int)index];

        public T this[int index] 
            => cells[index];

        public uint length 
            => cells.length;

        [MethodImpl(Inline)]   
        public Vector<N,T> tranpose()
            => new Vector<N,T>(cells);

        [MethodImpl(Inline)]   
        public string format()
            => cells.format();


        public bool eq(Covector<N, T> rhs)
            => cells.eq(rhs);

        [MethodImpl(Inline)]   
        public bool neq(Covector<N, T> rhs)
            => cells.neq(rhs);

        [MethodImpl(Inline)]   
        public bool eq(Covector<N, T> lhs, Covector<N, T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]   
        public bool neq(Covector<N, T> lhs, Covector<N, T> rhs)
            => lhs.neq(rhs);

  
        [MethodImpl(Inline)]
        public bool Equals(Covector<N, T> rhs)
            => eq(rhs);

        [MethodImpl(Inline)]   
        public IReadOnlyList<T> unwrap()
            => cells.unwrap();

        public IEnumerator<T> GetEnumerator()
            => cells.data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        [MethodImpl(Inline)]
        public int hash()
            => cells.hash();

        public override int GetHashCode()
            => hash();

        public override string ToString()
            => format();

        public override bool Equals(object obj)
            => obj is Covector<N,T> ? eq((Covector<N,T>)obj) : false;
    }

}