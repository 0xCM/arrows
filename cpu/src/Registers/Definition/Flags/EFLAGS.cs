//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.InteropServices;

    
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
            /// <summary>
            /// Set if an arithmetic operation generates a carry or a borrow out of the mostsignificant
            /// bit of the result; cleared otherwise. This flag indicates an overflow condition for
            /// unsigned-integer arithmetic. It is also used in multiple-precision arithmetic
            ///</summary>
            [Info("Carry Flag")]            
            CF = 0,

            /// <summary>
            /// Set if the least-significant byte of the result contains an even number of 1 bits; cleared otherwise.
            ///</summary>
            [Info("Parity Flag")]
            PF = 2,
            
            /// <summary>
            ///  Set if an arithmetic operation generates a carry or a borrow out of bit. 3 of the result; cleared otherwise. 
            /// This flag is used in binary-coded decimal (BCD) arithmetic 
            ///</summary>
            [Info("Adjust Flag")]
            AF = 4,

            /// <summary>
            /// Set if the result is zero; cleared otherwise
            ///</summary>
            [Info("Zero Flag")]
            ZF = 6,

            /// <summary>
            /// Set equal to the most-significant bit of the result, which is the sign bit of a signed
            /// integer. (0 indicates a positive value and 1 indicates a negative value.)
            ///</summary>
            [Info("Sign Flag")]
            SF = 7,

            /// <summary>
            ///  Set to enable single-step mode for debugging; clear to disable single-step mode.
            ///</summary>
            [Info("Trap Flag")]
            TF = 8,

            /// <summary>
            ///
            ///</summary>
            [Info("Interupt Flag")]
            IF = 9,

            /// <summary>
            ///
            ///</summary>
            [Info("Direction Flag")]
            DF = 10,

            /// <summary>
            /// Set if the integer result is too large a positive number or too small a negative number 
            /// (excluding the sign-bit) to fit in the destination operand; cleared otherwise. This flag 
            /// indicates an overflow condition for signed-integer (two’s complement) arithmetic.
            ///</summary>
            [Info("Overflow Flag")]
            OF = 11,
        }
    }
}