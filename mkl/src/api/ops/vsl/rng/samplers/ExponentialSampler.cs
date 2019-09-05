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

    sealed class ExponentialSampler<T> : Sampler<T, ExponentialSpec<T>>
        where T : unmanaged
    {
        public ExponentialSampler(MklRng src, ExponentialSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        public ExponentialSampler(MklRng src, T a, T b, int? buferLen = null)
            : base(src, ExponentialSpec<T>.Define(a, b), buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {
            if(typeof(T) == typeof(float))
                sample.exp(Source, float32(DistSpec.a), float32(DistSpec.b), buffer.As<float>());
            else if(typeof(T) == typeof(double))
                sample.exp(Source, float64(DistSpec.a), float64(DistSpec.b), buffer.As<double>());
            else 
                throw unsupported<T>();

            return buffer.Length;

        }
    }
}