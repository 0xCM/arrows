//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static zfunc;
    using static As;
    using static AsInX;
    
    public static partial class Vec128
    {
        [MethodImpl(Inline)]
        public static ref readonly Vec128<T> Zero<T>() 
            where T : struct
                => ref Vec128<T>.Zero;

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
         [MethodImpl(Inline)]
         public static Vec128<T> Fill<T>(T value)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Vec128.fill(int8(value)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Vec128.fill(uint8(value)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Vec128.fill(int16(value)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Vec128.fill(uint16(value)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Vec128.fill(int32(value)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Vec128.fill(uint32(value)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Vec128.fill(int64(value)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Vec128.fill(uint64(value)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Vec128.fill(float32(value)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Vec128.fill(float64(value)));
            else
                throw unsupported<T>();
        }


        /// <summary>
        /// Produces a vector with each component assigned unit value
        /// </summary>
        /// <typeparam name="T">The component primitive type</typeparam>
        [MethodImpl(Inline)]
         public static ref readonly Vec128<T> Ones<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref generic<T>(in OneI8);
            else if(typeof(T) == typeof(byte))
                return ref generic<T>(in OneU8);
            else if(typeof(T) == typeof(short))
                return ref generic<T>(in OneI16);
            else if(typeof(T) == typeof(ushort))
                return ref generic<T>(in OneU16);
            else if(typeof(T) == typeof(int))
                return ref generic<T>(in OneI32);
            else if(typeof(T) == typeof(uint))
                return ref generic<T>(in OneU32);
            else if(typeof(T) == typeof(long))
                return ref generic<T>(in OneI64);
            else if(typeof(T) == typeof(ulong))
                return ref generic<T>(in OneU64);
            else if(typeof(T) == typeof(float))
                return ref generic<T>(in OneF32);
            else if(typeof(T) == typeof(double))
                return ref generic<T>(in OneF64);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Stores vector content to a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public unsafe static void Store<T>(in Vec128<T> src, ref T dst)
            where T : struct
        {            

            if(typeof(T) == typeof(sbyte))
                vstore(in int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(in uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(in int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(in uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(in int32(src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(in uint32(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(in int64(src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(in uint64(src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(in float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(in float64(src), ref float64(ref dst));
            else
                throw unsupported<T>();
        }       

        /// <summary>
        /// Stores an intrinsic vector to a blocked span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target span</param>
        /// <param name="blockIndex">The block position in the target span where storage begins</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> Store<T>(Vec128<T> src, Span128<T> dst, int blockIndex)
            where T : struct        
        {
            var offset = Span128.BlockLength<T>(blockIndex);
            Vec128.Store(src, ref dst[offset]);
            return dst;                        
        }


        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(ref T src)
            where T : struct  
        {            
            if(typeof(T) == typeof(sbyte))
                return generic<T>(load(ref int8(ref src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(load(ref uint8(ref src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(load(ref int16(ref src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(load(ref uint16(ref src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(load(ref int32(ref src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(load(ref uint32(ref src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(load(ref int64(ref src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(load(ref uint64(ref src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(load(ref float32(ref src)));
            else if(typeof(T) == typeof(double))
                return  generic<T>(load(ref float64(ref src)));
            else 
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static Vec128<T> Loadi<T>(in T src)
            where T : struct  
        {
            
            if(typeof(T) == typeof(sbyte))
                return generic<T>(load(ref int8(ref asRef(in src))));
            else if(typeof(T) == typeof(byte))
                return generic<T>(load(ref uint8(ref asRef(in src))));
            else if(typeof(T) == typeof(short))
                return generic<T>(load(ref int16(ref asRef(in src))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(load(ref uint16(ref asRef(in src))));
            else if(typeof(T) == typeof(int))
                return generic<T>(load(ref int32(ref asRef(in src))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(load(ref uint32(ref asRef(in src))));
            else if(typeof(T) == typeof(long))
                return generic<T>(load(ref int64(ref asRef(in src))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(load(ref uint64(ref asRef(in src))));
            else if(typeof(T) == typeof(float))
                return generic<T>(load(ref float32(ref asRef(in src))));
            else if(typeof(T) == typeof(double))
                return  generic<T>(load(ref float64(ref asRef(in src))));
            else 
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static ref Vec128<T> Load<T>(in ReadOnlySpan128<T> src, int block, out Vec128<T> dst)
            where T : struct
        {            
            ref var head = ref asRef(in src.Block(block));            
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(load(ref int8(ref head)));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(load(ref uint8(ref head)));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(load(ref int16(ref head)));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(load(ref uint16(ref head)));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(load(ref int32(ref head)));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(load(ref uint32(ref head)));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(load(ref int64(ref head)));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(load(ref uint64(ref head)));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(load(ref float32(ref head)));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(load(ref float64(ref head)));
            else 
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<T> Load<T>(in Span128<T> src, int block, out Vec128<T> dst)
            where T : struct
        {            
            ref var head = ref asRef(in src.Block(block));            
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(load(ref int8(ref head)));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(load(ref uint8(ref head)));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(load(ref int16(ref head)));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(load(ref uint16(ref head)));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(load(ref int32(ref head)));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(load(ref uint32(ref head)));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(load(ref int64(ref head)));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(load(ref uint64(ref head)));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(load(ref float32(ref head)));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(load(ref float64(ref head)));
            else 
                throw unsupported<T>();
            return ref dst;
        }        

        /// <summary>
        /// Loads source value into the first component of the target
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<T> LoadScalar<T>(T src, out Vec128<T> dst)
            where T : struct
        {            
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadScalar(int8(src)));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(LoadScalar(uint8(src)));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadScalar(int16(src)));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(LoadScalar(uint16(src)));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(LoadScalar(int32(src)));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(LoadScalar(uint32(src)));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(LoadScalar(int64(src)));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(LoadScalar(uint64(src)));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(LoadScalar(float32(src)));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(LoadScalar(float64(src)));
            else 
                throw unsupported<T>();
            return ref dst;
        }        


        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(Span128<T> src, int block = 0)
            where T : struct  
                => Load(in src, block, out Vec128<T> dst);

        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(ReadOnlySpan128<T> src, int block = 0)
            where T : struct  
                => Load(in src, block, out Vec128<T> dst);

        [MethodImpl(Inline)]
        public static ref Vec128<T> Load<T>(ReadOnlySpan<T> src, int offset, out Vec128<T> dst)
            where T : struct  
        {
            ref var head = ref asRef(in src[offset]);            
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(load(ref int8(ref head)));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(load(ref uint8(ref head)));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(load(ref int16(ref head)));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(load(ref uint16(ref head)));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(load(ref int32(ref head)));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(load(ref uint32(ref head)));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(load(ref int64(ref head)));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(load(ref uint64(ref head)));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(load(ref float32(ref head)));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(load(ref float64(ref head)));
            else 
                throw unsupported<T>();
            return ref dst;
        }

 

        [MethodImpl(Inline)]
        public static Vec128<T> Load<T>(in ReadOnlySpan<T> src, int offset = 0)
            where T : struct  
                =>  Load<T>(src, offset, out Vec128<T> dst);    

        
        [MethodImpl(Inline)]
        static Vec128<byte> LoadScalar(byte src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<sbyte> LoadScalar(sbyte src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<short> LoadScalar(short src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<ushort> LoadScalar(ushort src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<int> LoadScalar(int src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<uint> LoadScalar(uint src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<long> LoadScalar(long src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<ulong> LoadScalar(ulong src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<float> LoadScalar(float src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static Vec128<double> LoadScalar(double src)
            => Vector128.CreateScalarUnsafe(src);

        [MethodImpl(Inline)]
        static unsafe Vec128<sbyte> load(ref sbyte src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<byte> load(ref byte src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<short> load(ref short src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<ushort> load(ref ushort src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<int> load(ref int src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<uint> load(ref uint src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<long> load(ref long src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<ulong> load(ref ulong src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<float> load(ref float src)
            => LoadVector128(refptr(ref src));

        [MethodImpl(Inline)]
        static unsafe Vec128<double> load(ref double src)
            => LoadVector128(refptr(ref src)); 
 
        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<byte> fill(byte src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<sbyte> fill(sbyte src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<short> fill(short src)
            => Vector128.Create(src);
        
        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<ushort> fill(ushort src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<int> fill(int src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<uint> fill(uint src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<long> fill(long src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<ulong> fill(ulong src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<float> fill(float src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector where all components have been assigned the same value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
        static Vec128<double> fill(double src)
            => Vector128.Create(src);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        /// <param name="x4">The component at index 4</param>
        /// <param name="x5">The component at index 5</param>
        /// <param name="x6">The component at index 6</param>
        /// <param name="x7">The component at index 7</param>
        /// <param name="x8">The component at index 8</param>
        /// <param name="x9">The component at index 9</param>
        /// <param name="x10">The component at index 10</param>
        /// <param name="x11">The component at index 11</param>
        /// <param name="x12">The component at index 12</param>
        /// <param name="x13">The component at index 13</param>
        /// <param name="x14">The component at index 14</param>
        /// <param name="x15">The component at index 15</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> parts(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15) 
                =>  Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                    x8, x9, x10, x11,x12, x13, x14, x15);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        /// <param name="x4">The component at index 4</param>
        /// <param name="x5">The component at index 5</param>
        /// <param name="x6">The component at index 6</param>
        /// <param name="x7">The component at index 7</param>
        /// <param name="x8">The component at index 8</param>
        /// <param name="x9">The component at index 9</param>
        /// <param name="x10">The component at index 10</param>
        /// <param name="x11">The component at index 11</param>
        /// <param name="x12">The component at index 12</param>
        /// <param name="x13">The component at index 13</param>
        /// <param name="x14">The component at index 14</param>
        /// <param name="x15">The component at index 15</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> parts(
                sbyte x00, sbyte x01, sbyte x02, sbyte x03, 
                sbyte x04, sbyte x05, sbyte x06, sbyte x07,
                sbyte x08, sbyte x09, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                    => Vector128.Create(
                        x00, x01, x02, x03, x04, x05, x06, x07, 
                        x08, x09, x10, x11,x12, x13, x14, x15);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        /// <param name="x4">The component at index 4</param>
        /// <param name="x5">The component at index 5</param>
        /// <param name="x6">The component at index 6</param>
        /// <param name="x7">The component at index 7</param>
        [MethodImpl(Inline)]
        public static Vec128<short> define(
            short x0, short x1, short x2, short x3, 
            short x4, short x5, short x6, short x7) 
                => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        /// <param name="x4">The component at index 4</param>
        /// <param name="x5">The component at index 5</param>
        /// <param name="x6">The component at index 6</param>
        /// <param name="x7">The component at index 7</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> define(
            ushort x0, ushort x1, ushort x2, ushort x3, 
            ushort x4, ushort x5, ushort x6, ushort x7)
                => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        [MethodImpl(Inline)]
        public static Vec128<int> define(int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1,x2,x3);
                
        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> define(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1,x2,x3);        
        
        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        [MethodImpl(Inline)]
        public static Vec128<long> define(long x0, long x1)
            => Vector128.Create(x0,x1);

        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> define(ulong x0, ulong x1)
            => Vector128.Create(x0,x1);
        
        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        /// <param name="x2">The component at index 2</param>
        /// <param name="x3">The component at index 3</param>
        [MethodImpl(Inline)]
        public static Vec128<float> define(float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);
    
        /// <summary>
        /// Creates a new vector via component-wise specification
        /// </summary>
        /// <param name="x0">The component at index 0</param>
        /// <param name="x1">The component at index 1</param>
        [MethodImpl(Inline)]
        public static Vec128<double> define(double x0, double x1)
            => Vector128.Create(x0,x1);
 
        static readonly Vec128<byte> OneU8 = Vec128.fill((byte)1);

        static readonly Vec128<sbyte> OneI8 = Vec128.fill((sbyte)1);

        static readonly Vec128<short> OneI16 = Vec128.fill((short)1);

        static readonly Vec128<ushort> OneU16 = Vec128.fill((ushort)1);

        static readonly Vec128<int> OneI32 = Vec128.fill(1);

        static readonly Vec128<uint> OneU32 = Vec128.fill(1u);

        static readonly Vec128<long> OneI64 = Vec128.fill(1L);

        static readonly Vec128<ulong> OneU64 = Vec128.fill(1ul);

        static readonly Vec128<float> OneF32 = Vec128.fill(1f);

        static readonly Vec128<double> OneF64 = Vec128.fill(1d);
    }
}