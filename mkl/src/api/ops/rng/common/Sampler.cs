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
    using System.Collections;
    using System.Linq;

    using static zfunc;
    using static As;

    abstract class Sampler<T,S> : ISampler<T>    
        where T : unmanaged
        where S : IDistributionSpec
    {        
        [MethodImpl(Inline)]
        public static implicit operator MklRng(Sampler<T,S> src)
            => src.Source;

        [MethodImpl(Inline)]
        public Sampler(MklRng src, S distspec, int? bufferLen = null)
        {
            this.Source = src;
            this.BufferLength  = bufferLen ?? Pow2.T14;
            this.Buffer = MemorySpan.Alloc<T>(this.BufferLength);
            this.Remaining = 0;
            this.DistSpec = distspec;
        }

        public RngKind RngKind 
            => Source.RngKind;

        public DistKind DistKind
            => DistSpec.DistKind;

        public int BufferLength {get;}

        int Remaining;

        readonly T[] Buffer;

        protected readonly MklRng Source;

        /// <summary>
        /// Characterizes the distribution that will be used when sampling
        /// </summary>
        protected readonly S DistSpec;
        
        protected abstract int FillBuffer(Span<T> buffer);

        public IEnumerator<T> GetEnumerator()
            => Samples.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Samples.GetEnumerator();

        [MethodImpl(Inline)]
        public IEnumerable<T> Next(int count)
            => Samples.Take(count);

        [MethodImpl(Inline)]
        public T Next()
            => Samples.First();

        IEnumerable<T> Samples
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