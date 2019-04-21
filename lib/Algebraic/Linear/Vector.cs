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

    public readonly struct Vector<N, T> : Equatable<Vector<N,T>>, Formattable, Lengthwise
        where N : TypeNat, new()
        where T : struct, IEquatable<T>    
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
        Slice<N,T> data {get;}

        [MethodImpl(Inline)]   
        public Vector(params T[] src)
            => data = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(IReadOnlyList<T> src)
            => data = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(IEnumerable<T> src)
            => data = slice<N,T>(src);

        [MethodImpl(Inline)]   
        public Vector(Slice<N,T> src)
            => data = src;

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

        public uint length 
            => data.length;

        [MethodImpl(Inline)]   
        public Covector<N, T> tranpose()
            => new Covector<N,T>(data);

        [MethodImpl(Inline)]
        public string format()
            => data.format();

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
            => data.all(predicate);

        /// <summary>
        /// Reduces the cells via a monoid
        /// </summary>
        /// <param name="monoid">The monoid to use</param>

        [MethodImpl(Inline)]   
        public T reduce(Operative.Monoidal<T> monoid)
            =>  data.reduce(monoid);

        [MethodImpl(Inline)]   
        public Vector<N,Y> fuse<Y>(Vector<N,T> rhs, Func<T,T,Y> composer)
            where Y : struct, IEquatable<Y>    
                => new Vector<N,Y>(zcore.fuse(unwrap(), rhs.unwrap(), composer));

        /// <summary>
        /// Transforms Vector[N,T] => Vector[Y,T] via component transformation f:T->Y
        /// </summary>
        /// <param name="f">The component transformation function</param>
        /// <typeparam name="Y">The transformation codomain</typeparam>
        [MethodImpl(Inline)]   
        public Vector<N,Y> map<Y>(Func<T,Y> f)
            where Y : struct, IEquatable<Y>    
                => new Vector<N, Y>(data.map(f));

        [MethodImpl(Inline)]   
        public IReadOnlyList<T> unwrap()
            => data.unwrap();

        [MethodImpl(Inline)]
        public bool eq(Vector<N, T> rhs)
            => data.eq(rhs);


        [MethodImpl(Inline)]
        public bool neq(Vector<N, T> rhs)
            => data.neq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(Vector<N, T> rhs)
            => eq(rhs); 
 
        [MethodImpl(Inline)]
        public int hash()
            => data.hash();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => rhs is Covector<N,T> ? eq((Vector<N,T>)rhs) : false;
 
        public override string ToString()
            => format();

    }

}