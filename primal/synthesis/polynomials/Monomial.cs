//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;

    /// <summary>
    /// Represents a one-term polynomial or component of a polynomial with more than one term
    /// </summary>
    public readonly struct Monomial<T>
        where T : unmanaged
    {
        /// <summary>
        /// The monomial coefficient
        /// </summary>
        public readonly T Scalar;

        /// <summary>
        /// The monomial exponent/order
        /// </summary>
        public readonly int Exp;

        [MethodImpl(Inline)]
        public static implicit operator (T scalar, int exp)(Monomial<T> src)
            => src.ToPair();

        [MethodImpl(Inline)]
        public static implicit operator Monomial<T>((T scalar, int exp) src)
            => new Monomial<T>(src.scalar, src.exp);

        /// <summary>
        /// Produces the zero monomial of a given order
        /// </summary>
        /// <param name="exp">The monomial exponent/order</param>
        [MethodImpl(Inline)]
        public static Monomial<T> Zero(int exp)
            => new Monomial<T>(default, exp);        

        [MethodImpl(Inline)]
        public Monomial(T scalar, int exp)
        {
            this.Scalar = scalar;
            this.Exp = exp;
        }

        /// <summary>
        /// Specifies whether the coeifficient, and thus the monomial, is nonzero
        /// </summary>
        public bool Nonzero
        {
            [MethodImpl(Inline)]
            get => gmath.nonzero(Scalar);
        }

        string FormatScalar(bool abs)
            => abs ? gmath.abs(Scalar).ToString() : Scalar.ToString();

        public string Format(char? variable = null, bool abs = false)
            => Nonzero 
            ? (Exp != 0 ? $"{FormatScalar(abs)}{variable ?? 'x' }^{Exp}" : $"{FormatScalar(abs)}") 
            : string.Empty;
        
        public (T scalar, int exp) ToPair()
            => (Scalar, Exp);

        public override string ToString()
            => Format();

    }

    /// <summary>
    /// Represents a one-term polynomial or component of a polynomial with more than one term
    /// where the scalar coefficient has modulus M
    /// </summary>
    public readonly struct Monomial<N,T>
        where T : unmanaged
        where N : ITypeNat, new()
    {
        /// <summary>
        /// The monomial coefficient
        /// </summary>
        public readonly T Scalar;

        /// <summary>
        /// The monomial exponent/order
        /// </summary>
        public readonly int Exp;

        [MethodImpl(Inline)]
        public static implicit operator Monomial<N,T>((T scalar, int exp) src)
            => new Monomial<N,T>(src.scalar, src.exp);

        [MethodImpl(Inline)]
        public static Monomial<N,T> Zero(int exp) 
            => new Monomial<N,T>(default, exp);

        [MethodImpl(Inline)]
        public Monomial(T scalar, int exp)
        {
            this.Scalar = scalar;
            this.Exp = exp;
        }

        public Monomial<T> Unsized
        {
            [MethodImpl(Inline)]
            get => new Monomial<T>(Scalar, Exp);
        }

        /// <summary>
        /// Specifies whether the coeifficient, and thus the monomial, is nonzero
        /// </summary>
        public bool Nonzero
            => gmath.nonzero(Scalar);

        public (T scalar, int exp) ToPair()
            => (Scalar, Exp);

        public string Format(char? variable = null)
            => Nonzero ? $"{Scalar}{variable ?? 'x'}^{Exp}" : string.Empty;

        public override string ToString()
            => Format();
        }
}