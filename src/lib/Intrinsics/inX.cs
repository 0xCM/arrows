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

    
    public static partial class inX
    {

        /// <summary>
        /// Raises an error if the destination array is too small to recieve the source data
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The index at which source data may start in the target</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void checkTarget<T>(IReadOnlyList<Vec128<T>> src, T[] dst, int offset)
            where T : struct, IEquatable<T>
        {
            var required = Vec128<T>.Length * src.Count;                
            if(required > dst.Length - offset)
                throw new Exception($"Array of length {dst.Length} too small;" 
                            + $" An array of length {required} is required to receive {src.Count} vectors");
        }

        [MethodImpl(Inline)]
        public static unsafe byte* copy<T>(IReadOnlyList<T> src, byte* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (byte)(object)(src[i]);                            
        
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe sbyte* copy<T>(IReadOnlyList<T> src, sbyte* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (sbyte)(object)(src[i]);                            
            
            return dst;
        }        

        [MethodImpl(Inline)]
        public static unsafe short* copy<T>(IReadOnlyList<T> src, short* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (short)(object)(src[i]);     

            return dst;                       
        }

        [MethodImpl(Inline)]
        public static unsafe ushort* copy<T>(IReadOnlyList<T> src, ushort* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (ushort)(object)(src[i]);                            

            return dst;                
        }

        [MethodImpl(Inline)]
        public static unsafe int* copy<T>(IReadOnlyList<T> src, int* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (int)(object)(src[i]);                            

            return dst;                
        }

        [MethodImpl(Inline)]
        public static unsafe uint* copy<T>(IReadOnlyList<T> src, uint* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (uint)(object)(src[i]);                            
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe long* copy<T>(IReadOnlyList<T> src, long* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (long)(object)(src[i]);                            

            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ulong* copy<T>(IReadOnlyList<T> src, ulong* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (ulong)(object)(src[i]);                            
        
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe float* copy<T>(IReadOnlyList<T> src, float* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (float)(object)(src[i]);                            
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe double* copy<T>(IReadOnlyList<T> src, double* dst)
        {
            var p = dst;
            for (var i = 0; i < src.Count; ++i, p++)
                *p = (double)(object)(src[i]);     
            
            return dst;                                       
        }


        static Exception badlen(int datalen, int veclen, int startpos, int maxpos, int finalpos)
            => new Exception($"Length mismatch: length of data source = " 
                + $"{datalen}, veclen = {veclen}, startpos = {startpos}, " 
                + $"maxpos = {maxpos}, finalpos = {finalpos}");


        [MethodImpl(Inline)]
        public static void checklen128<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {
            var maxpos = src.Length - 1;
            var finalpos = offset + Vec128<T>.Length - 1;

            if(finalpos > maxpos)
                throw badlen(src.Length, Vec128<T>.Length, offset, maxpos, finalpos);
        }

        [MethodImpl(Inline)]
        public static void checklen128<T>(IReadOnlyList<T> src, int offset = 0)
            where T : struct, IEquatable<T>
        {
            var maxpos = src.Count - 1;
            var finalpos = offset + Vec128<T>.Length - 1;

            if(finalpos > maxpos)
                throw badlen(src.Count, Vec128<T>.Length, offset, maxpos, finalpos);
        }

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> datasource<T>(object data, int count, int startpos = 0)
            where T : struct, IEquatable<T>
        {
            var src = (IReadOnlyList<T>)data;
            checklen128(src, startpos);
            return src;
        }

        [MethodImpl(Inline)]
        public static Exception segerror<T>(T[] src)
            => new Exception($"The source array of {typename<int>()} values with length {src.Length} is not segmented properly");                


        [MethodImpl(Inline)]
        public static unsafe void* i8num(object value, int count)
        {
            var dst =  stackalloc sbyte[count];
            dst[0] = cast<sbyte>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe sbyte* i8vec(object data, int count)
        {
            var src = datasource<sbyte>(data,count);
            var dst =  stackalloc sbyte[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe byte* u8num(object value, int count)
        {
            var dst =  stackalloc byte[count];
            dst[0] = cast<byte>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe byte* u8vec(object data, int count)
        {
            var src = datasource<byte>(data,count);
            var dst =  stackalloc byte[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe short* i16vec(object data, int count)
        {
            var src = datasource<short>(data,count);
            var dst =  stackalloc short[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe short* i16num(object value, int count)
        {
            var dst =  stackalloc short[count];
            dst[0] = cast<short>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ushort* u16num(object value, int count)
        {
            var dst =  stackalloc ushort[count];
            dst[0] = cast<ushort>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ushort* u16vec(object data, int count)
        {
            var src = datasource<ushort>(data,count);
            var dst =  stackalloc ushort[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe int* i32num(object value, int count)
        {
            var dst =  stackalloc int[count];
            dst[0] = cast<int>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe int* i32vec(object data, int count)
        {
            var src = datasource<int>(data,count);
            var dst =  stackalloc int[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe uint* u32num(object value, int count)
        {
            var dst =  stackalloc uint[count];
            dst[0] = cast<uint>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe uint* u32vec(object data, int count)
        {
            var src = datasource<uint>(data,count);
            var dst =  stackalloc uint[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe long* i64num(object value, int count)
        {
            var dst =  stackalloc long[count];
            dst[0] = cast<long>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe long* i64vec(object data, int count)
        {
            var src = datasource<long>(data,count);
            var dst =  stackalloc long[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe ulong* u64num(object value, int count)
        {
            var dst =  stackalloc ulong[count];
            dst[0] = cast<ulong>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ulong* u64vec(object data, int count)
        {
            var src = datasource<ulong>(data,count);
            var dst =  stackalloc ulong[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe float* f32num(object value, int count)
        {
            var dst =  stackalloc float[count];
            dst[0] = cast<float>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe float* f32vec(object data, int count)
        {
            var src = datasource<float>(data,count);
            var dst =  stackalloc float[count];
            return copy(src,dst);
        }

        [MethodImpl(Inline)]
        public static unsafe double* f64num(object value, int count)
        {
            var dst =  stackalloc double[count];
            dst[0] = cast<double>(value);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe double* f64vec(object data, int count)
        {
            var src = datasource<double>(data,count);
            var dst =  stackalloc double[count];
            return copy(src,dst);
        }
 
    }
}