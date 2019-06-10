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
    
    using static zfunc;    
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte exp(sbyte src)
            => (sbyte)MathF.Exp(src);

        [MethodImpl(Inline)]
        public static byte exp(byte src)
            => (byte)MathF.Exp(src);

        [MethodImpl(Inline)]
        public static short exp(short src)
            => (short)MathF.Exp(src);

        [MethodImpl(Inline)]
        public static ushort exp(ushort src)
            => (ushort)MathF.Exp(src);

        [MethodImpl(Inline)]
        public static int exp(int src)
            => (int)MathF.Exp(src);

        [MethodImpl(Inline)]
        public static uint exp(uint src)
            => (uint)MathF.Exp(src);

        [MethodImpl(Inline)]
        public static long exp(long src)
            => (long)Math.Exp(src);

        [MethodImpl(Inline)]
        public static ulong exp(ulong src)
            => (ulong)Math.Exp(src);

        [MethodImpl(Inline)]
        public static float exp(float src)
            => MathF.Exp(src);

        [MethodImpl(Inline)]
        public static double exp(double src)
            => Math.Exp(src);

    }

}