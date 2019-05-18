//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static mfunc;

    partial class math
    {

       [MethodImpl(Inline)]
        public static sbyte square(sbyte src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static byte square(byte src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static short square(short src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static ushort square(ushort src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static int square(int src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static uint square(uint src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static long square(long src)
            => (long)Math.Sqrt(src);

        [MethodImpl(Inline)]
        public static ulong square(ulong src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static float square(float src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static double square(double src)
            => mul(src,src);
                 
        [MethodImpl(Inline)] 
        public static ref sbyte square(ref sbyte src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte square(ref byte src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short square(ref short src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort square(ref ushort src)
        {
            mul(ref src, src);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref int square(ref int src)
        {
            mul(ref src, src);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref uint square(ref uint src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long square(ref long src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong square(ref ulong src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float square(ref float src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double square(ref double src)
        {
            mul(ref src, src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref sbyte square(sbyte src, out sbyte dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte square(byte src, out byte dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short square(short src, out short dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort square(ushort src, out ushort dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int square(int src, out int dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint square(uint src, out uint dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long square(long src, out long dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong square(ulong src, out ulong dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float square(float src, out float dst)
        {
            dst = square(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double square(double src, out double dst)
        {
            dst = square(ref src);
            return ref dst;
        }
    }
}