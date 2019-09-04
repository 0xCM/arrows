//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    
    public readonly struct RngDefaults : 
        ISampleDefaults<sbyte>,
        ISampleDefaults<byte>,
        ISampleDefaults<short>,
        ISampleDefaults<ushort>,
        ISampleDefaults<int>,
        ISampleDefaults<uint>,
        ISampleDefaults<long>,
        ISampleDefaults<ulong>,
        ISampleDefaults<float>,
        ISampleDefaults<double>,
        ISampleDefaults<decimal>,
        ISampleDefaults<BigInteger>
    {
        static readonly RngDefaults TheOnly = default;

        public static ISampleDefaults<T> get<T>()
            where T : struct
                => (ISampleDefaults<T>)(object)(TheOnly);

        const int SampleSize = (int)Pow2.T14;

        int ISampleDefaults.SampleSize 
            => SampleSize;

        const sbyte Int8Min = sbyte.MinValue;

        const sbyte Int8Max = sbyte.MaxValue;

        static readonly Interval<sbyte> Int8Domain = closed(Int8Min,Int8Max);

        Interval<sbyte> ISampleDefaults<sbyte>.SampleDomain 
            => Int8Domain;

        const byte UInt8Min = byte.MinValue;

        const byte UInt8Max = byte.MaxValue;

        static readonly Interval<byte> UInt8Domain = closed(UInt8Min,UInt8Max);

        Interval<byte> ISampleDefaults<byte>.SampleDomain 
            => UInt8Domain;

        const short Int16Min = short.MinValue;
        
        const short Int16Max = short.MaxValue;

        static readonly Interval<short> Int16Domain = closed(Int16Min,Int16Max);

        Interval<short> ISampleDefaults<short>.SampleDomain 
            => Int16Domain;

        const ushort UInt16Min = 0;
        
        const ushort UInt16Max = 30000;

        static readonly Interval<ushort> UInt16Range = closed(UInt16Min,UInt16Max);

        Interval<ushort> ISampleDefaults<ushort>.SampleDomain 
            => UInt16Range;

        const int Int32Min = -250000;
        
        const int Int32Max = 250000;

        static readonly Interval<int> Int32Domain = closed(Int32Min,Int32Max);

        Interval<int> ISampleDefaults<int>.SampleDomain 
            => Int32Domain;

        const uint UInt32Min = 0;
        
        const uint UInt32Max = 500000;

        static readonly Interval<uint> UInt32Domain = closed(UInt32Min,UInt32Max);

        Interval<uint> ISampleDefaults<uint>.SampleDomain 
            => UInt32Domain;
 
        const long Int64Min = -250000;
        
        const long Int64Max = 250000;

        static readonly Interval<long> Int64Domain = closed(Int64Min,Int64Max);

        Interval<long> ISampleDefaults<long>.SampleDomain 
            => Int64Domain;

        const ulong UInt64Min = 0;
        
        const ulong UInt64Max = 500000;

        static readonly Interval<ulong> UInt64Domaim = closed(UInt64Min,UInt64Max);

        Interval<ulong> ISampleDefaults<ulong>.SampleDomain 
            => UInt64Domaim;

        const float Float32Min = -250000.00f;
        
        const float Float32Max = 250000.00f;

        static readonly Interval<float> Float32Domain = closed(Float32Min,Float32Max);

        Interval<float> ISampleDefaults<float>.SampleDomain 
            => Float32Domain;

        const double Float64Min = -250000.00;
        
        const double Float64Max = 250000.00;

        static readonly Interval<double> Float64Domain = closed(Float64Min,Float64Max);

        Interval<double> ISampleDefaults<double>.SampleDomain 
            => Float64Domain;

        const decimal DecimalMin = -250000.00m;
        
        const decimal DecimalMax = 250000.00m;

        static readonly Interval<decimal> DecimalDomain = closed(DecimalMin,DecimalMax);

        Interval<decimal> ISampleDefaults<decimal>.SampleDomain 
            => DecimalDomain;

        static readonly BigInteger BigIntMin = -250000;
        
        static readonly BigInteger BigIntMax = 250000;

        static readonly Interval<BigInteger> BigIntRange = closed(BigIntMin,BigIntMax);

        Interval<BigInteger> ISampleDefaults<BigInteger>.SampleDomain 
            => BigIntRange;

    }
}