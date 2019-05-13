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
    using static zfunc;

    using static Operative;
    using Primal = PrimOps.Reify;


    partial class Operative
    {

        public interface PrimOps<T> :
                IAdditiveOps<T>, 
                ISubtractiveOps<T>,
                IMultiplicativeOps<T>, 
                INegatableOps<T>, 
                IAbsolutiveOps<T>, 
                IStepwiseOps<T>,
                IBitwiseOps<T>, 
                IDivisiveOps<T>, 
                INullaryOps<T>, 
                IUnitalOps<T>,
                IOrderedOps<T>,
                ISemigroupOps<T>,
                ITrigonmetricOps<T>,
                ISpecialOps<T>,
                IParser<T>
            where T : struct, IEquatable<T>
        {
            
        
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
            Sign Sign(T src);

            /// <summary>
            /// Returns true if the operand is nonzero, false otherwisee
            /// </summary>
            /// <param name="src">The source value</param>
            bool Nonzero(T src);

            /// <summary>
            /// Returns true if the number is even, false otherwise
            /// </summary>
            /// <param name="src">The source value</param>
            bool Even(T src);

            /// <summary>
            /// Computes the value x*y + z
            /// </summary>
            /// <param name="x">The first operand</param>
            /// <param name="y">The second operand</param>
            /// <param name="z">The third operand</param>
            T MulAdd(T x, T y, T z);

            /// <summary>
            /// Determines whether ther right operand is evenly divisible by
            /// the left operand, i.e., lhs divides rhs <=> rhs % lhs == 0
            /// </summary>
            /// <param name="lhs">The bottom</param>
            /// <param name="rhs">The top</param>
            /// <returns></returns>
            bool Divides(T lhs, T rhs);

            /// <summary>
            /// Specifies various metadata pertaining to the numeric type
            /// </summary>
            NumberInfo<T> NumberInfo {get;}

        }

    }

    partial class Reify
    {
        public readonly struct PrimOps<T> : Operative.PrimOps<T>
            where T : struct, IEquatable<T>

        {
            public static readonly PrimOps<T> Inhabitant = default;
            static readonly IAdditiveOps<T> Additive = Primal.Additive.Operator<T>();

            static readonly IDivisiveOps<T> Divisive = Primal.Divisive.Operator<T>();

            static readonly IMultiplicativeOps<T> Multiplicative = Primal.Multiplicative.Operator<T>();

            static readonly IAbsolutiveOps<T> Absolutive = Primal.Absolutive.Operator<T>();

            static readonly ISubtractiveOps<T> Subtractive = Primal.Subtractive.Operator<T>();

            static readonly INegatableOps<T> Negatable = Primal.Negatable.Operator<T>();

            static readonly INullaryOps<T> Nullary = Primal.Nullary.Operator<T>();

            static readonly IUnitalOps<T> Unital = Primal.Unital.Operator<T>();

            static readonly IOrderedOps<T> Ordered = Primal.Ordered.Operator<T>();

            static readonly IStepwiseOps<T> Stepwise = Primal.Stepwise.Operator<T>();

            //static readonly IBitwiseOps<T> Bitwise = Bitwise.Operator<T>();

            static readonly ISemigroupOps<T> Equality = Primal.Equality.Operator<T>();
            
            //static readonly ITrigonmetricOps<T> Trig = Primal.Trig.Operator<T>();

            static readonly Operative.ISpecialOps<T> Special = Primal.Special.Operator<T>();

            static readonly NumberInfo<T> NumInfo = Z0.NumberInfo.Get<T>();

            static readonly IParser<T> Parser = Primal.Parser.Operator<T>();

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
                get => NumberInfo.BitSize;
            }

            public NumberInfo<T> NumberInfo
            {
                [MethodImpl(Inline)]
                get => NumInfo;
            }

            [MethodImpl(Inline)]
            public T add(T lhs, T rhs)
                => Additive.add(lhs,rhs);

            [MethodImpl(Inline)]
            public Index<T> add(T[] lhs, T[] rhs)
                =>  fuse(lhs,rhs,add);

            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => Multiplicative.mul(lhs,rhs);

            [MethodImpl(Inline)]
            public Index<T> mul(T[] lhs, T[] rhs)
                => fuse(lhs,rhs,mul);

            [MethodImpl(Inline)]
            public T div(T lhs, T rhs)
                => Divisive.div(lhs,rhs);

            [MethodImpl(Inline)]
            public Index<T> div(T[] lhs, T[] rhs)
                =>  fuse(lhs,rhs,div);

            [MethodImpl(Inline)]
            public T mod(T lhs, T rhs)
                => Divisive.mod(lhs,rhs);

            [MethodImpl(Inline)]
            public Index<T> mod(T[] lhs, T[] rhs)
                =>  fuse(lhs,rhs,mod);

            [MethodImpl(Inline)]
            public T gcd(T lhs, T rhs)
                => Divisive.gcd(lhs,rhs);

            [MethodImpl(Inline)]
            public Index<T> gcd(T[] lhs, T[] rhs)
                =>  fuse(lhs,rhs,gcd);
            
            [MethodImpl(Inline)]
            public T negate(T x)
                => Negatable.negate(x);


            [MethodImpl(Inline)]
            public Index<T> negate(Index<T> src)
                =>  map(src,negate);

            [MethodImpl(Inline)]
            public T sub(T lhs, T rhs)
                => Subtractive.sub(lhs,rhs);

            
            [MethodImpl(Inline)]
            public Index<T> sub(T[] lhs, T[] rhs)
                =>  fuse(lhs,rhs,sub);

            [MethodImpl(Inline)]
            public T abs(T x)
                => Absolutive.abs(x);


            [MethodImpl(Inline)]
            public Index<T> abs(Index<T> src)
                =>  map(src,abs);

            [MethodImpl(Inline)]
            public bool lt(T lhs, T rhs)
                => Ordered.lt(lhs,rhs);



            [MethodImpl(Inline)]
            public bool lteq(T lhs, T rhs)
                => Ordered.lteq(lhs,rhs);


            [MethodImpl(Inline)]
            public bool gt(T lhs, T rhs)
                => Ordered.gt(lhs,rhs);


            [MethodImpl(Inline)]
            public bool gteq(T lhs, T rhs)
                => Ordered.gteq(lhs,rhs);


            [MethodImpl(Inline)]
            public T inc(T x)
                => Stepwise.inc(x);

            [MethodImpl(Inline)]
            public Index<T> inc(Index<T> src)
                =>  map(src,inc);

            [MethodImpl(Inline)]
            public T dec(T x)
                => Stepwise.dec(x);

            [MethodImpl(Inline)]
            public Index<T> dec(Index<T> src)
                =>  map(src,dec);








            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => Equality.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => Equality.neq(lhs,rhs);

            [MethodImpl(Inline)]
            public Quorem<T> divrem(T lhs, T rhs)
                => Divisive.divrem(lhs,rhs);

            [MethodImpl(Inline)]
            public bool Divides(T lhs, T rhs)
                => eq(mod(rhs, lhs), zero);

            [MethodImpl(Inline)]
            public int CompareTo(T lhs, T rhs)
                => lt(lhs,rhs) ? -1
                : gt(lhs,rhs) ? 1
                : 0;

            [MethodImpl(Inline)]
            public bool Nonzero(T src)
                => neq(src,zero);

            [MethodImpl(Inline)]
            public Sign Sign(T src)
                => Nonzero(src) ? Z0.Sign.Neutral :
                    lt(src, zero) ? Z0.Sign.Negative :
                    Z0.Sign.Positive;


            [MethodImpl(Inline)]
            public T MulAdd(T x, T y, T z)
                => add(mul(x,y),z);


            [MethodImpl(Inline)]
            public bool Even(T src)
                => eq(mod(src, inc(Unital.one)), Nullary.zero);

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


            [MethodImpl(Inline)]
            public T fact(T src)
                => Special.fact(src);

            [MethodImpl(Inline)]
            public Option<T> tryParse(string src)
                => Parser.tryParse(src);

            [MethodImpl(Inline)]
            public T parse(string src)
                => Parser.parse(src);



            public Index<T> div(Index<T> lhs, Index<T> rhs)
            {
                throw new NotImplementedException();
            }

            public Index<T> and(Index<T> lhs, Index<T> rhs)
            {
                throw new NotImplementedException();
            }

            public Index<T> or(Index<T> lhs, Index<T> rhs)
            {
                throw new NotImplementedException();
            }

            public Index<T> xor(Index<T> lhs, Index<T> rhs)
            {
                throw new NotImplementedException();
            }

            public T and(T lhs, T rhs)
            {
                throw new NotImplementedException();
            }

            public T or(T lhs, T rhs)
            {
                throw new NotImplementedException();
            }

            public T xor(T lhs, T rhs)
            {
                throw new NotImplementedException();
            }

            public T flip(T x)
            {
                throw new NotImplementedException();
            }

            public T lshift(T lhs, int rhs)
            {
                throw new NotImplementedException();
            }

            public T rshift(T lhs, int rhs)
            {
                throw new NotImplementedException();
            }

            public string BitString(T src)
            {
                throw new NotImplementedException();
            }

            public bool TestBit(T src, int pos)
            {
                throw new NotImplementedException();
            }

            public byte[] Bytes(T src)
            {
                throw new NotImplementedException();
            }

            public Bit[] Bits(T src)
            {
                throw new NotImplementedException();
            }

            public T sin(T x)
            {
                throw new NotImplementedException();
            }

            public T sinh(T x)
            {
                throw new NotImplementedException();
            }

            public T asin(T x)
            {
                throw new NotImplementedException();
            }

            public T asinh(T x)
            {
                throw new NotImplementedException();
            }

            public T cos(T x)
            {
                throw new NotImplementedException();
            }

            public T cosh(T x)
            {
                throw new NotImplementedException();
            }

            public T acos(T x)
            {
                throw new NotImplementedException();
            }

            public T acosh(T x)
            {
                throw new NotImplementedException();
            }

            public T tan(T x)
            {
                throw new NotImplementedException();
            }

            public T tanh(T x)
            {
                throw new NotImplementedException();
            }

            public T atan(T x)
            {
                throw new NotImplementedException();
            }

            public T atanh(T x)
            {
                throw new NotImplementedException();
            }
        }    
    }
}

