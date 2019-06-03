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
    
    using static zfunc;
    using static As;
    using static AsInX;

    partial class Vec128
    {
        [MethodImpl(Inline)]
        public static ref Vec128<T> single<T>(in ReadOnlySpan128<T> src, int block, out Vec128<T> dst)
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
            else throw unsupported(PrimalKinds.kind<T>());
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static unsafe ref Vec128<T> single<T>(in Span128<T> src, int block, out Vec128<T> dst)
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
            else throw unsupported(PrimalKinds.kind<T>());
            return ref dst;
        }        


        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(T[] src, int block = 0)
            where T : struct  
                => single(src, block, out Vec128<T> dst);

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(in ReadOnlySpan128<T> src, int block = 0)
            where T : struct  
                => single(in src, block, out Vec128<T> dst);

        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(in Span128<T> src, int block = 0)
            where T : struct  
                => single(src, block, out Vec128<T> dst);

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