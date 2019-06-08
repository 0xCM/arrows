//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    public ref struct Vec<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Vec<N,T> Load(ref T src)
            => new Vec<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Vec<N,T> Define(ref Span<N,T> src)
            => new Vec<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Vec<N,T> Define(in ReadOnlySpan<T> src)
            => new Vec<N,T>(src);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator + (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Add(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator - (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Sub(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator * (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Mul(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator / (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Div(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator % (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Mod(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator - (in Vec<N,T> src) 
            => src.Negate();

        [MethodImpl(Inline)]
        public static Vec<N,T> operator -- (in Vec<N,T> src) 
            => src.Dec();

        [MethodImpl(Inline)]
        public static Vec<N,T> operator ++ (in Vec<N,T> src) 
            => src.Inc();

        [MethodImpl(Inline)]
        public static Vec<N,T> operator & (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator | (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator ^ (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator ~ (in Vec<N,T> src) 
            => src.Flip();

        [MethodImpl(Inline)]
        public static Vec<N,T> operator << (in Vec<N,T> lhs, int rhs) 
            => lhs.ShiftL(rhs);

        [MethodImpl(Inline)]
        public static Vec<N,T> operator >> (in Vec<N,T> lhs, int rhs) 
            => lhs.ShiftR(rhs);

        [MethodImpl(Inline)]
        public static Span<N,bool> operator == (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static Span<N,bool> operator != (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static Span<N,bool> operator < (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Lt(rhs);

        [MethodImpl(Inline)]
        public static Span<N,bool> operator > (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.Gt(rhs);

        [MethodImpl(Inline)]
        public static Span<N,bool> operator <= (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.LtEq(rhs);

        [MethodImpl(Inline)]
        public static Span<N,bool> operator >= (in Vec<N,T> lhs, in Vec<N,T> rhs) 
            => lhs.GtEq(rhs);

        /// <summary>
        /// Specifies the length of the vector, i.e. its component count
        /// </summary>
        public static readonly int Length = nati<N>();     

        /// <summary>
        /// Vec => Slice
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Span<N,T>(Vec<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Vec<N,T>(Span<N,T> src)
            => new Vec<N,T>(src);

        [MethodImpl(Inline)]
        Vec(ref T src)
        {
            data =  NatSpan.load<N,T>(ref src);  
            require(data.Length == Length);
        }

        [MethodImpl(Inline)]
        Vec(in ReadOnlySpan<N,T> src)
        {
            require(src.Length == Length);
            data = NatSpan.replicate(src);
        }

        [MethodImpl(Inline)]
        Vec(in ReadOnlySpan<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.replicate<N,T>(src);
        }

        [MethodImpl(Inline)]
        Vec(ref Span<N,T> src)
        {
            require(src.Length == Length);
            data = src;
        }
        
        Span<N,T> data {get;}

        [MethodImpl(Inline)]   
        public Vec(Span<N,T> src)
            => data = src;

        public ref T this[int index] 
            => ref data[index];

        [MethodImpl(Inline)]
        public Vec<N,T> Add(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.add(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Sub(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.sub(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Mul(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.mul(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Div(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.div(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Mod(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.mod(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> And(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.and(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Or(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.or(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> XOr(in Vec<N,T> rhs)
        {
            var x = data.Unsize();
            gmath.xor(ref x, rhs.data);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> ShiftL(in int rhs)
        {
            var x = data.Unsize();
            gmath.shiftl(ref x, rhs);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> ShiftR(in int rhs)
        {
            var x = data.Unsize();
            gmath.shiftr(ref x, rhs);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Negate()
        {
            var x = data.Unsize();
            gmath.negate(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Flip()
        {
            var x = data.Unsize();
            gmath.flip(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Inc()
        {
            var x = data.Unsize();
            gmath.inc(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,T> Dec()
        {
            var x = data.Unsize();
            gmath.dec(ref x);
            return this;
        }

        [MethodImpl(Inline)]
        public Vec<N,bool> Eq(in Vec<N,T> rhs)
            => gmath.eq<T>(data.Unsize(), rhs.data).ToNatSpan(NatRep);

        [MethodImpl(Inline)]
        public Vec<N,bool> NEq(in Vec<N,T> rhs)
            => gmath.neq<T>(data.Unsize(), rhs.data).ToNatSpan(NatRep);

        [MethodImpl(Inline)]
        public Vec<N,bool> Gt(in Vec<N,T> rhs)
            => gmath.gt<T>(data.Unsize(), rhs.data).ToNatSpan(NatRep);

        [MethodImpl(Inline)]
        public Vec<N,bool> GtEq(in Vec<N,T> rhs)
            => gmath.gteq<T>(data.Unsize(), rhs.data).ToNatSpan(NatRep);

        [MethodImpl(Inline)]
        public Vec<N,bool> Lt(in Vec<N,T> rhs)
            => gmath.lt<T>(data.Unsize(), rhs.data).ToNatSpan(NatRep);

        [MethodImpl(Inline)]
        public Vec<N,bool> LtEq(in Vec<N,T> rhs)
            => gmath.lteq<T>(data.Unsize(), rhs.data).ToNatSpan(NatRep);

        [MethodImpl(Inline)]
        public string Format()
            => data.Format();
 
        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    }
}

