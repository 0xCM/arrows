//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public class AsmImmInfo
    {
        public AsmImmInfo(BitSize size, ulong value)
        {
            this.Size = size;
            this.Value = value;
        }

        public AsmImmInfo(BitSize size, long value)
        {
            this.Size = size;
            this.Value = (ulong)value;
        }

        public BitSize Size {get;}

        /// <summary>
        /// Specifies a label for the immedate that has the form imm{BitWidth}
        /// </summary>
        public string Label
            => $"imm{Size}";

        public ulong Value {get;}
    }

}