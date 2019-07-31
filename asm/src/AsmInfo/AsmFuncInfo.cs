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
    /// Describes the assembly encoding for a function
    /// </summary>
    public class AsmFuncInfo
    {   
        public AsmFuncInfo(ulong StartAddress, ulong EndAddress, MethodSig Signature, AsmInstructionInfo[] Instructions, byte[] Encoding)
        {
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Signature = Signature;
            this.Instructions = Instructions;
            this.Encoding = Encoding;
        }

        /// <summary>
        /// The address at which the function definition begins
        /// </summary>
        public ulong StartAddress {get;}

        /// <summary>
        /// The address at which the function definition ends
        /// </summary>
        public ulong EndAddress {get;}

        /// <summary>
        /// The signature of the defined function
        /// </summary>
        public MethodSig Signature {get;}

        public string FunctionName
            => Signature.MethodName;
        
        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
            => Instructions.Length;

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionInfo[] Instructions {get;}

        /// <summary>
        /// The instruction encoding
        /// </summary>
        public byte[] Encoding {get;}        
        
    }

}
