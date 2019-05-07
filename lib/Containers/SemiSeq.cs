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

    /// <summary>
    /// Defines the primary semi-sequence api
    /// </summary>
    public static class SemiSeq
    {
        /// <summary>
        /// Constructs a semisequence from an enumerable
        /// </summary>
        /// <param name="src">The element source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static SemiSeq<T> define<T>(IEnumerable<T> src)
            where T : Structures.Semigroup<T>, new()
                => new SemiSeq<T>(src);

        /// <summary>
        /// Constructs a semisequence from a parameter array
        /// </summary>
        /// <param name="src">The element source</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static SemiSeq<T> define<T>(params T[] src)
            where T : Structures.Semigroup<T>, new()
                => new SemiSeq<T>(src);
    }

    /// <summary>
    /// Canonical semiseq reification structure
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public readonly struct SemiSeq<T> :  Contain.SemiSeq<SemiSeq<T>,T>
        where T : Structures.Semigroup<T>, new()
    {        
        public static readonly SemiSeq<T> Empty  = new SemiSeq<T>(new T[]{});
        
        [MethodImpl(Inline)]   
        public static bool operator == (SemiSeq<T> lhs, SemiSeq<T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]   
        public static SemiSeq<T> operator + (SemiSeq<T> lhs, SemiSeq<T> rhs)
            => lhs.concat(rhs);

        [MethodImpl(Inline)]   
        public static bool operator != (SemiSeq<T> lhs, SemiSeq<T> rhs)
            => not(lhs == rhs);


        [MethodImpl(Inline)]   
        public SemiSeq(params T[] src)
            => this._content = defer(() => src.ToIndex());        

        [MethodImpl(Inline)]   
        public SemiSeq(IEnumerable<T> src)
            => this._content = defer(() => src.ToIndex());        

        readonly Lazy<Index<T>> _content;

        uint length 
            => (uint)_content.Value.Count;

        public T[] content 
            => _content.Value;

        public SemiSeq<T> zero 
            => Empty;

        IEnumerable<T> Contain.DiscreteContainer<SemiSeq<T>, T>.content 
            => content;

        [MethodImpl(Inline)]   
        public bool eq(SemiSeq<T> rhs)
        {
            if(length != rhs.length)
                return false;
            
            var equated = map(zip(content,rhs.content), x =>  x.right.eq(x.left));
            return not(equated.Any(x => x == false));
        }

        [MethodImpl(Inline)]   
        public int hash()
            => content.HashCode();

        [MethodImpl(Inline)]   
        public bool neq(SemiSeq<T> rhs)
            => not(eq(rhs));

        [MethodImpl(Inline)]   
        public SemiSeq<T> concat(SemiSeq<T> rhs)
            => new SemiSeq<T>(content.Concat(rhs.content));

        [MethodImpl(Inline)]   
        public bool Equals(SemiSeq<T> rhs)        
            => eq(rhs);

        public override bool Equals(object rhs)
            => rhs is SemiSeq<T> ? Equals((SemiSeq<T>)rhs) : false;

        public override int GetHashCode()
            => hash();
    }
}

