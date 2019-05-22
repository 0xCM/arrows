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
        internal static ref Vec256<sbyte> int8<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<sbyte>>(ref asRef(in src));
                
        [MethodImpl(Inline)]
        internal static ref Vec256<byte> uint8<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<byte>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<short> int16<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<short>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<ushort> uint16<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<ushort>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref  Vec256<int> int32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<int>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<uint> uint32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<uint>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<long> int64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<long>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<ulong> uint64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<ulong>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<float> float32<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<float>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<double> float64<T>(in Vec256<T> src)
            where T : struct        
                => ref Unsafe.As<Vec256<T>,Vec256<double>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<sbyte>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<byte>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<short> src)
            where T : struct        
                => ref Unsafe.As<Vec256<short>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ushort>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<int> src)
            where T : struct        
                => ref Unsafe.As<Vec256<int>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec256<uint>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<long> src)
            where T : struct        
                => ref Unsafe.As<Vec256<long>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ulong>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<float> src)
            where T : struct        
                => ref Unsafe.As<Vec256<float>,Vec256<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(in Vec256<double> src)
            where T : struct        
                => ref Unsafe.As<Vec256<double>,Vec256<T>>(ref asRef(in src));
    }
}