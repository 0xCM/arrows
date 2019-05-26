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

    partial class Vec256
    {
        [MethodImpl(Inline)]
        public static Vec256<T> single<T>(T[] src, int block = 0)
            where T : struct  
                => single(src, block, out Vec256<T> dst);

        [MethodImpl(Inline)]
        public static Vec256<T> single<T>(in ReadOnlySpan256<T> src, int block = 0)
            where T : struct  
                => single(in src, block, out Vec256<T> dst);

        [MethodImpl(Inline)]
        public static Vec256<T> single<T>(in Span256<T> src, int block = 0)
            where T : struct  
                => single(src, block, out Vec256<T> dst);

        [MethodImpl(Inline)]
        public static ref Vec256<T> single<T>(in ReadOnlySpan256<T> src, int block, out Vec256<T> dst)
            where T : struct
        {            
            var kind = PrimalKinds.kind<T>();
            ref var head = ref asRef(in src.Block(block));            
            if(kind.IsFloat())
                return ref singleFloat(kind, src, ref head, out dst);
            else if(kind.IsSmallInt())
                return ref singleSmall(kind, src, ref head, out dst);
            else
                return ref singleLarge(kind, src, ref head, out dst);                            
            throw unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<T> single<T>(in Span256<T> src, int block, out Vec256<T> dst)
            where T : struct
        {            
            var kind = PrimalKinds.kind<T>();
            ref var head = ref asRef(in src.Block(block));            
            if(kind.IsFloat())
                return ref singleFloat(kind, src, ref head, out dst);
            else if(kind.IsSmallInt())
                return ref singleSmall(kind, src, ref head, out dst);
            else
                return ref singleLarge(kind, src, ref head, out dst);                            
            throw unsupported(kind);
        }        

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load(ref sbyte head)
            => LoadVector256(pint8(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(ref byte head)
            => LoadVector256(puint8(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(ref short head)
            => LoadVector256(pint16(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(ref ushort head)
            => LoadVector256(puint16(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(ref int head)
            => LoadVector256(pint32(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(ref uint head)
            => LoadVector256(puint32(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(ref long head)
            => LoadVector256(pint64(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(ref ulong head)
            => LoadVector256(puint64(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(ref float head)
            => LoadVector256(pfloat32(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(ref double head)
            => LoadVector256(pfloat64(ref head));
        

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load(short* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load(ushort* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load(int* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load(uint* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load(long* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load(ulong* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> load(float* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> load(double* src)
            => LoadVector256(src);


        [MethodImpl(Inline)]
        static ref Vec256<T> singleFloat<T>(PrimalKind kind, in ReadOnlySpan256<T> src, ref T head, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dst = generic<T>(load(ref float32(ref head)));
            else if(kind == PrimalKind.float64)
                dst = generic<T>(load(ref float64(ref head)));
            else throw unsupported(kind);
            return ref dst;

        }

        [MethodImpl(Inline)]
        static ref Vec256<T> singleSmall<T>(PrimalKind kind, in ReadOnlySpan256<T> src, ref T head, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int8)
                dst = generic<T>(load(ref int8(ref head)));
            else if(kind == PrimalKind.uint8)
                dst = generic<T>(load(ref uint8(ref head)));
            else if(kind == PrimalKind.int16)
                dst = generic<T>(load(ref int16(ref head)));
            else if(kind == PrimalKind.uint16)
                dst = generic<T>(load(ref uint16(ref head)));
            else throw unsupported(kind);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Vec256<T> singleLarge<T>(PrimalKind kind, in ReadOnlySpan256<T> src, ref T head, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dst = generic<T>(load(ref int32(ref head)));
            else if(kind == PrimalKind.uint32)
                dst = generic<T>(load(ref uint32(ref head)));
            else if(kind == PrimalKind.int64)
                dst = generic<T>(load(ref int64(ref head)));
            else if(kind == PrimalKind.uint64)
                dst = generic<T>(load(ref uint64(ref head)));
            else throw unsupported(kind);
            return ref dst;
        }

 
        [MethodImpl(Inline)]
        static ref Vec256<T> singleFloat<T>(PrimalKind kind, in Span256<T> src, ref T head, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.float32)
                dst = generic<T>(load(ref float32(ref head)));
            else if(kind == PrimalKind.float64)
                dst = generic<T>(load(ref float64(ref head)));
            else throw unsupported(kind);
            return ref dst;

        }

        [MethodImpl(Inline)]
        static ref Vec256<T> singleSmall<T>(PrimalKind kind, in Span256<T> src, ref T head, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int8)
                dst = generic<T>(load(ref int8(ref head)));
            else if(kind == PrimalKind.uint8)
                dst = generic<T>(load(ref uint8(ref head)));
            else if(kind == PrimalKind.int16)
                dst = generic<T>(load(ref int16(ref head)));
            else if(kind == PrimalKind.uint16)
                dst = generic<T>(load(ref uint16(ref head)));
            else throw unsupported(kind);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Vec256<T> singleLarge<T>(PrimalKind kind, in Span256<T> src, ref T head, out Vec256<T> dst)
            where T : struct
        {
            if(kind == PrimalKind.int32)
                dst = generic<T>(load(ref int32(ref head)));
            else if(kind == PrimalKind.uint32)
                dst = generic<T>(load(ref uint32(ref head)));
            else if(kind == PrimalKind.int64)
                dst = generic<T>(load(ref int64(ref head)));
            else if(kind == PrimalKind.uint64)
                dst = generic<T>(load(ref uint64(ref head)));
            else throw unsupported(kind);
            return ref dst;
        }

    }

}