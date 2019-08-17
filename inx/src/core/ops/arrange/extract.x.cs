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
            
    using static zfunc;
    
    partial class dinxx
    {

        [MethodImpl(Inline)]
        public static byte Extract(this Vec128<byte> src, int index)
            => Sse41.Extract(src,(byte)index);

        [MethodImpl(Inline)]
        public static uint Extract(this Vec128<ushort> src, int index)
            => Sse2.Extract(src,(byte)index);

        [MethodImpl(Inline)]
        public static int Extract(this Vec128<int> src, int index)
            => Sse41.Extract(src,(byte)index);

        [MethodImpl(Inline)]
        public static uint Extract(this Vec128<uint> src, int index)
            => Sse41.Extract(src,(byte)index);

        [MethodImpl(Inline)]
        public static long Extract(this Vec128<long> src, int index)
            => Sse42.X64.Extract(src,(byte)index);

        [MethodImpl(Inline)]
        public static ulong Extract(this Vec128<ulong> src, int index)
            => Sse42.X64.Extract(src,(byte)index);

        [MethodImpl(Inline)]
        public static float Extract(this Vec128<float> src, int index)
            => Sse41.Extract(src,(byte)index);

        /// <summary>
        /// Extracts the low 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ulong Lo(this Vec128<ulong> src)
            => Sse42.X64.Extract(src, 0);

        /// <summary>
        /// Extracts the high 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ulong Hi(this Vec128<ulong> src)
            => Sse42.X64.Extract(src,  1);

    }

}