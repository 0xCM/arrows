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


    sealed class UniformBitsBuffer<T> : SampleBuffer<T, UniformBitsSpec<T>>
        where T : unmanaged
    {
        public UniformBitsBuffer(RngStream src, int? buferLen = null)
            : base(src, default, buferLen)
        {

        }

        protected override int FillBuffer(MemorySpan<T> buffer)
        {
            if(typeof(T) == typeof(uint))
                mkl.bits(Source,  buffer.As<uint>());
            else if(typeof(T) == typeof(ulong))
                mkl.bits(Source,  buffer.As<ulong>());
            else 
                throw unsupported<T>();
            
            return buffer.Length;
        }

    }

}