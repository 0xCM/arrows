//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using C = Contracts;

    using static corefunc;
    using static MathOps;
    
    public static class intG
    {
        public static intg<T> define<T>(T value)
            where T : new() => value;


        public static IEnumerable<intg<T>> range<T>(intg<T> min, intg<T> max)
            where T : new()
        {
            var current = min;
            while(current <= max)
                yield return current++;
        }

        public static bool prime<T>(intg<T> candidate)
            where T : new()
                => divisors(candidate).Count() == 0;


        /// <summary>
        /// Enumerates the divisors of the input values, excluding 1 and itself
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static IEnumerable<intg<T>> divisors<T>(intg<T> src)
            where T : new()
        {
            var candidates = range(intg<T>.One.inc(), src.abs().dec());
            foreach(var c in candidates)
                if(c.divides(src))
                    yield return c;
        }
    }    

    /// <summary>
    /// Represents an integer predicated on (and constrained by) an underlying type
    /// </summary>
    public readonly struct intg<T> : C.Integer<intg<T>,T> 
        where T : new()
    {
        static readonly C.Integer<T> ops 
            = MathOps.integer<T>();

        public static readonly intg<T> Zero = ops.zero;

        public static readonly intg<T> One = ops.one;

        public static implicit operator intg<T>(T src)
            => new intg<T>(src);

        public static implicit operator T(intg<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static bool operator == (intg<T> lhs, intg<T> rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (intg<T> a, intg<T> b) 
            => ops.neq(a,b);

        [MethodImpl(Inline)]
        public static intg<T> operator + (intg<T> lhs, intg<T> rhs) 
            => ops.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ++ (intg<T> x) 
            => ops.inc(x);


        [MethodImpl(Inline)]
        public static intg<T> operator - (intg<T> lhs, intg<T> rhs) 
            => ops.sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator -- (intg<T> x) 
            =>  ops.dec(x);

        [MethodImpl(Inline)]
        public static intg<T> operator * (intg<T> lhs, intg<T> rhs) 
            => ops.mul(lhs, rhs);


        [MethodImpl(Inline)]
        public static intg<T> operator / (intg<T> lhs, intg<T> rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator % (intg<T> lhs, intg<T> rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (intg<T> lhs, intg<T> rhs) 
            => ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (intg<T> lhs, intg<T> rhs) 
            => ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (intg<T> lhs, intg<T> rhs) 
            => ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (intg<T> lhs, intg<T> rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator & (intg<T> lhs, intg<T> rhs) 
            => ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator | (intg<T> lhs, intg<T> rhs) 
            => ops.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ^ (intg<T> lhs, intg<T> rhs) 
            => ops.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator ~ (intg<T> x) 
            => ops.flip(x);

        [MethodImpl(Inline)]
        public static intg<T> operator >> (intg<T> lhs, int rhs) 
            => ops.rshift(lhs, rhs);

        [MethodImpl(Inline)]
        public static intg<T> operator << (intg<T> lhs, int rhs) 
            => ops.lshift(lhs, rhs);

        public T data {get;}

        public intg<T> zero => ops.zero;

        public intg<T> one => ops.one;

        public intg (T x) 
            => data = x;

        [MethodImpl(Inline)]
        public intg<T> dec() 
            => ops.dec(data);

        [MethodImpl(Inline)]
        public intg<T> add(intg<T> rhs)
            => ops.add(data, rhs);


        [MethodImpl(Inline)]
        public intg<T> sub(intg<T> rhs)
            => ops.sub(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> mul(intg<T> rhs)
            => ops.mul(data,rhs);

        
        [MethodImpl(Inline)]
        public intg<T> div(intg<T> rhs)
            => ops.div(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> mod(intg<T> rhs)
            => ops.mod(data,rhs);

        [MethodImpl(Inline)]
        public bool divides(intg<T> lhs)
            => lhs % this == zero;

        [MethodImpl(Inline)]
        public bool even()
            => one.inc().divides(this);

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());


        [MethodImpl(Inline)]
        public QR<intg<T>> divrem(intg<T> rhs)
            => map(ops.divrem(data,rhs), 
                x => QR.define<intg<T>>(x.q,x.r));

        [MethodImpl(Inline)]
        public intg<T> and(intg<T> rhs)
            => ops.and(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> or(intg<T> rhs)
            => ops.or(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> xor(intg<T> rhs)
            => ops.xor(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> flip()
            => ops.flip(data);

        [MethodImpl(Inline)]
        public intg<T> lshift(int rhs)
            => ops.lshift(data, rhs);

        [MethodImpl(Inline)]
        public bool eq(intg<T> rhs)
            => ops.eq(this,rhs);

        [MethodImpl(Inline)]
        public bool neq(intg<T> rhs)
            => ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public intg<T> rshift(int rhs)
            => ops.rshift(data, rhs);
 
        [MethodImpl(Inline)]
        public bool lteq(intg<T> rhs) 
            => ops.lteq(this, rhs);

        [MethodImpl(Inline)]
        public bool gteq(intg<T> rhs) 
            => ops.gteq(this, rhs);

        [MethodImpl(Inline)]
        public bool lt(intg<T> rhs) 
            => ops.lt(this, rhs);

        [MethodImpl(Inline)]
        public bool gt(intg<T> rhs) 
            => ops.gt(this, rhs);

        [MethodImpl(Inline)]
        public intg<T> inc()
            =>  ops.inc(data);

        [MethodImpl(Inline)]
        public intg<T> abs()
            =>ops.abs(data);

        [MethodImpl(Inline)]
        public Sign sign()
            => ops.sign(data);

        [MethodImpl(Inline)]
        public int CompareTo(intg<T> rhs)
            => ops.lt(data,rhs) ? -1
             : ops.eq(data,rhs) ? 0
             : 1;
            
        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();
    }
}