//-----------------------------------------------------------------------------
// This source is a shuffling of the https://github.com/0xd4d/JitDasm source
// See License.txt
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

	public sealed class NativeContent 
    {
		public NativeContent(int MethodId, NativeBlock[] Blocks)
		{
			this.MethodId = MethodId;
			this.NativeCode = Blocks;
		}
				
    	public int MethodId;
				

    	public NativeBlock[] NativeCode {get;}
	

	}
}