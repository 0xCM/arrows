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

    
    using static zfunc;
    using static mfunc;

    using target = System.Single;
    using stream = System.Collections.Generic.IEnumerable<float>;

    partial class ClrConverters
    {        
        public readonly struct ToClrFloat32 : 
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
            public static readonly ToClrFloat32 Inhabitant = default;

            public static readonly Type TargetType = typeof(target);

            [MethodImpl(Inline)]
            public target convert(byte src)
                => src;

            [MethodImpl(Inline)]
            public target convert(byte src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(sbyte src)
                => src;

            [MethodImpl(Inline)]
            public target convert(sbyte src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(short src)
                => src;

            [MethodImpl(Inline)]
            public target convert(short src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(ushort src)
                => src;

            [MethodImpl(Inline)]
            public target convert(ushort src, out target dst)
                => dst = src;


            [MethodImpl(Inline)]
            public target convert(int src)
                => src;

            [MethodImpl(Inline)]
            public target convert(int src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(uint src)
                => src;

            [MethodImpl(Inline)]
            public target convert(uint src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(long src)
                => src;

            [MethodImpl(Inline)]
            public target convert(long src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(ulong src)
                => src;

            [MethodImpl(Inline)]
            public target convert(ulong src, out target dst)
                => dst = src;

            [MethodImpl(Inline)]
            public target convert(float src)
                => src;

            [MethodImpl(Inline)]
            public target convert(float src, out target dst)
                => dst = src;

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

    public static class ToFloatX
    {
        [MethodImpl(Inline)]
        public static float[] ToFloat(this byte[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this sbyte[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this short[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this ushort[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this int[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this uint[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this long[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this float[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this double[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this decimal[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static float[] ToFloat(this BigInteger[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<byte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<sbyte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<short> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<ushort> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<int> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<uint> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<long> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<float> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<double> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<decimal> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToFloat(this IEnumerable<BigInteger> src)
            => map(src,x => (target)x);

    }    
}