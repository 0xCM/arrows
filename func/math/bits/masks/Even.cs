//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static BitParts;

    public static partial class BitMasks
    {        

        /// <summary>
        /// Identifies the even bits in a nibble
        /// </summary>
        [Flags]
        public enum Even4x1 : byte
        {
            /// <summary>
            /// Identifies the first even bit
            /// </summary>
            Bit0 = Part4x1.Part0,
            
            /// <summary>
            /// Identifies the second even bit
            /// </summary>
            Bit2 = Bit0 << 2,
                        
                        
            /// <summary>
            /// Selects the even bits in a nibble
            /// </summary>
            Select = Bit0 |  Bit2 
        }

        /// <summary>
        /// Identifies the even bits in a byte
        /// </summary>
        [Flags]
        public enum Even8x1 : byte
        {
            /// <summary>
            /// Identifies the first even bit
            /// </summary>
            Bit0 = Part8x1.Part0,
            
            /// <summary>
            /// Identifies the second even bit
            /// </summary>
            Bit2 = Bit0 << 2,
                        
            /// <summary>
            /// Identifies third even bit
            /// </summary>
            Bit4 = Bit2 << 2,
                        
            /// <summary>
            /// Identifies the fourth even bit
            /// </summary>
            Bit6 = Bit4 << 2,
                        
            /// <summary>
            /// Selects the even bits in a byte
            /// </summary>
            Select = Bit0 |  Bit2 |  Bit4 | Bit6 

        }

        /// <summary>
        /// Identifies even bits in a 16-bit segment
        /// </summary>
        [Flags]
        public enum Even16x8 : ushort
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8x1.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Selects the even bits in a 16-bit segment
            /// </summary>
            Select = Byte0 | Byte1
        }

        /// <summary>
        /// Identifies even bits in a 32-bit segment
        /// </summary>
        [Flags]
        public enum Even32x8 : uint
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8x1.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the even bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the even bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Selects the even bits in a 32-bit segment
            /// </summary>
            Select = Byte0 | Byte1 | Byte2 | Byte3
        }
 
        /// <summary>
        /// Identifies even bits in a 64-bit segment
        /// </summary>
        [Flags]
        public enum Even64x8 : ulong
        {
            /// <summary>
            /// Identifies the even bits in the first byte
            /// </summary>
            Byte0 = Even8x1.Select,
            
            /// <summary>
            /// Identifies the even bits in the second byte
            /// </summary>
            Byte1 = Byte0 << 8,

            /// <summary>
            /// Identifies the even bits in the third byte
            /// </summary>
            Byte2 = Byte1 << 8,

            /// <summary>
            /// Identifies the even bits in the fourth byte
            /// </summary>
            Byte3 = Byte2 << 8,

            /// <summary>
            /// Identifies the even bits in the fifth byte
            /// </summary>
            Byte4 = Byte3 << 8,

            /// <summary>
            /// Identifies the even bits in the sixth byte
            /// </summary>
            Byte5 = Byte4 << 8,

            /// <summary>
            /// Identifies the even bits in the seventh byte
            /// </summary>
            Byte6 = Byte5 << 8,

            /// <summary>
            /// Identifies the even bits in the eighth byte
            /// </summary>
            Byte7 = Byte6 << 8,

            Select = Byte0 | Byte1 | Byte2 | Byte3 | Byte4 | Byte5 | Byte6 | Byte7
        }

    }

}