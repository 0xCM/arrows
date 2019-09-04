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

    sealed class UniformSampler<T> : Sampler<T, UniformSpec<T>>
        where T : unmanaged
    {
        public UniformSampler(RngStream src, UniformSpec<T> distspec,  int? buferLen = null)
            : base(src, distspec, buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {
            var min = DistSpec.Min;
            var max = DistSpec.Max;
            if(typeof(T) == typeof(int))
                mkl.uniform(Source, int32(min), int32(max), buffer.As<int>());
            else if(typeof(T) == typeof(float))
                mkl.uniform(Source, float32(min), float32(max), buffer.As<float>());
            else if(typeof(T) == typeof(double))
                mkl.uniform(Source, float64(min), float64(max), buffer.As<double>());
            else 
                throw unsupported<T>();

            return buffer.Length;

        }
    }
}