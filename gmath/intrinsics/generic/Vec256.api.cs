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
    using static global::mfunc;

    public static class Vec256
    {

        [MethodImpl(Inline)]
        public static Vec256<T> single<T>(T[] src)
            where T : struct, IEquatable<T>            
                => define<T>(src,0);


        [MethodImpl(Inline)]
        public static unsafe Vec256<T> define<T>(Span256<T> src, int blockOffset = 0)
            where T : struct, IEquatable<T>
        {            

            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return load(src.Block(blockOffset).As<sbyte>()).As<T>();                    
                case PrimalKind.uint8:
                    return load(src.Block(blockOffset).As<byte>()).As<T>();                    
                case PrimalKind.int16:
                    return load(src.Block(blockOffset).As<short>()).As<T>();                    
                case PrimalKind.uint16:
                    return load(src.Block(blockOffset).As<ushort>()).As<T>();                    
                case PrimalKind.int32:
                    return load(src.Block(blockOffset).As<int>()).As<T>();                    
                case PrimalKind.uint32:
                    return load(src.Block(blockOffset).As<uint>()).As<T>();                    
                case PrimalKind.int64:
                    return load(src.Block(blockOffset).As<long>()).As<T>();                    
                case PrimalKind.uint64:
                    return load(src.Block(blockOffset).As<ulong>()).As<T>();                    
                case PrimalKind.float32:
                    return load(src.Block(blockOffset).As<float>()).As<T>();                    
                case PrimalKind.float64:                
                    return load(src.Block(blockOffset).As<double>()).As<T>();                    
                default:
                    throw new Exception($"Kind {kind} not supported");
            }
        }        

        static Exception errlen(int datalen, int veclen, int startpos, int maxpos, int finalpos)
            => new Exception($"Length mismatch: length of data source = " 
                + $"{datalen}, veclen = {veclen}, startpos = {startpos}, " 
                + $"maxpos = {maxpos}, finalpos = {finalpos}");

        [MethodImpl(Inline)]
        static T[] datasource<T>(object data, int count, int startpos = 0)
            where T : struct, IEquatable<T>
        {
            var src = (T[])data;
            checklen(src, startpos);
            return src;
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(Span256<sbyte> src)
        {
            fixed (sbyte* psrc = &first(src))
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(Span256<byte> src)
        {
            fixed (byte* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(Span256<short> src)
        {
            fixed (short* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(Span256<ushort> src)
        {
            fixed (ushort* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(Span256<int> src)
        {
            fixed (int* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(Span256<uint> src)
        {
            fixed (uint* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(Span256<long> src)
        {
            fixed (long* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(Span256<ulong> src)
        {
            fixed (ulong* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(Span256<float> src)
        {
            fixed (float* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(Span256<double> src)
        {
            fixed (double* psrc = &src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        static void checklen<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {
            var maxpos = src.Length - 1;
            var finalpos = offset + Vector256<T>.Count - 1;

            if(finalpos > maxpos)
                throw errlen(src.Length, Vector256<T>.Count, offset, maxpos, finalpos);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(params byte[] src)
        {
            checklen(src);

            fixed(byte* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(params sbyte[] src)
        {
            checklen(src);

            fixed(sbyte* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(params short[] src)
        {
            checklen(src);

            fixed(short* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(params ushort[] src)
        {
            checklen(src);

            fixed(ushort* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(params int[] src)
        {
            checklen(src);

            fixed(int* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(params uint[] src)
        {
            checklen(src);

            fixed(uint* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(params long[] src)
        {
            checklen(src);

            fixed(long* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(params ulong[] src)
        {
            checklen(src);

            fixed(ulong* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(params float[] src)
        {
            checklen(src);

            fixed(float* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(params double[] src)
        {
            checklen(src);

            fixed(double* psrc = & src[0])
                return Avx2.LoadVector256(psrc);
        }

        [MethodImpl(Inline)]
        static unsafe Vec256<sbyte> loadI8(void* src, out Vec256<sbyte> dst)
            => dst = Avx2.LoadVector256((sbyte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<byte> loadU8(void* src, out Vec256<byte> dst)
            => dst = Avx2.LoadVector256((byte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<short> loadI16(void* src, out Vec256<short> dst)
            => dst = Avx2.LoadVector256((short*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<ushort> loadU16(void* src, out Vec256<ushort> dst)
            => dst = Avx2.LoadVector256((ushort*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<int> loadI32(void* src, out Vec256<int> dst)
            => dst = Avx2.LoadVector256((int*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> loadU32(void* src, out Vec256<uint> dst)
            => dst = Avx2.LoadVector256((uint*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<long> loadI64(void* src, out Vec256<long> dst)
            => dst = Avx2.LoadVector256((long*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<ulong> loadU64(void* src, out Vec256<ulong> dst)
            => dst = Avx2.LoadVector256((ulong*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<float> loadF32(void* src, out Vec256<float> dst)
            => dst = Avx2.LoadVector256((float*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<double> loadF64(void* src, out Vec256<double> dst)
            => dst = Avx2.LoadVector256((double*)src);




        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(sbyte* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(byte* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(short* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(ushort* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(int* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(uint* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(long* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(ulong* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(float* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(double* src)
            => Avx2.LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> broadcast(byte* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> broadcast(sbyte* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> broadcast(short* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> broadcast(ushort* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> broadcast(int* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> broadcast(uint* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> broadcast(long* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> broadcast(ulong* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> broadcast(float* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> broadcast(double* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        static Vec256<T> vInt8<T>(T[] data, int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.int8(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt8<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.uint8(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vInt16<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.int16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt16<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.uint16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vInt32<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.int32(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt32<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.uint32(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vInt64<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.int64(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vUInt64<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.uint64(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec256<T> vFloat32<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.float32(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]                

            );
            return As.generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec256<T> vFloat64<T>(T[] data,int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.float64(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++]

            );
            return As.generic<T>(dst);
        }


        /// <summary>
        /// Constructs a 256-bit vector from the contents of a list. An error will
        /// be raised if the length of the list does not match the length of the
        /// target vector
        /// </summary>
        /// <param name="src">The source list</param>
        /// <typeparam name="T">The primitive type</typeparam>        
        [MethodImpl(Inline)]
        public static unsafe Vec256<T> define<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {            

            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)            
                return vInt8(src,offset);

            if(kind == PrimalKind.uint8)            
                return vUInt8(src,offset);

            if(kind == PrimalKind.int16)            
                return vInt16(src,offset);

            if(kind == PrimalKind.uint16)            
                return vUInt16(src,offset);

            if(kind == PrimalKind.int32)            
                return vInt32(src,offset);

            if(kind == PrimalKind.uint32)            
                return vUInt32(src,offset);

            if(kind == PrimalKind.int64)            
                return vInt64(src,offset);

            if(kind == PrimalKind.uint64)            
                return vUInt64(src,offset);

            if(kind == PrimalKind.float32)            
                return vFloat32(src,offset);

            if(kind == PrimalKind.float64)            
                return vFloat64(src,offset);

            throw new NotSupportedException($"Kind {kind} not supported");
        }        

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
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
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
        public static unsafe Vec256<short> define(
            short x0, short x1, short x2, short x3,  
            short x4, short x5, short x6, short x7, 
            short x8, short x9, short x10, short x11,
            short x12, short x13, short x14, short x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> define(
            ushort x0, ushort x1, ushort x2, ushort x3,  
            ushort x4, ushort x5, ushort x6, ushort x7, 
            ushort x8, ushort x9, ushort x10, ushort x11,
            ushort x12, ushort x13, ushort x14, ushort x15)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7,
                    x8,x9,x10,x11,x12,x13,x14,x15);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> define(
            int x0, int x1, int x2, int x3,  
            int x4, int x5, int x6, int x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> define(
            uint x0, uint x1, uint x2, uint x3,  
            uint x4, uint x5, uint x6, uint x7)
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> define(long x0, long x1, long x2, long x3)
                => Vector256.Create(x0,x1,x2,x3);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> define(ulong x0, ulong x1, ulong x2, ulong x3)
                => Vector256.Create(x0,x1,x2,x3);

       [MethodImpl(Inline)]
        public static unsafe Vec256<float> define(
            float x0, float x1, float x2, float x3,  
            float x4, float x5, float x6, float x7 )
                => Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);

 
        [MethodImpl(Inline)]
        public static unsafe Vec256<double> define(double x0, double x1, double x2, double x3)
                => Vector256.Create(x0,x1,x2,x3);

        public static unsafe Vec256<double> next(IEnumerable<double> src)
        {
            var len = Vec256<double>.Length;
            var vecSrc = src.Take(Vec256<double>.Length).ToArray();
            return load(vecSrc);
        }
    } 
}