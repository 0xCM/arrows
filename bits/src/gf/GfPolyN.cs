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
    /// Represents a base-2 polynomial of degree N. The represented polynomial is of the form
    /// a_i * x^i + . . . a_1 * x^1 + a_0 * x^0 where  a_i = 0 | 1 and i = 0..N
    /// </summary>
    public readonly struct GfPoly<N,T>
        where N : ITypeNat, new()
        where T : unmanaged
    {
        readonly T data;

        static readonly int degree = (int)new N().value;

        public static readonly GfPoly<N,T> Zero = default;
        
        public static implicit operator T(GfPoly<N,T> src)
            => src.data;

        public GfPoly(params byte[] exponents)
        {
            var components = default(T);
            for(var i=0; i< exponents.Length; i++)
                components = gbits.or(components, Pow2.pow<T>(exponents[i]));
            data = components;
        }

        [MethodImpl(Inline)]
        public GfPoly(T data)
        {
            this.data = data;
        }

        /// <summary>
        /// Returns a bit indicating whether the coefficient for x^i is 1 or 0
        /// </summary>
        public Bit this[int i]
        {
            [MethodImpl(Inline)]
            get => gbits.test(data,i);
        }

        /// <summary>
        /// Returns the scalar representation of the polynomial
        /// </summary>
        public T Scalar
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// The degree (N) of the polynomial
        /// </summary>
        public int Degree
        {
            [MethodImpl(Inline)]
            get => degree;
        }

        /// <summary>
        /// Specfies whether the polynomial is the zero polynomial
        /// </summary>
        public bool Nonzero
        {
            [MethodImpl(Inline)]
            get => !gmath.nonzero(data);
        }

        /// <summary>
        /// Formats the polynomial 
        /// </summary>
        public string Format(char? variable = null)
        {
            var bs = BitString.FromScalar(data);
            var terms = new List<string>();
            
            for(var i=0; i<bs.Length; i++)
                if(bs[i]) terms.Add($"{variable ?? 'x'}^{i}");
            
            var sb = sbuild();
            terms.Reverse();
            return string.Join($" + ", terms);            
        }

        public GfPoly<N,U> As<U>()
            where U: unmanaged
                => Unsafe.As<GfPoly<N,T>, GfPoly<N,U>>(ref Unsafe.AsRef(in this));

        public GfPoly<M,U> As<M,U>()
            where M : ITypeNat, new()
            where U: unmanaged
                => Unsafe.As<GfPoly<N,T>, GfPoly<M,U>>(ref Unsafe.AsRef(in this));
    }
}