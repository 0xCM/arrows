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

    sealed class BernoulliBuffer<T> : SampleBuffer<T, BernoulliSpec<double>>
        where T : unmanaged
    {
        public BernoulliBuffer(RngStream src, BernoulliSpec<double> distspec, int? buferLen = null)
            : base(src, distspec, buferLen)
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