//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;

    partial class InXG
    {

        /// <summary>
        /// Obtains the generic store operator for a parametric primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXStore<T> store<T>()
            where T : struct, IEquatable<T>
                => SSR.InXStoreG<T>.Operator;

        /// <summary>
        /// Writes data data in a source vector to a target array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The position in the target array where receipt of source data can begin</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void store<T>(Vec128<T> src, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => SSR.InXStoreG<T>.TheOnly.store(src, dst, offset);

        /// <summary>
        /// Writes data data in a list of source vectors to a target array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target array</param>
        /// <param name="offset">The position in the target array where receipt of source data can begin</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static void store<T>(Index<Vec128<T>> src, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => SSR.InXStoreG<T>.TheOnly.store(src, dst, offset);

    }

    partial class SSR
    {

        /// <summary>
        /// The generic add operator via singleton reification
        /// </summary>
        public readonly struct InXStoreG<T> : InXStore<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXStore<T> Operator = cast<InXStore<T>>(InXStore.TheOnly);
            
            public static readonly InXStoreG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public void store(in Vec128<T> src, T[] dst, int offset = 0)
                => Operator.store(src,dst,offset);

            [MethodImpl(Inline)]
            public void store(in Index<Vec128<T>> src, T[] dst, int offset = 0)
                => Operator.store(src,dst,offset);
        }

        public readonly struct InXStore : 
            InXStore<byte>,
            InXStore<sbyte>,
            InXStore<short>,
            InXStore<ushort>,
            InXStore<int>,
            InXStore<uint>,
            InXStore<long>,
            InXStore<ulong>,
            InXStore<float>,
            InXStore<double>

        {
            public static readonly InXStore TheOnly = default;


            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<sbyte> src, sbyte[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<sbyte>> src, sbyte[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<byte> src, byte[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<byte>> src, byte[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<short> src, short[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<short>> src, short[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<ushort> src, ushort[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<ushort>> src, ushort[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<int> src, int[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<int>> src, int[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<uint> src, uint[] dst, int offset = 0)
                => InX.store(src,dst,offset);            

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<uint>> src, uint[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<long> src, long[] dst, int offset = 0)
                => InX.store(src,dst,offset);
            
            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<long>> src, long[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<ulong> src, ulong[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<ulong>> src, ulong[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<float> src, float[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<float>> src, float[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Vec128<double> src, double[] dst, int offset = 0)
                => InX.store(src,dst,offset);

            [MethodImpl(Inline)]
            public unsafe void store(in Index<Vec128<double>> src, double[] dst, int offset = 0)
                => InX.store(src,dst,offset);

 
        }

    }
}
