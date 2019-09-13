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

    sealed class GeometricSampler<T> : Sampler<T, GeometricSpec<T>>
        where T : unmanaged
    {
        public GeometricSampler(MklRng src, GeometricSpec<T> distspec, int? buferLen = null)
            : base(src, distspec, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            
            if(typeof(T) == typeof(int))
                sample.geometric(Source,  DistSpec, int32(buffer));
            else 
                throw unsupported<T>();
            
            return buffer.Length;

        }
    }

}