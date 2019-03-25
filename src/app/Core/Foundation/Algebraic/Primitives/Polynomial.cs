//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using static corefunc;

    public static class Polynomial
    {
        public static PolynomialTerm<T> term<T>(T coefficient, intg<uint> power)
            => new PolynomialTerm<T>(coefficient,power);
    }
    public readonly struct PolynomialTerm<T>
    {
        public static readonly PolynomialTerm<T> Zero = default;
        public static implicit operator PolynomialTerm<T>((T coefficient, intg<uint> power) x)        
            => new PolynomialTerm<T>(x.coefficient, x.power);

        public static implicit operator (T coefficient, intg<uint> power)(PolynomialTerm<T> x)        
            => (x.coefficient, x.power);

        public PolynomialTerm(T coefficient, intg<uint> degree)
        {
            this.coefficient = coefficient;
            this.power = degree;
        }

        public T coefficient {get;}
        
        public intg<uint> power {get;}

        public override string ToString()
            => $"{coefficient}X^{power}";
    }

    public readonly struct Polynomial<T>
    {
        static readonly Traits.Field<T> Ops = ops<T,Traits.Field<T>>();
        static readonly T FZero = Ops.zero;

        public static Polynomial<T> operator +(Polynomial<T> lhs, Polynomial<T> rhs)
            => throw new Exception();

        readonly Slice<PolynomialTerm<T>> terms;
    
        public Polynomial(params PolynomialTerm<T>[] terms)
            => this.terms = Slice.define(terms);

        public override string ToString()
            => concat(AsciSym.Plus, terms);

        public intg<uint> degree()
            => nonzero ? filter(reverse(terms), t => Ops.neq(t.coefficient, FZero)).First().power : 0;

        public bool nonzero
            => any(terms, t => Ops.neq(t.coefficient, FZero));

        public Polynomial<T> add(Polynomial<T> rhs)
        {
            var dst = new PolynomialTerm<T>[max(terms.length, rhs.terms.length)]; 
            var src = terms.conform(rhs.terms, PolynomialTerm<T>.Zero);
            for(var i = 0; i<= dst.Length(); i++)           
                dst[i] = Polynomial.term(Ops.add(src.lhs[i].coefficient, src.rhs[i].coefficient), i.ToIntG<uint>());
            return new Polynomial<T>(dst);
        }

    }



}