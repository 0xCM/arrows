//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Pow2;

    /// <summary>
    /// Prepresents a power of 2 in compact form
    /// </summary>
    public readonly struct Pow2<T>
        where T : unmanaged
    {
        public readonly T Exp;

        [MethodImpl(Inline)]
        public static Pow2<T> operator *(Pow2<T> a, Pow2<T> b)
            => new Pow2<T>(gmath.add(a.Exp, b.Exp));

        [MethodImpl(Inline)]
        public Pow2(T exp)
        {
            this.Exp = exp;
        }
        
        public string Format()
            => $"2^{Exp}";

        public override string ToString()
            => Format();

    }

}