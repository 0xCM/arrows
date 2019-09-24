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
        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte negate(sbyte src)
            => (sbyte)(- src);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// For example, -3 = -0b00000010 = 0b11111101
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static byte negate(byte src)
            => (byte)(~src + 1);
     
        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short negate(short src)
            => (short)(- src);

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int negate(int src)
            => -src;

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static uint negate(uint src)
            => ~src + 1;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static long negate(long src)
            => -src;

        /// <summary>
        /// Computes the two's complement negation of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static ulong negate(ulong src)
            => ~src + 1;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float negate(float src)
            => -src;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double negate(double src)
            => -src;
 
        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte negate(ref sbyte src)
        {
            src = (sbyte) - src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref byte negate(ref byte src)
        {
            src = negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short negate(ref short src)
        {
            src = (short) - src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ushort negate(ref ushort src)
        {
            src = negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int negate(ref int src)
        {
            src = - src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref uint negate(ref uint src)
        {
            src = negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long negate(ref long src)
        {
            src = - src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ulong negate(ref ulong src)
        {
            src = negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float negate(ref float src)
        {
            src = - src;
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double negate(ref double src)
        {
            src = - src;
            return ref src;
        } 


        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte negate(sbyte src, ref sbyte dst)
        {
            dst = (sbyte) - src;
            return ref dst;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref byte negate(byte src, ref byte dst)
        {
            dst = negate(src);
            return ref dst;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short negate(short src, ref short dst)
        {
            dst = (short) - src;
            return ref dst;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ushort negate(ushort src, ref ushort dst)
        {
            dst = negate(src);
            return ref dst;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int negate(int src, ref int dst)
        {
            dst = - src;
            return ref dst;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref uint negate(uint src, ref uint dst)
        {
            dst = negate(src);
            return ref dst;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long negate(long src, ref long dst)
        {
            dst = - src;
            return ref dst;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ulong negate(ulong src, ref ulong dst)
        {
            dst = negate(src);
            return ref dst;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float negate(float src, ref float dst)
        {
            dst = - src;
            return ref dst;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double negate(double src, ref double dst)
        {
            dst = - src;
            return ref dst;
        } 

   }
}