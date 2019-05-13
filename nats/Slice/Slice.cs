//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Encapsulates a linear data segment with naturally-typed length
    /// </summary>
    public readonly struct Slice<N,T> //: ISlice<Slice<N,T>,T>
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>
    {                    
        
        /// <summary>
        /// Interprets an array as a slice
        /// </summary>
        /// <param name="s">The source slice</param>
        [MethodImpl(Inline)]
        public static implicit operator Slice<N,T>(T[] src)
            => new Slice<N,T>(src);
        
        static readonly uint Length = (uint)natu<N>();

        public T[] data {get;}

        public uint length {get;}


        [MethodImpl(Inline)]
        public Slice(params T[] src)
        {
             this.data = src;
             this.length = (uint)Prove.claim<N>(data.Length);
        }

        [MethodImpl(Inline)]
        public Slice(IReadOnlyList<T> src)
        {
            this.data = src.ToArray();
            this.length = (uint)Prove.claim<N>(data.Length);
        }

        [MethodImpl(Inline)]
        public Slice(IEnumerable<T> src)
        {
            this.data = src.Take((int)natu<N>()).ToArray();
            this.length = (uint)Prove.claim<N>(data.Length);
        }

        public T this[int i] 
            => data[i];

        public T this[uint i] 
            => data[i];

        public T this[ulong i] 
            => data[i];


        /// <summary>
        /// Reverses the slice elements
        /// </summary>
        [MethodImpl(Inline)]   
        public Z0.Slice<N,T> Reverse()
            => slice<N, T>(Enumerable.Reverse(data));

        [MethodImpl(Inline)]   
        public bool eq(Slice<N, T> rhs)
            => data.ReallyEqual(rhs.data);

        [MethodImpl(Inline)]   
        public bool neq(Slice<N, T> rhs)
            => ! data.ReallyEqual(rhs.data);

        [MethodImpl(Inline)]   
        public bool eq(Slice<N, T> lhs, Slice<N, T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]   
        public bool neq(Slice<N, T> lhs, Slice<N, T> rhs)
            => lhs.neq(rhs);
 

        [MethodImpl(Inline)]   
        public bool Equals(Slice<N, T> rhs)
            => eq(rhs);

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

        /// <summary>
        /// Reduces the cells via a monoid
        /// </summary>
        /// <param name="monoid">The monoid to use</param>
        [MethodImpl(Inline)]   
        public T reduce(IMonoidalOps<T> monoid)
            =>  fold(data,monoid);

        [MethodImpl(Inline)]   
        public T[] unwrap()
            => data;

        /// <summary>
        /// Transforms slice[T] to slice[Y] via component transformation f:T->Y
        /// </summary>
        /// <param name="f">The component transformation function</param>
        /// <typeparam name="Y">The transformation codomain</typeparam>
        [MethodImpl(Inline)]   
        public Slice<N,Y> map<Y>(Func<T,Y> f)
            where Y : struct, IEquatable<Y>    
                => new Slice<N, Y>(data.Select(x => f(x)));

        /// <summary>
        /// Renders the slice as a comma-delimted parenthetical value
        /// </summary>
        [MethodImpl(Inline)]   
        public string format()
            => paren(csv(data));

        public IEnumerator<T> GetEnumerator()
            => (data as IReadOnlyList<T>).GetEnumerator();

        // IEnumerator IEnumerable.GetEnumerator()
        //     => GetEnumerator();
 
        public override string ToString()
            => format();
    }            
}