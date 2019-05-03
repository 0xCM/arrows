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
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static inxfunc;

    public static class Vec128
    {
        const int Len8 = 16;
        const int Len16 = 8;
        const int Len32 = 4;
        const int Len64 = 2;

        static Exception badlen(int value)
            => new Exception($"Source array is of insufficent length = {value}");


        public static Vec128<T>[] load<T>(T[] src)
            where T : struct, IEquatable<T>

        {
            var vLen = Vec128<T>.Length;
            var count = src.Length / vLen;
            var dst = alloc<Vec128<T>>(count);
            var j = 0;
            for(var i = 0; i < src.Length; i += vLen, j++)
                dst[j] = Vec128.single(src,i);
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(params byte[] src)
        {
            if(src.Length < Len8)
                throw badlen(src.Length);

            fixed(byte* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(params sbyte[] src)
        {
            if(src.Length < Len8)
                throw badlen(src.Length);

            fixed(sbyte* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(params short[] src)
        {
            if(src.Length < Len16)
                throw badlen(src.Length);

            fixed(short* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(params ushort[] src)
        {
            if(src.Length < Len16)
                throw badlen(src.Length);

            fixed(ushort* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(params int[] src)
        {
            if(src.Length < Len32)
                throw badlen(src.Length);

            fixed(int* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(params uint[] src)
        {
            if(src.Length < Len32)
                throw badlen(src.Length);

            fixed(uint* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(params long[] src)
        {
            if(src.Length < Len64)
                throw badlen(src.Length);

            fixed(long* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(params ulong[] src)
        {
            if(src.Length < Len64)
                throw badlen(src.Length);

            fixed(ulong* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(params float[] src)
        {
            if(src.Length < Len32)
                throw badlen(src.Length);

            fixed(float* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(params double[] src)
        {
            if(src.Length < Len64)
                throw badlen(src.Length);

            fixed(double* psrc = & src[0])
                return Avx2.LoadVector128(psrc);
        }

        //! load

        [MethodImpl(Inline)]
        static unsafe Vec128<sbyte> loadI8(void* src)
            => Avx2.LoadVector128((sbyte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<byte> loadU8(void* src)
            => Avx2.LoadVector128((byte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<short> loadI16(void* src)
            => Avx2.LoadVector128((short*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<ushort> loadU16(void* src)
            => Avx2.LoadVector128((ushort*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<int> loadI32(void* src)
            => Avx2.LoadVector128((int*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<uint> loadU32(void* src)
            => Avx2.LoadVector128((uint*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<long> loadI64(void* src)
            => Avx2.LoadVector128((long*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<ulong> loadU64(void* src)
            => Avx2.LoadVector128((ulong*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<float> loadF32(void* src)
            => Avx2.LoadVector128((float*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<double> loadF64(void* src)
            => Avx2.LoadVector128((double*)src);


        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(byte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(sbyte* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(short* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ushort* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(int* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(uint* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(long* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ulong* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(float* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(double* src)
            => Avx2.LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(Span128<sbyte> src)
        {
            fixed (sbyte* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(Span128<byte> src)
        {
            fixed (byte* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(Span128<short> src)
        {
            fixed (short* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(Span128<ushort> src)
        {
            fixed (ushort* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(Span128<int> src)
        {
            fixed (int* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(Span128<uint> src)
        {
            fixed (uint* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(Span128<long> src)
        {
            fixed (long* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(Span128<ulong> src)
        {
            fixed (ulong* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(Span128<float> src)
        {
            fixed (float* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(Span128<double> src)
        {
            fixed (double* psrc = &src[0])
                return Avx2.LoadVector128(psrc);
        }
 
        public static IEnumerable<Vec128<sbyte>> stream(sbyte[] src)
        {
            var veclen = Vec128<sbyte>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }
            
            
        public static IEnumerable<Vec128<byte>> stream(byte[] src)
        {
            var veclen = Vec128<byte>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<short>> stream(short[] src)
        {
            var veclen = Vec128<short>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<ushort>> stream(ushort[] src)
        {
            var veclen = Vec128<ushort>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<int>> stream(int[] src)
        {
            var veclen = Vec128<int>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<uint>> stream(uint[] src)
        {
            var veclen = Vec128<uint>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<long>> stream(long[] src)
        {
            var veclen = Vec128<long>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<ulong>> stream(ulong[] src)
        {
            var veclen = Vec128<ulong>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<float>> stream(float[] src)
        {
            var veclen = Vec128<float>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }

        public static IEnumerable<Vec128<double>> stream(double[] src)
        {
            var veclen = Vec128<double>.Length;
            for(var i = 0; i< src.Length; i+= veclen)
                yield return load(src,i);
        }


        [MethodImpl(Inline)]
        public static Vec128<T> zero<T>()
            where T : struct, IEquatable<T>                    
            => Vector128<T>.Zero;

        [MethodImpl(Inline)]
        public static Vec128<T> define<T>(Vector128<T> src)
            where T : struct, IEquatable<T>            
                => src.ToVec128();



        [MethodImpl(Inline)]
        public static unsafe Vec128<T> define<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {            

            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return vInt8(src,offset);
                case PrimalKind.uint8:
                    return vUInt8(src,offset);
                case PrimalKind.int16:
                    return vInt16(src,offset);
                case PrimalKind.uint16:
                    return vUInt16(src,offset);
                case PrimalKind.int32:
                    return vInt32(src,offset);
                case PrimalKind.uint32:
                    return vUInt32(src,offset);
                case PrimalKind.int64:
                    return vInt64(src,offset);
                case PrimalKind.uint64:
                    return vUInt64(src,offset);
                case PrimalKind.float32:
                    return vFloat32(src,offset);
                case PrimalKind.float64:                
                    return vFloat64(src,offset);
                default:
                    throw new Exception($"Kind {kind} not supported");
            }
        }        
        

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>            
                => define<T>(src,offset);

        [MethodImpl(Inline)]
        public static Vec128<T> define<T>(ArraySegment<T> src)
            where T : struct, IEquatable<T>            
                => define<T>(src.Array,src.Offset);


        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(byte x0)
            => Vector128.Create(x0);


        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> define(
            byte x0, byte x1, byte x2, byte x3,  
            byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte x10, byte x11,
            byte x12, byte x13, byte x14, byte x15) 
                =>  Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                    x8, x9, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> define(sbyte x0, sbyte x1, sbyte x2, sbyte x3, 
                sbyte x4, sbyte x5, sbyte x6, sbyte x7,
                sbyte x8, sbyte x9, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                    => Vector128.Create(x0, x1, x2, x3, x4, x5, x6, x7, 
                        x8, x9, x10, x11,x12, x13, x14, x15);


        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(short x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> define(
                short x0, short x1, short x2, short x3, 
                short x4, short x5, short x6, short x7) 
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(ushort x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> define(ushort x0, ushort x1, ushort x2, ushort x3, 
                ushort x4, ushort x5, ushort x6, ushort x7)
                    => Vector128.Create(x0,x1,x2,x3,x4,x5,x6,x7);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> define(int x0, int x1, int x2, int x3)
            => Vector128.Create(x0,x1,x2,x3);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> define(uint x0, uint x1, uint x2, uint x3)
            => Vector128.Create(x0,x1,x2,x3);

        
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<long> define(long x0, long x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> define(ulong x0, ulong x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0)
            => Vector128.Create(x0);
        
        [MethodImpl(Inline)]
        public static unsafe Vec128<float> define(float x0, float x1, float x2, float x3)
            => Vector128.Create(x0,x1,x2,x3);
    
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0)
            => Vector128.Create(x0);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> define(double x0, double x1)
            => Vector128.Create(x0,x1);

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(byte[] src, int offset = 0)
        {
            fixed (byte* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(sbyte[] src, int offset = 0)
        {
            fixed (sbyte* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(short[] src, int offset = 0)
        {
            fixed (short* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ushort[] src, int offset = 0)
        {
            fixed (ushort* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(int[] src, int offset = 0)
        {
            fixed (int* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }
 

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(uint[] src, int offset = 0)
        {
            fixed (uint* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(long[] src, int offset = 0)
        {
            checklen128(src,offset);

            fixed (long* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ulong[] src, int offset = 0)
        {
            fixed (ulong* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(float[] src, int offset = 0)
        {
            fixed (float* psrc = &src[offset])
                return Avx2.LoadVector128(psrc);
        }
 
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(double[] src, int startpos = 0)
        {
            fixed (double* psrc = &src[startpos])
                return Avx2.LoadVector128(psrc);
        }


        [MethodImpl(Inline)]
        public static Vec128<byte> define(Span128<byte> src)
            => load(src);

        [MethodImpl(Inline)]
        public static Vec128<int> define(Span128<int> src)
            => load(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> define(Span128<uint> src)
            => load(src);

        [MethodImpl(Inline)]
        public static Vec128<long> define(Span128<long> src)
            => load(src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> define(Span128<ulong> src)
            => load(src);

        [MethodImpl(Inline)]
        public static Vec128<float> define(Span128<float> src)
            => load(src);

        [MethodImpl(Inline)]
        public static Vec128<double> define(Span128<double> src)
            => load(src);
 
 
        [MethodImpl(Inline)]
        static Vec128<T> vInt8<T>(T[] data, int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = As.int8(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Vec128<T> vUInt8<T>(T[] data, int offset)
            where T : struct, IEquatable<T>
        {
            var src = As.uint8(data);
            var i = offset;
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return As.generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vInt16<T>(T[] data,int offset)
            where T : struct, IEquatable<T>            
        {
            var i = offset;
            var src = As.int16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt16<T>(T[] data,int offset)
            where T : struct, IEquatable<T>            
        {
            var i = offset;
            var src = As.uint16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt32<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = As.int32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt32<T>(T[] data, int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = As.uint32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt64<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = As.int64(data);
            var dst = define(src[i++],src[i++]);
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt64<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = As.uint64(data);
            var dst = define(src[i++],src[i++]);
            return As.generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vFloat32<T>(T[] data, int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = As.float32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return As.generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vFloat64<T>(T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = As.float64(data);
            var dst = define(src[i++],src[i++]);
            return As.generic<T>(dst);
        }
    }
}