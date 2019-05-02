//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using X86 = System.Runtime.Intrinsics.X86;
    using NumVec = System.Numerics.Vector;

    using static zcore;

    
    public static class inxfunc
    {
        public static Exception errlen(int datalen, int veclen, int startpos, int maxpos, int finalpos)
            => new Exception($"Length mismatch: length of data source = " 
                + $"{datalen}, veclen = {veclen}, startpos = {startpos}, " 
                + $"maxpos = {maxpos}, finalpos = {finalpos}");

        public static Exception errlen(int dstlen, int required, int count)
            => new Exception($"Array of length {dstlen} too small;" 
                            + $" An array of length {required} is required to receive {count} vectors");

        public static Exception errseglen<T>(T[] src)
            => new Exception($"The source array of {typeof(T)} values with length {src.Length} is not segmented properly");                

        [MethodImpl(Inline)]
        public static T component<T>(Vector128<T> src, int ix)
            where T : struct, IEquatable<T>
                => src.GetElement(ix);

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool isNaN(float src)
            => float.IsNaN(src);

        /// <summary>
        /// Returns true if one of the supplied values is the NaN representative
        /// </summary>
        /// <param name="x0">The first source value</param>
        /// <param name="x1">The second source value</param>
        /// <param name="x2">The third source value</param>
        /// <param name="x3">The fourth source value</param>
        [MethodImpl(Inline)]
        public static bool anyNaN(float x0, float x1, float x2, float x3)
            => isNaN(x0) || isNaN(x1) || isNaN(x2) || isNaN(x3);

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool isNaN(double src)
            => double.IsNaN(src);

        /// <summary>
        /// Returns true if one of the supplied values is the NaN representative
        /// </summary>
        /// <param name="x0">The first source value</param>
        /// <param name="x1">The second source value</param>
        [MethodImpl(Inline)]
        public static bool anyNan(double x0, double x1)
            => isNaN(x0) || isNaN(x1);


        /// <summary>
        /// Returns true if the value of an identified component the NaN representative
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="ix">The 0-based component index</param>
        [MethodImpl(Inline)]
        public static bool isNaN(Vector128<float> src, int ix)
            => float.IsNaN(src.GetElement(ix));

        /// <summary>
        /// Returns true if any component of the source vector is the NaN representative
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool anyNaN(Vector128<float> src)
            => anyNaN(component(src,0), component(src, 1), component(src,2), component(src,3));

        /// <summary>
        /// Returns true if the value of a component the NaN representative
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline)]
        public static bool isNaN(Vector128<double> src, int index)
            => double.IsNaN(src.GetElement(index));

        /// <summary>
        /// Returns true if any component of the source vector is the NaN representative
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static bool anyNaN(Vector128<double> src)
            => anyNan(component(src,0), component(src, 1));


        /// <summary>
        /// Replaces a NaN representive value with 0
        /// </summary>
        /// <param name="src">The source value to sanitize</param>
        [MethodImpl(Inline)]
        public static double clearNaN(double x, double replacement = -1)
            => isNaN(x) ? replacement : x;


        /// <summary>
        /// Replaces a NaN representive value with 0
        /// </summary>
        /// <param name="src">The source value to sanitize</param>
        [MethodImpl(Inline)]
        public static float clearNaN(float x, float replacement = -1)
            => isNaN(x) ? replacement : x;

        /// <summary>
        /// Replaces an identified NaN component with a specified value
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vector128<float> clearNaN(Vector128<float> src, int ix, float replacement = -1)
            => src.WithElement(ix,clearNaN(src.GetElement(ix), replacement));

        /// <summary>
        /// Replaces any NaN components with a specified value
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vector128<float> clearNaN(Vector128<float> src, float replacement = -1)
        {
            var lolo = clearNaN(src.GetElement(0), replacement);
            var lohi = clearNaN(src.GetElement(1), replacement);
            var hilo = clearNaN(src.GetElement(2), replacement);
            var hihi = clearNaN(src.GetElement(3), replacement);
            return Vector128.Create(lolo,lohi,hilo,hihi);
        }

        /// <summary>
        /// Replaces an identified NaN component with a specified value
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vector128<double> clearNaN(Vector128<double> src, int ix, double replacement = -1)
            => src.WithElement(ix,clearNaN(src.GetElement(ix), replacement));

        /// <summary>
        /// Replaces any NaN components with -1
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vec128<double> clearNaN(Vector128<double> src, double replacement = -1)
        {
            var lo = clearNaN(src.GetElement(0),replacement);
            var hi = clearNaN(src.GetElement(1),replacement);
            return Vector128.Create(lo,hi);
        }


        /// <summary>
        /// Replaces any NaN components with -1
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vec256<double> clearNaN(Vector256<double> src, double replacement = -1)
        {
            var x0 = clearNaN(src.GetElement(0),replacement);
            var x1 = clearNaN(src.GetElement(1),replacement);
            var x2 = clearNaN(src.GetElement(2),replacement);
            var x3 = clearNaN(src.GetElement(3),replacement);
            return Vector256.Create(x0,x1,x2,x3);
        }


        /// <summary>
        /// Replaces any NaN components with -1
        /// </summary>
        /// <param name="src">The source vector to sanitize</param>
        [MethodImpl(Inline)]
        public static Vec256<float> clearNaN(Vector256<float> src, float replacement = -1)
        {
            var x0 = clearNaN(src.GetElement(0),replacement);
            var x1 = clearNaN(src.GetElement(1),replacement);
            var x2 = clearNaN(src.GetElement(2),replacement);
            var x3 = clearNaN(src.GetElement(3),replacement);
            var x4 = clearNaN(src.GetElement(4),replacement);
            var x5 = clearNaN(src.GetElement(5),replacement);
            var x6 = clearNaN(src.GetElement(6),replacement);
            var x7 = clearNaN(src.GetElement(7),replacement);
            return Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);
        }

        /// <summary>
        /// Raises an error if the destination array is too small to recieve the source data
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The index at which source data may start in the target</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void checkTarget<T>(Vec128<T>[] src, T[] dst, int offset)
            where T : struct, IEquatable<T>
        {
            var required = Vec128<T>.Length * src.Length;                
            if(required > dst.Length - offset)
                throw errlen(dst.Length, required, src.Length);
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, byte* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (byte)(object)(src[i]);                                    
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, sbyte* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (sbyte)(object)(src[i]);                            
            
            return dst;
        }        

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, short* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (short)(object)(src[i]);     

            return dst;                       
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, ushort* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (ushort)(object)(src[i]);                            

            return dst;                
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, int* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (int)(object)(src[i]);                            

            return dst;                
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, uint* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (uint)(object)(src[i]);                            
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, long* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (long)(object)(src[i]);                            

            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, ulong* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (ulong)(object)(src[i]);                            
        
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, float* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (float)(object)(src[i]);                            
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* copy<T>(T[] src, double* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Length; ++i, p++)
                *p = (double)(object)(src[i]);     
            
            return dst;                                       
        }


        [MethodImpl(Inline)]
        public static void checklen128<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {
            var maxpos = src.Length - 1;
            var finalpos = offset + Vec128<T>.Length - 1;

            if(finalpos > maxpos)
                throw errlen(src.Length, Vec128<T>.Length, offset, maxpos, finalpos);
        }

        [MethodImpl(Inline)]
        public static void checklen256<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {
            var maxpos = src.Length - 1;
            var finalpos = offset + Vector256<T>.Count - 1;

            if(finalpos > maxpos)
                throw errlen(src.Length, Vector256<T>.Count, offset, maxpos, finalpos);
        }


        [MethodImpl(Inline)]
        public static T[] datasource<T>(object data, int count, int startpos = 0)
            where T : struct, IEquatable<T>
        {
            var src = (T[])data;
            checklen128(src, startpos);
            return src;
        }

        [MethodImpl(Inline)]
        public static unsafe void* i8num(object value, int count)
        {
            var dst =  stackalloc sbyte[count];
            dst[0] = As.int8(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* i8vec(object data, int count)
        {
            var src = datasource<sbyte>(data,count);
            var dst =  stackalloc sbyte[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* u8num(object value, int count)
        {
            var dst =  stackalloc byte[count];
            dst[0] = As.uint8(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u8vec(object data, int count)
        {
            var src = datasource<byte>(data,count);
            var dst =  stackalloc byte[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i16vec(object data, int count)
        {
            var src = datasource<short>(data,count);
            var dst =  stackalloc short[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i16num(object value, int count)
        {
            var dst =  stackalloc short[count];
            dst[0] = As.int16(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u16num(object value, int count)
        {
            var dst =  stackalloc ushort[count];
            dst[0] = As.uint16(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u16vec(object data, int count)
        {
            var src = datasource<ushort>(data,count);
            var dst =  stackalloc ushort[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i32num(object value, int count)
        {
            var dst =  stackalloc int[count];
            dst[0] = As.int32(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* i32vec(object data, int count)
        {
            var src = datasource<int>(data,count);
            var dst =  stackalloc int[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* u32num(object value, int count)
        {
            var dst =  stackalloc uint[count];
            dst[0] = As.uint32(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u32vec(object data, int count)
        {
            var src = datasource<uint>(data,count);
            var dst =  stackalloc uint[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* i64num(object value, int count)
        {
            var dst =  stackalloc long[count];
            dst[0] = As.int64(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* i64vec(object data, int count)
        {
            var src = datasource<long>(data,count);
            var dst =  stackalloc long[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* u64num(object value, int count)
        {
            var dst =  stackalloc ulong[count];
            dst[0] = As.uint64(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* u64vec(object data, int count)
        {
            var src = datasource<ulong>(data,count);
            var dst =  stackalloc ulong[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* f32num(object value, int count)
        {
            var dst =  stackalloc float[count];
            dst[0] = As.float32(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* f32vec(object data, int count)
        {
            var src = datasource<float>(data,count);
            var dst =  stackalloc float[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe void* f64num(object value, int count)
        {
            var dst =  stackalloc double[count];
            dst[0] = As.float64(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void* f64vec(object data, int count)
        {
            var src = datasource<double>(data,count);
            var dst =  stackalloc double[count];
            return copy(src,dst);
        }


        [MethodImpl(Inline)]
        public static unsafe ref T castref<T>(void* src)
            => ref Unsafe.AsRef<T>(src);


    }
}