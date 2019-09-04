//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;
    using static As;

    sealed class GammaSampler<T> : Sampler<T, GammaSpec<T>>
        where T : unmanaged
    {
        public GammaSampler(RngStream src, GammaSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        public GammaSampler(RngStream src, T alpha, T dx, T beta,  int? buferLen = null)
            : base(src, GammaSpec<T>.Define(alpha, dx, beta), buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {
            if(typeof(T) == typeof(float))
                mkl.gamma(Source, float32(DistSpec.Alpha), float32(DistSpec.Dx), float32(DistSpec.Beta), buffer.As<float>());
            else if(typeof(T) == typeof(double))
                mkl.gamma(Source, float64(DistSpec.Alpha), float64(DistSpec.Dx), float64(DistSpec.Beta), buffer.As<double>());
            else 
                throw unsupported<T>();

            return buffer.Length;

        }
    }
}