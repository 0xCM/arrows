//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    class BitSource<T> : IRandomStream<Bit>, IPointStream<Bit>
        where T : unmanaged
    {
        const int BufferSize = Pow2.T10;

        [MethodImpl(Inline)]
        public static IRandomStream<Bit> From(IPointSource<T> src)
                => new BitSource<T>(src);
        
        [MethodImpl(Inline)]
        public BitSource(IPointSource<T> random)
        {
            this.RngKind = random.RngKind;
            this.Stream = random.Stream().GetEnumerator().ToBitStream();
            this.BitQueue = new Queue<Bit>(BufferSize);
        }
                
        Queue<Bit> BitQueue {get;}

        public RngKind RngKind {get;}

        public IEnumerable<Bit> Stream {get;}

        [MethodImpl(Inline)]
        public Bit Next()
        {
            if(BitQueue.TryDequeue(out Bit bit))
                return bit;

            BitQueue.Enqueue(Stream.Take(BufferSize));
            return Next();
        }

        public IEnumerable<Bit> Next(int count)
        {
            for(var i=0; i<count; i++)
                yield return Next();
        }

        public IEnumerator<Bit> GetEnumerator()
            => Stream.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }

}