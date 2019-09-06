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
    /// Represents a polynomial 
    /// </summary>
    /// <typeparam name="M">The coefficient modulus</typeparam>
    /// <typeparam name="N">The polynomial degree</typeparam>
    /// <typeparam name="T">The primal coefficient type</typeparam>
    public readonly struct Polynomial<T>
        where T : unmanaged
    {
        public static Polynomial<T> Define(params (T scalar, int exp)[] terms)
        {
            var expanse = new Monomial<T>[terms[0].exp + 1];
            for(var i = 0; i < terms.Length; i++)
                expanse[terms[i].exp] = terms[i];  
            expanse.Reverse();              
            return new Polynomial<T>(expanse);
        }

        readonly MemorySpan<Monomial<T>> Terms;

        [MethodImpl(Inline)]
        Polynomial(MemorySpan<Monomial<T>> terms)
        {
            this.Terms = terms;
        }

        [MethodImpl(Inline)]
        Polynomial(Monomial<T>[] terms)
        {
            this.Terms = terms;
        }

        public Polynomial(params (T scalar, int exp)[] terms)
        {
            this.Terms = new Monomial<T>[terms.Length];
            for(var i=0; i<terms.Length; i++)
                Terms[i] = terms[i];
        }

        public int Degree
            => Terms[0].Exp;
        
        public T Eval(T x)
        {
            var result = Terms[0].Scalar;
            var i = Terms.Length - 1;

            do 
                result = gmath.add(gmath.mul(result, x), Terms[i].Scalar);
            while(--i != 0 );

            return result ;
        }

        static string GetSep(Monomial<T> term)
            => gmath.negative(term.Scalar) ? " - " : " + ";

        public string Format(char? variable = null)
        {
            var dst = new List<string>();
            for(var i=0; i< Terms.Length; i++)            
                if(Terms[i].Nonzero)
                {
                    if(dst.Count != 0)
                        dst.Add(GetSep(Terms[i]));
                    else
                    {
                        if(gmath.negative(Terms[i].Scalar))
                            dst.Add("-");
                    }

                    dst.Add(Terms[i].Format(variable,true));
                }
            
            return dst.Concat();
        }

        public override string ToString()
            => Format();
    }

    /// <summary>
    /// Represents a base-M polynomial of degree N over values of primal type T 
    /// </summary>
    /// <typeparam name="M">The coefficient modulus</typeparam>
    /// <typeparam name="N">The polynomial degree</typeparam>
    /// <typeparam name="T">The primal coefficient type</typeparam>
    public readonly struct Polynomial<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : unmanaged
    {
        public readonly MemorySpan<Monomial<M,T>> Terms;

        public static readonly int Degree = (int)new N().value;
        
        /// <summary>
        /// The zero polynomial of degree N
        /// </summary>
        public static readonly Polynomial<M,N,T> Zero = new Polynomial<M, N, T>(Monomial<M,T>.Zero(Degree));

        [MethodImpl(Inline)]
        public Polynomial(MemorySpan<Monomial<M,T>> terms)
        {
            require(terms[0].Exp == Degree);
            this.Terms = terms;
        }

        [MethodImpl(Inline)]
        public Polynomial(params Monomial<M,T>[] terms)
        {
            require(terms[0].Exp == Degree);
            this.Terms = terms;
        }

        /// <summary>
        /// Selects the term with the specified order if it exists;
        /// otherwise, returns the zero monomial
        /// </summary>
        public Monomial<M,T> this[int exp]
        {
            [MethodImpl(Inline)]
            get => Term(exp);
        }

        /// <summary>
        /// Selects the term with the specified order if it exists;
        /// otherwise, returns the zero monomial
        /// </summary>
        public Monomial<M,T> Term(int exp)
        {
            for(var j = 0; j<Terms.Length; j++)
                if(Terms[j].Exp == exp)
                    return Terms[j];
            return Monomial<M,T>.Zero(exp);
        }

        public string Format(char? variable = null)
        {
            var terms = Terms;
            var dst = new string[Terms.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = terms[i].Format(variable);
            return string.Join(" + ", dst);
        }
   }
}