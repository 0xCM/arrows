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
            where T : struct
                => new numbers<T>(src);

        [MethodImpl(Inline)]
        public static numbers<T> define<T>(ref Span<T> src)
            where T : struct
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
        public numbers(ref Span<T> src)
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
            =>  throw new NotImplementedException(); 

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(T[] src)
            => new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(Span<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(numbers<T> src)
            =>  src.data;


        [MethodImpl(Inline)]
        public static numbers<T> operator + (numbers<T> lhs, in numbers<T> rhs) 
            => fused.add(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator - (numbers<T> lhs, in numbers<T> rhs) 
            => fused.sub(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator * (numbers<T> lhs, in numbers<T> rhs) 
            => fused.mul(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator / (numbers<T> lhs, in numbers<T> rhs) 
            => fused.div(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator % (numbers<T> lhs, in numbers<T> rhs) 
            => fused.mod(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator & (numbers<T> lhs, in numbers<T> rhs) 
            => fused.and(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator | (numbers<T> lhs, in numbers<T> rhs) 
            => fused.or(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator ^ (numbers<T> lhs, in numbers<T> rhs) 
            => fused.xor(lhs.data, rhs.data, lhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator - (numbers<T> src) 
            => fused.negate(src.data, src.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator ++ (numbers<T> src) 
            => fused.inc(src.data, src.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator -- (numbers<T> src) 
            => fused.dec(src.data, src.data);

        [MethodImpl(Inline)]
        public static numbers<T> operator ~ (numbers<T> src) 
            => fused.flip(src.data, src.data);

        [MethodImpl(Inline)]
        public static Span<bool> operator < (in numbers<T> lhs, in numbers<T> rhs) 
            => fused.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator <= (in numbers<T> lhs, in numbers<T> rhs) 
            => fused.lteq<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator > (in numbers<T> lhs, in numbers<T> rhs) 
            => fused.gt<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static Span<bool> operator >= (in numbers<T> lhs, in numbers<T> rhs) 
            => fused.gteq<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static numbers<T> add(ref numbers<T> lhs, in numbers<T> rhs)
            => Numbers.define(ref fused.add(ref lhs.data, rhs.data));            

        [MethodImpl(Inline)]
        public static numbers<T> sub(ref numbers<T> lhs, in numbers<T> rhs)
            => Numbers.define(ref fused.sub(ref lhs.data, rhs.data));            

        [MethodImpl(Inline)]
        public static numbers<T> mul(ref numbers<T> lhs, in numbers<T> rhs)
            => fused.mul(lhs.data,rhs.data, lhs.data);            

        [MethodImpl(Inline)]
        public static numbers<T> div(ref numbers<T> lhs, in numbers<T> rhs)
            => fused.div(lhs.data,rhs.data, lhs.data);            

        [MethodImpl(Inline)]
        public static numbers<T> mod(ref numbers<T> lhs, in numbers<T> rhs)
            => fused.mod(lhs.data,rhs.data, lhs.data);            

        [MethodImpl(Inline)]
        static numbers<T> and(ref numbers<T> lhs, in numbers<T> rhs)
            => fused.and(lhs.data,rhs.data, lhs.data);            

        [MethodImpl(Inline)]
        static numbers<T> or(ref numbers<T> lhs, in numbers<T> rhs)
            => fused.or(lhs.data,rhs.data, lhs.data);            

        [MethodImpl(Inline)]
        static numbers<T> xor(ref numbers<T> lhs, in numbers<T> rhs)
            => fused.xor(lhs.data,rhs.data, lhs.data);            

        [MethodImpl(Inline)]
        public static numbers<T> negate(ref numbers<T> src)
            => fused.negate(src.data, src.data);            

        [MethodImpl(Inline)]
        public static numbers<T> inc(numbers<T> src)
            => new numbers<T>(fused.inc(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> dec(numbers<T> src)
            => new numbers<T>(fused.dec(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> flip(numbers<T> src)
            => new numbers<T>(fused.flip(src.data, src.data));            

        [MethodImpl(Inline)]
        public static numbers<T> abs(numbers<T> src)
            => fused.abs(src.data, src.data);            

        [MethodImpl(Inline)]
        static Span<bool> eq(in numbers<T> lhs, in numbers<T> rhs)
            => fused.eq<T>(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        static Span<bool> gt(in numbers<T> lhs, in numbers<T> rhs)
            => fused.gt<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        static Span<bool> gteq(in numbers<T> lhs, in numbers<T> rhs)
            => fused.gteq<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static Span<bool> lt(in numbers<T> lhs, in numbers<T> rhs)
            => fused.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> lteq(in numbers<T> lhs, in numbers<T> rhs)
            => fused.lteq<T>(lhs.data,rhs.data);


        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public override int GetHashCode()
            =>throw new NotSupportedException(); 
    }
}