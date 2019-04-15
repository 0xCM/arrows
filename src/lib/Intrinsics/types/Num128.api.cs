//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static x86;

    public static class Num128
    {
       [MethodImpl(Inline)]
        public static unsafe Num128<T> define<T>(T value)
            where T : struct, IEquatable<T>
        {
            void* scalar = typecode<T>() switch 
            {
                TypeCode.SByte => i8num(value, 16),
                TypeCode.Byte => u8num(value, 16),
                TypeCode.Int16 => i16num(value, 8),
                TypeCode.UInt16 => u16num(value, 8),
                TypeCode.Int32 => i32num(value, 4),
                TypeCode.UInt32 => u32num(value, 4),
                TypeCode.Int64 => i64num(value, 2),
                TypeCode.UInt64 => u64num(value, 2),
                TypeCode.Single => f32num(value, 4),
                TypeCode.Double => f64num(value, 2),
                _ => throw new NotSupportedException()
            };        

            return castref<Vector128<T>>(scalar);                    
         }

        /// <summary>
        /// Presents a vectorized mutable view over an array element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe Num128<long> load(long[] src, int pos)
        {
            fixed (long* psrc = &src[pos])
                return Avx2.LoadScalarVector128(psrc);
        }


        /// <summary>
        /// Presents a vectorized mutable view over an array element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe Num128<ulong> load(ulong[] src, int pos)
        {
            fixed (ulong* psrc = &src[pos])
                return Avx2.LoadScalarVector128(psrc);
        }

        /// <summary>
        /// Presents a vectorized mutable view over an array element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe Num128<float> load(float[] src, int pos)
        {
            fixed (float* psrc = &src[pos])
                return Avx2.LoadScalarVector128(psrc);
        }

        /// <summary>
        /// Presents a vectorized mutable view over an array element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe Num128<double> load(double[] src, int pos)
        {
            fixed (double* psrc = &src[pos])
                return Avx2.LoadScalarVector128(psrc);
        }



        /// <summary>
        /// Writes a scalar value to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe float[] store(Num128<float> src, float[] dst, int startpos)
        {
            fixed (float* pdst = &dst[startpos])
            {                
                Avx2.StoreScalar(pdst,src);
                return dst;
            }                
        }


        /// <summary>
        /// Writes a scalar value to an array segment
        /// </summary>
        /// <param name="src">The soruce vector</param>
        /// <param name="dst">The target array</param>
        /// <param name="startpos">The array index of the first element</param>
        [MethodImpl(Inline)]
        public static unsafe double[] store(Num128<double> src, double[] dst, int startpos)
        {
            fixed (double* pdst = &dst[startpos])
            {                
                Avx2.StoreScalar(pdst,src);
                return dst;
            }                
        }



    }

}