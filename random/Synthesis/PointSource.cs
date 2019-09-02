//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    class PointSource : IPointSource<ulong>
    {
        readonly IRandomSource Random;

        [MethodImpl(Inline)]
        public PointSource(IRandomSource Random)
        {
            this.Random = Random;
        }

        [MethodImpl(Inline)]
        public ulong Next()        
            => Random.NextUInt64();        

        [MethodImpl(Inline)]
        public ulong Next(ulong max)
            => Next().Contract(max);

        [MethodImpl(Inline)]
        public ulong Next(ulong min, ulong max)        
            => min + Next(max - min);
    }

    readonly struct PointSource<T> : IPointSource<T>
        where T : struct
    {
        readonly IPointSource<ulong> Points;
                
        readonly T MinVal;

        readonly T MaxVal;

        readonly bool Bounded;

        public PointSource(IPointSource<ulong> points, Interval<T>? domain = null)
        {
            this.Points = points;
            this.MinVal = domain?.Left ?? default;
            this.MaxVal = domain?.Right ?? default;
            this.Bounded = domain != null;
        }

        [MethodImpl(Inline)]
        public T Next()
            => Bounded ? NextBounded(MinVal,MaxVal) : NextUnbounded();

        [MethodImpl(Inline)]
        public T Next(T max)
            => NextBounded(default,max);

        [MethodImpl(Inline)]
        public T Next(T min, T max)
            => NextBounded(min,max);

        [MethodImpl(Inline)]
        T NextBounded(T min, T max)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Next(int8(MinVal), int8(MaxVal)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Next(uint8(MinVal), uint8(MaxVal)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Next(int16(MinVal), int16(MaxVal)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Next(uint16(MinVal), uint16(MaxVal)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Next(int32(MinVal), int32(MaxVal)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Next(uint32(MinVal), uint32(MaxVal)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Next(int64(MinVal), int64(MaxVal)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Next(uint64(MinVal), uint64(MaxVal)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Next(float32(MinVal), float32(MaxVal)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Next(float64(MinVal), float64(MaxVal)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        T NextUnbounded()
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(NextI8());
            else if(typeof(T) == typeof(byte))
                return generic<T>(NextU8());
            else if(typeof(T) == typeof(short))
                return generic<T>(NextI16());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(NextU16());
            else if(typeof(T) == typeof(int))
                return generic<T>(NextI32());
            else if(typeof(T) == typeof(uint))
                return generic<T>(NextU32());
            else if(typeof(T) == typeof(long))
                return generic<T>(NextI64());
            else if(typeof(T) == typeof(ulong))
                return generic<T>(NextU64());
            else if(typeof(T) == typeof(float))
                return generic<T>(NextF32());
            else if(typeof(T) == typeof(double))
                return generic<T>(NextU32());
            else 
                throw unsupported<T>();

        }
    
        [MethodImpl(Inline)]
        short NextI8()
            => (sbyte) Points.Next(((ulong)SByte.MaxValue*2) - (ulong)SByte.MaxValue);

        [MethodImpl(Inline)]
        byte NextU8()
            => (byte)Points.Next((ulong)Byte.MaxValue);

        [MethodImpl(Inline)]
        short NextI16()
            => (short) Points.Next(((ulong)Int16.MaxValue*2) - (ulong)Int16.MaxValue);

        [MethodImpl(Inline)]
        ushort NextU16()
            => (ushort)Points.Next((ulong)UInt16.MaxValue);


        [MethodImpl(Inline)]
        int NextI32()
            => (int) (Points.Next((ulong)Int32.MaxValue*2) - Int32.MaxValue);

        [MethodImpl(Inline)]
        uint NextU32()
            => (uint)Points.Next((ulong)UInt32.MaxValue);


        [MethodImpl(Inline)]
        long NextI64()
        {
            var next = (long)Points.Next(Int64.MaxValue);
            var negative = BitMask.test(next, 7);
            var result = BitMask.test(next, 7) ? BitMask.enable(ref next, 63) : next;
            return result;
        }

        [MethodImpl(Inline)]
        ulong NextU64()
            => Points.Next();

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        float NextF32()
            => math.ldexp((float)NextU32(), -32);

        // For the logic of this, see http://mumble.net/~campbell/tmp/random_real.c
        [MethodImpl(Inline)]
        double NextF64()
            => math.ldexp((double)NextU64(), -64);        

        [MethodImpl(Inline)]
        sbyte Next(sbyte min, sbyte max)
        {
            var delta = math.sub(min,max);
            var next = 
                delta > 0 
                ? math.add(min, (sbyte)Points.Next((ulong)delta)) 
                : math.add(min, (sbyte)Points.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        byte Next(byte min, byte max)
            => math.add(min, (byte)Points.Next((ulong)(max - min)));

        [MethodImpl(Inline)]
        short Next(short min, short max)
        {
            var delta = math.sub(min,max);
            var next = 
                delta > 0 
                ? math.add(min, (short)Points.Next((ulong)delta)) 
                : math.add(min, (short)Points.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        ushort Next(ushort min, ushort max)
            => math.add(min, (ushort)Points.Next((ulong)(max - min)));

        [MethodImpl(Inline)]
        int Next(int min, int max)
        {
            var delta = math.sub(min,max);
            var next = 
                delta > 0 
                ? math.add(min, (int)Points.Next((ulong)delta)) 
                : math.add(min, (int)Points.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        uint Next(uint min, uint max)
            => math.add(min, (uint)Points.Next((ulong)(max - min)));

        [MethodImpl(Inline)]
        long Next(long min, long max)
        {
            var delta = math.sub(min,max);
            var next = 
                delta > 0 
                ? math.add(min, (long)Points.Next((ulong)delta)) 
                : math.add(min, (long)Points.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        ulong Next(ulong min, ulong max)
            => min + Points.Next(max - min);

        [MethodImpl(Inline)]
        float Next(float min, float max)
        {
            var whole = (float)Next((int)min, (int)max);
            return whole + NextF32();            
        }

        [MethodImpl(Inline)]
        double Next(double min, double max)
        {
            var whole = (double)Next((long)min, (long)max);
            return whole + NextF64();            
        }
    }

}
