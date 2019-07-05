//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using Microsoft.Diagnostics.Runtime;
	using Iced.Intel;
    using System.IO;


    using static zfunc;


    public static class MethodReader
    {
        public static byte[] ReadCilBytes(this DataTarget target,  ClrMethod method)
        {
            var ilAddress = method.IL.Address;
            var ilSize = method.IL.Length;
            var ilBytes = new byte[ilSize];
            target.ReadProcessMemory(ilAddress,ilBytes, ilSize, out int ilRead);
            Claim.eq(ilRead, ilSize);                    
            return ilBytes;
        }

 		public static NativeContent ReadNativeContent(this DataTarget dataTarget, ClrMethod method) 
		{			
            var blocks = new List<NativeBlock>();
			iter(dataTarget.ReadNativeBlocks(method), nb => blocks.Add(nb));
			return new NativeContent(
                MethodId: (int)method.MetadataToken,
                Blocks: blocks.ToArray()
            );
		}

		public static IEnumerable<NativeContent> ReadNativeContent(this DataTarget dataTarget, ClrRuntime runtime, IEnumerable<MethodBase> methods) 
		{
			foreach(var m in methods)
			{
				var rtm = runtime.GetRuntimeMethod(m);
				var data = dataTarget.ReadNativeContent(rtm);				
				yield return data;
			}
		}
		
        public static NativeContent ReadNativeContent(this DataTarget target, MethodBase method) 
			=> target.ReadNativeContent(target.CoreRuntime().GetRuntimeMethod(method));

		/// <summary>
		/// Reads a continuous block of memory
		/// </summary>
		/// <param name="target">The (source!) target </param>
		/// <param name="address">The starting address</param>
		/// <param name="size">The number of bytes to read</param>
		static Option<NativeBlock> ReadNativeBlock(this DataTarget target, ulong address, ByteSize size)
		{
			if (address == 0 || size == 0)
				return zfunc.none<NativeBlock>();

			var dst = new byte[(int)size];
			if (!target.ReadProcessMemory(address, dst, dst.Length, out int bytesRead))
				throw new Exception($"Memory access failure at address {address.ToHexString()}");
            
            if (dst.Length != size)
                throw Errors.LengthMismatch(size, dst.Length);

			return new NativeBlock(address, dst);
		}

        /// <summary>
        /// Reads the native code blocks that have been Jitted for a specified method
        /// </summary>
        /// <param name="target">The diagnostic target</param>
        /// <param name="method">The runtime method</param>
        /// <remarks>The content of this method was derived from https://github.com/0xd4d/JitDasm</remarks>
        static IEnumerable<NativeBlock> ReadNativeBlocks(this DataTarget target, ClrMethod method)
        {
			var codeInfo = method.HotColdInfo;
			
            var hot = target.ReadNativeBlock(codeInfo.HotStart, codeInfo.HotSize);
            if(hot.IsSome())
                yield return hot.Value();        
			
            var cold = target.ReadNativeBlock(codeInfo.ColdStart, codeInfo.ColdSize);
            if(cold.IsSome())
                yield return cold.Value();                  
        }       
 

    }

}