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
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static byte avgz(byte lhs, byte rhs)
            => (byte)((lhs & rhs) + ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ushort avgz(ushort lhs, ushort rhs)
            => (ushort)((lhs & rhs) + ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static uint avgz(uint lhs, uint rhs)
            => (lhs & rhs) + ((lhs ^ rhs) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ulong avgz(ulong lhs, ulong rhs)
            => (lhs & rhs) + ((lhs ^ rhs) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward zero and
        /// ovwriting the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref byte avgz(ref byte lhs, in byte rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero and ovwriting the 
        /// first operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ushort avgz(ref ushort lhs, in ushort rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero and ovwriting the 
        /// first operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref uint avgz(ref uint lhs, in uint rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes average of the operands, rounding toward zero and ovwriting the 
        /// first operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ulong avgz(ref ulong lhs, in ulong rhs)
        {
            lhs = avgz(lhs,rhs);
            return ref lhs;
        }

        public static Span<byte> avgz(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)        
        {
            Span<byte> dst = new byte[length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = avgz(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<byte> avgi(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)        
        {
            Span<byte> dst = new byte[length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = avgi(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<ushort> avgi(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)        
        {
            Span<ushort> dst = new ushort[length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = avgi(lhs[i],rhs[i]);
            return dst;
        }

        public static ulong avgz(ReadOnlySpan<ulong> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i=1; i<src.Length; i++)
                avgz(ref result, in src[i]);
            return result;
        }

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static byte avgi(byte lhs, byte rhs)
            => (byte)((lhs | rhs) - ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ushort avgi(ushort lhs, ushort rhs)
            => (ushort)((lhs | rhs) - ((lhs ^ rhs) >> 1));

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static uint avgi(uint lhs, uint rhs)
            => (lhs | rhs) - ((lhs ^ rhs) >> 1);

        /// <summary>
        /// Takes the average of the operands, rounding toward infinity
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <remarks>Algorithm adapted from Arndt, Matters Computational</remarks>
        [MethodImpl(Inline)]
        public static ulong avgi(ulong lhs, ulong rhs)
            => (lhs | rhs) - ((lhs ^ rhs) >> 1);

        public static sbyte avg(ReadOnlySpan<sbyte> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        public static byte avg(ReadOnlySpan<byte> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        public static short avg(ReadOnlySpan<short> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        public static ushort avg(ReadOnlySpan<ushort> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                     sum += src[i];

                return (ushort)(sum/(ulong)src.Length);
            }
        }
   
        public static int avg(ReadOnlySpan<int> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }
   
        public static uint avg(ReadOnlySpan<uint> src)
        {
            checked 
            {
                var sum = default(ulong);
                
                for(var i=0; i<src.Length; i++)
                    checked{ sum += src[i];}
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        public static long avg(ReadOnlySpan<long> src)
        {
            checked
            {
                var sum = default(long);

                for(var i=0; i<src.Length; i++)
                    sum += src[i]; 

                return sum/src.Length;
            }
        }

        public static ulong avg(ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/(ulong)src.Length;
            }
        }

        public static float avg(ReadOnlySpan<float> src)
        {
            checked
            {
                var sum = default(double);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (float)(sum/(float)src.Length);
            }
        }

        public static double avg(ReadOnlySpan<double> src)
        {
            checked
            {
                var sum = default(double);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return sum/(double)src.Length;
            }
        }
    }
}