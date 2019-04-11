//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using static zcore;

    public static class Defaults
    {
        public const int Reps = 1;

        public const uint SampleSize = Pow2.T20;

        public const uint BigVector = Pow2.T20;
        
        public const long Int64Min = -250000;
        
        public const long Int64Max = 250000;

        public static readonly Interval<long> Int64Range = Interval.closed(Int64Min,Int64Max);

        public const ulong UInt64Min = 0;
        
        public const ulong UInt64Max = 500000;

        public static readonly Interval<ulong> UInt64Range = Interval.closed(UInt64Min,UInt64Max);

        public const int Int32Min = -250000;
        
        public const int Int32Max = 250000;

        public static readonly Interval<int> Int32Range = Interval.closed(Int32Min,Int32Max);

        public const uint UInt32Min = 0;
        
        public const uint UInt32Max = 500000;

        public static readonly Interval<uint> UInt32Range = Interval.closed(UInt32Min,UInt32Max);

        public const short Int16Min = -500;
        
        public const short Int16Max = 500;

        public static readonly Interval<short> Int16Range = Interval.closed(Int16Min,Int16Max);

        public const double Float64Min = -250000.00;
        
        public const double Float64Max = 250000.00;

        public static readonly Interval<double> Float64Range = Interval.closed(Float64Min,Float64Max);

    }


}