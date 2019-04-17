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
    using static inX;


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