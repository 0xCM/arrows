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

    
    using static mfunc;
    using static zfunc;
    using static As;

    public static class Vec128
    {
        const int Len8 = 16;
        const int Len16 = 8;
        const int Len32 = 4;
        const int Len64 = 2;

        static Exception badlen(int value)
            => new Exception($"Source array is of insufficent length = {value}");


        public static Vec128<T>[] exhaust<T>(T[] src)
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
        public static unsafe Vec128<T> zero<T>()
            where T : struct, IEquatable<T>                    
        {
            var space = new T[Vec128<T>.Length];
            return define(ref space);
            
        }
            
        [MethodImpl(Inline)]
        public static Vec128<T> define<T>(Vector128<T> src)
            where T : struct, IEquatable<T>            
                => src.ToVec128();


        [MethodImpl(Inline)]
        public static unsafe Vec128<T> define<T>(Span128<T> src, int blockOffset = 0)
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


        [MethodImpl(Inline)]
        public static unsafe Vec128<T> define<T>(ref T[] src, int offset = 0)
            where T : struct, IEquatable<T>
        {            

            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return vInt8(ref src,offset);
                case PrimalKind.uint8:
                    return vUInt8(ref src,offset);
                case PrimalKind.int16:
                    return vInt16(ref src,offset);
                case PrimalKind.uint16:
                    return vUInt16(ref src,offset);
                case PrimalKind.int32:
                    return vInt32(ref src,offset);
                case PrimalKind.uint32:
                    return vUInt32(ref src,offset);
                case PrimalKind.int64:
                    return vInt64(ref src,offset);
                case PrimalKind.uint64:
                    return vUInt64(ref src,offset);
                case PrimalKind.float32:
                    return vFloat32(ref src,offset);
                case PrimalKind.float64:                
                    return vFloat64(ref src,offset);
                default:
                    throw new Exception($"Kind {kind} not supported");
            }
        }        

        

        [MethodImpl(Inline)]
        public static Num128<T> scalar<T>(Vec128<T> src, int index)
            where T : struct, IEquatable<T>            
                => Num128.define(src[index]);

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(params T[] src)
            where T : struct, IEquatable<T>            
                => define<T>(src);

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(T[] src, int offset = 0)
            where T : struct, IEquatable<T>            
                => define<T>(src,offset);

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(Span128<T> src, int blockIndex)
            where T : struct, IEquatable<T>            
                => define<T>(src.Block(blockIndex));


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
        public static unsafe Vec128<sbyte> define(
                sbyte x00, sbyte x01, sbyte x02, sbyte x03, 
                sbyte x04, sbyte x05, sbyte x06, sbyte x07,
                sbyte x08, sbyte x09, sbyte x10, sbyte x11,
                sbyte x12, sbyte x13, sbyte x14, sbyte x15)
                    => Vector128.Create(
                        x00, x01, x02, x03, x04, x05, x06, x07, 
                        x08, x09, x10, x11,x12, x13, x14, x15);


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
        public static unsafe Vec128<ushort> define(
                ushort x0, ushort x1, ushort x2, ushort x3, 
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
        static Vec128<T> vInt8<T>(ref T[] data, int offset)
            where T : struct, IEquatable<T>
        {
            var i = offset;
            var src = int8(ref data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Vec128<T> vUInt8<T>(ref T[] data, int offset)
            where T : struct, IEquatable<T>
        {
            var src = uint8(data);
            var i = offset;
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
            );
            return generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vInt16<T>(ref T[] data,int offset)
            where T : struct, IEquatable<T>            
        {
            var i = offset;
            var src = int16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt16<T>(ref T[] data,int offset)
            where T : struct, IEquatable<T>            
        {
            var i = offset;
            var src = uint16(data);
            var dst = define(
                src[i++],src[i++],src[i++],src[i++],
                src[i++],src[i++],src[i++],src[i++]
                );
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt32<T>(ref T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = int32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt32<T>(ref T[] data, int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = uint32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vInt64<T>(ref T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = int64(data);
            var dst = define(src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vUInt64<T>(ref T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = uint64(data);
            var dst = define(src[i++],src[i++]);
            return generic<T>(dst);
        }


        [MethodImpl(Inline)]
        static Vec128<T> vFloat32<T>(ref T[] data, int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = float32(data);
            var dst = define(src[i++],src[i++],src[i++],src[i++]);
            return generic<T>(dst);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vFloat64<T>(ref T[] data,int startpos)
            where T : struct, IEquatable<T>            
        {
            var i = startpos;
            var src = float64(data);
            var dst = define(src[i++],src[i++]);
            return generic<T>(dst);
        }


        [MethodImpl(Inline)]
        public static unsafe ref Vec128<int> add(ref Vec128<int> lhs, in Vec128<int> rhs)
        {
            dinx.store(dinx.add(lhs,rhs), pint32(ref lhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<int> sub(ref Vec128<int> lhs, in Vec128<int> rhs)
        {
            dinx.store(dinx.sub(lhs,rhs), pint32(ref lhs));
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static unsafe ref Vec128<int> mul(ref Vec128<int> lhs, in Vec128<int> rhs)
        {
            dinx.store(dinx.sub(lhs,rhs), pint32(ref lhs));
            return ref lhs;
        }

    }
}