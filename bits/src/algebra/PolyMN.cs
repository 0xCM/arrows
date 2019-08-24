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
    /// Represents a base-M polynomial of degree N. The represented polynomial is of the form
    /// a_i * x^i + . . . a_1 * x^1 + a_0 * x^0, 
    /// where a_i = 0 | 1 | ... | M - 1  denote coefficients of modulus M
    /// and i = 0..N specify nonnegative integral exponents
    /// </summary>
    /// <typeparam name="M">The coefficient modulus</typeparam>
    /// <typeparam name="N">The polynomial degree</typeparam>
    /// <typeparam name="T">The primal coefficient type</typeparam>
    public readonly struct Poly<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : struct
    {
        readonly Monomial<M,T>[] Terms;

        static readonly int degree = (int)new N().value;

        public static readonly Poly<M,N,T> Zero = default;

        public Poly(params Monomial<M,T>[] terms)
        {
            this.Terms = terms;
        }

        /// <summary>
        /// Selects the term with the specified order if it exists;
        /// otherwise, returns the zero monomial
        /// </summary>
        public Monomial<M,T> this[int exp]
            => Term(exp);

        /// <summary>
        /// The degree (N) of the polynomial
        /// </summary>
        public int Degree
        {
            [MethodImpl(Inline)]
            get => degree;
        }

        /// <summary>
        /// Selects the term with the specified order if it exists;
        /// otherwise, returns the zero monomial
        /// </summary>
        public Monomial<M,T> Term(int exp)
        {
            for(var j = 0; j<Terms.Length; j++)
            {
                if(Terms[j].Order == exp)
                    return Terms[j];
            }
            return Monomial<M,T>.Zero(exp);
        }

        public string Format(char? variable = null)
        {
            var sb = sbuild();
            for(var i=0; i<Terms.Length; i++)
            {
                sb.Append(Terms[i].Format(variable ?? 'x'));
                if( i != Terms.Length - 1)
                    sb.Append($" + ");
            }
            return sb.ToString();
        }        
    }
}