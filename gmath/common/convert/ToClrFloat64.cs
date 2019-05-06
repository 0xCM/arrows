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
    using static zfunc;    
    using static mfunc;
    
    using target = System.Double;
    using stream = System.Collections.Generic.IEnumerable<double>;
    
    partial class ClrConverters
    {        
        public readonly struct ToClrFloat64 : 
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
            public static readonly ToClrFloat64 Inhabitant = default;

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
                => src;

            [MethodImpl(Inline)]
            public target convert(double src, out target dst)
                => dst = src;

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

    public static class ToDoubleX
    {
        [MethodImpl(Inline)]
        public static double[] ToDouble(this sbyte[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this byte[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this short[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this ushort[] src)
            => map(src,x => (target)x);


        [MethodImpl(Inline)]
        public static double[] ToDouble(this int[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this uint[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this long[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this ulong[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this float[] src)
            => map(src,x => (target)x);


        [MethodImpl(Inline)]
        public static double[] ToDouble(this decimal[] src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static double[] ToDouble(this BigInteger[] src)
            => map(src,x => (target)x);
 
 
        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<sbyte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<byte> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<short> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<ushort> src)
            => map(src,x => (target)x);


        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<int> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<uint> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<long> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<ulong> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<float> src)
            => map(src,x => (target)x);


        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<decimal> src)
            => map(src,x => (target)x);

        [MethodImpl(Inline)]
        public static stream ToDouble(this IEnumerable<BigInteger> src)
            => map(src,x => (target)x);


        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<sbyte> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }
            

        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<byte> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<short> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<int> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<uint> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }


        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<ushort> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<long> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<ulong> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }



        [MethodImpl(Inline)]
        public static Span<double> ToDouble(this Span<float> src)
        {
            var dst = span<double>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;

        }

    }    

}