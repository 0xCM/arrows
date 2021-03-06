//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Establishes a correlation between a block of CIL and and block of native code
    /// </summary>
	public readonly struct CilNativeMap 
    {
        public CilNativeMap(int cilOffset, ulong startAddress, ulong endAddress)
        {
            this.CilOffset = cilOffset;
            this.StartAddress = startAddress;
            this.EndAddress = endAddress;
        }
		
        public readonly int CilOffset; 
		
        public readonly ulong StartAddress;
		
        public readonly ulong EndAddress;
	}

}