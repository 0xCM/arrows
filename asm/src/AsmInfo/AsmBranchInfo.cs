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
    /// Describes a branching instruction operand
    /// </summary>
    public class AsmBranchInfo
    {
        public AsmBranchInfo(BitSize size, ulong value, bool near, ulong @base)
        {
            this.Size = size;
            this.Target = value;
            this.Near = near;
            this.Base = @base;
        }

        public AsmBranchInfo(BitSize size, long value, bool near, ulong @base)
        {
            this.Size = size;
            this.Target = (ulong)value;
            this.Near = near;
            this.Base = @base;
        }

        public BitSize Size {get;}

        public bool Near {get;}

        /// <summary>
        /// Specifies a label for the immedate that has the form jmp{BitWidth}
        /// </summary>
        public string Label
            => $"jmp{Size}";

        public ulong Base {get;}
        
        public ulong Target {get;}
    }

}