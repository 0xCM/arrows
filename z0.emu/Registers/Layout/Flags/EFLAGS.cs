//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.InteropServices;

    using static BitWidth;
    
    partial class Registers
    {
        /// <summary>
        /// Stack segment register - pointer to stack
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct EFLAGS : ICpuReg32
        {
            [FieldOffset(0)]
            public uint flags;            
        }

        public enum EFLAG : byte
        {
            [Info("Carry Flag")]
            CF = 0,

            [Info("Parity Flag")]
            PF = 2,
            
            [Info("Adjust Flag")]
            AF = 4,

            [Info("Zero Flag")]
            ZF = 6,

            [Info("Sign Flag")]
            SF = 7,

            [Info("Trap Flag")]
            TF = 8,

            [Info("Interupt Flag")]
            IF = 9,

            [Info("Direction Flag")]
            DF = 10,

            [Info("Overflow Flag")]
            OF = 11,
        }
    }
}