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
        public static Vec128<T> define<T>(Vector128<T> src)
            where T : struct            
                => src.ToVec128();


        [MethodImpl(Inline)]
        public static Vec128<T> single<T>(in Span128<T> src, int blockIndex = 0)
            where T : struct
        {            

            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return load(src.Block(blockIndex).As<sbyte>()).As<T>();                    
                case PrimalKind.uint8:
                    return load(src.Block(blockIndex).As<byte>()).As<T>();                    
                case PrimalKind.int16:
                    return load(src.Block(blockIndex).As<short>()).As<T>();                    
                case PrimalKind.uint16:
                    return load(src.Block(blockIndex).As<ushort>()).As<T>();                    
                case PrimalKind.int32:
                    return load(src.Block(blockIndex).As<int>()).As<T>();                    
                case PrimalKind.uint32:
                    return load(src.Block(blockIndex).As<uint>()).As<T>();                    
                case PrimalKind.int64:
                    return load(src.Block(blockIndex).As<long>()).As<T>();                    
                case PrimalKind.uint64:
                    return load(src.Block(blockIndex).As<ulong>()).As<T>();                    
                case PrimalKind.float32:
                    return load(src.Block(blockIndex).As<float>()).As<T>();                    
                case PrimalKind.float64:                
                    return load(src.Block(blockIndex).As<double>()).As<T>();                    
                default:
                    throw new Exception($"Kind {kind} not supported");
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
        public static unsafe Vec128<sbyte> load(ref sbyte head)
            => LoadVector128(pint8(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load(ref byte head)
            => LoadVector128(puint8(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load(ref short head)
            => LoadVector128(pint16(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load(ref ushort head)
            => LoadVector128(puint16(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load(ref int head)
            => LoadVector128(pint32(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load(ref uint head)
            => LoadVector128(puint32(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load(ref long head)
            => LoadVector128(pint64(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load(ref ulong head)
            => LoadVector128(puint64(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<float> load(ref float head)
            => LoadVector128(pfloat32(ref head));

        [MethodImpl(Inline)]
        public static unsafe Vec128<double> load(ref double head)
            => LoadVector128(pfloat64(ref head));
 
        [MethodImpl(Inline)]
        static unsafe Vec128<sbyte> load(Span128<sbyte> src)
            => LoadVector128(pint8(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<byte> load(Span128<byte> src)
            => LoadVector128(puint8(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<short> load(Span128<short> src)
            => LoadVector128(pint16(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<ushort> load(Span128<ushort> src)
            => LoadVector128(puint16(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<int> load(Span128<int> src)
            => LoadVector128(pint32(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<uint> load(Span128<uint> src)
            => LoadVector128(puint32(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<long> load(Span128<long> src)
            => LoadVector128(pint64(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<ulong> load(Span128<ulong> src)
            => LoadVector128(puint64(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<float> load(Span128<float> src)
            => LoadVector128(pfloat32(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec128<double> load(Span128<double> src)
            => LoadVector128(pfloat64(ref first(src))); 

    }

}