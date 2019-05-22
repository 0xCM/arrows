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

    public static partial class As
    {

        [MethodImpl(Inline)]
        internal static Num256<sbyte> int8<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<sbyte> int8<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<byte> uint8<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<byte> uint8<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<short> int16<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<short> int16<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<ushort> uint16<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<ushort> uint16<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<int> int32<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<int> int32<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<uint> uint32<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<uint> uint32<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<long> int64<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<long> int64<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<ulong> uint64<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<ulong> uint64<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<float> float32<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<float> float32<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<double> float64<T>(Num256<T> src)
            where T : struct        
                => Unsafe.As<Num256<T>,Num256<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<double> float64<T>(ref Num256<T> src)
            where T : struct        
                => ref Unsafe.As<Num256<T>,Num256<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<sbyte> src)
            where T : struct        
            => Unsafe.As<Num256<sbyte>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<sbyte> src)
            where T : struct        
            => ref Unsafe.As<Num256<sbyte>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<byte> src)
            where T : struct        
            => Unsafe.As<Num256<byte>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<byte> src)
            where T : struct        
            => ref Unsafe.As<Num256<byte>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<short> src)
            where T : struct        
            => Unsafe.As<Num256<short>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<short> src)
            where T : struct        
            => ref Unsafe.As<Num256<short>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<ushort> src)
            where T : struct        
            => Unsafe.As<Num256<ushort>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<ushort> src)
            where T : struct        
            => ref Unsafe.As<Num256<ushort>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<int> src)
            where T : struct        
            => Unsafe.As<Num256<int>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<int> src)
            where T : struct        
            => ref Unsafe.As<Num256<int>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<uint> src)
            where T : struct        
            => Unsafe.As<Num256<uint>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<uint> src)
            where T : struct        
            => ref Unsafe.As<Num256<uint>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<long> src)
            where T : struct        
            => Unsafe.As<Num256<long>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<long> src)
            where T : struct        
            => ref Unsafe.As<Num256<long>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<ulong> src)
            where T : struct        
            => Unsafe.As<Num256<ulong>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<ulong> src)
            where T : struct        
            => ref Unsafe.As<Num256<ulong>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<float> src)
            where T : struct        
            => Unsafe.As<Num256<float>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<float> src)
            where T : struct        
            => ref Unsafe.As<Num256<float>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<double> src)
            where T : struct        
            => Unsafe.As<Num256<double>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<double> src)
            where T : struct        
            => ref Unsafe.As<Num256<double>,Num256<T>>(ref src);

    }

}