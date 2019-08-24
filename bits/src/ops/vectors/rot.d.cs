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
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> rotr(Vec128<ushort> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.slli(in src, (byte)(16 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotr(Vec128<uint> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.slli(in src, (byte)(32 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotr(Vec128<ulong> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.slli(in src, (byte)(64 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> rotr(Vec256<ushort> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.slli(in src, (byte)(16 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotr(Vec256<uint> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.slli(in src, (byte)(32 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotr(Vec256<ulong> src, byte offset)
        {
            var x = Bits.srli(in src, offset);
            var y = Bits.slli(in src, (byte)(64 - offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> rotl(Vec128<ushort> src, byte offset)
        {
            var x = Bits.slli(in src, offset);
            var y = Bits.srli(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotl(Vec128<uint> src, byte offset)
        {
            var x = Bits.slli(in src, offset);
            var y = Bits.srli(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotl(Vec128<ulong> src, byte offset)
        {
            var x = Bits.slli(in src, offset);
            var y = Bits.srli(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> rotl(Vec256<ushort> src, byte offset)
        {
            var x = Bits.slli(in src, offset);
            var y = Bits.srli(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotl(Vec256<uint> src, byte offset)
        {
            var x = Bits.slli(in src, offset);
            var y = Bits.srli(in src, (byte)(32-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotl(Vec256<ulong> src, byte offset)
        {
            var x = Bits.slli(in src, offset);
            var y = Bits.srli(in src, (byte)(64-offset));   
            return Bits.or(x,y);             
        }

    }

}