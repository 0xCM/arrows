//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Collections.Generic;
    
    using static zcore;
    using static inxfunc;

    partial class InX
    {

        static readonly SSR.InXStore StoreOp = SSR.InXStore.TheOnly;

        //! vec[T] -> T* -> void
        //! ---------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<float> src, float* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<double> src, double* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, byte* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, sbyte* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, short* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, ushort* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, int* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, uint* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, long* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, ulong* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, float* dst)
            => StoreOp.store(src,dst);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, double* dst)
            => StoreOp.store(src,dst);


        //! vec [T] -> [T]
        //! ---------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<float> src, float[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, sbyte[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, byte[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, short[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, ushort[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, int[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, uint[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, long[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, ulong[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, float[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, double[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        //! index[vec[T]] -> [T]
        //! ---------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<sbyte>> src, sbyte[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(Index<Vec128<byte>> src, byte[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<short>> src, short[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<ushort>> src, ushort[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<int>> src, int[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<uint>> src, uint[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<long>> src, long[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<ulong>> src, ulong[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<float>> src, float[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);


        [MethodImpl(Inline)]
        public static unsafe void store(in Index<Vec128<double>> src, double[] dst, int offset = 0)
            => StoreOp.store(src, dst,offset);


        //! vec[T] -> span[T]
        //! ---------------------------------------------------------------

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<byte> src, Span<byte> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<sbyte> src, Span<sbyte> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<short> src, Span<short> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ushort> src, Span<ushort> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<int> src, Span<int> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<uint> src, Span<uint> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<long> src, Span<long> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<ulong> src, Span<ulong> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<float> src, Span<float> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);

        [MethodImpl(Inline)]
        public static unsafe void store(in Vec128<double> src, Span<double> dst, int offset = 0)
            => StoreOp.store(src, dst,offset);
    }

}