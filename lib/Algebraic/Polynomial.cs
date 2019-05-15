//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static zcore;
    using static zfunc;

    public static class Polynomial
    {
        public static PolynomialTerm<T> term<T>(T coefficient, intg<uint> power)
            where T : new()
               => new PolynomialTerm<T>(coefficient,power);
    }
    
    public readonly struct PolynomialTerm<T>
        where T : new()
    {
        
        public static readonly PolynomialTerm<T> Zero = default;

        public static implicit operator PolynomialTerm<T>((T coefficient, uint power) x)        
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
            => lhs.coefficient.Equals(rhs.coefficient) && lhs.power == rhs.power;

        public bool neq(PolynomialTerm<T> lhs, PolynomialTerm<T> rhs)
            => not(eq(lhs,rhs));

        public bool eq(PolynomialTerm<T> rhs)
            => eq(this, rhs);

        public bool neq(PolynomialTerm<T> rhs)
            => not(eq(rhs));

        public bool Equals(PolynomialTerm<T> rhs)
            => eq(rhs);

        public int hash()
            => coefficient.GetHashCode() & power.GetHashCode();
    }

    public readonly struct Polynomial<T>
        where T : IMonoidAOps<T>, new()
    {
        static readonly IMonoidAOps<T> Ops = new T();
        
        static readonly T FZero = Ops.zero;

        public static Polynomial<T> operator +(Polynomial<T> lhs, Polynomial<T> rhs)
            => throw new Exception();

        readonly PolynomialTerm<T>[] terms;
    
        public Polynomial(params PolynomialTerm<T>[] terms)
            => this.terms = terms;

        public override string ToString()
            => append(AsciSym.Plus, terms);

        public uint degree()
            => nonzero ? terms.Reverse().Where(t => !t.coefficient.Equals(FZero)).Max(x => x.power): 0;

        public bool nonzero
            => any(terms, t => !t.coefficient.Equals(FZero));

        static (PolynomialTerm<T>[] lhs, PolynomialTerm<T>[] rhs) Conform(PolynomialTerm<T>[] lhs, PolynomialTerm<T>[] rhs, PolynomialTerm<T> filler)
        {
            var lhsLen = lhs.Length;
            var rhsLen = rhs.Length;
            if(lhsLen == rhsLen)
                return(lhs,rhs);

            var filled = repeat(filler, lhsLen > rhsLen ? lhsLen - rhsLen : lhsLen - rhsLen);
            if(lhsLen > rhsLen)
                return (lhs, concat(rhs, filled));
            else
                return (concat(lhs,filled), rhs);

        }

        public Polynomial<T> add(Polynomial<T> rhs)
        {
            var dst = new PolynomialTerm<T>[Math.Max(terms.Length, rhs.terms.Length)]; 
            var src = Conform(terms, rhs.terms, PolynomialTerm<T>.Zero);
            for(var i = 0; i<= dst.Length(); i++)           
                dst[i] = Polynomial.term(Ops.add(src.lhs[i].coefficient, src.rhs[i].coefficient), (uint)i);
            return new Polynomial<T>(dst);
        }
    }
}