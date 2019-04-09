//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using Primal = PrimOps.Reify;

    partial class Operative
    {

        public interface PrimOps<T> :
                Additive<T>, 
                Additive<IReadOnlyList<T>>,            

                Subtractive<T>,
                Subtractive<IReadOnlyList<T>>,
                
                Multiplicative<T>, 
                Multiplicative<IReadOnlyList<T>>,            

                Negatable<T>, 
                Negatable<IReadOnlyList<T>>,             

                Absolutive<T>, 
                Absolutive<IReadOnlyList<T>>,             

                Stepwise<T>,
                Stepwise<IReadOnlyList<T>>,            

                Bitwise<T>,            
                
                Divisive<T>, 
                Nullary<T>, 
                Unital<T>,
                Ordered<T>,
                Semigroup<T>,
                Trigonmetric<T>,
                Special<T>
            where T : struct, IEquatable<T>
        {
            /// <summary>
            /// Computes component-wise equality between two lists of equal length
            /// </summary>
            /// <param name="lhs">The first list</param>
            /// <param name="rhs">The second list</param>
            /// <returns>A list r whose i'th entry is deterimed by r[i] = eq(lhs[i], rhs[i]) </returns>
            IReadOnlyList<bool> eq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
            
            /// <summary>
            /// Computes component-wise inequality between two lists of equal length
            /// </summary>
            /// <param name="lhs">The first list</param>
            /// <param name="rhs">The second list</param>
            /// <returns>A list r whose i'th entry is deterimed by r[i] = neq(lhs[i], rhs[i]) </returns>
            IReadOnlyList<bool> neq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
            
            IReadOnlyList<bool> lt(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
            
            IReadOnlyList<bool> lteq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
            
            IReadOnlyList<bool> gt(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
            
            IReadOnlyList<bool> gteq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
            
            IReadOnlyList<bool> testbit(IReadOnlyList<T> src, int pos);
            
            IReadOnlyList<T> lshift(IReadOnlyList<T> src, int pos);
            
            IReadOnlyList<T> rshift(IReadOnlyList<T> src, int pos);

            /// <summary>
            /// Computes the component-wise gcd between two lists of equal length
            /// </summary>
            /// <param name="lhs">The first list</param>
            /// <param name="rhs">The second list</param>
            /// <returns>A list r whose i'th entry is deterimed by r[i] = gcd(lhs[i], rhs[i]) </returns>
            IReadOnlyList<T> gcd(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);

            /// <summary>
            /// Computes the component-wise division between two lists of equal length
            /// </summary>
            /// <param name="lhs">The first list</param>
            /// <param name="rhs">The second list</param>
            /// <returns>A list r whose i'th entry is deterimed by r[i] = lhs[i] / rhs[i] </returns>
            IReadOnlyList<T> div(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);

            /// <summary>
            /// Computes the component-wise modulus between two lists of equal length
            /// </summary>
            /// <param name="lhs">The first list</param>
            /// <param name="rhs">The second list</param>
            /// <returns>A list r whose i'th entry is deterimed by r[i] = lhs[i] % rhs[i] </returns>
            IReadOnlyList<T> mod(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs);
        
            /// <summary>
            /// Implements .net-style comparison for compatibility
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            int CompareTo(T lhs, T rhs);

            /// <summary>
            /// Computes the sign of the operand
            /// </summary>
            /// <param name="src">The source value</param>
            Sign sign(T src);

            /// <summary>
            /// Returns true if the operand is nonzero, false otherwisee
            /// </summary>
            /// <param name="src">The source value</param>
            bool nonzero(T src);

            /// <summary>
            /// Returns true if the number is even, false otherwise
            /// </summary>
            /// <param name="src">The source value</param>
            bool even(T src);

            /// <summary>
            /// Computes the value x*y + z
            /// </summary>
            /// <param name="x">The first operand</param>
            /// <param name="y">The second operand</param>
            /// <param name="z">The third operand</param>
            T muladd(T x, T y, T z);

            /// <summary>
            /// Determines whether ther right operand is evenly divisible by
            /// the left operand, i.e., lhs divides rhs <=> rhs % lhs == 0
            /// </summary>
            /// <param name="lhs">The bottom</param>
            /// <param name="rhs">The top</param>
            /// <returns></returns>
            bool divides(T lhs, T rhs);

            /// <summary>
            /// Specifies various metadata pertaining to the numeric type
            /// </summary>
            NumberInfo<T> numinfo {get;}

            /// <summary>
            /// For fixed-sized types, returns the number of bits required to represent a value
            /// </summary>
            /// <value></value>
            uint bitsize {get;}
        }

    }

    partial class Reify
    {
        public readonly struct PrimOps<T> : Operative.PrimOps<T>
            where T : struct, IEquatable<T>

        {
            public static readonly PrimOps<T> Inhabitant = default;
            static readonly Operative.Additive<T> Additive = Primal.Additive.Operator<T>();

            static readonly Operative.Divisive<T> Divisive = Primal.Divisive.Operator<T>();

            static readonly Operative.Multiplicative<T> Multiplicative = Primal.Multiplicative.Operator<T>();

            static readonly Operative.Absolutive<T> Absolutive = Primal.Absolutive.Operator<T>();

            static readonly Operative.Subtractive<T> Subtractive = Primal.Subtractive.Operator<T>();

            static readonly Operative.Negatable<T> Negatable = Primal.Negatable.Operator<T>();

            static readonly Operative.Nullary<T> Nullary = Primal.Nullary.Operator<T>();

            static readonly Operative.Unital<T> Unital = Primal.Unital.Operator<T>();

            static readonly Operative.Ordered<T> Ordered = Primal.Ordered.Operator<T>();

            static readonly Operative.Stepwise<T> Stepwise = Primal.Stepwise.Operator<T>();

            static readonly Operative.Bitwise<T> Bitwise = Primal.Bitwise.Operator<T>();

            static readonly Operative.Semigroup<T> Equality = Primal.Equality.Operator<T>();
            
            static readonly Operative.Trigonmetric<T> Trig = Primal.Trig.Operator<T>();

            static readonly Operative.Special<T> Special = Primal.Special.Operator<T>();

            static readonly NumInfoProvider<T> NumInfo = Primal.NumInfo.Operator<T>();

            public T zero
            {
                [MethodImpl(Inline)]
                get => Nullary.zero;
            }

            public T one
            {
                [MethodImpl(Inline)]
                get => Unital.one;
            }

            public uint bitsize
            {
                [MethodImpl(Inline)]
                get => numinfo.BitSize;
            }

            public NumberInfo<T> numinfo
            {
                [MethodImpl(Inline)]
                get => NumInfo.numinfo;
            }

            [MethodImpl(Inline)]
            public T add(T lhs, T rhs)
                => Additive.add(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> add(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,add);

            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => Multiplicative.mul(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> mul(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                => fuse(lhs,rhs,mul);

            [MethodImpl(Inline)]
            public T div(T lhs, T rhs)
                => Divisive.div(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> div(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,div);

            [MethodImpl(Inline)]
            public T mod(T lhs, T rhs)
                => Divisive.mod(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> mod(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,mod);

            [MethodImpl(Inline)]
            public T gcd(T lhs, T rhs)
                => Divisive.gcd(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> gcd(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,gcd);
            
            [MethodImpl(Inline)]
            public T negate(T x)
                => Negatable.negate(x);

            [MethodImpl(Inline)]
            public IEnumerable<T> negate(IEnumerable<T> src)
                =>  map(src,negate);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> negate(IReadOnlyList<T> src)
                =>  map(src,negate);

            [MethodImpl(Inline)]
            public T sub(T lhs, T rhs)
                => Subtractive.sub(lhs,rhs);

            
            [MethodImpl(Inline)]
            public IReadOnlyList<T> sub(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,sub);

            [MethodImpl(Inline)]
            public T abs(T x)
                => Absolutive.abs(x);


            [MethodImpl(Inline)]
            public IReadOnlyList<T> abs(IReadOnlyList<T> src)
                =>  map(src,abs);

            [MethodImpl(Inline)]
            public bool lt(T lhs, T rhs)
                => Ordered.lt(lhs,rhs);


            [MethodImpl(Inline)]
            public IReadOnlyList<bool> lt(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,lt);

            [MethodImpl(Inline)]
            public bool lteq(T lhs, T rhs)
                => Ordered.lteq(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<bool> lteq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,lteq);

            [MethodImpl(Inline)]
            public bool gt(T lhs, T rhs)
                => Ordered.gt(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<bool> gt(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,gt);

            [MethodImpl(Inline)]
            public bool gteq(T lhs, T rhs)
                => Ordered.gteq(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<bool> gteq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,gteq);

            [MethodImpl(Inline)]
            public T inc(T x)
                => Stepwise.inc(x);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> inc(IReadOnlyList<T> src)
                =>  map(src,inc);

            [MethodImpl(Inline)]
            public T dec(T x)
                => Stepwise.dec(x);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> dec(IReadOnlyList<T> src)
                =>  map(src,dec);

            [MethodImpl(Inline)]
            public T and(T lhs, T rhs)
                => Bitwise.and(lhs,rhs);


            [MethodImpl(Inline)]
            public IReadOnlyList<T> and(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,and);

            [MethodImpl(Inline)]
            public T or(T lhs, T rhs)
                => Bitwise.or(lhs,rhs);


            [MethodImpl(Inline)]
            public IReadOnlyList<T> or(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,or);

            [MethodImpl(Inline)]
            public T xor(T lhs, T rhs)
                => Bitwise.xor(lhs,rhs);
            

            [MethodImpl(Inline)]
            public IReadOnlyList<T> xor(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,xor);

            [MethodImpl(Inline)]
            public T flip(T x)
                => Bitwise.flip(x);


            [MethodImpl(Inline)]
            public IReadOnlyList<T> flip(IReadOnlyList<T> src)
                =>  map(src,flip);

            [MethodImpl(Inline)]
            public T lshift(T lhs, int rhs)
                => Bitwise.lshift(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> lshift(IReadOnlyList<T> lhs, int rhs)
            {
                var dst = array<T>(lhs.Count);
                iter(lhs.Count, i => dst[i] = Bitwise.lshift(lhs[i],rhs));
                return dst;
            }                

            [MethodImpl(Inline)]
            public T rshift(T lhs, int rhs)
                => Bitwise.rshift(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<T> rshift(IReadOnlyList<T> lhs, int rhs)
            {
                var dst = array<T>(lhs.Count);
                iter(lhs.Count, i => dst[i] = Bitwise.rshift(lhs[i],rhs));
                return dst;
            }

            [MethodImpl(Inline)]
            public BitString bitstring(T x)
                => Bitwise.bitstring(x);

            [MethodImpl(Inline)]
            public IReadOnlyList<BitString> bitstring(IReadOnlyList<T> src)
                => map(src,bitstring);

            [MethodImpl(Inline)]
            public byte[] bytes(T x)
                => Bitwise.bytes(x);

            [MethodImpl(Inline)]
            public bool testbit(T src, int pos)
                => Bitwise.testbit(src,pos);

            [MethodImpl(Inline)]
            public IReadOnlyList<bool> testbit(IReadOnlyList<T> src, int pos)
                => map(src, x => Bitwise.testbit(x,pos));

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => Equality.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<bool> eq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,eq);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => Equality.neq(lhs,rhs);

            [MethodImpl(Inline)]
            public IReadOnlyList<bool> neq(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
                =>  fuse(lhs,rhs,neq);

            [MethodImpl(Inline)]
            public Quorem<T> divrem(T lhs, T rhs)
                => Divisive.divrem(lhs,rhs);

            [MethodImpl(Inline)]
            public bool divides(T lhs, T rhs)
                => eq(mod(rhs, lhs), zero);

            [MethodImpl(Inline)]
            public int CompareTo(T lhs, T rhs)
                => lt(lhs,rhs) ? -1
                : gt(lhs,rhs) ? 1
                : 0;

            [MethodImpl(Inline)]
            public bool nonzero(T src)
                => neq(src,zero);

            [MethodImpl(Inline)]
            public Sign sign(T src)
                =>  nonzero(src) ? Sign.Neutral : 
                    lt(src, zero) ? Sign.Negative :
                    Sign.Positive;


            [MethodImpl(Inline)]
            public T muladd(T x, T y, T z)
                => add(mul(x,y),z);

            [MethodImpl(Inline)]
            public T sin(T x)
                => Trig.sin(x);

            [MethodImpl(Inline)]
            public T sinh(T x)
                => Trig.sinh(x);

            [MethodImpl(Inline)]
            public T asin(T x)
                => Trig.asin(x);

            [MethodImpl(Inline)]
            public T asinh(T x)
                => Trig.asinh(x);

            [MethodImpl(Inline)]
            public T cos(T x)
                => Trig.cos(x);

            [MethodImpl(Inline)]
            public T cosh(T x)
                => Trig.cosh(x);

            [MethodImpl(Inline)]
            public T acos(T x)
                => Trig.acos(x);

            [MethodImpl(Inline)]
            public T acosh(T x)
                => Trig.acosh(x);

            [MethodImpl(Inline)]
            public T tan(T x)
                => Trig.tan(x);

            [MethodImpl(Inline)]
            public T tanh(T x)
                => Trig.tanh(x);

            [MethodImpl(Inline)]
            public T atan(T x)
                => Trig.atan(x);

            [MethodImpl(Inline)]
            public T atanh(T x)
                => Trig.atanh(x);

            [MethodImpl(Inline)]
            public bool even(T src)
                => eq(mod(src,  inc(Unital.one)), Nullary.zero);

            [MethodImpl(Inline)]
            public T sqrt(T src)
                => Special.sqrt(src);

            [MethodImpl(Inline)]
            public T floor(T src)
                => Special.floor(src);

            [MethodImpl(Inline)]
            public T ceiling(T src)
                => Special.ceiling(src);

            [MethodImpl(Inline)]
            public T pow(T src, int exp)
                => Special.pow(src,exp);
        }    
    }
}

