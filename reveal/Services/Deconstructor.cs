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
    using System.Diagnostics;
    using Microsoft.Diagnostics.Runtime;
	using Iced.Intel;

    using static zfunc;
    
    /// <summary>
    /// Disassembles CLR methods
    /// </summary>
    /// <remarks>The implementation details were greatly facilitated by the following projects:
    /// SharpLab: https://github.com/ashmind/SharpLab
    /// JitDasm:  https://github.com/0xd4d/JitDasm
    /// SeeJit:   https://github.com/JeffreyZhao/SeeJit
    /// </remarks>
    public class Deconstructor : IDisposable
    {
        readonly DataTarget Target;

        readonly ClrRuntime Runtime;

        readonly MetadataIndex MdIx;

        public static IEnumerable<MethodDisassembly> Deconstruct(params MethodInfo[] methods)
            => Disassemble(x => error(x), methods);

        static IEnumerable<MethodDisassembly> Disassemble(Action<string> onError, params MethodInfo[] methods)
        {
            methods.JitMethods();
            var modules = methods.Select(x => x.Module).Distinct();
            using var decon = new Deconstructor(modules);
            foreach(var m in methods)
            {
                var d = decon.Disassemble(m, onError);
                if(d)
                    yield return d.ValueOrDefault();
            }            
        }
        
        Deconstructor(IEnumerable<Module> modules)
        {
            Target = DataTarget.AttachToProcess(Process.GetCurrentProcess().Id, uint.MaxValue, AttachFlag.Passive);
            Runtime = CreateRuntime(Target);
            MdIx = MetadataIndex.Create(modules.ToArray());
        }

        /// <summary>
        /// Creates a .net core runtime predicated on a  target
        /// </summary>
        /// <param name="target">The target relative type which the runtime abstraction will be created</param>
        static ClrRuntime CreateRuntime(DataTarget target)
            => target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();

        /// <summary>
        /// Queries the runtime for the runtime method corresponding to a supplied <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="rt">The source runtime</param>
        /// <param name="src">The represented method</param>
        ClrMethod GetRuntimeMethod(MethodBase src)
            =>  Runtime.GetMethodByHandle((ulong)src.MethodHandle.Value.ToInt64());
            
            //Runtime.GetMethodByAddress((ulong)src.MethodHandle.GetFunctionPointer());

        Option<MethodDisassembly> Disassemble(MethodInfo method, Action<string> onError)
        {
            try
            {
                var clrMethod = GetRuntimeMethod(method);
                if(clrMethod == null || clrMethod.NativeCode == 0)
                {
                    onError($"Method {method.Name} not found");
                    return null;
                }
                
                var asmBody = DecodeAsm(method);
                var ilBytes = ReadCilBytes(clrMethod);            
                Claim.eq(ilBytes, method.GetMethodBody().GetILAsByteArray()) ;
                        
                var d = new MethodDisassembly
                {
                    MethodInfo = method,
                    NativeAddress = clrMethod.NativeCode,
                    MethodSig = method.MethodSig(),
                    CilData = ilBytes,
                    CilBody = MdIx.FindCil(method),
                    CilMap = MapCilToNative(clrMethod),
                    AsmBody =  asmBody,
                    NativeBody = asmBody.NativeBlocks
                };

                return d;            
            }
            catch(Exception e)
            {
                onError(e.ToString());
                return none<MethodDisassembly>();
            }
        }

        MethodAsmBody DecodeAsm(MethodBase method)
        {
            var data = ReadNativeContent(method);
            var instructions = new List<Instruction>();
            var blocks = new List<CodeBlock>();
            foreach(var block in data.NativeCode)
            {
                instructions.AddRange(DecodeAsm(block));
                blocks.Add(block);
            }
            return new MethodAsmBody(method, blocks.ToArray(), instructions.ToArray());
        }

        void IDisposable.Dispose()
        {
            Target?.Dispose();
        }

		static InstructionList DecodeAsm(CodeBlock src)
		{
            var dst = new InstructionList();
            var reader = new ByteArrayCodeReader(src.Data);
			var decoder = Decoder.Create(IntPtr.Size * 8, reader);
			decoder.IP = src.Address;			
			while (reader.CanReadByte) 
			{
				ref var instruction = ref dst.AllocUninitializedElement();
				decoder.Decode(out instruction);                
			}
            return dst;
		}

        static CilNativeMap[] MapCilToNative(ClrMethod method)
        {
            var map = method.ILOffsetMap;
            var result = new CilNativeMap[map.Length];
            for (int i = 0; i < result.Length; i++) 
            {
                ref var m = ref map[i];
                result[i] = new CilNativeMap 
                (
                    m.ILOffset,
                    m.StartAddress,
                    m.EndAddress
                );
            }

            Array.Sort(result, (a, b) => 
            {
                int c = a.StartAddress.CompareTo(b.StartAddress);
                if (c != 0)
                    return c;
                return a.EndAddress.CompareTo(b.EndAddress);
            });

            return result;
        }

        byte[] ReadCilBytes(ClrMethod method)
        {
            var ilAddress = method.IL.Address;
            var ilSize = method.IL.Length;
            var ilBytes = new byte[ilSize];
            Target.ReadProcessMemory(ilAddress,ilBytes, ilSize, out int ilRead);
            Claim.eq(ilRead, ilSize);                    
            return ilBytes;
        }

        CodeBlocks ReadNativeContent(MethodBase method) 
			=> ReadNativeContent(GetRuntimeMethod(method));

 		CodeBlocks ReadNativeContent(ClrMethod method) 
		{			
            var blocks = new List<CodeBlock>();
			iter(ReadNativeBlocks(method), nb => blocks.Add(nb));
			return new CodeBlocks(
                MethodId: (int)method.MetadataToken,
                Blocks: blocks.ToArray()
            );
		}

		/// <summary>
		/// Reads a continuous block of memory
		/// </summary>
		/// <param name="target">The (source!) target </param>
		/// <param name="address">The starting address</param>
		/// <param name="size">The number of bytes to read</param>
		Option<CodeBlock> ReadNativeBlock(ulong address, ByteSize size)
		{
			if (address == 0 || size == 0)
				return zfunc.none<CodeBlock>();

			var dst = new byte[(int)size];
			if (!Target.ReadProcessMemory(address, dst, dst.Length, out int bytesRead))
				throw new Exception($"Memory access failure at address {address.FormatHex()}");
            
            if (dst.Length != size)
                throw Errors.LengthMismatch(size, dst.Length);

			return new CodeBlock(address, dst);
		}

        /// <summary>
        /// Reads the native code blocks that have been Jitted for a specified method
        /// </summary>
        /// <param name="target">The diagnostic target</param>
        /// <param name="method">The runtime method</param>
        /// <remarks>The content of this method was derived from https://github.com/0xd4d/JitDasm</remarks>
        IEnumerable<CodeBlock> ReadNativeBlocks(ClrMethod method)
        {
			var codeInfo = method.HotColdInfo;
			
            var hot = ReadNativeBlock(codeInfo.HotStart, codeInfo.HotSize);
            if(hot.IsSome())
                yield return hot.Value();        
			
            var cold = ReadNativeBlock(codeInfo.ColdStart, codeInfo.ColdSize);
            if(cold.IsSome())
                yield return cold.Value();                  
        }       
    }
}