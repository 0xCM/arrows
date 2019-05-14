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
        
    using static mfunc;
    using static zfunc;

    public static class Numbers
    {
        [MethodImpl(Inline)]
        public static numbers<T> define<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new numbers<T>(src);

        [MethodImpl(Inline)]
        public static numbers<T> define<T>(Span<T> src)
            where T : struct, IEquatable<T>
                => new numbers<T>(src);

    }

    public ref struct numbers<T>
        where T : struct
    {
        Span<T> data;

        [MethodImpl(Inline)]
        public numbers(Span<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public numbers(num<T>[] src)
            => this.data = src.Extract();


        [MethodImpl(Inline)]
        public Span<T> Extract(bool copy = false)
        {
            if(copy)
            {
                var dst = span<T>(data.Length);
                data.CopyTo(dst);
                return dst;
            }
            else
                return data;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> ToReadOnlySpan()
            => data;

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();


        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];            
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => data.Length;            
        }

        [MethodImpl(Inline)]
        public bool Equals(numbers<T> rhs)
            =>  throw new NotImplementedException(); //not(eq(this, rhs).Contains(false));

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(T[] src)
            => new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(Span<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(numbers<T> src)
            =>  src.data;

        // [MethodImpl(Inline)]
        // public static Span<bool> operator == (numbers<T> lhs, numbers<T> rhs) 
        //     => eq(lhs,rhs);

        // [MethodImpl(Inline)]
        // public static Span<bool> operator != (numbers<T> lhs, numbers<T> rhs) 
        //     => neq(lhs,rhs);

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
        public static numbers<T> add(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.add(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        public static numbers<T> sub(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.sub(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        public static numbers<T> mul(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.mul(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        public static numbers<T> div(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.div(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        public static numbers<T> mod(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.mod(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        static numbers<T> and(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.and(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        static numbers<T> or(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.or(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        static numbers<T> xor(numbers<T> lhs, numbers<T> rhs)
            => new numbers<T>(gmath.xor(lhs.data,rhs.data, lhs.data));            

        [MethodImpl(Inline)]
        static Span<bool> gt(numbers<T> lhs, numbers<T> rhs)
        {
            return gmath.gt<T>(lhs.data, rhs.data);            
        }

        [MethodImpl(Inline)]
        static Span<bool> gteq(numbers<T> lhs, numbers<T> rhs)
        {
            return gmath.gteq<T>(lhs.data, rhs.data);            
        }

        // [MethodImpl(Inline)]
        // public static Span<bool> eq(numbers<T> lhs, numbers<T> rhs)
        //     => gmath.eq<T>(lhs.data,rhs.data);            

        // [MethodImpl(Inline)]
        // public static Span<bool> neq(numbers<T> lhs, numbers<T> rhs)
        //     => gmath.neq<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> lt(numbers<T> lhs, numbers<T> rhs)
            => gmath.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> lteq(numbers<T> lhs, numbers<T> rhs)
            => gmath.lteq<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static numbers<T> negate(numbers<T> src)
            => numbers<T>(gmath.negate(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> inc(numbers<T> src)
            => new numbers<T>(gmath.inc(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> dec(numbers<T> src)
            => new numbers<T>(gmath.dec(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> flip(numbers<T> src)
            => new numbers<T>(gmath.flip(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> abs(numbers<T> src)
            => new numbers<T>(gmath.abs(src.data, src.data));            

         
        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public override int GetHashCode()
            =>throw new NotSupportedException(); 
    }
}