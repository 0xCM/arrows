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
    
    using static zcore;
    using static inxfunc;

    partial class InXG
    {

        /// <summary>
        /// Obtains the load[T] operator bundle where
        /// T: sbyte | byte | short | ushort | int | uint | long | ulong | single | double
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXLoad<T> load<T>()
            where T : struct, IEquatable<T>
                => SSR.InXLoadG<T>.Operator;

        /// <summary>
        /// Loads a vector from a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> load<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXLoadG<T>.TheOnly.load(src);


    }

    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InXLoadG<T> : InXLoad<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXLoad<T> Operator = cast<InXLoad<T>>(InXLoad.TheOnly);
            
            public static readonly InXLoadG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> load(Span128<T> src)
                => Operator.load(src);

            [MethodImpl(Inline)]
            public Vec128<T> load(params T[] src)
                => Operator.load(src);

            [MethodImpl(Inline)]
            public Vec128<T> load(T[] src, int offset = 0)
                => Operator.load(src,offset);
        }

        public readonly struct InXLoad : 
            InXLoad<byte>,
            InXLoad<sbyte>,
            InXLoad<short>,
            InXLoad<ushort>,
            InXLoad<int>,
            InXLoad<uint>,
            InXLoad<long>,
            InXLoad<ulong>,
            InXLoad<float>,
            InXLoad<double>
        {        
            public static readonly InXLoad TheOnly = default;

            [MethodImpl(Inline)]
            public Vec128<byte> load(Span128<byte> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<sbyte> load(Span128<sbyte> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<short> load(Span128<short> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<ushort> load(Span128<ushort> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<int> load(Span128<int> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<uint> load(Span128<uint> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<long> load(Span128<long> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<ulong> load(Span128<ulong> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<float> load(Span128<float> src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<double> load(Span128<double> src)
                => InX.load(src);


            [MethodImpl(Inline)]
            public Vec128<byte> load(params byte[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<sbyte> load(params sbyte[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<short> load(params short[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<ushort> load(params ushort[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<int> load(params int[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<uint> load(params uint[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<long> load(params long[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<ulong> load(params ulong[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<float> load(params float[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<double> load(params double[] src)
                => InX.load(src);

            [MethodImpl(Inline)]
            public Vec128<byte> load(byte[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<sbyte> load(sbyte[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<short> load(short[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<ushort> load(ushort[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<int> load(int[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<uint> load(uint[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<long> load(long[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<ulong> load(ulong[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<float> load(float[] src, int offset = 0)
                => InX.load(src,offset);

            [MethodImpl(Inline)]
            public Vec128<double> load(double[] src, int offset = 0)
                => InX.load(src,offset);

        }

    }

}

