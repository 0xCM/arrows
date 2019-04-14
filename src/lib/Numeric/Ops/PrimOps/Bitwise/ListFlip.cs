namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using static zcore;

    partial class PrimalList
    {

        [MethodImpl(Inline)]
        public static IReadOnlyList<sbyte> Flip(this IReadOnlyList<sbyte> src)
            => map(src,x => (sbyte) ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<byte> Flip(this IReadOnlyList<byte> src)
            => map(src,x => (byte) ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<short> Flip(this IReadOnlyList<short> src)
            => map(src,x => (short) ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<ushort> Flip(this IReadOnlyList<ushort> src)
            => map(src,x => (ushort) ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> Flip(this IReadOnlyList<int> src)
            => map(src,x =>  ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<uint> Flip(this IReadOnlyList<uint> src)
            => map(src,x =>  ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<long> Flip(this IReadOnlyList<long> src)
            => map(src,x =>  ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<ulong> Flip(this IReadOnlyList<ulong> src)
            => map(src,x =>  ~x );

        [MethodImpl(Inline)]
        public static IReadOnlyList<BigInteger> Flip(this IReadOnlyList<BigInteger> src)
            => map(src,x =>  ~x );

    }    
}