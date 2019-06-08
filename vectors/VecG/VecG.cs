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

    public ref struct VecG<T>
        where T : struct
    {
        Span256<T> data;

        [MethodImpl(Inline)]
        public VecG(in Span256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public VecG(in ReadOnlySpan256<T> src)
            => this.data = src.Replicate();

        [MethodImpl(Inline)]
        public static implicit operator VecG<T>(in Span256<T> src)
            =>  new VecG<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator VecG<T>(in ReadOnlySpan256<T> src)
            =>  new VecG<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(in VecG<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in VecG<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in VecG<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static VecG<T> operator + (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.add(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator - (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.sub(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator * (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.mul(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator / (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.div(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator % (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.mod(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator & (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.and(lhs.data, rhs.data, alloc(lhs,rhs)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator | (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.or(lhs.data, rhs.data, span<T>(count(lhs,rhs))).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator ^ (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.xor(lhs.data, rhs.data, lhs.data.ToSpan()).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator << (in VecG<T> lhs, int rhs) 
            => gmath.shiftl(lhs.data.Unblock().ToReadOnlySpan(), rhs).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator >> (in VecG<T> lhs, int rhs) 
            => gmath.shiftr(lhs.data.Unblock().ToReadOnlySpan(), rhs).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator - (in VecG<T> src) 
            => gmath.negate(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator ++ (in VecG<T> src) 
            => gmath.inc(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator -- (in VecG<T> src) 
            => gmath.dec(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static VecG<T> operator ~ (in VecG<T> src) 
            => gmath.flip(src.data, alloc(src)).ToSpan256();

        [MethodImpl(Inline)]
        public static Span<bool> operator < (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.lt<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator <= (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.lteq<T>(lhs.data,rhs.data);            

        [MethodImpl(Inline)]
        public static Span<bool> operator > (in VecG<T> lhs, in VecG<T> rhs) 
            => gmath.gt<T>(lhs.data,rhs.data);

        [MethodImpl(Inline)]
        public static Span<bool> operator >= (in VecG<T> lhs, in VecG<T> rhs) 
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
        public VecG<T> Add(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.add(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Sub(in VecG<T> rhs)
        {
            var x = data.Unblock();
            var y = rhs.data.Unblock();
            gmath.sub(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Mul(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.mul(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Div(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.div(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Mod(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = rhs.data.Unblock();
            gmath.mod(ref x, y);
            return this;
        }


        [MethodImpl(Inline)]
        public VecG<T> Negate()
        {
            var x = unblock(data);
            gmath.negate(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Inc()
        {
            var x = unblock(data);
            gmath.inc(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Dec()
        {
            var x = unblock(data);
            gmath.dec(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Abs()
        {
            var x = unblock(data);
            gmath.abs(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> And(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = unblock(rhs.data);
            gmath.and(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Or(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = unblock(rhs.data);
            gmath.or(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> XOr(in VecG<T> rhs)
        {
            var x = unblock(data);
            var y = unblock(rhs.data);
            gmath.xor(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> ShiftL(in VecG<int> shifts)
        {
            var x = unblock(data);
            var y = shifts.data.Unblock();
            gmath.shiftl(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> ShiftR(in VecG<int> shifts)
        {
            var x = unblock(data);
            var y = shifts.data.Unblock();
            gmath.shiftr(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> RotL(in VecG<int> shifts)
        {
            var x = unblock(data);
            var y = shifts.data.Unblock();
            gbits.rotl(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> RotR(in VecG<int> shifts)
        {
            var x = unblock(data);
            var y = shifts.data.Unblock();
            gbits.rotr(ref x, y);
            return this;
        }

        [MethodImpl(Inline)]
        public VecG<T> Flip()
        {
            var x = unblock(data);
            gmath.flip(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public T Dot(in VecG<T> rhs)
            => gmath.dot<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Eq(in VecG<T> rhs)
            => gmath.eq<T>(data, rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Gt(in VecG<T> rhs)
            => gmath.gt<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> GtEq(in VecG<T> rhs)
            => gmath.gteq<T>(data,rhs.data);

        [MethodImpl(Inline)]
        public Span<bool> Lt(in VecG<T> rhs)
            => gmath.lt<T>(data,rhs.data);            

        [MethodImpl(Inline)]
        public Span<bool> LtEq(in VecG<T> rhs)
            => gmath.lteq<T>(data,rhs.data);

        public int Length
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        [MethodImpl(Inline)]
        static Span<T> alloc(VecG<T> src)
            => span<T>(src.Count);

        [MethodImpl(Inline)]
        static int count(in VecG<T> lhs, in VecG<T> rhs)        
            => length(lhs.data.Unblock(),rhs.data.Unblock());
        
        [MethodImpl(Inline)]
        static Span<T> alloc(in VecG<T> lhs, in VecG<T> rhs)
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