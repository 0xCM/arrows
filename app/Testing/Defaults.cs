//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zcore;

    public interface Default
    {
        int SampleSize {get;}

        int Reps {get;}

    }
    
    public interface Default<T> : Default
        where T : struct, IEquatable<T>
    {
        Interval<T> Domain {get;}
    }


    public readonly struct Defaults : 
        Default<sbyte>,
        Default<byte>,
        Default<short>,
        Default<ushort>,
        Default<int>,
        Default<uint>,
        Default<long>,
        Default<ulong>,
        Default<float>,
        Default<double>,
        Default<decimal>,
        Default<BigInteger>

    {

        static readonly Defaults TheOnly = default;

        public static Default<T> get<T>()
            where T : struct, IEquatable<T>
                => cast<Default<T>>(TheOnly);

        public const int Reps = 1;

        public const int OpApplyReps = 50;

        public const int SampleSize = (int)Pow2.T14;

        int Default.SampleSize 
            => SampleSize;

        int Default.Reps 
            => Reps;

        // ! Int8
        public const sbyte Int8Min = sbyte.MinValue;

        public const sbyte Int8Max = sbyte.MaxValue;

        public static readonly Interval<sbyte> Int8Domain = Interval.closed(Int8Min,Int8Max);

        Interval<sbyte> Default<sbyte>.Domain 
            => Int8Domain;

        // ! UInt8
        public const byte UInt8Min = byte.MinValue;

        public const byte UInt8Max = byte.MaxValue;

        public static readonly Interval<byte> UInt8Domain = Interval.closed(UInt8Min,UInt8Max);

        Interval<byte> Default<byte>.Domain 
            => UInt8Domain;

        // ! Int16

        public const short Int16Min = short.MinValue;
        
        public const short Int16Max = short.MaxValue;

        public static readonly Interval<short> Int16Domain = Interval.closed(Int16Min,Int16Max);

        Interval<short> Default<short>.Domain 
            => Int16Domain;

        // ! Int16

        public const ushort UInt16Min = 0;
        
        public const ushort UInt16Max = 30000;

        public static readonly Interval<ushort> UInt16Range = Interval.closed(UInt16Min,UInt16Max);

        Interval<ushort> Default<ushort>.Domain 
            => UInt16Range;

        // ! Int32

        public const int Int32Min = -250000;
        
        public const int Int32Max = 250000;

        public static readonly Interval<int> Int32Domain = Interval.closed(Int32Min,Int32Max);

        Interval<int> Default<int>.Domain 
            => Int32Domain;

        // ! UInt32

        public const uint UInt32Min = 0;
        
        public const uint UInt32Max = 500000;

        public static readonly Interval<uint> UInt32Domain = Interval.closed(UInt32Min,UInt32Max);

        Interval<uint> Default<uint>.Domain 
            => UInt32Domain;
 
        // ! Int64

        public const long Int64Min = -250000;
        
        public const long Int64Max = 250000;

        public static readonly Interval<long> Int64Domain = Interval.closed(Int64Min,Int64Max);

       Interval<long> Default<long>.Domain 
            => Int64Domain;

        // ! UInt64

        public const ulong UInt64Min = 0;
        
        public const ulong UInt64Max = 500000;

        public static readonly Interval<ulong> UInt64Domaim = Interval.closed(UInt64Min,UInt64Max);

        Interval<ulong> Default<ulong>.Domain 
            => UInt64Domaim;

       // ! Float32

        public const float Float32Min = -250000.00f;
        
        public const float Float32Max = 250000.00f;

        public static readonly Interval<float> Float32Domain = Interval.closed(Float32Min,Float32Max);

        Interval<float> Default<float>.Domain 
            => Float32Domain;

        // ! Float64

        public const double Float64Min = -250000.00;
        
        public const double Float64Max = 250000.00;

        public static readonly Interval<double> Float64Domain = Interval.closed(Float64Min,Float64Max);

        Interval<double> Default<double>.Domain 
            => Float64Domain;

        // ! Float64

        public const decimal DecimalMin = -250000.00m;
        
        public const decimal DecimalMax = 250000.00m;

        public static readonly Interval<decimal> DecimalDomain = Interval.closed(DecimalMin,DecimalMax);

        Interval<decimal> Default<decimal>.Domain 
            => DecimalDomain;

       // ! BigInteger

        public static readonly BigInteger BigIntMin = -250000;
        
        public static readonly BigInteger BigIntMax = 250000;

        public static readonly Interval<BigInteger> BigIntRange = Interval.closed(BigIntMin,BigIntMax);

        Interval<BigInteger> Default<BigInteger>.Domain 
            => BigIntRange;

    }
}