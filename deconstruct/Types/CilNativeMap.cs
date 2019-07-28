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
	public struct CilNativeMap 
    {
        public CilNativeMap(int cilOffset, ulong startAddress, ulong endAddress)
        {
            this.CilOffset = cilOffset;
            this.StartAddress = startAddress;
            this.EndAddress = endAddress;
        }
		
        public int CilOffset; 
		
        public ulong StartAddress;
		
        public ulong EndAddress;
	}

}