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

    class PolyRandU8 : IBoundRandomSource<byte>
    {
        static readonly Interval<byte> DefaultRange = Interval<byte>.Full;

        [MethodImpl(Inline)]
        internal PolyRandU8(IRandomSource<ulong> random, Interval<byte>? range = null)
        {
            this.Random = random;
            this.Range = range ?? DefaultRange;
            this.LowerBound = Range.Left;
            this.UpperBound = Range.Right;
            this.RangeDelta = math.sub(UpperBound, LowerBound);
        }

        readonly byte LowerBound;
        
        readonly byte UpperBound;

        readonly IRandomSource<ulong> Random;

        readonly byte RangeDelta;

        public Interval<byte> Range {get;}

        [MethodImpl(Inline)]
        public byte Next()
        {
            var sample = Random.Next(RangeDelta);
            return (byte)math.add(LowerBound, sample);
        }
    }

    class PolyRandI8 : IBoundRandomSource<sbyte>
    {
        static readonly Interval<sbyte> DefaultRange = Interval<sbyte>.Full;

        [MethodImpl(Inline)]
        internal PolyRandI8(IRandomSource<byte> random, Interval<sbyte>? range = null)
        {
            this.Random = random;
            this.Range = range ?? DefaultRange;
            this.LowerBound = Range.Left;
            this.UpperBound = Range.Right;
            this.RangeDelta = math.sub(UpperBound, LowerBound);
        }

        readonly sbyte LowerBound;
        
        readonly sbyte UpperBound;

        readonly IRandomSource<byte> Random;

        readonly sbyte RangeDelta;

        public Interval<sbyte> Range {get;}

        [MethodImpl(Inline)]
        public sbyte Next()
        {
            var sample = Random.Next((byte)RangeDelta);
            var signed = RangeDelta > 0 ? (sbyte)sample : math.negate((sbyte)sample);
            var next = math.add(LowerBound, signed);
            return next;
        }
    }

    public class Polyrand : 
        IRandomSource<ulong>, 
        IRandomSource<double>, 
        IRandomSource<uint>, 
        IRandomSource<int>, 
        IRandomSource<float>,
        IRandomSource<long>,
        IRandomSource<byte>,
        IRandomSource<ushort>
    {
        internal Polyrand(IRandomSource<ulong> Random)
        {
            this.Random = Random;            
        }


        readonly IRandomSource<ulong> Random;

        IPointSource<int> Int32Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

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
            var negative = Bits.test(next, 7);
            var result = Bits.test(next, 7) ? Bits.enable(ref next, 63) : next;
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