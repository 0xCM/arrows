//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;


    partial class Registers
    {

       [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<sbyte>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec128<byte>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<short> src)
            where T : struct        
                => ref Unsafe.As<Vec128<short>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ushort>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<int> src)
            where T : struct        
                => ref Unsafe.As<Vec128<int>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec128<uint>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<long> src)
            where T : struct        
                => ref Unsafe.As<Vec128<long>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec128<ulong>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<float> src)
            where T : struct        
                => ref Unsafe.As<Vec128<float>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(ref Vec128<double> src)
            where T : struct        
                => ref Unsafe.As<Vec128<double>,Vec128<T>>(ref src);

 
         [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<sbyte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<sbyte>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<byte> src)
            where T : struct        
                => ref Unsafe.As<Vec256<byte>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<short> src)
            where T : struct        
                => ref Unsafe.As<Vec256<short>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<ushort> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ushort>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<int> src)
            where T : struct        
                => ref Unsafe.As<Vec256<int>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<uint> src)
            where T : struct        
                => ref Unsafe.As<Vec256<uint>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<long> src)
            where T : struct        
                => ref Unsafe.As<Vec256<long>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<ulong> src)
            where T : struct        
                => ref Unsafe.As<Vec256<ulong>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<float> src)
            where T : struct        
                => ref Unsafe.As<Vec256<float>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(ref Vec256<double> src)
            where T : struct        
                => ref Unsafe.As<Vec256<double>,Vec256<T>>(ref src);
    }

}