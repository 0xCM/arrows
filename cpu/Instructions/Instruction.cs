//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    [Flags]
    public enum OperandSize
    {
                
        /// <summary>
        /// 8 bits
        /// </summary>
        B8 = Pow2.T03,

        /// <summary>
        /// 16 bits
        /// </summary>
        B16 = Pow2.T04,

        /// <summary>
        /// 32 bits
        /// </summary>
        B32 = Pow2.T05,

        /// <summary>
        /// 64 bits
        /// </summary>
        B64 = Pow2.T06,

        /// <summary>
        /// 128 bits
        /// </summary>
        B128 = Pow2.T07,

        /// <summary>
        /// 256 bits
        /// </summary>
        B256 = Pow2.T08,

        /// <summary>
        /// 512 bits
        /// </summary>
        B512 = Pow2.T09,

    }

    [Flags]
    public enum OperandTarget
    {
        /// <summary>
        /// Either unknown or unnecessary
        /// </summary>
        None = 0,

        /// <summary>
        /// A general purpose 8-bit register
        /// </summary>
        GP8  = Pow2.T03,

        /// <summary>
        /// A general purpose 16-bit register
        /// </summary>
        GP16 = Pow2.T04,

        /// <summary>
        /// A general purpose 32-bit register
        /// </summary>
        GP32 = Pow2.T05,

        /// <summary>
        /// A general purpose 64-bit register
        /// </summary>
        GP64= Pow2.T06,

        /// <summary>
        /// A 128-bit xmm register
        /// </summary>
        XMM = Pow2.T07,

        /// <summary>
        /// A 256-bit ymm register
        /// </summary>
        YMM = Pow2.T08,

        /// <summary>
        /// A 512-bit zmm register
        /// </summary>
        ZMM = Pow2.T09,

        /// <summary>
        /// An 8-bit immediate
        /// </summary>
        IMM8 = Pow2.T03,

        /// <summary>
        /// A 128-bit memory location
        /// </summary>
        M128 = Pow2.T06,
        
        /// <summary>
        /// A 256-bit memory location
        /// </summary>
        M256 = Pow2.T07,
    }


    public enum OperandSlot
    {
        /// <summary>
        /// Either unknown or unnecessary
        /// </summary>
        None = 0,
        
        /// <summary>
        /// The first slot
        /// </summary>
        Slot1 = 1,

        /// <summary>
        /// The second slot
        /// </summary>
        Slot2 = 2,

        /// <summary>
        /// The third slot
        /// </summary>
        Slot3 = 3,

        /// <summary>
        /// The fourth slot
        /// </summary>
        Slot4 = 4
    }

    /// <summary>
    /// Characterizes an operand definition
    /// </summary>
    public readonly struct OperandSpec
    {
        public OperandSpec(OperandSlot slot, OperandTarget targets)
        {
            this.Slot = slot;
            this.Targets = targets;
        }

        /// <summary>
        /// The slot occupied by the operand
        /// </summary>
        public readonly OperandSlot Slot;

        /// <summary>
        /// The potential operand targets
        /// </summary>
        public readonly OperandTarget Targets;
    }

    public enum Mnemonic
    {
        VPERMPD,
    }


    public readonly struct InstructionSpec
    {
        public readonly Mnemonic Kind;

        public readonly OperandSpec Operand1;

        public readonly OperandSpec Operand2;

        public readonly OperandSpec Operand3;

        public readonly OperandSpec Operand4;
    
    
    }

    public abstract class Instruction
    {

    }

    public static partial class Instructions
    {
        public sealed class VPERMPD : Instruction
        {

        }

    }

}