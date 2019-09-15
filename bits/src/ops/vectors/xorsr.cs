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
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> xorsr(in Vec128<ushort> src, byte offset)
            => xor(src,srl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> xorsr(in Vec128<uint> src, byte offset)
            => xor(src,srl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> xorsr(in Vec128<ulong> src, byte offset)
            => xor(src,srl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> xorsr(in Vec256<ushort> src, byte offset)
            => xor(src,srl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> xorsr(in Vec256<uint> src, byte offset)
            => xor(src,srl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> xorsr(in Vec256<ulong> src, byte offset)
            => xor(src,srl(src,offset));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> xorsrv(in Vec128<uint> src, in Vec128<uint> offsets)
            => xor(src, srlv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> xorsrv(in Vec128<ulong> src, in Vec128<ulong> offsets)
            => xor(src, srlv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> xorsrv(in Vec256<uint> src, in Vec256<uint> offsets)
            => xor(src,srlv(src,offsets));

        /// <summary>
        /// A composite operation that shifts the source vector components rightward
        /// by variable amounts and then computes the XOR between the original source vector and the shifted vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> xorsrv(in Vec256<ulong> src, in Vec256<ulong> offsets)
            => xor(src,srlv(src,offsets));
    }

}