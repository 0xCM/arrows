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
        IRandomSource<byte>,
        IRandomSource<ushort>,
        IRandomSource<int>, 
        IRandomSource<uint>, 
        IRandomSource<long>,
        IRandomSource<ulong>, 
        IRandomSource<float>,
        IRandomSource<double> 

    {
        internal Polyrand(IRandomSource<ulong> Random)
        {
            this.Random = Random;            
        }


        readonly IRandomSource<ulong> Random;

        IPointSource<byte> UInt8Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<ushort> UInt16Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<int> Int32Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<uint> UInt32Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<long> Int64Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<ulong> UInt64Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<float> Float32Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<double> Float64Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next()
            => Random.Next();

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next()
            => (byte)Random.Next((ulong)Byte.MaxValue);

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next()
            => (ushort)Random.Next((ushort)UInt16.MaxValue);

        [MethodImpl(Inline)]
        int IPointSource<int>.Next()
            => (int) (Random.Next((ulong)Int32.MaxValue*2) - Int32.MaxValue);

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next()
            =>(uint)Random.Next((ulong)UInt32.MaxValue);

        [MethodImpl(Inline)]
        long IPointSource<long>.Next()
        {
            var next = (long)Random.Next(Int64.MaxValue);
            var negative = BitMask.test(next, 7);
            var result = BitMask.test(next, 7) ? BitMask.enable(ref next, 63) : next;
            return result;
        }

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        float IPointSource<float>.Next()
            => math.ldexp((float)UInt32Source.Next(), -32);

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        double IPointSource<double>.Next()
            => math.ldexp((double)Random.Next(), -64);
        

        [MethodImpl(Inline)]
        public T Next<T>()
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(UInt8Source.Next());                
            else if(typeof(T) == typeof(ushort))
                return generic<T>(UInt16Source.Next());                
            else if(typeof(T) == typeof(int))
                return generic<T>(Int32Source.Next());                
            else if(typeof(T) == typeof(uint))
                return generic<T>(UInt32Source.Next());                
            else if(typeof(T) == typeof(long))
                return generic<T>(Int64Source.Next());                
            else if(typeof(T) == typeof(ulong))
                return generic<T>(UInt64Source.Next());                
            else if(typeof(T) == typeof(float))
                return generic<T>(Float32Source.Next());                
            else if(typeof(T) == typeof(double))
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