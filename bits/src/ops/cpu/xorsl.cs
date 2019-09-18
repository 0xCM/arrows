//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static zfunc;    

    partial class Bits
    {
        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> xorsl(in Vec128<ushort> src, byte offset)
            => xor(src,sll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> xorsl(in Vec128<uint> src, byte offset)
            => xor(src,sll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> xorsl(in Vec128<ulong> src, byte offset)
            => xor(src,sll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> xorsl(in Vec256<ushort> src, byte offset)
            => xor(src,sll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> xorsl(in Vec256<uint> src, byte offset)
            => xor(src,sll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by a specified offset and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> xorsl(in Vec256<ulong> src, byte offset)
            => xor(src,sll(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> xorslv(in Vec128<uint> src, in Vec128<uint> offsets)
            => xor(src, sllv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> xorslv(in Vec128<ulong> src, in Vec128<ulong> offsets)
            => xor(src, sllv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> xorslv(in Vec256<uint> src, in Vec256<uint> offsets)
            => xor(src,sllv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components leftward
        /// by variable offsets and then computes the XOR between the original source 
        /// vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> xorslv(in Vec256<ulong> src, in Vec256<ulong> offsets)
            => xor(src,sllv(src,offsets));

    }

}