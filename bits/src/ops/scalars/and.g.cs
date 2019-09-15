//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {
        /// <summary>
        /// Computes the bitwise AND of two primal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
                => gmath.and(lhs,rhs);

        /// <summary>
        /// Computes the bitwise AND of two primal operands and overwrites
        /// the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, in T rhs)
            where T : struct
               => ref gmath.and(ref lhs, in rhs);

        /// <summary>
        /// Computes the bitwise AND of two primal operands and stores the 
        /// result in a specified target
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T and<T>(in T lhs, in T rhs, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.and(in int8(in lhs), in int8(in rhs), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                 math.and(in uint8(in lhs), in uint8(in rhs), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                 math.and(in int16(in lhs), in int16(in rhs), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                 math.and(in uint16(in lhs), in uint16(in rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                 math.and(in int32(in lhs), in int32(in rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                 math.and(in uint32(in lhs), in uint32(in rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                 math.and(in int64(in lhs), in int64(in rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                 math.and(in uint64(in lhs), in uint64(in rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                 math.and(in float32(in lhs), in float32(in rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                 math.and(in float64(in lhs), in float64(in rhs), ref float64(ref dst));
            else            
                throw unsupported<T>();
            return ref dst;
        }
    

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
                => gmath.flip(src);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// and overwites the operand with the result
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
                => ref gmath.flip(ref src);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// and stores the result in a target operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T flip<T>(in T src, ref T dst)
            where T : struct
                => ref gmath.flip(in src, ref dst);
 
         [MethodImpl(Inline)]
        public static Span<T> and<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return  lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.and(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.and(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return  dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return  lhs;
        }

        /// <summary>
        /// Computes the bitwise AND between arrays of potentially different lengths
        /// </summary>
        /// <param name="lhs">The left cells</param>
        /// <param name="rhs">The right cells</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] and<T>(T[] lhs, T[] rhs)
            where T : unmanaged
        {            
            var dst = new T[math.max(lhs.Length, rhs.Length)];
            var len = math.min(lhs.Length, rhs.Length);
            for(var i=0; i<len; i++)
                and(in lhs[i],in rhs[i], ref dst[i]);
            return dst;
        }


   }    
}