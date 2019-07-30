//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Describes an operand in the context of an assembly instruction
    /// </summary>
    public class AsmOperand
    {
        public AsmOperand(byte Index, string Kind, Option<AsmOperandImm> imminfo, 
            Option<AsmOperandMemory> Memory, Option<AsmOperandRegister> register, Option<AsmBranch> branch)
        {
            this.Index = Index;
            this.Kind = Kind;
            this.ImmInfo = imminfo;
            this.Memory = Memory;
            this.Register = register;
            this.Branch = branch;
        }
        
        /// <summary>
        /// The 0-based operand position
        /// </summary>
        public byte Index {get;}

        /// <summary>
        /// Classifies the operand
        /// </summary>
        public string Kind {get;}

        /// <summary>
        /// Operand immediate info, if applicable
        /// </summary>
        public Option<AsmOperandImm> ImmInfo {get;}

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public Option<AsmOperandMemory> Memory {get;}
        
        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public Option<AsmOperandRegister> Register;

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public Option<AsmBranch> Branch {get;}
    }

}