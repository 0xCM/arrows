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

    public readonly struct Vector<N, T> : IEnumerable<T>, Equatable<Vector<N,T>>, Formattable, Lengthwise
        where N : TypeNat, new()    
        where T : Equatable<T>, new()    
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
            => new Vector<N,T>(src.data);

        /// <summary>
        /// The underlying data
        /// </summary>
        public Slice<N,T> cells {get;}

        [MethodImpl(Inline)]   
        public Vector(params T[] src)
            => cells = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(IEnumerable<T> src)
            => cells = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(IReadOnlyList<T> src)
            => cells = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(Slice<N,T> src)
            => cells = src;

        public T this[int index] 
            => cells[index];

        [MethodImpl(Inline)]   
        public T cell(uint index)
            => cells[(int)index];

        public uint length 
            => cells.length;

        [MethodImpl(Inline)]   
        public Covector<N, T> tranpose()
            => new Covector<N,T>(cells);


        [MethodImpl(Inline)]   
        public IEnumerator<T> GetEnumerator()
            => cells.data.GetEnumerator();

        [MethodImpl(Inline)]   
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        [MethodImpl(Inline)]
        public string format()
            => cells.format();

        [MethodImpl(Inline)]
        public bool eq(Vector<N, T> rhs)
            => cells.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(Vector<N, T> rhs)
            => cells.neq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(Vector<N, T> rhs)
            => eq(rhs); 
 
        [MethodImpl(Inline)]
        public int hash()
            => cells.hash();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is Covector<N,T> ? eq((Vector<N,T>)rhs) : false;
 
         public override string ToString()
            => format();

    }

}