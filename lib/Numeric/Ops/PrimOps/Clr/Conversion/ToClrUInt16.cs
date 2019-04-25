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
    
    using target = System.UInt16;
    using stream = System.Collections.Generic.IEnumerable<ushort>;
    using targets = Index<ushort>;
    
    partial class ClrConverters
    {        
        public readonly struct ToClrUInt16 : 
            Conversion<sbyte, target>, 
            Conversion<byte, target>, 
            Conversion<short, target>, 
            Conversion<ushort, target>, 
            Conversion<int, target>, 
            Conversion<uint, target>, 
            Conversion<long, target>, 
            Conversion<ulong, target>,
            Conversion<float, target>, 
            Conversion<double, target>, 
            Conversion<decimal, target>,
            Conversion<BigInteger, target>
        {
            public static readonly ToClrUInt16 Inhabitant = default;

            public static readonly Type TargetType = typeof(target);

            [MethodImpl(Inline)]
            public target convert(byte src)
                => src;

            [MethodImpl(Inline)]
            public target convert(byte src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(sbyte src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(sbyte src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(short src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(short src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(ushort src)
                => src;

            [MethodImpl(Inline)]
            public target convert(ushort src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(int src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(int src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(uint src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(uint src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(long src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(long src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(ulong src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(ulong src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(float src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(float src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(double src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(double src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(decimal src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(decimal src, out target dst)
                => dst = (target)src;

            [MethodImpl(Inline)]
            public target convert(BigInteger src)
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(BigInteger src, out target dst)
                => dst = (target)src;
        }

    }

    partial class xcore
    {
        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<byte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<sbyte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<short> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<ushort> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<int> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<uint> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<long> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<ulong> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<float> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<double> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<decimal> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt16(this Index<BigInteger> src)
            => map(src,x => (target)x);



        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<byte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<sbyte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<short> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<ushort> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<int> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<uint> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<long> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<float> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<double> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<decimal> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt16(this IEnumerable<BigInteger> src)
            => map(src,x => (target)x);

    }
}