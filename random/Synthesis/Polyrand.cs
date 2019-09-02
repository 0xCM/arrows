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

    class Polyrand<T> : IPointSource<T>
        where T : struct
    {
        readonly Polyrand Random;
        
        public Polyrand(IPointSource<ulong> Random)
        {
            this.Random = new Polyrand(Random);
        }

        public T Next()
            => Random.Next<T>();

        public T Next(T max)
            => Random.Next<T>(max);

        public T Next(T min, T max)
            => Random.Next<T>(min, max);
    }

    class Polyrand : IPolyrand

    {
        internal Polyrand(IPointSource<ulong> Random)
        {
            this.Random = Random;            
        }

        internal Polyrand(IRandomSource Random)
        {
            this.Random = new PointSource(Random);
        }

        readonly IPointSource<ulong> Random;


        [MethodImpl(Inline)]
        public T Next<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Int8Source.Next());                
            else if(typeof(T) == typeof(byte))
                return generic<T>(UInt8Source.Next());                
            else if(typeof(T) == typeof(short))
                return generic<T>(Int16Source.Next());                
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

        [MethodImpl(Inline)]
        public T Next<T>(T max)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Int8Source.Next(int8(max)));                
            else if(typeof(T) == typeof(byte))
                return generic<T>(UInt8Source.Next(uint8(max)));                
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Int16Source.Next(int16(max)));                
            else if(typeof(T) == typeof(ushort))
                return generic<T>(UInt16Source.Next(uint16(max)));                
            else if(typeof(T) == typeof(int))
                return generic<T>(Int32Source.Next(int32(max)));                
            else if(typeof(T) == typeof(uint))
                return generic<T>(UInt32Source.Next(uint32(max)));                
            else if(typeof(T) == typeof(long))
                return generic<T>(Int64Source.Next(int64(max)));                
            else if(typeof(T) == typeof(ulong))
                return generic<T>(UInt64Source.Next(uint64(max)));                
            else if(typeof(T) == typeof(float))
                return generic<T>(Float32Source.Next(float32(max)));                
            else if(typeof(T) == typeof(double))
                return generic<T>(Float64Source.Next(float64(max)));                
            else 
                throw unsupported<T>();                
        }

        [MethodImpl(Inline)]
        public T Next<T>(T min, T max)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Int8Source.Next(int8(min), int8(max)));                
            else if(typeof(T) == typeof(byte))
                return generic<T>(UInt8Source.Next(uint8(min), uint8(max)));                
            else if(typeof(T) == typeof(short))
                return generic<T>(Int16Source.Next(int16(min), int16(max)));                
            else if(typeof(T) == typeof(ushort))
                return generic<T>(UInt16Source.Next(uint16(min), uint16(max)));                
            else if(typeof(T) == typeof(int))
                return generic<T>(Int32Source.Next(int32(min),int32(max)));                
            else if(typeof(T) == typeof(uint))
                return generic<T>(UInt32Source.Next(uint32(min), uint32(max)));                
            else if(typeof(T) == typeof(long))
                return generic<T>(Int64Source.Next(int64(min), int64(max)));                
            else if(typeof(T) == typeof(ulong))
                return generic<T>(UInt64Source.Next(uint64(min), uint64(max)));                
            else if(typeof(T) == typeof(float))
                return generic<T>(Float32Source.Next(float32(min), float32(max)));                
            else if(typeof(T) == typeof(double))
                return generic<T>(Float64Source.Next(float64(min), float64(max)));                
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

        IPointSource<sbyte> Int8Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<byte> UInt8Source
        {
            [MethodImpl(Inline)]
            get => this;
        }

        IPointSource<short> Int16Source
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
        sbyte IPointSource<sbyte>.Next()
             => (sbyte) (Random.Next((ulong)SByte.MaxValue*2) - (ulong)SByte.MaxValue);

        [MethodImpl(Inline)]
        sbyte IPointSource<sbyte>.Next(sbyte max)
        {
            var amax = (ulong)math.abs(max);
            return (sbyte) (Random.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        sbyte IPointSource<sbyte>.Next(sbyte min, sbyte max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? math.add(min, (sbyte)Random.Next((ulong)delta)) 
                : math.add(min, (sbyte)Random.Next((ulong)delta.Negate()));
        }

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next(byte min, byte max)
            => (byte)Random.Next((ulong)min, (ulong)max);

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next(byte max)
            => (byte)Random.Next((ulong)max);

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next()
            => (byte)Random.Next((ulong)Byte.MaxValue);

        [MethodImpl(Inline)]
        short IPointSource<short>.Next()
            => (short) (Random.Next((ulong)Int16.MaxValue*2) - (ulong)Int16.MaxValue);

        [MethodImpl(Inline)]
        short IPointSource<short>.Next(short max)
        {
            var amax = (ulong)math.abs(max);
            return (short) (Random.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        short IPointSource<short>.Next(short min, short max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? math.add(min, (short)Random.Next((ulong)delta)) 
                : math.add(min, (short)Random.Next((ulong)delta.Negate()));
        }

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next()
            => (ushort)Random.Next((ushort)UInt16.MaxValue);

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next(ushort max)
            => (ushort)Random.Next((ulong)max);

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next(ushort min, ushort max)
            => (ushort)Random.Next((ulong)min, (ulong)max);

        [MethodImpl(Inline)]
        int IPointSource<int>.Next()
            => (int) (Random.Next((ulong)Int32.MaxValue*2) - Int32.MaxValue);

        [MethodImpl(Inline)]
        int IPointSource<int>.Next(int max)
        {
            var amax = (ulong)math.abs(max);
            return (int) (Random.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        int IPointSource<int>.Next(int min, int max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? min + (int)Random.Next((ulong)delta) 
                : min + (int)Random.Next((ulong)delta.Negate());
        }

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next()
            =>(uint)Random.Next((ulong)UInt32.MaxValue);

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next(uint max)
            => (uint)Random.Next((ulong)max);

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next(uint min, uint max)
            => (uint)Random.Next((ulong)min, (ulong)max);

        [MethodImpl(Inline)]
        long IPointSource<long>.Next()
        {
            var next = (long)Random.Next(Int64.MaxValue);
            var negative = BitMask.test(next, 7);
            var result = BitMask.test(next, 7) ? BitMask.enable(ref next, 63) : next;
            return result;
        }

        [MethodImpl(Inline)]
        long IPointSource<long>.Next(long max)
        {
            var amax = (ulong)math.abs(max);
            return (long) (Random.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        long IPointSource<long>.Next(long min, long max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? min + (long)Random.Next((ulong)delta) 
                : min + (long)Random.Next((ulong)delta.Negate());
        }

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next()
            => Random.Next();

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next(ulong max)
            => Random.Next(max);

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next(ulong min, ulong max)
            => Random.Next(min, max);

        [MethodImpl(Inline)]
        float IPointSource<float>.Next()
            => NextF32();

        [MethodImpl(Inline)]
        float IPointSource<float>.Next(float max)
        {
            var whole = (float)Int32Source.Next((int)max);
            return whole + NextF32();
        }

        [MethodImpl(Inline)]
        float IPointSource<float>.Next(float min, float max)
        {
            var whole = (float)Int32Source.Next((int)min, (int)max);
            return whole + NextF32();
        }

        [MethodImpl(Inline)]
        double IPointSource<double>.Next()
            => NextF64();

        [MethodImpl(Inline)]
        double IPointSource<double>.Next(double min, double max)
        {
            var whole = (double)Int64Source.Next((long)min, (long)max);
            return whole + NextF64();
        }

        [MethodImpl(Inline)]
        double IPointSource<double>.Next(double max)
        {
            var whole = (double)Int64Source.Next((long)max);
            return whole + NextF64();
        }

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        float NextF32()
            => math.ldexp((float)UInt32Source.Next(), -32);


        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        double NextF64()
            => math.ldexp((double)Random.Next(), -64);


    }
}