//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;

    public static class Defaults
    {
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

    }

    public static class Context
    {
        static readonly Guid s1 = Guid.Parse("ca3d0da1-271a-4c97-8d4b-062796bc2450");
        
        static readonly Guid s2 = Guid.Parse("83861b3a-8012-4edf-aaee-c7d7136117cf");
        
        public static readonly Randomizer Random = new Randomizer(s1,s2);

        public static Context<T> get<T>()
            => Context<T>.Current;
    }

    public class Context<T>
    {
        public static readonly Context<T> Current = new Context<T>();

        static readonly Guid s1 = Guid.Parse("ca3d0da1-271a-4c97-8d4b-062796bc2450");
        
        static readonly Guid s2 = Guid.Parse("83861b3a-8012-4edf-aaee-c7d7136117cf");
        
        static readonly Randomizer random = new Randomizer(s1,s2);


        public Randomizer Random = random;


    }   
}