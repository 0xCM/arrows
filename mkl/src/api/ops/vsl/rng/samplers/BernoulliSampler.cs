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
        public BernoulliSampler(RngStream src, BernoulliSpec<double> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {
            
            if(typeof(T) == typeof(int))
                mkl.bernoulli(Source,  DistSpec, buffer.As<int>());
            else 
                throw unsupported<T>();
            
            return buffer.Length;

        }
    }

}