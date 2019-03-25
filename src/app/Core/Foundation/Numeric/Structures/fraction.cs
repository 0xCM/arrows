//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;

    using static Traits;

    
    /// <summary>
    /// Represents a rational number
    /// </summary>
    public readonly struct fraction<T> : Rational<fraction<T>, T>, IEquatable<fraction<T>>
        where T : Integer<T>, new()
    {
        static readonly Integer<T> Ops = integer<T>();

        public static implicit operator fraction<T> ((T over, T under) x)
            => new fraction<T>(x.over,x.under);

        public static implicit operator (T over,T under) (fraction<T> x)
            => (x.over, x.under);

        [MethodImpl(Inline)]
        public static bool operator == (fraction<T> lhs, fraction<T> rhs) 
            => Ops.eq(lhs.over, rhs.over) && Ops.eq(lhs.under, rhs.under);

        [MethodImpl(Inline)]
        public static bool operator != (fraction<T> lhs, fraction<T> rhs) 
            => not(lhs == rhs);


        [MethodImpl(Inline)]
        public fraction (T over, T under) 
            => this.data = ( sigmul(over,under).ToIntG<T>() * Ops.abs(over),Ops.abs(under));

        public (intg<T> over,intg<T> under) data {get;}

        public T over 
            => data.over;            

        public T under 
            => data.under;

        public fraction<T> zero 
            => (Ops.zero, Ops.one);

        public fraction<T> one 
            => (Ops.one,Ops.one);

        (T over, T under) Structure<fraction<T>, (T over, T under)>.data 
            => data;

        [MethodImpl(Inline)]
        public fraction<T> add(fraction<T> rhs)
            => (data.over + rhs.over, data.under + rhs.under);

        [MethodImpl(Inline)]
        public fraction<T> div(fraction<T> rhs)
            => mul(rhs.reciprocal());

        [MethodImpl(Inline)]
        public fraction<T> mul(fraction<T> rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public fraction<T> sub(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

        [MethodImpl(Inline)]
        public bool eq(fraction<T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(fraction<T> rhs)
            => this != rhs;

        public fraction<T> reciprocal()
            => (under,over);

       public fraction<T> abs()
       {
            throw new NotImplementedException();
       }

        public Sign sign()
        {
            throw new NotImplementedException();
        }

        public fraction<T> mod(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

        public fraction<T> ceiling()
        {
            throw new NotImplementedException();
        }

        public fraction<T> floor()
        {
            throw new NotImplementedException();
        }

 
        public string bitstring()
        {
            throw new NotImplementedException();
        }

        public fraction<T> negate()
        {
            throw new NotImplementedException();
        }

        public fraction<T> distributeL((fraction<T> x, fraction<T> y) rhs)
        {
            throw new NotImplementedException();
        }

        public fraction<T> distributeR((fraction<T> x, fraction<T> y) rhs)
        {
            throw new NotImplementedException();
        }

        public fraction<T> gcd(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

        public Quorem<fraction<T>> divrem(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object rhs)
            => rhs is fraction<T> ? Equals(rhs) : false;

        public override int GetHashCode()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(fraction<T> rhs)
            => this == rhs;

    }

}