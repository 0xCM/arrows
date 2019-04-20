//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zcore;
    using static Structures;

    public interface Listed<S> : Equatable<S>, Nullary<S>, Reversible<S>, Lengthwise<S>
        where S : Listed<S>, new()
    {
        /// <summary>
        /// Returns the elements following the head, if any; otherwise, returns the zero element of S
        /// </summary>
        S tail();

    }

    public interface Listed<S,T> : Listed<S>
        where S : Listed<S,T>, new()
        where T : struct, MonoidA<T>
    {
        /// <summary>
        /// Returns the first constituent if it exits; otherwise, the zero element of T
        /// </summary>
        T head();

        /// <summary>
        /// Returns the last constituent if it exits; otherwise, the zero element of T
        /// </summary>
        T last();

        /// <summary>
        /// Replaces the existing list with a new list with specified content
        /// </summary>
        /// <param name="src"></param>
        S redefine(IEnumerable<T> src);
    }

    public static class Listing
    {
        public static Listing<T> define<T>(IEnumerable<T> src)
            where T : struct,MonoidA<T>
                => new Listing<T>(src);
    }

    public readonly struct Listing<T> : Listed<Listing<T>, T>
        where T : struct, MonoidA<T>
    {

        [MethodImpl(Inline)]
        public static bool operator ==(Listing<T> lhs, Listing<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(Listing<T> lhs, Listing<T> rhs)
            => lhs.neq(rhs);
   
        public static readonly Listing<T>  Empty = default;
        
        static readonly T EmptyElement = new T().zero;
        
        readonly Lazy<Slice<T>> _data;

        Slice<T> data
            => _data.Value;

        readonly IEnumerable<T> src;
        
        public Listing<T> zero 
            => Empty;

        public Listing(IEnumerable<T> items)
        {
            this.src = items;            
            _data = defer(() => items.ToSlice());
        }

        public Listing(Slice<T> items)
        {
            this.src = items;            
            _data = defer(() => items);
        }

        public Listing(params T[] items)
        {
            this.src = items;            
            _data = defer(() => slice(items));
        }
        
        public uint length 
            => data.length;

        [MethodImpl(Inline)]
        public bool eq(Listing<T> rhs)
            => data.eq(rhs.data);

        [MethodImpl(Inline)]
        public bool eq(Listing<T> lhs, Listing<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(Listing<T> rhs)
            => this.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(Listing<T> rhs)
            => data.neq(rhs.data);

        [MethodImpl(Inline)]
        public bool neq(Listing<T> lhs, Listing<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public T head()
            => data.FirstOrDefault(EmptyElement);

        [MethodImpl(Inline)]
        public Listing<T> tail()
            => data.length > 1 ? redefine(data.Skip(1)) : Empty;

        [MethodImpl(Inline)]
        public T last()
            => data.LastOrDefault(EmptyElement);

        [MethodImpl(Inline)]
        public bool nonzero()
            => length != 0;

        [MethodImpl(Inline)]
        public Listing<T> redefine(IEnumerable<T> content)
            => new Listing<T>(content);

        [MethodImpl(Inline)]
        public Listing<U> redefine<U>(IEnumerable<T> content, Func<T,U> f)
            where U : struct, MonoidA<U>
            => new Listing<U>(content.Select(f));

        [MethodImpl(Inline)]
        public Listing<T> reverse()
            => new Listing<T>(src.Reverse());
 
        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public string format()
            => data.format();

        public override string ToString() 
            => format();

        public override bool Equals(Object rhs)
            => rhs is Symbol ? eq((Listing<T>)rhs) : false;

        public override int GetHashCode() 
            => hash();
    }
}