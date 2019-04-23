//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using static zcore;
    using static Operative;
    
    using Target = System.Double;
    using TargetStream = System.Collections.Generic.IEnumerable<double>;
    using TargetList = System.Collections.Generic.IReadOnlyList<double>;

    partial class ClrConverters
    {        
        public readonly struct ToClrFloat64 : 
            Conversion<sbyte, Target>, 
            Conversion<byte, Target>, 
            Conversion<short, Target>, 
            Conversion<ushort, Target>, 
            Conversion<int, Target>, 
            Conversion<uint, Target>, 
            Conversion<long, Target>, 
            Conversion<ulong, Target>,
            Conversion<float, Target>, 
            Conversion<double, Target>, 
            Conversion<decimal, Target>,
            Conversion<BigInteger, Target>
        {
            public static readonly ToClrFloat64 Inhabitant = default;

            public static readonly Type TargetType = typeof(Target);

            [MethodImpl(Inline)]
            public Target convert(byte src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(byte src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(short src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(short src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(ushort src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(ushort src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(int src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(int src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(uint src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(uint src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(long src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(long src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(ulong src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(ulong src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(float src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(float src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(double src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(double src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(decimal src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(decimal src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(BigInteger src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(BigInteger src, out Target dst)
                => dst = (Target)src;
        }

    }

    partial class xcore
    {
        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<sbyte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<byte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<short> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<ushort> src)
            => map(src,x => (Target)x);


        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<int> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<uint> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<long> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<ulong> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<float> src)
            => map(src,x => (Target)x);


        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<decimal> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToDouble(this IReadOnlyList<BigInteger> src)
            => map(src,x => (Target)x);
 
 
         [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<sbyte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<byte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<short> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<ushort> src)
            => map(src,x => (Target)x);


        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<int> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<uint> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<long> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<ulong> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<float> src)
            => map(src,x => (Target)x);


        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<decimal> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToDouble(this IEnumerable<BigInteger> src)
            => map(src,x => (Target)x);
 
    }    

}