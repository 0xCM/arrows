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
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> rotl(in Vec128<ushort> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotl(in Vec128<uint> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotl(in Vec128<ulong> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotl(in Vec128<ulong> src, in Vec128<ulong> offsets)
        {
            var x = Bits.sllv(src,offsets);
            var y = Bits.srlv(src, dinx.sub(Vec128u64,offsets));
            return Bits.or(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotl(in Vec128<uint> src, in Vec128<uint> offsets)
        {
            var x = Bits.sllv(src,offsets);
            var y = Bits.srlv(src, dinx.sub(Vec128u32,offsets));
            return Bits.or(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> rotl(in Vec256<byte> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(8-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> rotl(in Vec256<ushort> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(16-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotl(in Vec256<uint> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(32-offset));   
            return Bits.or(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotl(in Vec256<ulong> src, byte offset)
        {
            var x = Bits.sll(in src, offset);
            var y = Bits.srl(in src, (byte)(64-offset));   
            return Bits.or(x,y);             
        }
        
        /// <summary>
        /// Rotates each component in the source vector leftwards by the 
        /// corresponding component in the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotl(in Vec256<ulong> src, in Vec256<ulong> offsets)
        {
            var x = Bits.sllv(src,offsets);
            var y = Bits.srlv(src, dinx.sub(Vec256u64,offsets));
            return Bits.or(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the 
        /// corresponding component in the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotl(in Vec256<uint> src, in Vec256<uint> offsets)
        {
            var x = Bits.sllv(src,offsets);
            var y = Bits.srlv(src, dinx.sub(Vec256u32,offsets));
            return Bits.or(x,y);
        }

        static readonly Vec128<uint> Vec128u32 = Vec128.Fill(32u);

        static readonly Vec128<ulong> Vec128u64 = Vec128.Fill(64ul);

        static readonly Vec256<uint> Vec256u32 = Vec256.Fill(32u);

        static readonly Vec256<ulong> Vec256u64 = Vec256.Fill(64ul);

    }

}