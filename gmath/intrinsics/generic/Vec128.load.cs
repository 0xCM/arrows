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

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static mfunc;
    using static zfunc;
    using static As;

    partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(params T[] src)
            where T : struct            
                => single<T>(src.ToSpan128());
        
        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(in ReadOnlySpan128<T> src, int blockIndex = 0)
            where T : struct
        {            
            var kind = PrimalKinds.kind<T>();
            ref var head = ref asRef(in src.Block(blockIndex));
            if(kind.IsFloat())
            {
                if(kind == PrimalKind.float32)
                    return generic<T>(load(ref float32(ref head)));
                else if(kind == PrimalKind.float64)
                    return generic<T>(load(ref float64(ref head)));
            }       
            else if(kind.IsSmallInt())
            {
                if(kind == PrimalKind.int8)
                    return generic<T>(load(ref int8(ref head)));
                else if(kind == PrimalKind.uint8)
                    return generic<T>(load(ref uint8(ref head)));
                else if(kind == PrimalKind.int16)
                    return generic<T>(load(ref int16(ref head)));
                else if(kind == PrimalKind.uint16)
                    return generic<T>(load(ref uint16(ref head)));
            }
            else
            {
                if(kind == PrimalKind.int32)
                    return generic<T>(load(ref int32(ref head)));
                else if(kind == PrimalKind.uint32)
                    return generic<T>(load(ref uint32(ref head)));
                else if(kind == PrimalKind.int64)
                    return generic<T>(load(ref int64(ref head)));
                else if(kind == PrimalKind.uint64)
                    return generic<T>(load(ref uint64(ref head)));
            }
                
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(in Span128<T> src, int blockIndex = 0)
            where T : struct
        {            

            var kind = PrimalKinds.kind<T>();
            ref var head = ref src.Block(blockIndex);
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(load(ref int8(ref head)));
                case PrimalKind.uint8:
                    return generic<T>(load(ref uint8(ref head))); 
                case PrimalKind.int16:
                    return generic<T>(load(ref int16(ref head)));
                case PrimalKind.uint16:
                    return generic<T>(load(ref uint16(ref head)));
                case PrimalKind.int32:
                    return generic<T>(load(ref int32(ref head)));
                case PrimalKind.uint32:
                    return generic<T>(load(ref uint32(ref head)));
                case PrimalKind.int64:
                    return generic<T>(load(ref int64(ref head)));
                case PrimalKind.uint64:
                    return generic<T>(load(ref uint64(ref head)));
                case PrimalKind.float32:
                    return generic<T>(load(ref float32(ref head)));
                case PrimalKind.float64:                
                    return generic<T>(load(ref float64(ref head)));
                default:
                    throw unsupported(kind);
            }
        }        


       public static Vec128<T>[] exhaust<T>(T[] src)
            where T : struct
        {
            var vLen = Vec128<T>.Length;
            var count = src.Length / vLen;
            var dst = alloc<Vec128<T>>(count);
            var j = 0;
            for(var i = 0; i < src.Length; i += vLen, j++)
                dst[j] = define<T>(src,i);
            return dst;
        }

       [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(byte* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load(sbyte* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(short* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ushort* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(int* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(uint* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(long* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ulong* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(float* src)
            => LoadVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(double* src)
            => Avx2.LoadVector128(src);

 
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
 

    }

}