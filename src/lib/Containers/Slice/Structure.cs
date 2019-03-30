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


    /// <summary>
    /// Encapsulates a linear data segment with length determined at runtime
    /// </summary>
    public readonly struct Slice<T> : Traits.Slice<Slice<T>, T>
        where T : Structure.Equatable<T>, new()        
    {                    
        public static Slice<T> operator + (Slice<T> lhs, Slice<T> rhs)
            => new Slice<T>(lhs.data.Concat(rhs.data));

        public static bool operator == (Slice<T> lhs, Slice<T> rhs)
            => lhs.Equals(rhs);

        public static bool operator != (Slice<T> lhs, Slice<T> rhs)
            => not(lhs == rhs);

        public IReadOnlyList<T> data {get;}

        public static implicit operator Slice<T>(T[] src)
            => new Slice<T>(src);

        public Slice(params T[] src)
        {
            this.length = src.Length();
            this.data = src;
        }

        public Slice(IReadOnlyList<T> src)
        {
            this.data = src;
            this.length = this.data.Length();
        }

        public Slice(IEnumerable<T> src)
        {
            this.data = src.ToArray();
            this.length = this.data.Length();
        }

        public intg<uint> length {get;}

        public T this[int i] 
            => data[i];

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

        public Slice<N,T> ToNatLenth<N>()
            where N : TypeNat, new()
                => new Slice<N,T>(data);

        /// <summary>
        /// Reverses the slice elements
        /// </summary>
        [MethodImpl(Inline)]   
        public Z0.Slice<T> reverse()
            => slice(data.Reverse());

        [MethodImpl(Inline)]   
        Slice<T> Traits.Reversible<Slice<T>>.reverse(Slice<T> src)
            => src.reverse();

        /// <summary>
        /// Reverses the slice elements
        /// </summary>
        [MethodImpl(Inline)]   
        public Z0.Slice<T> filter(Func<T,bool> predicate)
            => slice(data.Where(predicate));

        /// <summary>
        /// Renders the slice as a comma-delimted parenthetical value
        /// </summary>
        public string format()
            => paren(csv(data));

        public IEnumerator<T> GetEnumerator()
            => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        public bool eq(Slice<T> lhs, Slice<T> rhs)
        {
            if(lhs.length != rhs.length)
                return false;
            for(var i = 0; i<length; i++)
            {
                if(lhs[i].neq(rhs[i]))
                    return false;
            }
            return true;            
        }

        public bool neq(Slice<T> lhs, Slice<T> rhs)
            => not(eq(lhs,rhs));

        public bool Equals(Slice<T> rhs)
            => eq(this,rhs);

        public override bool Equals(object rhs)
            => rhs is Slice<T> ? Equals((Slice<T>)rhs) : false;

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => format();

    }        


    /// <summary>
    /// Encapsulates a linear data segment with naturally-typed length
    /// </summary>
    public readonly struct Slice<N,T> : Traits.NSlice<Slice<N,T>,N,T>, IEnumerable<T>, Traits.Reversible<Slice<N,T>,T>
        where N : TypeNat, new()
    {                    
        

        /// <summary>
        /// Interprets an array as a slice
        /// </summary>
        /// <param name="s">The source slice</param>
        [MethodImpl(Inline)]
        public static implicit operator Slice<N,T>(T[] src)
            => new Slice<N,T>(src);
        
        static readonly uint Length = natval<N>();

        public IReadOnlyList<T> data {get;}

        public intg<uint> length {get;}

        [MethodImpl(Inline)]
        public Slice(params T[] src)
        {
             this.data = src;
             this.length = Prove.claim<N>(data.Length());
        }

        [MethodImpl(Inline)]
        public Slice(IReadOnlyList<T> src)
        {
            this.data = src;
            this.length = Prove.claim<N>(data.Length());
        }

        [MethodImpl(Inline)]
        public Slice(IEnumerable<T> src)
        {
            this.data = src.Take((int)natval<N>()).ToArray();
            this.length = Prove.claim<N>(this.data.Count);
        }


        public T this[int i] 
            => data[i];

        /// <summary>
        /// Renders the slice as a comma-delimted parenthetical value
        /// </summary>
        [MethodImpl(Inline)]   
        public string format()
            => paren(csv(data));

        /// <summary>
        /// Reverses the slice elements
        /// </summary>
        [MethodImpl(Inline)]   
        public Z0.Slice<N,T> reverse()
            => slice<N,T>(data.Reverse());

        public IEnumerator<T> GetEnumerator()
            => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
 
        public override string ToString()
            => format();

        Slice<N, T> Traits.Reversible<Slice<N,T>>.reverse(Slice<N, T> src)
            => src.reverse();

    }        

}