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
    
    
    using static zfunc;

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte parse(string src, out sbyte dst)
            => dst = sbyte.Parse(src);

        [MethodImpl(Inline)]
        public static byte parse(string src, out byte dst)
            => dst = byte.Parse(src);

        [MethodImpl(Inline)]
        public static short parse(string src, out short dst)
            => dst = short.Parse(src);

        [MethodImpl(Inline)]
        public static ushort parse(string src, out ushort dst)
            => dst = ushort.Parse(src);

        [MethodImpl(Inline)]
        public static int parse(string src, out int dst)
            => dst = int.Parse(src);

        [MethodImpl(Inline)]
        public static uint parse(string src, out uint dst)
            => dst = uint.Parse(src);

        [MethodImpl(Inline)]
        public static long parse(string src, out long dst)
            => dst = long.Parse(src);

        [MethodImpl(Inline)]
        public static ulong parse(string src, out ulong dst)
            => dst = ulong.Parse(src);

        [MethodImpl(Inline)]
        public static float parse(string src, out float dst)
            => dst = float.Parse(src);

        [MethodImpl(Inline)]
        public static double parse(string src, out double dst)
            => dst = double.Parse(src);

        [MethodImpl(Inline)]
        public static decimal parse(string src, out decimal dst)
            => dst = decimal.Parse(src);

        [MethodImpl(Inline)]
        public static BigInteger parse(string src, out BigInteger dst)
            => dst = BigInteger.Parse(src);

   
    }    
}