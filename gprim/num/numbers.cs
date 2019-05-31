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
        public numbers(in Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public numbers(in ReadOnlySpan256<T> src)
            => this.data = src.Replicate();


        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(in Span256<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator numbers<T>(in ReadOnlySpan256<T> src)
            =>  new numbers<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(in numbers<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static numbers<T> operator + (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.add(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator - (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.sub(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator * (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.mul(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator / (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.div(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator % (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.mod(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator & (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.and(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator | (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.or(lhs.data, rhs.data, span<T>(count(lhs,rhs))).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator ^ (in numbers<T> lhs, in numbers<T> rhs) 
            => gmath.xor(lhs.data, rhs.data, lhs.data.ToSpan()).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator << (in numbers<T> lhs, int rhs) 
            => gmath.shiftl(lhs.data.Unblock().ToReadOnlySpan(), rhs).ToSpan256();


        [MethodImpl(Inline)]
        public static numbers<T> operator >> (in numbers<T> lhs, int rhs) 
            => gmath.shiftr(lhs.data.Unblock().ToReadOnlySpan(), rhs).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator - (in numbers<T> src) 
            => gmath.negate(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator ++ (in numbers<T> src) 
            => gmath.inc(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator -- (in numbers<T> src) 
            => gmath.dec(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static numbers<T> operator ~ (in numbers<T> src) 
            => gmath.flip(src.data, alloc(src)).ToSpan256();

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
        public numbers<T> Add(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.add(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Sub(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.sub(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Mul(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.mul(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Div(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.div(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Mod(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.mod(ref x, y).ToSpan256();
            return this;
        }


        [MethodImpl(Inline)]
        public numbers<T> Negate()
        {
            var x = data.Unblock();
            data = gmath.negate(ref x).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Inc()
        {
            var x = data.Unblock();
            data = gmath.inc(ref x).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Dec()
        {
            var x = data.Unblock();
            data = gmath.dec(ref x).ToSpan256();
            return this;
        }


        [MethodImpl(Inline)]
        public numbers<T> Abs()
        {
            var x = data.Unblock();
            data = gmath.abs(ref x).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> And(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.and(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Or(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.or(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> XOr(in numbers<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            data = gmath.xor(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> ShiftL(in numbers<int> shifts)
        {
            var x = data.Unblock();
            var y = shifts.data.Unblock();
            data = gmath.shiftl(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> ShiftR(in numbers<int> shifts)
        {
            var x = data.Unblock();
            var y = shifts.data.Unblock();
            data = gmath.shiftr(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> RotL(in numbers<int> shifts)
        {
            var x = data.Unblock();
            var y = shifts.data.Unblock();
            data = gmath.rotl(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> RotR(in numbers<int> shifts)
        {
            var x = data.Unblock();
            var y = shifts.data.Unblock();
            data = gmath.rotr(ref x, y).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public numbers<T> Flip()
        {
            var x = data.Unblock();
            data = gmath.flip(ref x).ToSpan256();
            return this;
        }

        [MethodImpl(Inline)]
        public Span<bool> Eq(in numbers<T> rhs)
            => gmath.eq<T>(data, rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Gt(in numbers<T> rhs)
            => gmath.gt<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> GtEq(in numbers<T> rhs)
            => gmath.gteq<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Lt(in numbers<T> rhs)
            => gmath.lt<T>(data,rhs.data);            

        [MethodImpl(Inline)]
        public Span<bool> LtEq(in numbers<T> rhs)
            => gmath.lteq<T>(data,rhs.data);

        public string Format(char delimiter = ',')
            => data.Unblock().Format(delimiter);

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException(); 
 
        [MethodImpl(Inline)]
        static Span<T> alloc(numbers<T> src)
            => span<T>(src.Count);

        [MethodImpl(Inline)]
        static int count(in numbers<T> lhs, in numbers<T> rhs)        
            => length(lhs.data.Unblock(),rhs.data.Unblock());
        
        [MethodImpl(Inline)]
        static Span<T> alloc(in numbers<T> lhs, in numbers<T> rhs)
            => span<T>(count(lhs,rhs));

    }
}