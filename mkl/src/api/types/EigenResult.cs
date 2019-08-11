//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
 
    using static zfunc;
    using static nfunc;

    public static class EigenResult
    {
        public static EigenResult<N,T> Define<N,T>(Span<N,Complex<T>> values, Span256<T> lv = default,  Span256<T> rv = default)
            where N : ITypeNat, new()
            where T : struct
                => new EigenResult<N, T>(values, lv, rv);
    }

    /// <summary>
    /// Encapsulates eigenvalues and possibly eigenvectors
    /// </summary>
    public readonly ref  struct EigenResult<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        public EigenResult(Span<N,Complex<T>> values, Span256<T> lv = default,  Span256<T> rv = default)
        {
            this.Values = values;
            this.LeftVectors  = lv;
            this.RightVectors = rv;
        }
        
        public readonly Span<N,Complex<T>> Values;

        public readonly Span256<T> LeftVectors;

        public readonly Span256<T> RightVectors;

    }

}