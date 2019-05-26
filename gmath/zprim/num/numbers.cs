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
        public static numbers<T> define<T>(Span256<T> src)
            where T : struct
                => new numbers<T>(src);                

    }

    public ref struct numbers<T>
        where T : struct
    {
        Span256<T> data;

        [MethodImpl(Inline)]
        public numbers(Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public numbers(ReadOnlySpan256<T> src)
            => this.data = src.Replicate();


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
            =>  throw new NotImplementedException(); 


        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(Span256<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(ReadOnlySpan256<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(numbers<T> src)
            =>  src.data;


        [MethodImpl(Inline)]
        public static numbers<T> operator + (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.add(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator - (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.sub(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator * (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.mul(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator / (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.div(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator % (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.mod(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator & (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.and(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator | (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.or(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator ^ (numbers<T> lhs, in numbers<T> rhs) 
            => gmath.xor(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator - (numbers<T> src) 
            => gmath.negate(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator ++ (numbers<T> src) 
            => gmath.inc(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator -- (numbers<T> src) 
            => gmath.dec(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator ~ (numbers<T> src) 
            => gmath.flip(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static Span<bool> operator < (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator <= (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.lteq<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator > (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.gt<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static Span<bool> operator >= (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.gteq<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> add(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.add(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> sub(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.sub(
                lhs.data.ToReadOnlySpan(),
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();            

        [MethodImpl(Inline)]
        public static numbers<T> mul(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.mul(
                lhs.data.ToReadOnlySpan(),
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();            

        [MethodImpl(Inline)]
        public static numbers<T> div(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.div(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> mod(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.mod(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        static numbers<T> and(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.and(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        static numbers<T> or(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.or(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        static numbers<T> xor(ref numbers<T> lhs, in numbers<T> rhs)
            => gmath.xor(
                lhs.data.ToReadOnlySpan(), 
                rhs.data.ToReadOnlySpan(), 
                lhs.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> negate(ref numbers<T> src)
             => gmath.negate(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> inc(numbers<T> src)
            => gmath.inc(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> dec(numbers<T> src)
            => gmath.dec(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> flip(numbers<T> src)
            => gmath.flip(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> abs(numbers<T> src)
            => gmath.abs(
                src.data.ToReadOnlySpan(), 
                src.data.ToSpan()
                    ).ToSpan256();            

        [MethodImpl(Inline)]
        static Span<bool> eq(in numbers<T> lhs, in numbers<T> rhs)
            => gmath.eq<T>(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        static Span<bool> gt(in numbers<T> lhs, in numbers<T> rhs)
            => gmath.gt<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        static Span<bool> gteq(in numbers<T> lhs, in numbers<T> rhs)
            => gmath.gteq<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static Span<bool> lt(in numbers<T> lhs, in numbers<T> rhs)
            => gmath.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> lteq(in numbers<T> lhs, in numbers<T> rhs)
            => gmath.lteq<T>(lhs.data,rhs.data);

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}