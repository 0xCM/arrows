//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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
    public class AsmOperandInfo
    {
        public AsmOperandInfo(byte Index, string Kind, Option<AsmImmInfo> imminfo, 
            Option<AsmMemInfo> Memory, Option<AsmRegisterInfo> register, Option<AsmBranchInfo> branch)
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
        public Option<AsmImmInfo> ImmInfo {get;}

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public Option<AsmMemInfo> Memory {get;}
        
        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public Option<AsmRegisterInfo> Register;

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public Option<AsmBranchInfo> Branch {get;}
    }

}