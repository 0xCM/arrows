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
    
    using static nfunc;
    using static zfunc;

    public readonly struct Vector<N, T> : ILengthwise
        where N : ITypeNat, new()
        where T : struct    
    {

        public static bool operator ==(Vector<N,T> lhs, Vector<N,T> rhs)
            => lhs.eq(rhs);

        public static bool operator !=(Vector<N,T> lhs, Vector<N,T> rhs)
            => lhs.neq(rhs);
        
        /// <summary>
        /// Vector => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Slice<N,T>(Vector<N,T> src)
            => src.data;

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
        //Slice<N,T> data {get;}

        T[] data {get;}

        [MethodImpl(Inline)]   
        public Vector(params T[] src)
            => data = src;

        [MethodImpl(Inline)]   
        public Vector(IEnumerable<T> src)
            => data = src.ToArray();

        [MethodImpl(Inline)]   
        public Vector(Slice<N,T> src)
            => data = src.data.ToArray();

        public T this[int index] 
            => data[index];

        /// <summary>
        /// Selects an index-identified component
        /// </summary>
        /// <param name="index">The 0-based component index</param>
        [MethodImpl(Inline)]   
        public T cell(uint index)
            => data[(int)index];

        /// <summary>
        /// Selects predicate-identified components
        /// </summary>
        /// <param name="index">The 0-based component index</param>
        [MethodImpl(Inline)]
        public IEnumerable<T> cells(Func<T,bool> predicate)
            => data.Where(predicate);

        public uint Length 
            => (uint)data.Length;

        [MethodImpl(Inline)]   
        public Covector<N, T> tranpose()
            => new Covector<N,T>(data);

        [MethodImpl(Inline)]
        public string format()
            => paren(string.Join(",", data));

        /// <summary>
        /// Retrurns true if a predicate holds for any components
        /// </summary>
        /// <param name="predicate">The adjudicating predicate</param>
        [MethodImpl(Inline)]   
        public bool any(Func<T,bool> predicate)
            => data.Any(predicate);

        /// <summary>
        /// Retrurns true if a predicate holds for all components
        /// </summary>
        /// <param name="predicate">The adjudicating predicate</param>
        [MethodImpl(Inline)]   
        public bool all(Func<T,bool> predicate)
            => data.All(predicate);

        [MethodImpl(Inline)]   
        public Vector<N,Y> fuse<Y>(Vector<N,T> rhs, Func<T,T,Y> composer)
            where Y : struct
                => new Vector<N,Y>(zfunc.fuse(data, rhs.data, composer));

        /// <summary>
        /// Transforms Vector[N,T] => Vector[Y,T] via component transformation f:T->Y
        /// </summary>
        /// <param name="f">The component transformation function</param>
        /// <typeparam name="Y">The transformation codomain</typeparam>
        [MethodImpl(Inline)]   
        public Vector<N,Y> map<Y>(Func<T,Y> f)
            where Y : struct
                => new Vector<N, Y>(zfunc.map(data,f));

        [MethodImpl(Inline)]   
        public IReadOnlyList<T> unwrap()
            => data;

        [MethodImpl(Inline)]
        public bool eq(Vector<N, T> rhs)
            => data.ReallyEqual(rhs.data);


        [MethodImpl(Inline)]
        public bool neq(Vector<N, T> rhs)
            => !eq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(Vector<N, T> rhs)
            => eq(rhs); 
 
        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is Covector<N,T> ? eq((Vector<N,T>)rhs) : false;
 
        public override string ToString()
            => format();

    }

}