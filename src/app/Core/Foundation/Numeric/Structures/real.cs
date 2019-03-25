//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;
    using structype = int64;
    using systype = System.Int64;

    using static Traits;
    using System.Collections.Generic;

    public readonly struct real<T> : Real<real<T>, T>
        where T : new()
    {


        static readonly Real<T> Ops = ops<T,Real<T>>();

        

        public real<T> ε 
            => throw new NotImplementedException();

        public T data => throw new NotImplementedException();

        public bool infinite => throw new NotImplementedException();

        public real<T> abs()
        {
            throw new NotImplementedException();
        }

        public real<T> acos()
        {
            throw new NotImplementedException();
        }

        public real<T> acosh()
        {
            throw new NotImplementedException();
        }

        public real<T> add(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> and(real<T> a)
        {
            throw new NotImplementedException();
        }

        public real<T> asin()
        {
            throw new NotImplementedException();
        }

        public real<T> asinh()
        {
            throw new NotImplementedException();
        }

        public real<T> atan()
        {
            throw new NotImplementedException();
        }

        public real<T> atanh()
        {
            throw new NotImplementedException();
        }

        public string bitstring()
        {
            throw new NotImplementedException();
        }

        public real<T> ceiling()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(real<T> other)
        {
            throw new NotImplementedException();
        }

        public real<T> cos()
        {
            throw new NotImplementedException();
        }

        public real<T> cosh()
        {
            throw new NotImplementedException();
        }

        public real<T> dec()
        {
            throw new NotImplementedException();
        }

        public real<T> distributeL((real<T> x, real<T> y) rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> distributeR((real<T> x, real<T> y) rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> div(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public Quorem<real<T>> divrem(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool eq(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> flip()
        {
            throw new NotImplementedException();
        }

        public real<T> floor()
        {
            throw new NotImplementedException();
        }

        public real<T> gcd(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool gt(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool gteq(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> inc()
        {
            throw new NotImplementedException();
        }

        public real<T> lshift(int shift)
        {
            throw new NotImplementedException();
        }

        public bool lt(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool lteq(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> mod(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> mul(real<T> a)
        {
            throw new NotImplementedException();
        }

        public real<T> negate()
        {
            throw new NotImplementedException();
        }

        public bool neq(real<T> rhs)
        {
            throw new NotImplementedException();
        }

        public real<T> or(real<T> a)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<real<T>> partition(real<T> min, real<T> max, real<T> width = default)
        {
            throw new NotImplementedException();
        }

        public real<T> rshift(int shift)
        {
            throw new NotImplementedException();
        }

        public Sign sign()
        {
            throw new NotImplementedException();
        }

        public real<T> sin()
        {
            throw new NotImplementedException();
        }

        public real<T> sinh()
        {
            throw new NotImplementedException();
        }

        public real<T> sqrt()
        {
            throw new NotImplementedException();
        }

        public real<T> tan()
        {
            throw new NotImplementedException();
        }

        public real<T> tanh()
        {
            throw new NotImplementedException();
        }

        public real<T> xor(real<T> a)
        {
            throw new NotImplementedException();
        }
 
         public bool Equals(real<T> rhs)
            => Ops.eq(this.data, rhs.data);

    }

}