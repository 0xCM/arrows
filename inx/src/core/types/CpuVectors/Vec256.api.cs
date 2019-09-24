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
    
    using static zfunc;
    using static As;
    using static AsIn;
    

    public static partial class Vec256
    {
        /// <summary>
        /// Returns a readonly reference to the zero vector
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Vec256<T> Zero<T>() 
            where T : unmanaged
                => ref Vec256<T>.Zero;        

        /// <summary>
        /// Returns the length of a vector with a specified primal component type
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>()
            where T : unmanaged
                => Vec256<T>.Length;

        /// <summary>
        /// Creates a new vector, initialing each component to a common value
        /// </summary>
        /// <param name="src">The fill value</param>
        [MethodImpl(Inline)]
         public static Vec256<T> Fill<T>(T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(fill(int8(value)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(fill(uint8(value)));
            else if(typeof(T) == typeof(short))
                return generic<T>(fill(int16(value)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(fill(uint16(value)));
            else if(typeof(T) == typeof(int))
                return generic<T>(fill(int32(value)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(fill(uint32(value)));
            else if(typeof(T) == typeof(long))
                return generic<T>(fill(int64(value)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(fill(uint64(value)));
            else if(typeof(T) == typeof(float))
                return generic<T>(fill(float32(value)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fill(float64(value)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a new vector with each component assigned unit value
        /// </summary>
        /// <typeparam name="T">The component primitive type</typeparam>
        [MethodImpl(Inline)]
         public static ref readonly Vec256<T> Ones<T>()
            where T : unmanaged
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
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void Store<T>(in Vec256<T> src, ref T dst)
            where T : unmanaged
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
        /// Loads vector content from a memory location
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static Vec256<T> Load<T>(ref T src)
            where T : unmanaged  
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
        public static Vector256<T> LoadVector<T>(ref T src)
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


        /// <summary>
        /// Loads vector content from the head of a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Load<T>(Span<T> src)
            where T : unmanaged  
                => Load(ref src[0]);

        /// <summary>
        /// Loads a vector from the head of the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Load<T>(ReadOnlySpan<T> src)
            where T : unmanaged  
                => Load(ref asRef( in src[0]));

        /// <summary>
        /// Loads vector content from read-only memory
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Loadi<T>(in T src)
            where T : unmanaged  
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


        /// <summary>
        /// Loads a target vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vec256<T> Load<T>(in ReadOnlySpan256<T> src, int block, out Vec256<T> dst)
            where T : unmanaged
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
        /// Loads a target vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vec256<T> Load<T>(in Span256<T> src, int block, out Vec256<T> dst)
            where T : unmanaged
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
        /// Loads a vector from an array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index into the source span</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Load<T>(T[] src, int block = 0)
            where T : unmanaged  
                => Load(src, block, out Vec256<T> dst);

        /// <summary>
        /// Loads a vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index into the source span</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Load<T>(in ReadOnlySpan256<T> src, int block = 0)
            where T : unmanaged  
                => Load(in src, block, out Vec256<T> dst);

        /// <summary>
        /// Loads a vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index into the source span</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Load<T>(in Span256<T> src, int block = 0)
            where T : unmanaged  
                => Load(src, block, out Vec256<T> dst);


        [MethodImpl(Inline)]
        public static Vec256<byte> FromParts(in Vec128<byte> lo, in Vec128<byte> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> FromParts(in Vec128<sbyte> lo, in Vec128<sbyte> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<short> FromParts(in Vec128<short> lo, in Vec128<short> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<ushort> FromParts(in Vec128<ushort> lo, in Vec128<ushort> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<int> FromParts(in Vec128<int> lo, in Vec128<int> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<uint> FromParts(in Vec128<uint> lo, in Vec128<uint> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<long> FromParts(in Vec128<long> lo, in Vec128<long> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<ulong> FromParts(in Vec128<ulong> lo, in Vec128<ulong> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<float> FromParts(in Vec128<float> lo, in Vec128<float> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<double> FromParts(in Vec128<double> lo, in Vec128<double> hi)
                => Vector256.Create(lo,hi);

        [MethodImpl(Inline)]
        public static Vec256<byte> FromBytes(
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11, byte x12, byte x13, byte x14, byte x15,
            byte x16, byte x17, byte x18, byte x19, byte x20, byte x21, byte x22, byte x23, 
            byte x24, byte x25, byte x26, byte x27, byte x28, byte x29, byte x30, byte x31)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23, 
                    x24,x25,x26,x27,x28,x29,x30,x31);


        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> FromParts(
            sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, 
            sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15, 
            sbyte x16, sbyte x17, sbyte x18, sbyte x19, sbyte x20, sbyte x21, sbyte x22, sbyte x23, 
            sbyte x24, sbyte x25, sbyte x26, sbyte x27,sbyte x28, sbyte x29, sbyte x30, sbyte x31)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23,
                    x24,x25,x26,x27,x28,x29,x30,x31);

        [MethodImpl(Inline)]
        public static Vec256<short> FromParts(short x0, short x1, short x2, short x3,  
            short x4, short x5, short x6, short x7, short x8, short x9, short x10, short x11,
            short x12, short x13, short x14, short x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15);
                    
        [MethodImpl(Inline)]
        public static Vec256<ushort> FromParts(ushort x0, ushort x1, ushort x2, ushort x3,  
            ushort x4, ushort x5, ushort x6, ushort x7, ushort x8, ushort x9, ushort x10, ushort x11,
            ushort x12, ushort x13, ushort x14, ushort x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static Vec256<int> FromParts(int x0, int x1, int x2, int x3,  int x4, int x5, int x6, int x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec256<uint> FromParts(uint x0, uint x1, uint x2, uint x3,  uint x4, uint x5, uint x6, uint x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec256<long> FromParts(long x0, long x1, long x2, long x3)
            => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static Vec256<ulong> FromParts(ulong x0, ulong x1, ulong x2, ulong x3)
                => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> FromParts(float x0, float x1, float x2, float x3,  
            float x4, float x5, float x6, float x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> FromParts(double x0, double x1, double x2, double x3)
                => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        static unsafe Vec256<sbyte> load(ref sbyte head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<byte> load(ref byte head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<short> load(ref short head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<ushort> load(ref ushort head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<int> load(ref int head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> load(ref uint head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<long> load(ref long head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<ulong> load(ref ulong head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<float> load(ref float head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static unsafe Vec256<double> load(ref double head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        static Vec256<byte> fill(byte x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<sbyte> fill(sbyte x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<short> fill(short x0)
            => Vector256.Create(x0);
        
        [MethodImpl(Inline)]
        static Vec256<ushort> fill(ushort x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<int> fill(int x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<uint> fill(uint x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<long> fill(long x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<ulong> fill(ulong x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<float> fill(float x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        static Vec256<double> fill(double x0)
            => Vector256.Create(x0);
             
        static readonly Vec256<byte> OneU8 = Vec256.fill((byte)1);

        static readonly Vec256<sbyte> OneI8 = Vec256.fill((sbyte)1);

        static readonly Vec256<short> OneI16 = Vec256.fill((short)1);

        static readonly Vec256<ushort> OneU16 = Vec256.fill((ushort)1);

        static readonly Vec256<int> OneI32 = Vec256.fill(1);

        static readonly Vec256<uint> OneU32 = Vec256.fill(1u);

        static readonly Vec256<long> OneI64 = Vec256.fill(1L);

        static readonly Vec256<ulong> OneU64 = Vec256.fill(1ul);

        static readonly Vec256<float> OneF32 = Vec256.fill(1f);

        static readonly Vec256<double> OneF64 = Vec256.fill(1d);
    } 
}