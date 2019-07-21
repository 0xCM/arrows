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

        public static IEnumerable<MethodDisassembly> Disassemble(params MethodInfo[] methods)
            => Disassemble(x => error(x), methods);

        public static IEnumerable<MethodDisassembly> Disassemble(params Type[] types)
        {
            var methods = from t in types
                          from m in t.DeclaredMethods().NonGeneric().Concrete()
                          select m;
            return Disassemble(methods.ToArray());                        
        }

        static IEnumerable<MethodDisassembly> Disassemble(Action<string> onError, params MethodInfo[] methods)
        {
            Jit(methods);
            var modules = methods.Select(x => x.Module).Distinct();
            using var decon = new Deconstructor(modules);
            foreach(var m in methods)
            {
                var d = decon.Disassemble(m);
                if(d)
                    yield return d.ValueOrDefault();
                else
                    onError($"Could not disassemble {m.Name}");
            }            
        }
        
        Deconstructor(IEnumerable<Module> modules)
        {
            Target = InProcTarget();
            Runtime = Target.CoreRuntime();
            MdIx = MetadataIndex.Create(modules.ToArray());
        }

        Option<MethodDisassembly> Disassemble(MethodInfo method)
        {
            try
            {
                var clrMethod = Runtime.GetRuntimeMethod(method);
                if(clrMethod == null)
                    return null;
                
                var asmBody = DecodeAsm(method);
                var ilBytes = Target.ReadCilBytes(clrMethod);            
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
            catch(Exception)
            {
                return none<MethodDisassembly>();
            }
        }

        MethodAsmBody DecodeAsm(MethodBase method)
        {
            var data = Target.ReadNativeContent(method);
            var instructions = new List<Instruction>();
            var blocks = new List<NativeBlock>();
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

		static InstructionList DecodeAsm(NativeBlock src)
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

        [MethodImpl(Inline)]
        static void Jit(MethodBase method)
        {
            try
            {
                RuntimeHelpers.PrepareMethod(method.MethodHandle);
            }
            catch(Exception e)
            {
                error(errorMsg(e));
            }
        }

        static void Jit(IEnumerable<MethodBase> methods)
            => iter(methods,Jit);

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

        /// <summary>
        /// Creates an in-process data target
        /// </summary>
        /// <returns>The (disposable) target</returns>
        static DataTarget InProcTarget()
            => DataTarget.AttachToProcess(Process.GetCurrentProcess().Id, uint.MaxValue, AttachFlag.Passive);

		static IEnumerable<MethodAsmBody> DecodeAsm(DataTarget target, IEnumerable<MethodBase> methods)
		{				
			var runtime = target.CoreRuntime();
            var midx = methods.Select(x => (x.MetadataToken, x)).ToDictionary();
            var data = target.ReadNativeContent(runtime, methods);
			foreach(var d in data)
            {
                foreach(var native in d.NativeCode)
                {
                    if(native.Data.Length != 0)
                    {
                        var instructions = DecodeAsm(native).ToArray();
                        var blocks = new List<NativeBlock>();
                        blocks.Add(native);

                        var body = new MethodAsmBody(midx[(int)d.MethodId], blocks.ToArray(), instructions);
                        yield return body;
                    }
                }
            }       
		}
    }
}