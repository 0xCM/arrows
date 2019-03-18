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
        public static frac<T> define<T>(T over, T under)
            where T : new()
                => new frac<T>(over,under);
    }
    
    /// <summary>
    /// Represents a rational number
    /// </summary>
    public readonly struct frac<T> : C.Rational<frac<T>, T>
        where T : new()
    {
        public (T over,T under) data {get;}

        [MethodImpl(Inline)]
        public frac (T over, T under) 
            => data = (over, under);        

        public T over 
            => data.over;

        public T  under 
            => data.under;

        public frac<T> zero => throw new NotImplementedException();

        public frac<T> one => throw new NotImplementedException();

        public frac<T> add(frac<T> rhs)
            => throw new NotImplementedException();

        public QR<frac<T>> div(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        public frac<T> mul(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        public frac<T> sub(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool eq(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        public bool neq(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        public frac<T> abs()
        {
            throw new NotImplementedException();
        }

        public Sign sign()
        {
            throw new NotImplementedException();
        }

        public frac<T> mod(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        frac<T> C.Divisive<frac<T>, (T over, T under)>.div(frac<T> rhs)
        {
            throw new NotImplementedException();
        }

        public frac<T> ceiling()
        {
            throw new NotImplementedException();
        }

        public frac<T> floor()
        {
            throw new NotImplementedException();
        }
    }

}