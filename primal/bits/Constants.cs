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
    
    partial class Bits
    {                
        /// <summary>
        ///  Defines a window over the lower four bits of a uint8
        /// </summary>
        public const byte LoMask8 = 0x0f;        

        /// <summary>
        ///  Defines a window over the upper four bits of a uint8
        /// </summary>
        public const byte HiMask8 = 0xf0;

        /// <summary>
        ///  Defines a window over the lower byte of a uint16
        /// </summary>
        public const ushort LoMask16 = 0x00ff;        

        /// <summary>
        ///  Defines a window over the upper byte of a uint16
        /// </summary>
        public const ushort HiMask16 = 0xff00;

        /// <summary>
        ///  Defines a window over the lower 2 bytes of a uint32
        /// </summary>
        public const uint LoMask32 = 0x0000ffffu;
        
        /// <summary>
        ///  Defines a window over the upper 2 bytes of a uint32
        /// </summary>
        public const uint HiMask32 = 0xffff0000u;

        /// <summary>
        ///  Defines a window over the lower 4 bytes of a uint32
        /// </summary>
        public const ulong LoMask64 = 0x00000000fffffffful;
        
        /// <summary>
        ///  Defines a window over the upper 4 bytes of a uint32
        /// </summary>
        public const ulong HiMask64 = 0xffffffff00000000ul;
             



    }

}