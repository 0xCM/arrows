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
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.sub(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<T> sub<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                gmath.sub(ref lhs[i], rhs[i]);
            return lhs;
        }
        
        /// <summary>
        /// Subracts a common value from each element in the left operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal element type</typeparam>
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, T rhs)
            where T : struct
        {
            Span<T> dst = new T[lhs.Length];
            dst.Fill(rhs);   
            sub(lhs, dst, dst);
            return dst;
        }


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
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                gfp.mod(ref lhs[i], rhs[i]);
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
        public static Span<T> fmod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gfp.mod(lhs[i], rhs[i]);
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
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.mul(lhs[i], rhs[i]);
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
        public static Span<T> fdiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                gfp.div(ref lhs[i], rhs[i]);
            return lhs;
        }


        public static Span<T> idiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.div(lhs[i], rhs[i]);
            return dst;
        }

        /// <summary>
        /// Computes integer division between cells in the left and right operands,
        /// overwriting the left operand cell with the result, i.e., lhs[i] = lhs[i] / rhs[i]
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        public static Span<T> idiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                gmath.div(ref lhs[i], rhs[i]);
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
        public static Span<T> fdiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gfp.div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<T> mod<T>(Span<T> lhs, T rhs)
            where T : struct
        {
            for(var i=0; i<lhs.Length; i++)
                gmath.mod(ref lhs[i],rhs);
            return lhs;
        }

        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                dst[i] = gmath.mod(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, T rhs, Span<T> dst)
            where T : struct
        {
            var len = length(lhs,dst);
            for(var i=0; i<len; i++)
                dst[i] = gmath.mod(lhs[i],rhs);
            return dst;
        }

        public static Span<T> mod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                gmath.mod(ref lhs[i],rhs[i]);
            return lhs;
        }

        public static Span<T> mul<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                gmath.mul(ref lhs[i],rhs[i]);
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

 
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.dec(src[i]);
            return dst;
        }        

        public static Span<T> dec<T>(Span<T> src)
            where T : struct
        {
            for(var i = 0; i< src.Length; i++)
                gmath.dec(ref src[i]);
            return src;
        }       

        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => neq(lhs,rhs,span<bool>(length(lhs,rhs)));

        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.neq(lhs[i], rhs[i]);
            return dst;
       }


        /// <summary>
        /// Applies the negate operator to each source element in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static Span<T> negate<T>(Span<T> src)
            where T : struct
        {
            for(var i = 0; i< src.Length; i++)
                gmath.negate(ref src[i]);
            return src;
        }

        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => gteq(lhs,rhs,span<bool>(length(lhs,rhs)));


        /// <summary>
        /// Increments each value in the source in-place
        /// </summary>
        /// <param name="src">The source values</param>
        public static Span<T> inc<T>(Span<T> src)
            where T : struct
        {
            for(var i = 0; i< src.Length; i++)
                gmath.inc(ref src[i]);
            return src;
        }

        public static Span<T> pow<T>(Span<T> b, ReadOnlySpan<uint> exp)
            where T : unmanaged
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = gmath.ipow(b[i], exp[i]);
            return b;
        }

        public static Span<T> pow<T>(Span<T> b, uint exp)
            where T : unmanaged
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = gmath.ipow(b[i], exp);
            return b;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i=0; i< len; i++)
                dst[i] = gmath.gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => gt(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => lteq(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => eq(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {

            if(src.IsEmpty)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(gmath.gt(src[i], result))
                    result = src[i];
            
            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(Span<T> src)
            where T : unmanaged
                => max(src.ReadOnly());

        [MethodImpl(Inline)]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T :  struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.sum(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.sum(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.sum(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sum(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.sum(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sum(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.sum(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.sum(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.sum(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.sum(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T sum<T>(Span<T> src)
            where T :  struct
                => sum(src.ReadOnly());


        public static T min<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.min(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.min(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.min(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.min(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.min(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.min(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.min(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.min(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.min(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.min(float64(src)));
            else
                throw unsupported<T>();
            
        }

        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                dst[i] = gmath.or(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                lhs[i] = gmath.or(lhs[i], rhs[i]);
            return lhs;
        }

        public static Span<T> or<T>(Span<T> lhs, in T rhs)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                lhs[i] = gmath.or(lhs[i], rhs);
            return lhs;
        }

        public static Span<T> or<T>(ReadOnlySpan<T> lhs, in T rhs, Span<T> dst)
            where T : unmanaged
        {
            lhs.CopyTo(dst);
            return or(dst,rhs);
        }

        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< length(lhs,rhs); i++)
                dst[i] = gmath.xor(lhs[i], rhs[i]);
           return dst;        
        }

        public static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            for(var i=0; i< length(lhs,rhs); i++)
                gmath.xor(ref lhs[i], rhs[i]);
           return lhs;
        }

        public static Span<T> xor<T>(Span<T> lhs, T rhs)
            where T : unmanaged
        {
            for(var i=0; i< lhs.Length; i++)
                gmath.xor(ref lhs[i],rhs);
            return lhs;
        }

        public static Span<T> flip<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                gmath.flip(ref src[i]);
            return src;
        }

        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                dst[i] = gmath.flip(src[i]);
            return dst;            
        }

        /// <summary>
        /// Computes in-place the quotient of each source element in the left operand and the right operand
        /// </summary>
        /// <param name="src"></param>
        /// <param name="rhs"></param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fdiv<T>(Span<T> src, T rhs)
            where T : struct
        {
            for(var i = 0; i< src.Length; i++)
                gfp.div(ref src[i], rhs);
            return src;
        }

        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : struct
        {            
            static Span<float> round32(ReadOnlySpan<float> src, int scale, Span<float> dst)
            {
                var len = length(src, dst);
                for(var i = 0; i< len; i++)
                    dst[i] = fmath.round(src[i], scale);
                return dst;
            }

            static Span<double> round64(ReadOnlySpan<double> src, int scale, Span<double> dst)
            {
                var len = length(src, dst);
                for(var i = 0; i< len; i++)
                    dst[i] = fmath.round(src[i], scale);
                return dst;
            }            
            
            if(typeof(T) == typeof(float))
                round32(float32(src), scale, float32(dst));
            else if(typeof(T) == typeof(double))
                round64(float64(src), scale, float64(dst));
            else
                return src.Replicate();
            return dst;
        }

        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale)
            where T : struct
                => round(src, scale, span<T>(src.Length));

        public static Span<T> round<T>(Span<T> io, int scale)
            where T : struct
        {
         
            static void round32(Span<float> io, int scale)
            {
                for(var i = 0; i< io.Length; i++)
                    fmath.round(ref io[i], scale);
            }

            static void round64(Span<double> io, int scale)
            {
                for(var i = 0; i< io.Length; i++)
                    fmath.round(ref io[i], scale);
            }
         
            if(typeof(T) == typeof(float))
                round32(float32(io), scale);
            else if(typeof(T) == typeof(double))
                round64(float64(io), scale);
            return io;        
        }


        [MethodImpl(Inline)]
        public static Span<T> sqrt<T>(Span<T> src)
            where T : struct
        {
            for(var i=0; i< src.Length; i++)
                gfp.sqrt(ref src[i]);
            return src;
        }

    }
}