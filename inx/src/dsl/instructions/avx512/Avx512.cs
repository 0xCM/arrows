//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static zfunc;

    public static partial class Avx512
    {
        [MethodImpl(Inline)]
        public static ref T asRef<T>(in T src)
            => ref Unsafe.AsRef(in src);

        [MethodImpl(Inline)]
        internal static ref Vec512<sbyte> int8<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        internal static ref Vec512<byte> uint8<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<short> int16<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<ushort> uint16<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref  Vec512<int> int32<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<uint> uint32<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<long> int64<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<ulong> uint64<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<float> float32<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<double> float64<T>(in Vec512<T> src)
            where T : struct        
                => ref Unsafe.As<Vec512<T>,Vec512<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec512<sbyte>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec512<byte>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<short> src)
            where T : struct        
                => ref Unsafe.As<Vec512<short>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec512<ushort>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<int> src)
            where T : struct        
                => ref Unsafe.As<Vec512<int>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec512<uint>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<long> src)
            where T : struct        
                => ref Unsafe.As<Vec512<long>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec512<ulong>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<float> src)
            where T : struct        
                => ref Unsafe.As<Vec512<float>,Vec512<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec512<T> generic<T>(in Vec512<double> src)
            where T : struct        
                => ref Unsafe.As<Vec512<double>,Vec512<T>>(ref asRef(in src));
    }

}
