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
        public static sbyte sqrt(sbyte src)
            => (sbyte)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static byte sqrt(byte src)
            => (byte)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static short sqrt(short src)
            => (short)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static ushort sqrt(ushort src)
            => (ushort)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static int sqrt(int src)
            => (int)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static uint sqrt(uint src)
            => (uint)MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static long sqrt(long src)
            => (long)Math.Sqrt(src);

        [MethodImpl(Inline)]
        public static ulong sqrt(ulong src)
            => (ulong)Math.Sqrt(src);

        [MethodImpl(Inline)]
        public static float sqrt(float src)
            => MathF.Sqrt(src);

        [MethodImpl(Inline)]
        public static double sqrt(double src)
            => Math.Sqrt(src); 
 
         [MethodImpl(Inline)]
        public static ref sbyte sqrt(ref sbyte src)
        {
            src = (sbyte)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte sqrt(ref byte src)
        {
            src = (byte)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short sqrt(ref short src)
        {
            src = (short)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort sqrt(ref ushort src)
        {
            src = (ushort)MathF.Sqrt(src);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref int sqrt(ref int src)
        {
            src = (int)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint sqrt(ref uint src)
        {
            src = (uint)MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long sqrt(ref long src)
        {
            src = (long)Math.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong sqrt(ref ulong src)
        {
            src = (ulong)Math.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float sqrt(ref float src)
        {
            src = MathF.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double sqrt(ref double src)
        {
            src = Math.Sqrt(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref sbyte sqrt(sbyte src, out sbyte dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte sqrt(byte src, out byte dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short sqrt(short src, out short dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort sqrt(ushort src, out ushort dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int sqrt(int src, out int dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint sqrt(uint src, out uint dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long sqrt(long src, out long dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong sqrt(ulong src, out ulong dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float sqrt(float src, out float dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double sqrt(double src, out double dst)
        {
            dst = sqrt(ref src);
            return ref dst;
        }
   }
}