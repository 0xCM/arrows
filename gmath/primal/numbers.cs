//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    
    using static zcore;
    using static global::mfunc;

    public static class numbers
    {
        [MethodImpl(Inline)]
        public static numbers<T> define<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new numbers<T>(src);

    }

    public readonly ref struct numbers<T>
        where T : struct, IEquatable<T>
    {
        
        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(T[] src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(Span<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(ReadOnlySpan<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(numbers<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static Span<bool> operator == (numbers<T> lhs, numbers<T> rhs) 
            => eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span<bool> operator != (numbers<T> lhs, numbers<T> rhs) 
            => neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static numbers<T> operator + (numbers<T> lhs, numbers<T> rhs) 
            => add(lhs,rhs);

        [MethodImpl(Inline)]
        public static numbers<T> operator - (numbers<T> lhs, numbers<T> rhs) 
            => sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static numbers<T> operator * (numbers<T> lhs, numbers<T> rhs) 
            => mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static numbers<T> operator / (numbers<T> lhs, numbers<T> rhs) 
            => div(lhs,rhs);


        [MethodImpl(Inline)]
        public static numbers<T> operator % (numbers<T> lhs, numbers<T> rhs) 
            => mod(lhs,rhs);


        [MethodImpl(Inline)]
        public static numbers<T> operator & (numbers<T> lhs, numbers<T> rhs) 
            => and(lhs,rhs);

        [MethodImpl(Inline)]
        public static numbers<T> operator | (numbers<T> lhs, numbers<T> rhs) 
            => or(lhs,rhs);

        [MethodImpl(Inline)]
        public static numbers<T> operator ^ (numbers<T> lhs, numbers<T> rhs) 
            => xor(lhs,rhs);


        [MethodImpl(Inline)]
        public static numbers<T> operator - (numbers<T> src) 
            => negate(src);

        [MethodImpl(Inline)]
        public static numbers<T> operator ++ (numbers<T> src) 
            => inc(src);

        [MethodImpl(Inline)]
        public static numbers<T> operator -- (numbers<T> src) 
            => dec(src);

        [MethodImpl(Inline)]
        public static numbers<T> operator ~ (numbers<T> src) 
            => flip(src);

        [MethodImpl(Inline)]
        public static Span<bool> operator < (numbers<T> lhs, numbers<T> rhs) 
            => lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span<bool> operator <= (numbers<T> lhs, numbers<T> rhs) 
            => lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span<bool> operator > (numbers<T> lhs, numbers<T> rhs) 
            => gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static Span<bool> operator >= (numbers<T> lhs, numbers<T> rhs) 
            => gteq(lhs,rhs);

        [MethodImpl(Inline)]
        static numbers<T> add(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.add(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> sub(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.sub(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> mul(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.mul(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> div(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.div(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> mod(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.mod(lhs.data,rhs.data, ref dst));            
        }


        [MethodImpl(Inline)]
        static numbers<T> and(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.and(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> or(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.or(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> xor(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<T>(length(lhs.data,rhs.data));
            return new numbers<T>(gmath.xor(lhs.data,rhs.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static Span<bool> gt(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<bool>(length(lhs.data,rhs.data));
            return gmath.gt(lhs.data,rhs.data, ref dst);            
        }

        [MethodImpl(Inline)]
        static Span<bool> gteq(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<bool>(length(lhs.data,rhs.data));
            return gmath.gteq(lhs.data,rhs.data, ref dst);            
        }

        [MethodImpl(Inline)]
        static Span<bool> eq(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<bool>(length(lhs.data,rhs.data));
            return gmath.eq(lhs.data,rhs.data, ref dst);            
        }

        [MethodImpl(Inline)]
        static Span<bool> neq(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<bool>(length(lhs.data,rhs.data));
            return gmath.neq(lhs.data,rhs.data, ref dst);            
        }

        [MethodImpl(Inline)]
        static Span<bool> lt(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<bool>(length(lhs.data,rhs.data));
            return gmath.lt(lhs.data,rhs.data, ref dst);            
        }

        [MethodImpl(Inline)]
        static Span<bool> lteq(numbers<T> lhs, numbers<T> rhs)
        {
            var dst = span<bool>(length(lhs.data,rhs.data));
            return gmath.lteq(lhs.data,rhs.data, ref dst);            
        }

        [MethodImpl(Inline)]
        static numbers<T> negate(numbers<T> src)
        {
            var dst = span<T>(src.data.Length);
            return new numbers<T>(gmath.negate(src.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> inc(numbers<T> src)
        {
            var dst = span<T>(src.data.Length);
            return new numbers<T>(gmath.inc(src.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> dec(numbers<T> src)
        {
            var dst = span<T>(src.data.Length);
            return new numbers<T>(gmath.dec(src.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> flip(numbers<T> src)
        {
            var dst = span<T>(src.data.Length);
            return new numbers<T>(gmath.flip(src.data, ref dst));            
        }

        [MethodImpl(Inline)]
        static numbers<T> abs(numbers<T> src)
        {
            var dst = span<T>(src.data.Length);
            return new numbers<T>(gmath.abs(src.data, ref dst));            
        }

        readonly ReadOnlySpan<T> data;

        [MethodImpl(Inline)]
        public numbers(Span<T> data)
            => this.data = data;

        [MethodImpl(Inline)]
        public numbers(ReadOnlySpan<T> data)
            => this.data = data;

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => data[i];            
        }

        [MethodImpl(Inline)]
        public bool Equals(numbers<T> rhs)
        {
            var lhs = this;
            var result = span<bool>(rhs.data.Length);
            gmath.eq(lhs.data,rhs.data, ref result);
            var notEq = result.Contains(false);
            return !notEq;
        }
         
        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public override int GetHashCode()
            =>throw new NotSupportedException();

 
    }


}