//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static As;

    /// <summary>
    /// A basic statistical accumulator that accrues information over an 
    /// arbitrary number of input sequences
    /// </summary>
    public class Collector
    {
        int count;
        
        double min;

        double max;

        double m0;

        double m1;

        double s0;

        double s1;


        /// <summary>
        /// Creates an empty collector
        /// </summary>
        [MethodImpl(Inline)]
        public static Collector Create()
            => new Collector(ReadOnlySpan<double>.Empty);

        /// <summary>
        /// Creates a collector with a set of initial observations
        /// </summary>
        /// <param name="src">The initial observations</param>
        /// <typeparam name="T">The observation type</typeparam>
        [MethodImpl(Inline)]
        public static void Create<T>(params T[] src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Create(src.ToSpan().As<T,sbyte>());
            else if(typeof(T) == typeof(byte))
                Create(src.ToSpan().As<T, byte>());
            else if(typeof(T) == typeof(short))
                Create(src.ToSpan().As<T, short>());
            else if(typeof(T) == typeof(ushort))
                Create(src.ToSpan().As<T,ushort>());
            else if(typeof(T) == typeof(int))
                Create(src.ToSpan().As<T,int>());
            else if(typeof(T) == typeof(uint))
                Create(src.ToSpan().As<T,uint>());
            else if(typeof(T) == typeof(long))
                Create(src.ToSpan().As<T,long>());
            else if(typeof(T) == typeof(ulong))
                Create(src.ToSpan().As<T,ulong>());
            else if(typeof(T) == typeof(float))
                Create(src.ToSpan().As<T,float>());
            else if(typeof(T) == typeof(double))
                Create(src.ToSpan().As<T,double>());
        }

        
        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, int value)
        {
            a.CollectValue(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<int> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, int[] value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<int> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<int> value)
        {
            a.CollectStream(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, uint value)
        {
            a.CollectValue(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<uint> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, uint[] value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<uint> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<uint> value)
        {
            a.CollectStream(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, long value)
        {
            a.CollectValue(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<long> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, long[] value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<long> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<long> value)
        {
            a.CollectStream(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ulong value)
        {
            a.CollectValue(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<ulong> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ulong[] value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<ulong> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<ulong> value)
        {
            a.CollectStream(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, float value)
        {
            a.CollectValue(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<float> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, float[] value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<float> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<float> value)
        {
            a.CollectStream(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, double value)
        {
            a.CollectValue(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, Span<double> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, double[] value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, ReadOnlySpan<double> value)
        {
            a.CollectSpan(value);
            return a;
        }

        [MethodImpl(Inline)]
        public static Collector operator +(Collector a, IEnumerable<double> value)
        {
            a.CollectStream(value);
            return a;
        }

        /// <summary>
        /// The number of accumulated observations
        /// </summary>
        public int Count 
        {
            [MethodImpl(Inline)]
            get => count;
        }

        /// <summary>
        /// The accumulated mean
        /// </summary>
        public double Mean
        {
            [MethodImpl(Inline)]
            get => m1;
        }
                    
        /// <summary>
        /// The accumulated variance
        /// </summary>
        public double Variance   
        {     
            [MethodImpl(Inline)]
            get => count > 1 ? s0/(count - 1) : 0;
        }

        /// <summary>
        /// The accumulated standard deviation
        /// </summary>
        public double Stdev
        {
            [MethodImpl(Inline)]
            get => fmath.sqrt(Variance);
        }

        /// <summary>
        /// Accumulates a stream of values
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(IEnumerable<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                CollectStream(src.Cast<sbyte>());
            else if(typeof(T) == typeof(byte))
                CollectStream(src.Cast<byte>());
            else if(typeof(T) == typeof(short))
                CollectStream(src.Cast<short>());
            else if(typeof(T) == typeof(ushort))
                CollectStream(src.Cast<ushort>());
            else if(typeof(T) == typeof(int))
                CollectStream(src.Cast<int>());
            else if(typeof(T) == typeof(uint))
                CollectStream(src.Cast<uint>());
            else if(typeof(T) == typeof(long))
                CollectStream(src.Cast<long>());
            else if(typeof(T) == typeof(ulong))
                CollectStream(src.Cast<ulong>());
            else if(typeof(T) == typeof(float))
                CollectStream(src.Cast<float>());
            else if(typeof(T) == typeof(double))
                CollectStream(src.Cast<double>());
        }

        /// <summary>
        /// Accumulates a span of values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(params T[] src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                CollectSpan(src.ToSpan().As<T,sbyte>());
            else if(typeof(T) == typeof(byte))
                CollectSpan(src.ToSpan().As<T, byte>());
            else if(typeof(T) == typeof(short))
                CollectSpan(src.ToSpan().As<T, short>());
            else if(typeof(T) == typeof(ushort))
                CollectSpan(src.ToSpan().As<T,ushort>());
            else if(typeof(T) == typeof(int))
                CollectSpan(src.ToSpan().As<T,int>());
            else if(typeof(T) == typeof(uint))
                CollectSpan(src.ToSpan().As<T,uint>());
            else if(typeof(T) == typeof(long))
                CollectSpan(src.ToSpan().As<T,long>());
            else if(typeof(T) == typeof(ulong))
                CollectSpan(src.ToSpan().As<T,ulong>());
            else if(typeof(T) == typeof(float))
                CollectSpan(src.ToSpan().As<T,float>());
            else if(typeof(T) == typeof(double))
                CollectSpan(src.ToSpan().As<T,double>());
        }

        /// <summary>
        /// Accumulates a span of values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                CollectSpan(src.As<T,sbyte>());
            else if(typeof(T) == typeof(byte))
                CollectSpan(src.As<T, byte>());
            else if(typeof(T) == typeof(short))
                CollectSpan(src.As<T, short>());
            else if(typeof(T) == typeof(ushort))
                CollectSpan(src.As<T,ushort>());
            else if(typeof(T) == typeof(int))
                CollectSpan(src.As<T,int>());
            else if(typeof(T) == typeof(uint))
                CollectSpan(src.As<T,uint>());
            else if(typeof(T) == typeof(long))
                CollectSpan(src.As<T,long>());
            else if(typeof(T) == typeof(ulong))
                CollectSpan(src.As<T,ulong>());
            else if(typeof(T) == typeof(float))
                CollectSpan(src.As<T,float>());
            else if(typeof(T) == typeof(double))
                CollectSpan(src.As<T,double>());
        }

        /// <summary>
        /// Accumulates a single value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public void Collect<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                CollectValue(int8(src));
            else if(typeof(T) == typeof(byte))
                CollectValue(uint8(src));
            else if(typeof(T) == typeof(short))
                CollectValue(int16(src));
            else if(typeof(T) == typeof(ushort))
                CollectValue(uint16(src));
            else if(typeof(T) == typeof(int))
                CollectValue(int32(src));
            else if(typeof(T) == typeof(uint))
                CollectValue(uint32(src));
            else if(typeof(T) == typeof(long))
                CollectValue(int64(src));
            else if(typeof(T) == typeof(ulong))
                CollectValue(uint64(src));
            else if(typeof(T) == typeof(float))
                CollectValue(float32(src));
            else if(typeof(T) == typeof(double))
                CollectValue(float64(src));
        }

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<sbyte> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<byte> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<short> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<ushort> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<int> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<uint> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<long> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<ulong> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<float> src)
            => new Collector(src);

        [MethodImpl(Inline)]
        static Collector Create(ReadOnlySpan<double> src)
            => new Collector(src);


        [MethodImpl(Inline)]
        Collector()
        {
            min = double.MaxValue;
            max = double.MinValue;
        }

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<sbyte> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<byte> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<short> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<ushort> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<int> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<uint> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<long> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<ulong> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<float> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        Collector(ReadOnlySpan<double> src)
            : this()
                => CollectSpan(src);

        [MethodImpl(Inline)]
        void CollectValue(sbyte value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(byte value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(short value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(ushort value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(int value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(uint value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(long value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(ulong value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(float value)
            => Merge(value);

        [MethodImpl(Inline)]
        void CollectValue(double value)
            => Merge(value);

        void CollectSpan(ReadOnlySpan<sbyte> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<byte> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<short> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<ushort> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<int> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<uint> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<long> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<ulong> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<float> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectSpan(ReadOnlySpan<double> values)
        {
            for(var i=0; i< values.Length; i++)
                Merge(i);
        }

        void CollectStream(IEnumerable<sbyte> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<byte> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<short> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<ushort> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<int> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<uint> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<long> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<ulong> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<float> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void CollectStream(IEnumerable<double> values)
        {
            foreach(var v in values)
                Merge(v);
        }

        void Merge(double value)
        {
            if(++count == 1)
            {
                m1 = value;
                m0 = value;
                s0 = 0;
            }
            else
            {
                var delta = value - m0;
                m1 = m0 + delta/count;
                s1 = s0 + delta*(value - m1);            
                m0 = m1;
                s0 = s1;                
            }

            if(value > max)
                max = value;
            
            if(value < min)
                min = value;            
        }

        public string Format(int? scale = null)
        {
            return $"observations = {count} | min = {min} | max = {max} | mean={Mean.Round(scale ?? 4)} | stdev={Stdev.Round(scale ?? 4)}";
        }

        public override string ToString()
            => Format();
    }
}