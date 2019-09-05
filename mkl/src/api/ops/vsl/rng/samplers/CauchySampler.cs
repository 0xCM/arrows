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

    sealed class CauchySampler<T> : Sampler<T, CauchySpec<T>>
        where T : unmanaged
    {
        public CauchySampler(MklRng src, T a, T b, int? buferLen = null)
            : base(src, (a,b), buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {            
            if(typeof(T) == typeof(float))
                sample.cauchy(Source, float32(DistSpec.Location), float32(DistSpec.Scale),  buffer.As<float>());
            else if (typeof(T) == typeof(double))
                sample.cauchy(Source, float64(DistSpec.Location), float64(DistSpec.Scale),  buffer.As<double>());
            else 
                throw unsupported<T>();            
            return buffer.Length;

        }
    }

}