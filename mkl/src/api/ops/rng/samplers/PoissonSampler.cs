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

    sealed class PoissonSampler<T> : Sampler<T, PoissonSpec<T>>
        where T : unmanaged
    {
        public PoissonSampler(MklRng src, PoissonSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            
            if(typeof(T) == typeof(int))
                sample.poisson(Source,  float64(DistSpec.Rate), int32(buffer));
            else 
                throw unsupported<T>();
            
            return buffer.Length;

        }
    }

}