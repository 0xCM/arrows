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

    class Polyrand : IPolyrand
    {
        internal Polyrand(IPointSource<ulong> Points)
        {
            this.Points = Points;            
            this.Nav = default;
        }


        internal Polyrand(IStepwiseSource<ulong> Points)
        {
            this.Points = Points;            
            this.Nav = some(Points as IRandomNav);
        }

        readonly IPointSource<ulong> Points;

        public Option<IRandomNav> Nav {get;}

        public RngKind RngKind 
            => Points.RngKind;

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

        [MethodImpl(Inline)]
        public T Next<T>(Interval<T> domain)
            where T : struct
            => Next(domain.Left, domain.Right);

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
             => (sbyte) (Points.Next((ulong)SByte.MaxValue*2) - (ulong)SByte.MaxValue);

 
        [MethodImpl(Inline)]
        sbyte IPointSource<sbyte>.Next(sbyte max)
        {
            var amax = (ulong)math.abs(max);
            return (sbyte) (Points.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        sbyte IPointSource<sbyte>.Next(sbyte min, sbyte max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? math.add(min, (sbyte)Points.Next((ulong)delta)) 
                : math.add(min, (sbyte)Points.Next((ulong)delta.Negate()));
        }

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next(byte min, byte max)
            => (byte)Points.Next((ulong)min, (ulong)max);

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next(byte max)
            => (byte)Points.Next((ulong)max);

        [MethodImpl(Inline)]
        byte IPointSource<byte>.Next()
            => (byte)Points.Next((ulong)Byte.MaxValue);

        [MethodImpl(Inline)]
        short IPointSource<short>.Next()
            => (short) (Points.Next((ulong)Int16.MaxValue*2) - (ulong)Int16.MaxValue);

        [MethodImpl(Inline)]
        short IPointSource<short>.Next(short max)
        {
            var amax = (ulong)math.abs(max);
            return (short) (Points.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        short IPointSource<short>.Next(short min, short max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? math.add(min, (short)Points.Next((ulong)delta)) 
                : math.add(min, (short)Points.Next((ulong)delta.Negate()));
        }

        [MethodImpl(Inline)]
        short NextI16()
            => (short) Points.Next(((ulong)Int16.MaxValue*2) - (ulong)Int16.MaxValue);

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next()
            => (ushort)Points.Next((ushort)UInt16.MaxValue);

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next(ushort max)
            => (ushort)Points.Next((ulong)max);

        [MethodImpl(Inline)]
        ushort IPointSource<ushort>.Next(ushort min, ushort max)
            => (ushort)Points.Next((ulong)min, (ulong)max);

        [MethodImpl(Inline)]
        int IPointSource<int>.Next()
            => (int) (Points.Next((ulong)Int32.MaxValue*2) - Int32.MaxValue);

        [MethodImpl(Inline)]
        int IPointSource<int>.Next(int max)
        {
            var amax = (ulong)math.abs(max);
            return (int) (Points.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        int IPointSource<int>.Next(int min, int max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? min + (int)Points.Next((ulong)delta) 
                : min + (int)Points.Next((ulong)delta.Negate());
        }

        [MethodImpl(Inline)]
        int NextI32()
            => (int) (Points.Next((ulong)Int32.MaxValue*2) - Int32.MaxValue);

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next()
            =>(uint)Points.Next((ulong)UInt32.MaxValue);

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next(uint max)
            => (uint)Points.Next((ulong)max);

        [MethodImpl(Inline)]
        uint IPointSource<uint>.Next(uint min, uint max)
            => (uint)Points.Next((ulong)min, (ulong)max);

        [MethodImpl(Inline)]
        uint NextU32(uint min, uint max)
            => math.add(min, (uint)Points.Next((ulong)(max - min)));

        [MethodImpl(Inline)]
        long IPointSource<long>.Next()
        {
            var next = (long)Points.Next(Int64.MaxValue);
            var negative = BitMask.test(next, 7);
            var result = BitMask.test(next, 7) ? BitMask.enable(ref next, 63) : next;
            return result;
        }

        [MethodImpl(Inline)]
        long IPointSource<long>.Next(long max)
        {
            var amax = (ulong)math.abs(max);
            return (long) (Points.Next(amax*2) - amax);
        }

        [MethodImpl(Inline)]
        long IPointSource<long>.Next(long min, long max)
        {
            var delta = math.sub(max, min);
            return delta > 0 
                ? min + (long)Points.Next((ulong)delta) 
                : min + (long)Points.Next((ulong)delta.Negate());
        }

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next()
            => Points.Next();

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next(ulong max)
            => Points.Next(max);

        [MethodImpl(Inline)]
        ulong IPointSource<ulong>.Next(ulong min, ulong max)
            => Points.Next(min, max);

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
            => (float)fmath.ldexp((double)Points.Next(), -32);                

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        double NextF64()
            => fmath.ldexp((double)Points.Next(), -64);    
    
    }
}