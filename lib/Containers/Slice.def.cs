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

    using static zcore;
    using static zfunc;
    using static nats;

    /// <summary>
    /// Encapsulates a linear data segment with length determined at runtime
    /// </summary>
    public readonly struct Slice<T> : Structures.Slice<Slice<T>, T>
        where T : struct, IEquatable<T>
    {                    
        
        [MethodImpl(Inline)]   
        public static Slice<T> operator + (Slice<T> lhs, Slice<T> rhs)
            => new Slice<T>(lhs.data.Concat(rhs.data));

        [MethodImpl(Inline)]   
        public static bool operator == (Slice<T> lhs, Slice<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]   
        public static bool operator != (Slice<T> lhs, Slice<T> rhs)
            => not(lhs == rhs);

        public Index<T> data {get;}

        [MethodImpl(Inline)]   
        public static implicit operator Slice<T>(T[] src)
            => new Slice<T>(src);

        [MethodImpl(Inline)]   
        public Slice(params T[] src)
        {
            this.length = src.Length();
            this.data = src;
        }

        [MethodImpl(Inline)]   
        public Slice(Index<T> src)
        {
            this.data = src;
            this.length = this.data.Length();
        }

        [MethodImpl(Inline)]   
        public Slice(IEnumerable<T> src)
        {
            this.data = src.ToArray();
            this.length = this.data.Length();
        }

        public uint length {get;}
    

        public T this[int i] 
            => data[i];

        public T this[uint i] 
            => data[(int)i];


        public T this[ulong i] 
            => data[(int)i];

        public (Slice<T> lhs, Slice<T> rhs) conform(Slice<T> rhs, T filler)
        {
            var lhsLen = length;
            var rhsLen = rhs.length;
            if(lhsLen == rhsLen)
                return(this,rhs);

            var filled = repeat(filler, lhsLen > rhsLen ? lhsLen - rhsLen : lhsLen - rhsLen);
            if(lhsLen > rhsLen)
                return (this, rhs + filled);
            else
                return (this + filled, rhs);
        }

        [MethodImpl(Inline)]   
        public Slice<N,T> ToNatLenth<N>()
            where N : ITypeNat, new()
                => new Slice<N,T>(data);

        /// <summary>
        /// Reverses the slice elements
        /// </summary>
        [MethodImpl(Inline)]   
        public Z0.Slice<T> Reverse()
            => slice(data.Reverse());

        /// <summary>
        /// Reverses the slice elements
        /// </summary>
        [MethodImpl(Inline)]   
        public Z0.Slice<T> filter(Func<T,bool> predicate)
            => slice(data.Where(predicate));

        public IEnumerator<T> GetEnumerator()
            => (data as IReadOnlyList<T>).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public bool eq(Slice<T> lhs, Slice<T> rhs)
        {
            if(lhs.length != rhs.length)
                return false;

            for(var i = 0; i<length; i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    return false;
            }
            return true;            
        }

        [MethodImpl(Inline)]   
        public bool neq(Slice<T> lhs, Slice<T> rhs)
            => not(eq(lhs,rhs));

        [MethodImpl(Inline)]   
        public bool eq(Slice<T> rhs)
            => eq(this, rhs);

        [MethodImpl(Inline)]   
        public bool neq(Slice<T> rhs)
            => neq(this, rhs);

        [MethodImpl(Inline)]   
        public bool Equals(Slice<T> rhs)
            => eq(this,rhs);

        [MethodImpl(Inline)]   
        public int hash()
            => data.HashCode();

        /// <summary>
        /// Renders the slice as a comma-delimted parenthetical value
        /// </summary>
        public string format()
            => paren(csv(data));

        public override bool Equals(object rhs)
            => rhs is Slice<T> ? Equals((Slice<T>)rhs) : false;

        public override int GetHashCode()
            => hash();

        public override string ToString()
            => format();
    
        [MethodImpl(Inline)]   
        public Index<T> unwrap()
            => data;
    }        

    /// <summary>
    /// Encapsulates a linear data segment with naturally-typed length
    /// </summary>
    public readonly struct Slice<N,T> : Structures.Slice<Slice<N,T>,T>
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

        public Slice<T> data {get;}

        public uint length {get;}


        [MethodImpl(Inline)]
        public Slice(params T[] src)
        {
             this.data = src;
             this.length = (uint)Prove.claim<N>(data.length);
        }

        [MethodImpl(Inline)]
        public Slice(IReadOnlyList<T> src)
        {
            this.data = new Slice<T>(src);
            this.length = (uint)Prove.claim<N>(data.length);
        }

        [MethodImpl(Inline)]
        public Slice(IEnumerable<T> src)
        {
            this.data = src.Take((int)natu<N>()).ToArray();
            this.length = (uint)Prove.claim<N>(data.length);
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
            => data.eq(rhs.data);

        [MethodImpl(Inline)]   
        public bool neq(Slice<N, T> rhs)
            => data.neq(rhs.data);

        [MethodImpl(Inline)]   
        public bool eq(Slice<N, T> lhs, Slice<N, T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]   
        public bool neq(Slice<N, T> lhs, Slice<N, T> rhs)
            => lhs.neq(rhs);
 
        [MethodImpl(Inline)]   
        public int hash()
            => data.HashCode();

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
        public Index<T> unwrap()
            => data.unwrap();


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
            => data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
 
        public override string ToString()
            => format();
    }        
}