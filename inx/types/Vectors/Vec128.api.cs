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
        public static ref readonly Vec128<T> zero<T>() 
            where T : struct
                => ref Vec128<T>.Zero;

        /// <summary>
        /// Produces a vector a vector that has all bits set to 1
        /// </summary>
        /// <typeparam name="T">The component primitive type</typeparam>
        [MethodImpl(Inline)]
         public static ref readonly Vec128<T> ones<T>()
            where T : struct
                => ref Vec128Const<T>.Ones;

        /// <summary>
        /// Produces a vector with each component assigned unit value
        /// </summary>
        /// <typeparam name="T">The component primitive type</typeparam>
        [MethodImpl(Inline)]
         public static ref readonly Vec128<T> one<T>()
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
        public unsafe static void store<T>(in Vec128<T> src, ref T dst)
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
        public static Span128<T> store<T>(Vec128<T> src, Span128<T> dst, int blockIndex)
            where T : struct        
        {
            var offset = Span128.blocklength<T>(blockIndex);
            Vec128.store(src, ref dst[offset]);
            return dst;                        
        }

         [MethodImpl(Inline)]
        public static Vec128<T> load<T>(ref T src)
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
        public static ref Vec128<T> load<T>(in ReadOnlySpan128<T> src, int block, out Vec128<T> dst)
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
        public static unsafe ref Vec128<T> load<T>(in Span128<T> src, int block, out Vec128<T> dst)
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
        public static Vec128<T> load<T>(Span128<T> src, int block = 0)
            where T : struct  
                => load(in src, block, out Vec128<T> dst);

        [MethodImpl(Inline)]
        public static Vec128<T> load<T>(ReadOnlySpan128<T> src, int block = 0)
            where T : struct  
                => load(in src, block, out Vec128<T> dst);

        [MethodImpl(Inline)]
        public static ref Vec128<T> load<T>(ReadOnlySpan<T> src, int offset, out Vec128<T> dst)
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
        public static Vec128<T> define<T>(T src)
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
        public static Vec128<T> load<T>(in ReadOnlySpan<T> src, int offset = 0)
            where T : struct  
            =>  load<T>(src, offset, out Vec128<T> dst);    


        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(ref sbyte src)
            => LoadVector128(pint8(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(ref byte src)
            => LoadVector128(puint8(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(ref short src)
            => LoadVector128(pint16(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ref ushort src)
            => LoadVector128(puint16(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(ref int src)
            => LoadVector128(pint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(ref uint src)
            => LoadVector128(puint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(ref long src)
            => LoadVector128(pint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ref ulong src)
            => LoadVector128(puint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(ref float src)
            => LoadVector128(pfloat32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(ref double src)
            => LoadVector128(pfloat64(ref src)); 
 
        [MethodImpl(Inline)]
        public static Vec128<byte> define(byte x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> define(sbyte x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<short> define(short x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static Vec128<ushort> define(ushort x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<int> define(int x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<uint> define(uint x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<long> define(long x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<ulong> define(ulong x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<float> define(float x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<double> define(double x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static Vec128<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15) 
                =>  Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                    x8, x9, x10, x11,x12, x13, x14, x15);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> define(
                sbyte x00, sbyte x01, sbyte x02, sbyte x03, 
                sbyte x04, sbyte x05, sbyte x06, sbyte x07,
                sbyte x08, sbyte x09, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                    => Vector128.Create(
                        x00, x01, x02, x03, x04, x05, x06, x07, 
                        x08, x09, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static Vec128<short> define(
                short x0, short x1, short x2, short x3, 
                short x4, short x5, short x6, short x7) 
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec128<ushort> define(
                ushort x0, ushort x1, ushort x2, ushort x3, 
                ushort x4, ushort x5, ushort x6, ushort x7)
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static Vec128<int> define(int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1,x2,x3);
                
        [MethodImpl(Inline)]
        public static Vec128<uint> define(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1,x2,x3);        
        
        [MethodImpl(Inline)]
        public static Vec128<long> define(long x0, long x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static Vec128<ulong> define(ulong x0, ulong x1)
            => Vector128.Create(x0,x1);
        
        [MethodImpl(Inline)]
        public static Vec128<float> define(float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);
    
        [MethodImpl(Inline)]
        public static Vec128<double> define(double x0, double x1)
            => Vector128.Create(x0,x1);
 
        static readonly Vec128<byte> OneU8 = Vec128.define((byte)1);

        static readonly Vec128<sbyte> OneI8 = Vec128.define((sbyte)1);

        static readonly Vec128<short> OneI16 = Vec128.define((short)1);

        static readonly Vec128<ushort> OneU16 = Vec128.define((ushort)1);

        static readonly Vec128<int> OneI32 = Vec128.define(1);

        static readonly Vec128<uint> OneU32 = Vec128.define(1u);

        static readonly Vec128<long> OneI64 = Vec128.define(1L);

        static readonly Vec128<ulong> OneU64 = Vec128.define(1ul);

        static readonly Vec128<float> OneF32 = Vec128.define(1f);

        static readonly Vec128<double> OneF64 = Vec128.define(1d);
    }
}