//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    readonly struct RegOffsets
    {
        /// <summary>
        /// Specifies the identifier offset for RAX-enclosed registers
        /// </summary>
        public const ulong RAX = 0;
        
        /// <summary>
        /// Specifies the identifier offset for RBX-enclosed registers
        /// </summary>
        public const ulong RBX = 8;
        
        /// <summary>
        /// Specifies the identifier offset for RCX-enclosed registers
        /// </summary>
        public const ulong RCX = 16;

        /// <summary>
        /// Specifies the identifier offset for RDX-enclosed registers
        /// </summary>
        public const ulong RDX = 24;

        /// <summary>
        /// Specifies the identifier offset for RSI-enclosed registers
        /// </summary>
        public const ulong RSI = 32;

        /// <summary>
        /// Specifies the identifier offset for RDI-enclosed registers
        /// </summary>
        public const ulong RDI = 40;

        /// <summary>
        /// Specifies the identifier offset for RSP-enclosed registers
        /// </summary>
        public const ulong RSP = 48;

        /// <summary>
        /// Specifies the identifier offset for RBP-enclosed registers
        /// </summary>
        public const ulong RBP = 56;

        /// <summary>
        /// Specifies the identifier offset for R8-enclosed registers
        /// </summary>
        public const ulong R8 = 64;

        /// <summary>
        /// Specifies the identifier offset for R9-enclosed registers
        /// </summary>
        public const ulong R9 = 72;

        /// <summary>
        /// Specifies the identifier offset for R10-enclosed registers
        /// </summary>
        public const ulong R10 = 80;

        /// <summary>
        /// Specifies the identifier offset for R11-enclosed registers
        /// </summary>
        public const ulong R11 = 88;

        /// <summary>
        /// Specifies the identifier offset for R12-enclosed registers
        /// </summary>
        public const ulong R12 = 96;

        /// <summary>
        /// Specifies the identifier offset for R13-enclosed registers
        /// </summary>
        public const ulong R13 = 104;

        /// <summary>
        /// Specifies the identifier offset for R14-enclosed registers
        /// </summary>
        public const ulong R14 = 112;

        /// <summary>
        /// Specifies the identifier offset for R15-enclosed registers
        /// </summary>
        public const ulong R15 = 120;

        /// <summary>
        /// Specifies the identifier offset for control registers
        /// </summary>
        public const ulong Control = 128;

        /// <summary>
        /// Specifies the identifier offset for mask registers
        /// </summary>
        public const ulong Mask = 256;

        /// <summary>
        /// Specifies the identifier offset for XMM registers
        /// </summary>
        public const ulong XMM = Pow2.T10;

        /// <summary>
        /// Specifies the identifier offset for YMM registers
        /// </summary>
        public const ulong YMM = Pow2.T11;

        /// <summary>
        /// Specifies the identifier offset for ZMM registers
        /// </summary>
        public const ulong ZMM = Pow2.T12;

    }



}