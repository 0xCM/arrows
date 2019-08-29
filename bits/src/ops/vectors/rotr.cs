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
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> rotr(in Vec128<ushort> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(16 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotr(in Vec128<uint> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(32 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotr(in Vec128<ulong> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(64 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotr(in Vec128<uint> src, Vec128<uint> offsets)
        {
            var x = Bits.srlv(in src, offsets);
            var y = Bits.sllv(in src, dinx.sub(Vec128u32, offsets));
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotr(in Vec128<ulong> src, in Vec128<ulong> offsets)
        {
            var x = Bits.srlv(in src, offsets);
            var y = Bits.sllv(in src, dinx.sub(Vec128u64, offsets));
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> rotr(in Vec256<byte> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(8 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> rotr(in Vec256<ushort> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(16 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotr(in Vec256<uint> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(32 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotr(in Vec256<ulong> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.sll(in src, (byte)(64 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotr(in Vec256<uint> src, in Vec256<uint> offsets)
        {
            var x = Bits.srlv(in src, offsets);
            var y = Bits.sllv(in src, dinx.sub(Vec256u32, offsets));
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotr(in Vec256<ulong> src, in Vec256<ulong> offsets)
        {
            var x = Bits.srlv(in src, offsets);
            var y = Bits.sllv(in src, dinx.sub(Vec256u64, offsets));
            return Bits.or(x,y);             
        }
    }

}