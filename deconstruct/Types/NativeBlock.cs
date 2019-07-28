//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

	/// <summary>
	/// Represents a native code block
	/// </summary>
	public readonly struct NativeBlock 
    {
    	public NativeBlock(ulong address, byte[] data) 
        {
			Address = address;
			Data = data;
		}

		/// <summary>
		/// The location of the block head
		/// </summary>
		public readonly ulong Address;
	
		/// <summary>
		/// The block data
		/// </summary>
    	public readonly byte[] Data;
	

		public override string ToString() 
			=> $"{Address.FormatHex()}: {Data.FormatHexBlocks()}";
	}
}