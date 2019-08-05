//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;
    using static nfunc;

    public static class ComplexNumber
    {
        /// <summary>
        /// Defines a generic comple number
        /// </summary>
        /// <param name="re">The real part</param>
        /// <param name="im">The imaginary part</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        public static Complex<T> Define<T>(T re, T im = default)   
            where T : struct
                => (re,im);

        
        public static Span<N,Complex<T>> FromPaired<N,T>(Span<N,T> re, Span<N,T> im)
            where N : ITypeNat, new()
            where T : struct
        {
            Span<Complex<T>> dst = new Complex<T>[nati<N>()];
            for(var i=0; i< dst.Length; i++)
                dst[i] = (re[i], im[i]);
            return dst;
        }
    }

}