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

    using target = System.Byte;
    using stream = System.Collections.Generic.IEnumerable<byte>;
    using targets = Index<byte>;


    partial class ClrConverters
    {        
        public readonly struct ToClrUInt8 : 
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
            public static readonly ToClrUInt8 Inhabitant = default;

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
                => (target)src;

            [MethodImpl(Inline)]
            public target convert(ushort src, out target dst)
                => dst = (target)src;

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
        public static targets ToUInt8(this Index<byte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<sbyte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<short> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<ushort> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<int> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<uint> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<long> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<ulong> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<float> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<double> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<decimal> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static targets ToUInt8(this Index<BigInteger> src)
            => map(src,x => (target)x);



        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<byte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<sbyte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<short> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<ushort> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<int> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<uint> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<long> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<float> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<double> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<decimal> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToUInt8(this IEnumerable<BigInteger> src)
            => map(src,x => (target)x);

    }    
}