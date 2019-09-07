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
    /// Represents an assembly instruction in the context of an <see cref='AsmFuncInfo' />
    /// </summary>
    public class AsmInstructionInfo
    {
        public AsmInstructionInfo(ushort Offset, string Display, string Mnemonic, string OpCode, AsmOperandInfo[] Operands, string EncodingKind, byte[] Encoding)
        {
            this.Offset = Offset;
            this.Display = Display;
            this.Mnemonic = Mnemonic;
            this.OpCode = OpCode;
            this.Operands = Operands;
            this.EncodingKind = EncodingKind;
            this.Encoding = Encoding;
        }
        
        /// <summary>
        /// The zero-based offset of the function, relative to the function address
        /// </summary>
        public ushort Offset {get;}

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public string Display {get;}

        /// <summary>
        /// The instruction mnemonic/class
        /// </summary>
        public string Mnemonic {get;}
        
        /// <summary>
        /// Idenfifies the op code
        /// </summary>
        public string OpCode {get;}

        /// <summary>
        /// Identifies the type of encoding, e.g VEX, REX, etc. 
        /// Left blank to indicate that no encoding prefix is specified
        /// </summary>
        public string EncodingKind {get;}

        /// <summary>
        /// The bytes encoded for the instruction
        /// </summary>
        public byte[] Encoding {get;}

        /// <summary>
        /// Describes the instruction operands
        /// </summary>
        public AsmOperandInfo[] Operands {get;}

    }
}