//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Identifies a location within a register bank
    /// </summary>
    public ref struct BankAddress
    {
        public uint Offset;

        public uint Size;
    }

}