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
    using static zfunc;

    public interface Setting
    {
        int SampleSize {get;}
        int Reps {get;}
        int Cycles {get;}

    }
    
    public interface Setting<T> : Setting
        where T : struct, IEquatable<T>
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
            where T : struct, IEquatable<T>
                => cast<Setting<T>>(TheOnly);
        
        public static int Cycles()
            => 5;

        public static int Reps()
            => 50;

        public static int SampleSize()
            => (int)Pow2.T19;

        int Setting.Cycles
            => Cycles();

        int Setting.SampleSize 
            =>SampleSize();

        int Setting.Reps 
            => Reps();

        public static Interval<T> Domain<T>()
            where T : struct, IEquatable<T>
                => get<T>().Domain;

        public static int Reps<T>()
            where T : struct, IEquatable<T>
                => get<T>().Reps;

        public static int Cycles<T>()
            where T : struct, IEquatable<T>
                => get<T>().Cycles;

        public static int SampleSize<T>()
            where T : struct, IEquatable<T>
                => get<T>().SampleSize;


        static readonly Interval<sbyte> Int8Domain 
            = closed<sbyte>(sbyte.MinValue + 1, sbyte.MaxValue - 1);

        Interval<sbyte> Setting<sbyte>.Domain 
            => Int8Domain;

        static readonly Interval<byte> UInt8Domain 
            = closed<byte>(byte.MinValue + 1, byte.MaxValue - 1);

        Interval<byte> Setting<byte>.Domain 
            => UInt8Domain;

        static readonly Interval<short> Int16Domain 
            = closed<short>(short.MinValue + 1, short.MaxValue - 1);

        Interval<short> Setting<short>.Domain 
            => Int16Domain;

        static readonly Interval<ushort> UInt16Range 
            = closed<ushort>(ushort.MinValue + 1, ushort.MaxValue - 1);

        Interval<ushort> Setting<ushort>.Domain 
            => UInt16Range;

        static readonly Interval<int> Int32Domain 
            = closed(-250000,250000);

        Interval<int> Setting<int>.Domain 
            => Int32Domain;

        static readonly Interval<uint> UInt32Domain 
            = closed(0u,500000u);

        Interval<uint> Setting<uint>.Domain 
            => UInt32Domain;
 
        static readonly Interval<long> Int64Domain 
            = closed(-250000L,250000L);

        Interval<long> Setting<long>.Domain 
            => Int64Domain;

        static readonly Interval<ulong> UInt64Domaim 
            = closed(0UL,500000UL);

        Interval<ulong> Setting<ulong>.Domain 
            => UInt64Domaim;

        static readonly Interval<float> Float32Domain 
            = closed(-250000.00f,250000.00f);

        Interval<float> Setting<float>.Domain 
            => Float32Domain;

        static readonly Interval<double> Float64Domain 
            = closed(-250000.00, 250000.00);

        Interval<double> Setting<double>.Domain 
            => Float64Domain;

        static readonly Interval<BigInteger> BigIntRange 
            = closed<BigInteger>(-250000,250000);

        Interval<BigInteger> Setting<BigInteger>.Domain 
            => BigIntRange;

    }
}