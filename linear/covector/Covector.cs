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

    public ref struct Covector<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {
        Span<N,T> data {get;}

        static readonly N NatRep = new N();

        [MethodImpl(Inline)]
        public static Covector<N,T> Load(ref T src)
            => new Covector<N,T>(ref src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(Span<N,T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(in ReadOnlySpan<T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Define(Span<T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator + (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Add(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator + (Covector<N,T> lhs, in T rhs) 
            => lhs.Add(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator - (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Sub(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator * (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Mul(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator / (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Div(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator % (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Mod(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator - (Covector<N,T> src) 
            => src.Negate();

        [MethodImpl(Inline)]
        public static Covector<N,T> operator -- (Covector<N,T> src) 
            => src.Dec();

        [MethodImpl(Inline)]
        public static Covector<N,T> operator ++ (Covector<N,T> src) 
            => src.Inc();

        [MethodImpl(Inline)]
        public static Covector<N,T> operator & (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator & (Covector<N,T> lhs, in T rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator | (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator | (Covector<N,T> lhs, in T rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator ^ (Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator ^ (Covector<N,T> lhs, in T rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator ~ (Covector<N,T> src) 
            => src.Flip();

        [MethodImpl(Inline)]
        public static Covector<N,T> operator << (Covector<N,T> lhs, int rhs) 
            => lhs.ShiftL(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,T> operator >> (Covector<N,T> lhs, int rhs) 
            => lhs.ShiftR(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,bool> operator == (in Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,bool> operator != (in Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,bool> operator < (in Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Lt(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,bool> operator > (in Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.Gt(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,bool> operator <= (in Covector<N,T> lhs, in Covector<N,T> rhs) 
            => lhs.LtEq(rhs);

        [MethodImpl(Inline)]
        public static Covector<N,bool> operator >= (in Covector<N,T> lhs, in Covector<N,T> rhs) 
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
        public static implicit operator Span<N,T>(Covector<N,T> src)
            => src.data;

        /// <summary>
        /// Slice => Vec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">THe component type</typeparam>
        [MethodImpl(Inline)]   
        public static implicit operator Covector<N,T>(Span<N,T> src)
            => new Covector<N,T>(src);

        [MethodImpl(Inline)]
        Covector(ref T src)
        {
            data =  NatSpan.load<N,T>(ref src);  
            require(data.Length == Length);
        }

        [MethodImpl(Inline)]
        Covector(in ReadOnlySpan<N,T> src)
        {
            data = NatSpan.replicate(src);
        }

        [MethodImpl(Inline)]
        Covector(in ReadOnlySpan<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.replicate<N,T>(src);
        }

        [MethodImpl(Inline)]
        Covector(Span<T> src)
        {
            require(src.Length == Length);
            data = NatSpan.adapt(src, NatRep);
        }

        [MethodImpl(Inline)]
        Covector(Span<N,T> src)
        {
            data = src;
        }
        

        public ref T this[int index] 
            => ref data[index];


        [MethodImpl(Inline)]
        public Covector<N,T> ShiftL(in int rhs)
        {
            var x = data.Unsize();
            gmath.shiftl(ref x, rhs);
            return this;
        }

        [MethodImpl(Inline)]
        public Covector<N,T> ShiftR(in int rhs)
        {
            var x = data.Unsize();
            gmath.shiftr(ref x, rhs);
            return this;
        }

        [MethodImpl(Inline)]
        public string Format()
            => data.Format();

        [MethodImpl(Inline)]
        public Span<T> Unsize()
            => data.Unsize();

        public bool All(T match)
        {
            for(var i=0; i<Length; i++)            
                if(gmath.neq(data[i],match))
                    return false;
            return true;
        }
 
        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
 
        public override string ToString()
            => throw new NotSupportedException();
    }
}

