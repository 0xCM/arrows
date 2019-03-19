//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;

    using C = Contracts;

    public static class frac
    {
        public static fraction<T> define<T>(T over, T under)
            where T : new()
                => new fraction<T>(over,under);
    }
    
    /// <summary>
    /// Represents a rational number
    /// </summary>
    public readonly struct fraction<T> : C.Rational<fraction<T>, T>
        where T : new()
    {
        static readonly C.Integer<T> ops = MathOps.integer<T>();

        public static implicit operator fraction<T> ((T over, T under) x)
            => new fraction<T>(x.over,x.under);

        public static implicit operator (T over,T under) (fraction<T> x)
            => (x.over, x.under);

        public (intg<T> over,intg<T> under) data {get;}


        [MethodImpl(Inline)]
        public fraction (T over, T under) 
            => this.data = (over,under);

        public T over => data.over;            

        public T under => data.under;

        public fraction<T> zero 
            => (ops.zero, ops.one);

        public fraction<T> one 
            => (ops.one,ops.one);

        (T over, T under) C.Structural<fraction<T>, (T over, T under)>.data 
            => (data.over, data.under);

        public fraction<T> add(fraction<T> rhs)
            => (data.over + rhs.over, data.under + rhs.under);

        public fraction<T> div(fraction<T> rhs)
            => mul(rhs.reciprocal());

        public fraction<T> mul(fraction<T> rhs)
            => throw new NotImplementedException();

        public fraction<T> sub(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool eq(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool neq(fraction<T> rhs)
        {
            throw new NotImplementedException();
        }

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

        fraction<T> C.Divisive<fraction<T>, (T over, T under)>.div(fraction<T> rhs)
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

        public fraction<T> reciprocal()
            => (under,over);

        public string bitstring()
        {
            throw new NotImplementedException();
        }
    }

}