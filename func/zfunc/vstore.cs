//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;    
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.Intrinsics.X86.Sse;
using static System.Runtime.Intrinsics.X86.Sse2;
using static System.Runtime.Intrinsics.X86.Avx;

using static zfunc;
using static Z0.As;
using static Z0.AsIn;
using Z0;

partial class zfunc
{
    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<sbyte> src, ref sbyte dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<byte> src, ref byte dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<short> src, ref short dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<ushort> src, ref ushort dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<int> src, ref int dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<uint> src, ref uint dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<long> src, ref long dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<ulong> src, ref ulong dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<float> src, ref float dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector128<double> src, ref double dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<sbyte> src, ref sbyte dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<byte> src, ref byte dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<short> src, ref short dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<ushort> src, ref ushort dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<int> src, ref int dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<uint> src, ref uint dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<long> src, ref long dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<ulong> src, ref ulong dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<float> src, ref float dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vector256<double> src, ref double dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<sbyte> src, ref sbyte dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<byte> src, ref byte dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<short> src, ref short dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<ushort> src, ref ushort dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<int> src, ref int dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<uint> src, ref uint dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<long> src, ref long dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<ulong> src, ref ulong dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<float> src, ref float dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec128<double> src, ref double dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<sbyte> src, ref sbyte dst)
        => Store(refptr(ref dst), src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<byte> src, ref byte dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<short> src, ref short dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<ushort> src, ref ushort dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<int> src, ref int dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<uint> src, ref uint dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<long> src, ref long dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_si256 (__m256i * mem_addr, __m256i a) MOVDQU m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<ulong> src, ref ulong dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_ps (float * mem_addr, __m256 a) MOVUPS m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<float> src, ref float dst)
        => Store(refptr(ref dst),src);            

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    ///<intrinsic>void _mm256_storeu_pd (double * mem_addr, __m256d a) MOVUPD m256, ymm</intrinsic>
    [MethodImpl(Inline)]
    static unsafe void vstore(Vec256<double> src, ref double dst)
        => Store(refptr(ref dst),src);                


    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    public static void vstore<T>(Vec128<T> src, ref T dst)
        where T : struct
    {            
        if(typeof(T) == typeof(sbyte))
            vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(byte))
            vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(short))
            vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(ushort))
            vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(int))
            vstore(int32(src), ref int32(ref dst));
        else if(typeof(T) == typeof(uint))
            vstore(uint32(src), ref uint32(ref dst));
        else if(typeof(T) == typeof(long))
            vstore(int64(src), ref int64(ref dst));
        else if(typeof(T) == typeof(ulong))
            vstore(uint64(src), ref uint64(ref dst));
        else if(typeof(T) == typeof(float))
            vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            vstore(float64(src), ref float64(ref dst));
        else
            throw unsupported<T>();
    }       

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    public static void vstore<T>(Vector128<T> src, ref T dst)
        where T : struct
    {            
        if(typeof(T) == typeof(sbyte))
            vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(byte))
            vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(short))
            vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(ushort))
            vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(int))
            vstore(int32(src), ref int32(ref dst));
        else if(typeof(T) == typeof(uint))
            vstore(uint32(src), ref uint32(ref dst));
        else if(typeof(T) == typeof(long))
            vstore(int64(src), ref int64(ref dst));
        else if(typeof(T) == typeof(ulong))
            vstore(uint64(src), ref uint64(ref dst));
        else if(typeof(T) == typeof(float))
            vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            vstore(float64(src), ref float64(ref dst));
        else
            throw unsupported<T>();
    }       


    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    public static void vstore<T>(Vec256<T> src, ref T dst)
        where T : struct
    {            
        if(typeof(T) == typeof(sbyte))
            vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(byte))
            vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(short))
            vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(ushort))
            vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(int))
            vstore(int32(src), ref int32(ref dst));
        else if(typeof(T) == typeof(uint))
            vstore(uint32(src), ref uint32(ref dst));
        else if(typeof(T) == typeof(long))
            vstore(int64(src), ref int64(ref dst));
        else if(typeof(T) == typeof(ulong))
            vstore(uint64(src), ref uint64(ref dst));
        else if(typeof(T) == typeof(float))
            vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            vstore(float64(src), ref float64(ref dst));
        else
            throw unsupported<T>();
    }        

    /// <summary>
    /// Stores vector content to a memory location
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="dst">The target memory</param>
    [MethodImpl(Inline)]
    public static void vstore<T>(Vector256<T> src, ref T dst)
        where T : struct
    {            
        if(typeof(T) == typeof(sbyte))
            vstore(int8(src), ref int8(ref dst));
        else if(typeof(T) == typeof(byte))
            vstore(uint8(src), ref uint8(ref dst));
        else if(typeof(T) == typeof(short))
            vstore(int16(src), ref int16(ref dst));
        else if(typeof(T) == typeof(ushort))
            vstore(uint16(src), ref uint16(ref dst));
        else if(typeof(T) == typeof(int))
            vstore(int32(src), ref int32(ref dst));
        else if(typeof(T) == typeof(uint))
            vstore(uint32(src), ref uint32(ref dst));
        else if(typeof(T) == typeof(long))
            vstore(int64(src), ref int64(ref dst));
        else if(typeof(T) == typeof(ulong))
            vstore(uint64(src), ref uint64(ref dst));
        else if(typeof(T) == typeof(float))
            vstore(float32(src), ref float32(ref dst));
        else if(typeof(T) == typeof(double))
            vstore(float64(src), ref float64(ref dst));
        else
            throw unsupported<T>();
    }        

}


