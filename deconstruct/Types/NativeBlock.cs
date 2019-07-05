//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

	public readonly struct NativeBlock 
    {
		public readonly ulong Address;
	
    	public readonly byte[] Data;
	
    	public NativeBlock(ulong address, byte[] data) 
        {
			Address = address;
			Data = data;
		}

		public override string ToString() 
			=> Data.ToBlockedHexString();
	}
}