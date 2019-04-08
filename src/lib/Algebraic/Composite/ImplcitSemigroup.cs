//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    using static Structures;

    public static class ImplicitSemigroup 
    {
        public static ImplicitSemigroup<T> define<T>(T src)
            where T : struct, IEquatable<T>
                => new ImplicitSemigroup<T>(src);
    }
    
    public interface ImplicitSemigroup<S,T> : 
        Wrapped<T>, 
        Structures.Nullary<S>, 
        Operative.Nullary<T>, 
        Structures.Semigroup<S>, 
        Operative.Semigroup<T>,
        Formattable
    where S : ImplicitSemigroup<S,T>, new()
    where T : struct, IEquatable<T>
    
    {

    }

    public readonly struct ImplicitSemigroup<T> : ImplicitSemigroup<ImplicitSemigroup<T>,T>
        where T : struct, IEquatable<T>
    {
        public static readonly ImplicitSemigroup<T> Inhabitant = default;

        [MethodImpl(Inline)]
        public static bool operator == (ImplicitSemigroup<T> lhs, T rhs)
            => lhs.data.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (ImplicitSemigroup<T> lhs, T rhs)
            => not(lhs.data.Equals(rhs));

        [MethodImpl(Inline)]
        public static bool operator == (T lhs, ImplicitSemigroup<T> rhs)
            => lhs.Equals(rhs.data);

        [MethodImpl(Inline)]
        public static bool operator != (T lhs, ImplicitSemigroup<T> rhs)
            => not(lhs.Equals(rhs.data));

        [MethodImpl(Inline)]
        public static bool operator == (ImplicitSemigroup<T> lhs, ImplicitSemigroup<T> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (ImplicitSemigroup<T> lhs, ImplicitSemigroup<T> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public static implicit operator ImplicitSemigroup<T>(T src)
            => new ImplicitSemigroup<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(ImplicitSemigroup<T> src)
            => new ImplicitSemigroup<T>(src);
        
        [MethodImpl(Inline)]
        public ImplicitSemigroup(T src)
            => this.data = src;

        readonly T data;

        public T zero 
        {
            [MethodImpl(Inline)]
            get => Inhabitant.data;
        }
            
        ImplicitSemigroup<T> Nullary<ImplicitSemigroup<T>>.zero 
        {
            [MethodImpl(Inline)]
            get => Inhabitant;
        }

        [MethodImpl(Inline)]
        public bool eq(ImplicitSemigroup<T> rhs)
            => data.Equals(rhs.data);

        [MethodImpl(Inline)]
        public bool Equals(ImplicitSemigroup<T> other)
            => data.Equals(other.data);

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public bool neq(ImplicitSemigroup<T> rhs)
            => not(data.Equals(rhs.data));

        [MethodImpl(Inline)]
        public bool Equals(T rhs)
            => rhs.Equals(data);

        [MethodImpl(Inline)]
        public T unwrap()
            => data;

        [MethodImpl(Inline)]
        public bool eq(T lhs, T rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public bool neq(T lhs, T rhs)
            => not(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public string format()
            => data.ToString();

        [MethodImpl(Inline)]
        public override int GetHashCode()
            => data.GetHashCode();            

        [MethodImpl(Inline)]
        public override bool Equals(object rhs)
            => rhs is ImplicitSemigroup<T> 
              ? eq((ImplicitSemigroup<T>)rhs) 
              : false;
    }
}