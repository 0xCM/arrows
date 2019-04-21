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
    using System.Text;


    using static zcore;
    using static Operative;
    
    using Target = System.UInt64;
    using TargetStream = System.Collections.Generic.IEnumerable<ulong>;
    using TargetList = System.Collections.Generic.IReadOnlyList<ulong>;

    partial class ClrConverters
    {        
        public readonly struct ToClrUInt64 : 
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
            public static readonly ToClrUInt64 Inhabitant = default;

            public static readonly Type TargetType = typeof(Target);

            [MethodImpl(Inline)]
            public Target convert(byte src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(byte src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(sbyte src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(short src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(short src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(ushort src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(ushort src, out Target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public Target convert(int src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(int src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(uint src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(uint src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(long src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(long src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(ulong src)
                => src;

            [MethodImpl(Inline)]
            public Target convert(ulong src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(float src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(float src, out Target dst)
                => dst = (Target)src;

            [MethodImpl(Inline)]
            public Target convert(double src)
                => (Target)src;

            [MethodImpl(Inline)]
            public Target convert(double src, out Target dst)
                => dst = (Target)src;

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
        public static TargetList ToUInt64(this IReadOnlyList<byte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<sbyte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<short> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<ushort> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<int> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<uint> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<long> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<float> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<double> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<decimal> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetList ToUInt64(this IReadOnlyList<BigInteger> src)
            => map(src,x => (Target)x);



        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<byte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<sbyte> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<short> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<ushort> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<int> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<uint> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<long> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<float> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<double> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<decimal> src)
            => map(src,x => (Target)x);

        [MethodImpl(Inline)]
        public static TargetStream ToUInt64(this IEnumerable<BigInteger> src)
            => map(src,x => (Target)x);

    }
}