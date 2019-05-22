//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static mfunc;
    using static zfunc;

    partial class As
    {

        [MethodImpl(Inline)]
        internal static ref Vec128<sbyte> int8<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        internal static ref Vec128<byte> uint8<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<short> int16<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<ushort> uint16<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref  Vec128<int> int32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<uint> uint32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<long> int64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<ulong> uint64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<float> float32<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<double> float64<T>(in Vec128<T> src)
            where T : struct        
                => ref Unsafe.As<Vec128<T>,Vec128<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<sbyte>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<byte>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<short> src)
            where T : struct        
                => ref Unsafe.As<Vec128<short>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ushort>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<int> src)
            where T : struct        
                => ref Unsafe.As<Vec128<int>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec128<uint>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<long> src)
            where T : struct        
                => ref Unsafe.As<Vec128<long>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ulong>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<float> src)
            where T : struct        
                => ref Unsafe.As<Vec128<float>,Vec128<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(in Vec128<double> src)
            where T : struct        
                => ref Unsafe.As<Vec128<double>,Vec128<T>>(ref asRef(in src));
    }
}