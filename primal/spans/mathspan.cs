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
        
    using static zfunc;    
    using static As;
    using static AsIn;

    public static partial class mathspan
    {
        
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            for(var i=0; i< length(lhs,rhs); i++)
                dst[i] = gmath.add(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<T> add<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct        
        {
            for(var i=0; i< length(lhs,rhs); i++)
                gmath.add(ref lhs[i],rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Adds a scalar value to each element of the source span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static Span<T> add<T>(Span<T> src, T scalar)
            where T : struct
        {
            for(var i=0; i< src.Length; i++)
                gmath.add(ref src[i],scalar);
            return src;
        }

        public static Span<T> fabs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i=0; i< len; i++)
                dst[i] = gfp.abs(src[i]);
            return dst;
        }

        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i=0; i< len; i++)
                dst[i] = gmath.abs(src[i]);
            return dst;
        }

        /// <summary>
        /// Computes the floating-point modulus of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] ^ rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> fmod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.mod(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                fmath.mod(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        /// <summary>
        /// Computes the floating-point modulus of cells in the left and right operands,
        /// and writes the result in the target operand
        /// Specifically, dst[i] = lhs[i] ^ rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> fmod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.mod(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                fmath.mod(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Span<T> floor<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = gfp.floor(src[i]);
            return dst;
        }

        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : struct
            => floor(src, src.Replicate(true));

        public static Span<T> floor<T>(Span<T> io)
            where T : struct
        {
            for(var i =0; i<io.Length; i++)
                io[i] = gfp.floor(io[i]);
            return  io;
        } 
        
        public static Span<T> ceil<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = gfp.ceil(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> ceil<T>(ReadOnlySpan<T> src)
            where T : struct
            => ceil(src, span<T>(src.Length));

        public static Span<T> ceil<T>(Span<T> io)
            where T : struct
        {
            for(var i =0; i<io.Length; i++)
                io[i] = gfp.ceil(io[i]);
            return io;
        }


         /// <summary>
        /// Multiplies corresponding elements in left/right primal source spans and writes
        /// the result to a caller-supplied target span
        /// </summary>
        /// <param name="lhs">The left primal span</param>
        /// <param name="rhs">The right primal span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Mul(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Mul(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Mul(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Mul(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Mul(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Mul(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Mul(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Mul(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Mul(float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> fdiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.fdiv(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                fmath.fdiv(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }

        public static Span<T> idiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.idiv(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.idiv(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.idiv(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.idiv(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.idiv(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.idiv(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.idiv(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.idiv(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        /// <summary>
        /// Computes integer division between cells in the left and right operands,
        /// overwriting the left operand cell with the result, i.e., lhs[i] = lhs[i] / rhs[i]
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> idiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.idiv(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.idiv(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.idiv(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.idiv(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.idiv(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.idiv(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.idiv(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.idiv(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }


        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// and writes the result in the target operand
        /// Specifically, dst[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> fdiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.fdiv(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                fmath.fdiv(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Span<T> mul<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Mul(int8(rhs));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Mul(uint8(rhs));
            else if(typeof(T) == typeof(short))
                int16(lhs).Mul(int16(rhs));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Mul(uint16(rhs));
            else if(typeof(T) == typeof(int))
                int32(lhs).Mul(int32(rhs));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs));
            else if(typeof(T) == typeof(long))
                int64(lhs).Mul(int64(rhs));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Mul(uint64(rhs));
            else if(typeof(T) == typeof(float))
                float32(lhs).Mul(float32(rhs));
            else if(typeof(T) == typeof(double))
                float64(lhs).Mul(float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }


        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        public static T dot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.dot(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.dot(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.dot(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.dot(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.dot(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.dot(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.dot(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.dot(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(fmath.dot(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.dot(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }

 

    }

}