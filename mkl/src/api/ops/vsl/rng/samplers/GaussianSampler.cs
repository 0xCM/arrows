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

    sealed class GaussianSampler<T> : Sampler<T, GaussianSpec<T>>
        where T : unmanaged
    {
        public GaussianSampler(RngStream src, GaussianSpec<T> distspec,  int? buferLen = null)
            : base(src, distspec, buferLen)
        {

        }

        public GaussianSampler(RngStream src, T mu, T sigma,  int? buferLen = null)
            : base(src, new GaussianSpec<T>(mu,sigma), buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {
            if(typeof(T) == typeof(float))
                mkl.gaussian(Source, float32(DistSpec.Mean), float32(DistSpec.StdDev), buffer.As<float>());
            else if(typeof(T) == typeof(double))
                mkl.gaussian(Source, float64(DistSpec.Mean), float64(DistSpec.StdDev), buffer.As<double>());
            else 
                throw unsupported<T>();

            return buffer.Length;

        }
    }
}