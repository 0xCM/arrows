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
    using static mfunc;
    using static As;

    partial class Vec256
    {
        [MethodImpl(Inline)]
        public static Vec256<T> single<T>(T[] src)
            where T : struct            
                => single(src.ToSpan256());

        [MethodImpl(Inline)]
        public static unsafe Vec256<T> single<T>(Span256<T> src, int blockIndex = 0)
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


        [MethodImpl(Inline)]
        static unsafe Vec256<sbyte> load(Span256<sbyte> src)
            => LoadVector256(pint8(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<byte> load(Span256<byte> src)
            => LoadVector256(puint8(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<short> load(Span256<short> src)
            => LoadVector256(pint16(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<ushort> load(Span256<ushort> src)
            => LoadVector256(puint16(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<int> load(Span256<int> src)
            => LoadVector256(pint32(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> load(Span256<uint> src)
            => LoadVector256(puint32(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<long> load(Span256<long> src)
            => LoadVector256(pint64(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<ulong> load(Span256<ulong> src)
            => LoadVector256(puint64(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<float> load(Span256<float> src)
            => LoadVector256(pfloat32(ref first(src)));

        [MethodImpl(Inline)]
        static unsafe Vec256<double> load(Span256<double> src)
            => LoadVector256(pfloat64(ref first(src)));
        

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
        public static unsafe Vec256<sbyte> load(sbyte* src)
            => LoadVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load(byte* src)
            => LoadVector256(src);

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


    }

}