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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;
    using static AsInX;

    public static partial class Vec256
    {
        [MethodImpl(Inline)]
        public static ref readonly Vec256<T> zero<T>() 
            where T : struct
                => ref Vec256<T>.Zero;        

        [MethodImpl(Inline)]
         public static ref readonly Vec256<T> one<T>()
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

        [MethodImpl(Inline)]
        public static void store<T>(in Vec256<T> src, ref T dst)
            where T : struct
        {            
            if(typeof(T) == typeof(sbyte))
                dinx.store(in int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                dinx.store(in uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                dinx.store(in int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                dinx.store(in uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.store(in int32(src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.store(in uint32(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.store(in int64(src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.store(in uint64(src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.store(in float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.store(in float64(src), ref float64(ref dst));
            else
                throw unsupported<T>();
        }        
 
        [MethodImpl(Inline)]
        public static Vec256<T> load<T>(ref T src)
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
        public static ref Vec256<T> load<T>(in ReadOnlySpan256<T> src, int block, out Vec256<T> dst)
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
        public static ref Vec256<T> load<T>(in Span256<T> src, int block, out Vec256<T> dst)
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
        public static Vec256<T> define<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(define(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(define(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(define(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(define(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(define(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(define(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(define(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(define(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(define(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(define(float64(src)));
            else 
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static Vec256<T> load<T>(T[] src, int block = 0)
            where T : struct  
                => load(src, block, out Vec256<T> dst);

        [MethodImpl(Inline)]
        public static Vec256<T> load<T>(in ReadOnlySpan256<T> src, int block = 0)
            where T : struct  
                => load(in src, block, out Vec256<T> dst);

        [MethodImpl(Inline)]
        public static Vec256<T> load<T>(in Span256<T> src, int block = 0)
            where T : struct  
                => load(src, block, out Vec256<T> dst);

        [MethodImpl(Inline)]
        public static Vec256<byte> define(byte x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> define(sbyte x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<short> define(short x0)
            => Vector256.Create(x0);
        
        [MethodImpl(Inline)]
        public static Vec256<ushort> define(ushort x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<int> define(int x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<uint> define(uint x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<long> define(long x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<ulong> define(ulong x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<float> define(float x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static Vec256<double> define(double x0)
            => Vector256.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> define(
            sbyte x0, sbyte x1, sbyte x2, sbyte x3,  
            sbyte x4, sbyte x5, sbyte x6, sbyte x7, 
            sbyte x8, sbyte x9, sbyte x10, sbyte x11,
            sbyte x12, sbyte x13, sbyte x14, sbyte x15,
            sbyte x16, sbyte x17, sbyte x18, sbyte x19,  
            sbyte x20, sbyte x21, sbyte x22, sbyte x23, 
            sbyte x24, sbyte x25, sbyte x26, sbyte x27,
            sbyte x28, sbyte x29, sbyte x30, sbyte x31)
                => Vector256.Create(
                    x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23,
                    x24,x25,x26,x27,x28,x29,x30,x31);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> definer(
            sbyte x31, sbyte x30, sbyte x29, sbyte x28,  
            sbyte x27, sbyte x26, sbyte x25, sbyte x24, 
            sbyte x23, sbyte x22, sbyte x21, sbyte x20,
            sbyte x19, sbyte x18, sbyte x17, sbyte x16,
            sbyte x15, sbyte x14, sbyte x13, sbyte x12,  
            sbyte x11, sbyte x10, sbyte x9, sbyte x8, 
            sbyte x7, sbyte x6, sbyte x5, sbyte x4,
            sbyte x3, sbyte x2, sbyte x1, sbyte x0
            ) => Vector256.Create( 
                x0,x1,x2,x3,x4,x5,x6,x7,
                x8,x9,x10,x11,x12,x13,x14,x15,
                x16,x17,x18,x19,x20,x21,x22,x23,
                x24,x25,x26,x27,x28,x29,x30,x31);

        [MethodImpl(Inline)]
        public static Vec256<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15,
            byte x16, byte x17, byte x18, byte x19,  
            byte x20, byte x21, byte x22, byte x23, 
            byte x24, byte x25, byte x26, byte x27,
            byte x28, byte x29, byte x30, byte x31)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23,
                    x24,x25,x26,x27,x28,x29,x30,x31);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> definer(
            byte x31, byte x30, byte x29, byte x28,  
            byte x27, byte x26, byte x25, byte x24, 
            byte x23, byte x22, byte x21, byte x20,
            byte x19, byte x18, byte x17, byte x16,
            byte x15, byte x14, byte x13, byte x12,  
            byte x11, byte x10, byte x9, byte x8, 
            byte x7, byte x6, byte x5, byte x4,
            byte x3, byte x2, byte x1, byte x0)
                => Vector256.Create(
                    x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15,
                    x16,x17,x18,x19,x20,x21,x22,x23,
                    x24,x25,x26,x27,x28,x29,x30,x31);

        [MethodImpl(Inline)]
        public static Vec256<short> define(
            short x0, short x1, short x2, short x3,  
            short x4, short x5, short x6, short x7, 
            short x8, short x9, short x10, short x11,
            short x12, short x13, short x14, short x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static Vec256<short> definer(
            short x15, short x14, short x13, short x12,  
            short x11, short x10, short x9, short x8, 
            short x7, short x6, short x5, short x4,
            short x3, short x2, short x1, short x0)
                => Vector256.Create(
                    x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);
                    
        [MethodImpl(Inline)]
        public static Vec256<ushort> define(
            ushort x0, ushort x1, ushort x2, ushort x3,  
            ushort x4, ushort x5, ushort x6, ushort x7, 
            ushort x8, ushort x9, ushort x10, ushort x11,
            ushort x12, ushort x13, ushort x14, ushort x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static Vec256<ushort> definer(
            ushort x15, ushort x14, ushort x13, ushort x12,  
            ushort x11, ushort x10, ushort x9, ushort x8, 
            ushort x7, ushort x6, ushort x5, ushort x4,
            ushort x3, ushort x2, ushort x1, ushort x0)
                => Vector256.Create(
                    x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static Vec256<int> define(
            int x0, int x1, int x2, int x3,  
            int x4, int x5, int x6, int x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec256<int> definer(
            int x7, int x6, int x5, int x4,  
            int x3, int x2, int x1, int x0 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec256<uint> define(
            uint x0, uint x1, uint x2, uint x3,  
            uint x4, uint x5, uint x6, uint x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec256<uint> definer(
            uint x7, uint x6, uint x5, uint x4,  
            uint x3, uint x2, uint x1, uint x0)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec256<long> define(long x0, long x1, long x2, long x3)
            => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static Vec256<long> definer(long x3, long x2, long x1, long x0)
            => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static Vec256<ulong> define(ulong x0, ulong x1, ulong x2, ulong x3)
                => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static Vec256<ulong> definer(ulong x3, ulong x2, ulong x1, ulong x0)
            => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> define(
            float x0, float x1, float x2, float x3,  
            float x4, float x5, float x6, float x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> define(double x0, double x1, double x2, double x3)
                => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(ref sbyte head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(ref byte head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(ref short head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(ref ushort head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(ref int head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(ref uint head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(ref long head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(ref ulong head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(ref float head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(ref double head)
            => LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public static Vec256<sbyte> load(Span<sbyte> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<byte> load(Span<byte> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<short> load(Span<short> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<ushort> load(Span<ushort> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<int> load(Span<int> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<uint> load(Span<uint> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<long> load(Span<long> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<ulong> load(Span<ulong> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<float> load(Span<float> src)
            => load(ref src[0]);

        [MethodImpl(Inline)]
        public static Vec256<double> load(Span<double> src)
            => load(ref src[0]);
        
        static readonly Vec256<byte> OneU8 = Vec256.define((byte)1);

        static readonly Vec256<sbyte> OneI8 = Vec256.define((sbyte)1);

        static readonly Vec256<short> OneI16 = Vec256.define((short)1);

        static readonly Vec256<ushort> OneU16 = Vec256.define((ushort)1);

        static readonly Vec256<int> OneI32 = Vec256.define(1);

        static readonly Vec256<uint> OneU32 = Vec256.define(1u);

        static readonly Vec256<long> OneI64 = Vec256.define(1L);

        static readonly Vec256<ulong> OneU64 = Vec256.define(1ul);

        static readonly Vec256<float> OneF32 = Vec256.define(1f);

        static readonly Vec256<double> OneF64 = Vec256.define(1d);
    } 
}