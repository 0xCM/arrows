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


    abstract class SampleBuffer<T,S> : ISampleBuffer<T>    
        where T : unmanaged
        where S : IDistributionSpec
    {        
        [MethodImpl(Inline)]
        public static implicit operator RngStream(SampleBuffer<T,S> src)
            => src.Source;

        [MethodImpl(Inline)]
        public SampleBuffer(RngStream src, S distspec, int? bufferLen = null)
        {
            this.Source = src;
            this.BufferLength  = bufferLen ?? Pow2.T08;
            this.Buffer = MemorySpan.Alloc<T>(this.BufferLength);
            this.Remaining = 0;
            this.DistSpec = distspec;

        }

        public DistKind DistKind
            => DistSpec.Kind;

        public int BufferLength {get;}

        int Remaining;

        readonly MemorySpan<T> Buffer;

        protected readonly RngStream Source;

        /// <summary>
        /// Characterizes the distribution that will be used when sampling
        /// </summary>
        protected readonly S DistSpec;

        protected abstract int FillBuffer(MemorySpan<T> buffer);

        public IEnumerable<T> Samples
        {
            get
            {
                while(true)
                {
                    while(--Remaining > 0)
                        yield return Buffer[Remaining - 1];

                    Remaining = FillBuffer(Buffer);
                }                
            }
        }

    }


}