//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zcore;

    public interface Setting
    {
        int SampleSize {get;}
        int Reps {get;}
        int Cycles {get;}

    }
    
    public interface Setting<T> : Setting
    {
        Interval<T> Domain {get;}
    }


    public readonly struct Settings : 
        Setting<sbyte>,
        Setting<byte>,
        Setting<short>,
        Setting<ushort>,
        Setting<int>,
        Setting<uint>,
        Setting<long>,
        Setting<ulong>,
        Setting<float>,
        Setting<double>,
        Setting<BigInteger>

    {

        static readonly Settings TheOnly = default;

        static Setting<T> get<T>()
            => cast<Setting<T>>(TheOnly);
        
        public static int Cycles()
            => 10;

        public static int Reps()
            => 100;

        public static int SampleSize()
            => (int)Pow2.T18;

        int Setting.Cycles
            => Cycles();

        int Setting.SampleSize 
            =>SampleSize();

        int Setting.Reps 
            => Reps();

        public static Interval<T> Domain<T>()
            => get<T>().Domain;

        public static int Reps<T>()
            => get<T>().Reps;

        public static int Cycles<T>()
            => get<T>().Cycles;

        public static int SampleSize<T>()
            => get<T>().SampleSize;


        static readonly Interval<sbyte> Int8Domain 
            = Interval.closed(sbyte.MinValue,sbyte.MaxValue);

        Interval<sbyte> Setting<sbyte>.Domain 
            => Int8Domain;

        static readonly Interval<byte> UInt8Domain 
            = Interval.closed(byte.MinValue,byte.MaxValue);

        Interval<byte> Setting<byte>.Domain 
            => UInt8Domain;

        static readonly Interval<short> Int16Domain 
            = Interval.closed(short.MinValue,short.MaxValue);

        Interval<short> Setting<short>.Domain 
            => Int16Domain;

        static readonly Interval<ushort> UInt16Range 
            = Interval.closed<ushort>(0,30000);

        Interval<ushort> Setting<ushort>.Domain 
            => UInt16Range;

        static readonly Interval<int> Int32Domain 
            = Interval.closed(-250000,250000);

        Interval<int> Setting<int>.Domain 
            => Int32Domain;

        static readonly Interval<uint> UInt32Domain 
            = Interval.closed(0u,500000u);

        Interval<uint> Setting<uint>.Domain 
            => UInt32Domain;
 
        static readonly Interval<long> Int64Domain 
            = Interval.closed(-250000L,250000L);

        Interval<long> Setting<long>.Domain 
            => Int64Domain;

        static readonly Interval<ulong> UInt64Domaim 
            = Interval.closed(0UL,500000UL);

        Interval<ulong> Setting<ulong>.Domain 
            => UInt64Domaim;

        static readonly Interval<float> Float32Domain 
            = Interval.closed(-250000.00f,250000.00f);

        Interval<float> Setting<float>.Domain 
            => Float32Domain;

        static readonly Interval<double> Float64Domain 
            = Interval.closed(-250000.00, 250000.00);

        Interval<double> Setting<double>.Domain 
            => Float64Domain;

        static readonly Interval<BigInteger> BigIntRange 
            = Interval.closed<BigInteger>(-250000,250000);

        Interval<BigInteger> Setting<BigInteger>.Domain 
            => BigIntRange;

    }
}