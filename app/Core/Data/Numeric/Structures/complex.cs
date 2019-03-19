//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    
    using static corefunc;
    using static MathOps;

    using C = Contracts;


    public static class complex
    {
        [MethodImpl(Inline)]        
        public static complex<T> define<T>(T re, T im)
            where T : new()
                => throw new NotImplementedException();
    }

    /// <summary>
    /// Defines a parameterized complex number 
    /// </summary>
    public readonly struct complex<T> : C.Number<complex<T>,(T re,T im)>
        where T : new()
    {
        static readonly C.Number<T> ops = MathOps.number<T>();
        
        public static readonly complex<T> Zero = (ops.zero,ops.zero);
        public static readonly complex<T> One = (ops.one,ops.zero);        
        public static implicit operator complex<T>((T re, T im) x)
            => complex.define(x.re,x.im);


        [MethodImpl(Inline)]
        public static bool operator == (complex<T> lhs, complex<T> rhs) 
            => ops.eq(lhs.re, rhs.re) && ops.eq(rhs.im, rhs.im);

        [MethodImpl(Inline)]
        public static bool operator != (complex<T> lhs, complex<T> rhs) 
            => ops.neq(lhs.re, rhs.re) && ops.neq(rhs.im, rhs.im);

        [MethodImpl(Inline)]
        public static complex<T> operator + (complex<T> a, complex<T> b) 
            => (ops.add(a.data.re, b.re), ops.add(a.data.im, b.data.im));

        [MethodImpl(Inline)]
        public static complex<T> operator - (complex<T> a, complex<T> b) 
            => (ops.sub(a.data.re, b.re), ops.sub(a.data.im, b.data.im));

        [MethodImpl(Inline)]        
        public complex (T re, T im) 
            => data = (re,im);        

        public (T re,T im) data {get;}

        public T re 
        {
            [MethodImpl(Inline)]
            get{return data.re;}
        }

        public T im
        {
            [MethodImpl(Inline)]
            get{return data.im;}
        }

        public complex<T> zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public complex<T> one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }

        public complex<T> add(complex<T> rhs)
            => this + rhs;

        public complex<T> sub(complex<T> rhs)
            => this - rhs;

        public QR<complex<T>> div(complex<T> rhs)        
            => throw new NotImplementedException();
        
        public complex<T> mul(complex<T> rhs)
            => throw new NotImplementedException();

        public bool eq(complex<T> rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        bool Equals(complex<T> rhs)
            => ops.eq(re, rhs.re) && ops.eq(im, rhs.im);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public bool neq(complex<T> rhs)
            => this != rhs;

        public complex<T> abs()
        {
            throw new NotImplementedException();
        }

        public Sign sign()
            => Sign.Neutral;

        public complex<T> mod(complex<T> rhs)
        {
            throw new NotImplementedException();
        }

        complex<T> C.Divisive<complex<T>, (T re, T im)>.div(complex<T> rhs)
        {
            throw new NotImplementedException();
        }

        public (T re, T im) mul((T re, T im) a, (T re, T im) b)
        {
            throw new NotImplementedException();

        }

        public string bitstring()
        {
            throw new NotImplementedException();
        }
    }
}