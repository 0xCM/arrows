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
    /// Represents one term expression or a component of a polynomial of degree > 1
    /// whe the coeifficient has modulus M
    /// </summary>
    public readonly struct Monomial<M,T>
        where T : struct
        where M : ITypeNat, new()
    {
        public static Monomial<M,T> Zero(int order)
            => new Monomial<M,T>(default, order);
        
        public Monomial(T coefficient, int order)
        {
            this.Coefficient = coefficient;
            this.Order = order;
        }
        
        public readonly T Coefficient;

        public readonly int Order;

        public bool Nonzero
            => gmath.nonzero(Coefficient);
        
        public string Format(char variable = 'x')
            => Nonzero ? $"{Coefficient}{variable}^{Order}" : string.Empty;
    }
}