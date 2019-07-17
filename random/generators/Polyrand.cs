//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using static As;

    public class Polyrand : 
        IRandomSource<ulong>, 
        IRandomSource<double>, 
        IRandomSource<uint>, 
        IRandomSource<int>, 
        IRandomSource<float>,
        IRandomSource<long>
    {
        internal Polyrand(IRandomSource<ulong> Random)
        {
            this.Random = Random;
        }

        readonly IRandomSource<ulong> Random;

        IPointSource<int> Int32Source
            => this;

        IPointSource<uint> UInt32Source
            => this;

        IPointSource<long> Int64Source
            => this;

        IPointSource<ulong> UInt64Source
            => this;

        IPointSource<float> Float32Source
            => this;

        IPointSource<double> Float64Source
            => this;

        ulong IPointSource<ulong>.Next()
            => Random.Next();

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next()
            =>(uint)Random.NextUInt64(UInt32.MaxValue);

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        float IPointSource<float>.Next()
            => math.ldexp((float)UInt32Source.Next(), -32);

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        double IPointSource<double>.Next()
            => math.ldexp((double)Random.Next(), -64);
        
        [MethodImpl(Inline)]
        int IPointSource<int>.Next()
            => (int) (Random.NextUInt64((ulong)Int32.MaxValue*2) - Int32.MaxValue);

        [MethodImpl(Inline)]
        long IPointSource<long>.Next()
        {
            var next = (long)Random.NextUInt64(Int64.MaxValue);
            var negative = Bits.test(next, 7);
            var result = Bits.test(next, 7) ? Bits.enable(ref next, 63) : next;
            return result;
        }

        [MethodImpl(Inline)]
        public T Next<T>()
            where T : struct
        {
            if(typeof(T) == typeof(int))
                return generic<T>(Int32Source.Next());                
            if(typeof(T) == typeof(uint))
                return generic<T>(UInt32Source.Next());                
            if(typeof(T) == typeof(long))
                return generic<T>(Int64Source.Next());                
            if(typeof(T) == typeof(ulong))
                return generic<T>(UInt64Source.Next());                
            if(typeof(T) == typeof(float))
                return generic<T>(Float32Source.Next());                
            if(typeof(T) == typeof(double))
                return generic<T>(Float64Source.Next());                
            else 
                throw unsupported<T>();                

        }
            
        public IEnumerable<T> Take<T>(int? count = null)
            where T : struct
        {
            if(count != null)
            {
                var counter = 0;
                while(counter++ < count)
                    yield return Next<T>();
            }
            else
                while(true)
                    yield return Next<T>();
        }

    }
}