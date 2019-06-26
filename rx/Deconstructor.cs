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

    using SharpDisasm;
    using SharpDisasm.Translators;

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
        public static IEnumerable<MethodDisassembly> Disassemble(params MethodInfo[] methods)
            => Disassemble(x => print(x), methods);

        public static IEnumerable<MethodDisassembly> Disassemble(Action<string> onError, params MethodInfo[] methods)
        {
            methods.JIT();
            using var decon = new Deconstructor();
            foreach(var m in methods)
            {
                var d = decon.Disassemble(decon.CreateRuntime(), m);
                if(d)
                    yield return d.ValueOrDefault();
                else
                    onError($"Could not disassemble {m.Name}");
            }            
        }

        readonly DataTarget Target;

        ClrRuntime CreateRuntime()
            => Target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();
        
        Deconstructor()
        {
            Target = DataTarget.AttachToProcess(procid(), uint.MaxValue, AttachFlag.Passive);
        }

        Option<MethodDisassembly> Disassemble(ClrRuntime rt, MethodInfo method)
        {
            var rtMethod = rt.GetMethodByAddress((ulong)method.MethodHandle.GetFunctionPointer());
            if(rtMethod == null)
                return null;

            Claim.eq(rtMethod.Name, method.Name);
            
            var nativeAddress = rtMethod.NativeCode;
            var nativeSize = rtMethod.HotColdInfo.HotSize;
            var nativeBytes = ReadNative(rt, rtMethod);

            var ilBytes = ReadIl(rt, rtMethod);
            Claim.eq(ilBytes, method.GetMethodBody().GetILAsByteArray()) ;
                    
            var d = new MethodDisassembly
            {
                MethodInfo = method,
                NativeAddress = nativeAddress,
                MethodSig = rtMethod.GetFullSignature(),
                IlBytes = ilBytes,
                NativeBytes = nativeBytes,
                AsmInstructions = ParseInstructions(nativeAddress, nativeSize)
            };

            return d;            
        }

        void IDisposable.Dispose()
        {
            Target?.Dispose();
        }
            
        static byte[] ReadNative(ClrRuntime rt, ClrMethod rtMethod)
        {
            var nativeAddress = rtMethod.NativeCode;
            var nativeSize = rtMethod.HotColdInfo.HotSize;
            var nativeBytes = new byte[nativeSize];
            rt.ReadMemory(nativeAddress, nativeBytes, (int)nativeSize, out int nativeByteCount);
            Claim.eq(nativeByteCount, (int)nativeSize);
            return nativeBytes;
        }

        static byte[] ReadIl(ClrRuntime rt, ClrMethod rtMethod)
        {
            var ilAddress = rtMethod.IL.Address;
            var ilSize = rtMethod.IL.Length;
            var ilBytes = new byte[ilSize];
            rt.ReadMemory(ilAddress,ilBytes, ilSize, out int ilRead);
            Claim.eq(ilRead, ilSize);                    
            return ilBytes;
        }

        static IReadOnlyList<MethodInstruction> ParseInstructions(ulong nativeAddress, ByteSize nativeSize)
        {
            var mode = IntPtr.Size == 8 ? ArchitectureMode.x86_64 : ArchitectureMode.x86_32;
            var translator = new IntelTranslator();            
            using var disasm = new Disassembler(intptr(nativeAddress), (int)nativeSize, mode, nativeAddress, false);
            var instructions = new List<MethodInstruction>();
            
            foreach(var i in disasm.Disassemble())
            {
                var loc = (ushort)(i.Offset - nativeAddress);
                instructions.Add(new MethodInstruction(loc, translator.Translate(i)));

            }    
            return instructions;

        }

    }

}