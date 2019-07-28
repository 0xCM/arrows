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
    /// Represents an assembly instruction in the context of an <see cref='AsmFuncSpec' />
    /// </summary>
    public class AsmFuncInstruction
    {
        public AsmFuncInstruction(ushort Offset, string Display, string Mnemonic,  string OpCode, string EncodingKind, byte[] Encoding)
        {
            this.Offset = Offset;
            this.Display = Display;
            this.Mnemonic = Mnemonic;
            this.OpCode = OpCode;
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
        /// Left blank for legacy encoding
        /// </summary>
        public string EncodingKind {get;}

        /// <summary>
        /// The bytes encoded for the instruction
        /// </summary>
        public byte[] Encoding {get;}


        public override string ToString()
            => this.Format();
    }
}