//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class ImmInfo
    {
        public ImmInfo(BitSize size, ulong value)
        {
            this.Size = size;
            this.Value = value;
        }

        public ImmInfo(BitSize size, long value)
        {
            this.Size = size;
            this.Value = (ulong)value;
        }

        public BitSize Size {get;}

        /// <summary>
        /// Specifies a label for the immedate that has the form imm{BitWidth}
        /// </summary>
        public string Label
        {
            get => $"imm{Size}";
        }

        public ulong Value {get;}
    }


}