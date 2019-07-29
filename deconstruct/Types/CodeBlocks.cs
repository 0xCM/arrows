//-----------------------------------------------------------------------------
// This source is a shuffling of the https://github.com/0xd4d/JitDasm source
// See License.txt
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

	using Z0.Cpu;
	
	public sealed class CodeBlocks 
    {
		public CodeBlocks(int MethodId, CodeBlock[] Blocks)
		{
			this.MethodId = MethodId;
			this.NativeCode = Blocks;
		}
				
    	public int MethodId;
				

    	public CodeBlock[] NativeCode {get;}
	
	}
}