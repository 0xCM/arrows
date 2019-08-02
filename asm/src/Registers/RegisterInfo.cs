//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes a register
    /// </summary>
    public readonly struct RegisterInfo
    {
        public RegisterInfo(string Name, BitSize Size)
        {
            this.Name = Name;
            this.Size = Size;
        }

        public Char8 Name {get;}

        public BitSize Size {get;}

        public override string ToString()
            => Name.Format();
    }

}