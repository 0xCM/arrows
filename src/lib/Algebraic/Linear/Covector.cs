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

    public static class Covector
    {
        [MethodImpl(Inline)]   
        public static T apply<N,T>(Covector<N,T> cv, Vector<N,T> v)
            where N : TypeNat, new()        
            where T : Traits.Semiring<T>, new()
        {
            var sr = new T();
            var result = sr.zero;
            for(var i = 0u; i<cv.length; i++)
                result = sr.add(result, sr.mul(cv.cell(i), v.cell(i)));
            return result;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> define<N,T>(Dim<N> dim, params T[] src) 
                where N : TypeNat, new() => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> define<N,T>(params T[] src) 
                where N : TypeNat, new() => new Covector<N,T>(src);


        [MethodImpl(Inline)]
        public static Covector<N,T> add<N,T>(Covector<N,T> lhs, Covector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Traits.Semiring<T>, new()
                => Slice.add(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static Covector<N,T> mul<N,T>(Covector<N,T> lhs, Covector<N,T> rhs) 
            where N : TypeNat, new() 
            where T : Traits.Semiring<T>, new()            
                => Slice.mul(lhs.cells,rhs.cells);

        [MethodImpl(Inline)]
        public static T sum<N,T>(Covector<N,T> x) 
            where N : TypeNat, new() 
            where T : Traits.Semiring<T>, new()
                => Slice.sum(x.cells);


    }

    /// <summary>
    /// Strutural represention of the dual of an N-dimensional vector
    /// </summary>
    public readonly struct Covector<N, T> : Traits.Covector<N, T>, Traits.Formattable
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

        public override string ToString()
            => format();

    }

}