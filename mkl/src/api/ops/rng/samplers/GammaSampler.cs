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
        public GammaSampler(MklRng src, GammaSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        public GammaSampler(MklRng src, T alpha, T dx, T beta,  int? buferLen = null)
            : base(src, GammaSpec<T>.Define(alpha, dx, beta), buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(float))
                sample.gamma(Source, float32(DistSpec.Alpha), float32(DistSpec.Dx), float32(DistSpec.Beta), float32(buffer));
            else if(typeof(T) == typeof(double))
                sample.gamma(Source, float64(DistSpec.Alpha), float64(DistSpec.Dx), float64(DistSpec.Beta), float64(buffer));
            else 
                throw unsupported<T>();

            return buffer.Length;

        }
    }
}