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

    sealed class UniformBitsSampler<T> : Sampler<T, UniformBitsSpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public UniformBitsSampler(MklRng src, int? buferLen = null)
            : base(src, default, buferLen)
        {
            
        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(uint))
                sample.bits(Source,  uint32(buffer));
            else if(typeof(T) == typeof(ulong))
                sample.bits(Source,  uint64(buffer));
            else 
                throw unsupported<T>();
            
            return buffer.Length;
        }

    }

}