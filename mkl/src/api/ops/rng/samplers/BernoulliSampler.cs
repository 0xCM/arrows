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

    sealed class BernoulliSampler<T> : Sampler<T, BernoulliSpec<double>>
        where T : unmanaged
    {
        public BernoulliSampler(MklRng src, BernoulliSpec<double> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            
            if(typeof(T) == typeof(int))
                sample.bernoulli(Source,  DistSpec, int32(buffer));
            else 
                throw unsupported<T>();
            
            return buffer.Length;

        }
    }

}