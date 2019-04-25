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
        /// Defines a stream of vectors over an array
        /// </summary>
        /// <param name="lhs">The source array</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<T>> stream128<T>(T[] src)
            where T : struct, IEquatable<T>
                => SSR.InX128StreamG<T>.TheOnly.stream(src); 

    }

    partial class SSR
    {

        /// <summary>
        /// The generic add operator via singleton reification
        /// </summary>
        public readonly struct InX128StreamG<T> : InXStream<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXStream<T> Operator = cast<InXStream<T>>(InX128Stream.TheOnly);
            
            public static readonly InX128StreamG<T> TheOnly = default;

            [MethodImpl(Inline)]
            public IEnumerable<Vec128<T>> stream(T[] src)
                => Operator.stream(src);

        }

        public readonly struct InX128Stream : 
            InXStream<byte>,
            InXStream<sbyte>,
            InXStream<short>,
            InXStream<ushort>,
            InXStream<int>,
            InXStream<uint>,
            InXStream<long>,
            InXStream<ulong>,
            InXStream<float>,
            InXStream<double>

        {
            public static readonly InX128Stream TheOnly = default;

            public IEnumerable<Vec128<sbyte>> stream(sbyte[] src)
                => map(range(0, src.Length, Vec128<sbyte>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<byte>> stream(byte[] src)
                => map(range(0, src.Length, Vec128<byte>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<short>> stream(short[] src)
                => map(range(0, src.Length, Vec128<short>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<ushort>> stream(ushort[] src)
                => map(range(0, src.Length, Vec128<ushort>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<int>> stream(int[] src)
                => map(range(0, src.Length, Vec128<int>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<uint>> stream(uint[] src)
                => map(range(0, src.Length, Vec128<uint>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<long>> stream(long[] src)
                => map(range(0, src.Length, Vec128<long>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<ulong>> stream(ulong[] src)
                => map(range(0, src.Length, Vec128<ulong>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<float>> stream(float[] src)
                => map(range(0, src.Length, Vec128<float>.Length),i => InX.load(src,i));    

            public IEnumerable<Vec128<double>> stream(double[] src)
                => map(range(0, src.Length, Vec128<double>.Length),i => InX.load(src,i));    
        }
    }

}