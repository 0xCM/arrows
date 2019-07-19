//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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