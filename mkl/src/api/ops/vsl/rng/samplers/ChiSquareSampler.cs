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

    sealed class ChiSquareSampler<T> : Sampler<T, ChiSquareSpec<int>>
        where T : unmanaged
    {
        public ChiSquareSampler(MklRng src, int freedom, int? buferLen = null)
            : base(src, freedom, buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {            
            if(typeof(T) == typeof(float))
                sample.chi2(Source,  DistSpec, buffer.As<float>());
            else if (typeof(T) == typeof(double))
                sample.chi2(Source,  DistSpec, buffer.As<double>());
            else 
                throw unsupported<T>();            
            return buffer.Length;

        }
    }

}