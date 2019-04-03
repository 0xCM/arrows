//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using static zcore;

    public static class Polynomial
    {
        public static PolynomialTerm<T> term<T>(T coefficient, intg<uint> power)
            where  T: Equatable<T>, new()
                => new PolynomialTerm<T>(coefficient,power);
    }
    
    public readonly struct PolynomialTerm<T> : Equatable<PolynomialTerm<T>>
        where  T: Equatable<T>, new()
    {
        
        static readonly Equatable<T> eqops = new T();
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

        public bool eq(PolynomialTerm<T> lhs, PolynomialTerm<T> rhs)
            => lhs.coefficient.eq(rhs.coefficient) && lhs.power == rhs.power;

        public bool neq(PolynomialTerm<T> lhs, PolynomialTerm<T> rhs)
            => not(eq(lhs,rhs));

        public bool eq(PolynomialTerm<T> rhs)
            => eq(this, rhs);

        public bool neq(PolynomialTerm<T> rhs)
            => not(eq(rhs));

        public bool Equals(PolynomialTerm<T> rhs)
            => eq(rhs);

        public int hash()
            => coefficient.hash() & power.GetHashCode();
    }

    public readonly struct Polynomial<T>
        where T : Operative.MonoidA<T>, Equatable<T>, new()
    {
        static readonly Operative.MonoidA<T> Ops = new T();
        
        static readonly T FZero = Ops.zero;

        public static Polynomial<T> operator +(Polynomial<T> lhs, Polynomial<T> rhs)
            => throw new Exception();

        readonly Slice<PolynomialTerm<T>> terms;
    
        public Polynomial(params PolynomialTerm<T>[] terms)
            => this.terms = terms;

        public override string ToString()
            => append(AsciSym.Plus, terms);

        public intg<uint> degree()
            => nonzero 
            ? terms.reverse().filter(t => t.coefficient.neq(FZero)).data.First().power 
            : 0;

        public bool nonzero
            => any(terms, t => t.coefficient.neq(FZero));

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