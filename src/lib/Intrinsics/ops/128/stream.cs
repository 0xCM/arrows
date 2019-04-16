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
    using static x86;

    partial class InX128G
    {
        /// <summary>
        /// Returns the stream operator
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InX128Stream<T> stream<T>()
            where T : struct, IEquatable<T>
                => InX128StreamG<T>.Operator;

        /// <summary>
        /// Applies the stream operator to an array
        /// </summary>
        /// <param name="lhs">The source array</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<T>> stream<T>(T[] src)
            where T : struct, IEquatable<T>
                => InX128StreamG<T>.TheOnly.stream(src);
    }

    public interface InX128Stream<T> : InX128Op<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// Constructs a stream of vectors predicated on an array
        /// </summary>
        /// <param name="src">The source data</param>
        IEnumerable<Vec128<T>> stream(T[] src);
    }

    /// <summary>
    /// The generic add operator via singleton reification
    /// </summary>
    readonly struct InX128StreamG<T> : InX128Stream<T>
        where T : struct, IEquatable<T>
    {
        public static readonly InX128Stream<T> Operator = cast<InX128Stream<T>>(InX128Stream.TheOnly);
        
        public static readonly InX128StreamG<T> TheOnly = default;

        [MethodImpl(Inline)]
        public IEnumerable<Vec128<T>> stream(T[] src)
            => Operator.stream(src);

    }

    public readonly struct InX128Stream : 
        InX128Stream<byte>,
        InX128Stream<sbyte>,
        InX128Stream<short>,
        InX128Stream<ushort>,
        InX128Stream<int>,
        InX128Stream<uint>,
        InX128Stream<long>,
        InX128Stream<ulong>,
        InX128Stream<float>,
        InX128Stream<double>

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


    partial class InX
    {

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<sbyte>> stream(sbyte[] src)
            => map(range(0, src.Length, Vec128<sbyte>.Length),i => load(src,i));    
            
        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<byte>> stream(byte[] src)
            => map(range(0, src.Length, Vec128<byte>.Length),i => load(src,i));    

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<short>> stream(short[] src)
            => map(range(0, src.Length, Vec128<short>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<ushort>> stream(ushort[] src)
            => map(range(0, src.Length, Vec128<ushort>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<int>> stream(int[] src)
            => map(range(0, src.Length, Vec128<int>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<uint>> stream(uint[] src)
            => map(range(0, src.Length, Vec128<uint>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<long>> stream(long[] src)
            => map(range(0, src.Length, Vec128<long>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<ulong>> stream(ulong[] src)
            => map(range(0, src.Length, Vec128<ulong>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<float>> stream(float[] src)
            => map(range(0, src.Length, Vec128<float>.Length),i => load(src,i));

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<double>> stream(double[] src)
            => map(range(0, src.Length, Vec128<double>.Length),i => load(src,i));


    }



}