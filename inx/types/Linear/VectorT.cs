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

    public ref struct Vector<T>
        where T : struct
    {
        Span256<T> data;

        [MethodImpl(Inline)]
        public Vector(in Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public Vector(in ReadOnlySpan256<T> src)
            => this.data = src.Replicate();

        [MethodImpl(Inline)]
        public static implicit operator Vector<T>(in Span256<T> src)
            =>  new Vector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Vector<T>(in ReadOnlySpan256<T> src)
            =>  new Vector<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(in Vector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in Vector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in Vector<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static Vector<T> operator + (Vector<T> lhs, in Vector<T> rhs)         
            => lhs.data.ReadOnly().Add(rhs.data, lhs.data);
                    

        [MethodImpl(Inline)]
        public static Vector<T> operator - (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.sub(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator * (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.mul(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator / (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.div(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator % (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.mod(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator & (in Vector<T> lhs, in Vector<T> rhs) 
            => gbits.and(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator | (in Vector<T> lhs, in Vector<T> rhs) 
            => gbits.or(lhs.data, rhs.data, span<T>(count(lhs,rhs))).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator ^ (in Vector<T> lhs, in Vector<T> rhs) 
            => gbits.xor(lhs.data, rhs.data, lhs.data.ToSpan()).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator << (in Vector<T> lhs, int rhs) 
            => gbits.shiftl(lhs.data.Unblock().ReadOnly(), rhs).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator >> (in Vector<T> lhs, int rhs) 
            => gbits.shiftr(lhs.data.Unblock().ReadOnly(), rhs).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator - (in Vector<T> src) 
            => gmath.negate(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator ++ (in Vector<T> src) 
            => gmath.inc(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator -- (in Vector<T> src) 
            => gmath.dec(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static Vector<T> operator ~ (in Vector<T> src) 
            => gbits.flip(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static Span<bool> operator < (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator <= (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.lteq<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator > (in Vector<T> lhs, in Vector<T> rhs) 
            => gmath.gt<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static Span<bool> operator >= (in Vector<T> lhs, in Vector<T> rhs) 
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
        public Vector<T> Add(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.add(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Sub(in Vector<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            gmath.sub(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Mul(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.mul(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Div(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.div(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Mod(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.mod(ref x, y);
            return this;
        }


        [MethodImpl(Inline)]
        public Vector<T> Negate()
        {
            var x = unblock(data);
            gmath.negate(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Inc()
        {
            var x = unblock(data);
            gmath.inc(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Dec()
        {
            var x = unblock(data);
            gmath.dec(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Abs()
        {
            var x = unblock(data);
            gmath.abs(in x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> And(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = unblock(rhs.data);
            gbits.and(in x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Or(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = unblock(rhs.data);
            gbits.or(in x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> XOr(in Vector<T> rhs)
        {
            var x = unblock(data);
            var y = unblock(rhs.data);
            gbits.xor(in x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public Vector<T> Flip()
        {
            var x = unblock(data);
            gbits.flip(in x);
            return this;
        }

        [MethodImpl(Inline)]
        public T Dot(in Vector<T> rhs)
            => gmath.dot<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Eq(in Vector<T> rhs)
            => gmath.eq<T>(data, rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Gt(in Vector<T> rhs)
            => gmath.gt<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> GtEq(in Vector<T> rhs)
            => gmath.gteq<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Lt(in Vector<T> rhs)
            => gmath.lt<T>(data,rhs.data);            

        [MethodImpl(Inline)]
        public Span<bool> LtEq(in Vector<T> rhs)
            => gmath.lteq<T>(data,rhs.data);

        public int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        [MethodImpl(Inline)]
        static Span<T> alloc(Vector<T> src)
            => span<T>(src.Count);

        [MethodImpl(Inline)]
        static int count(in Vector<T> lhs, in Vector<T> rhs)        
            => length(lhs.data.Unblock(),rhs.data.Unblock());
        
        [MethodImpl(Inline)]
        static Span<T> alloc(in Vector<T> lhs, in Vector<T> rhs)
            => span<T>(count(lhs,rhs)); 

        [MethodImpl(Inline)]
        static Span<T> unblock(in Span256<T> src)
            => src;

        public string Format(char delimiter = ',')
            => data.Unblock().Format(delimiter);

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}