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

	using Iced.Intel;

    using static zfunc;
    
    using Z0.Cpu;
    using AsmOpKind = Iced.Intel.OpKind;


    public static class AsmSpec
    {        
        public static IEnumerable<AsmFuncSpec> DefineAsmSpecs(this IEnumerable<MethodDisassembly> src)
            => src.Select(DefineAsmSpec);



        public static AsmFuncSpec DefineAsmSpec(this MethodDisassembly src)
        {
            var asm = src.AsmBody;
            var inxcount = asm.Instructions.Length;
            var code = asm.NativeBlocks.Single().Data;
            Span<byte> codespan = code;
            var startAddress = asm.Instructions.First().IP;
            var endAddress = asm.Instructions.Last().IP;
            var inxs = new AsmInstructionInfo[inxcount];
            var inxsfmt = asm.FormatInstructions();

            for(var i=0; i<asm.Instructions.Length; i++)
            {
                var inx = asm.Instructions[i];
                var args = new AsmOperandInfo[inx.OpCount];
                for(byte j=0; j< inx.OpCount; j++)
                {
                    var operandKind = inx.GetOpKind(j);
                    var imm = inx.ImmediateInfo(j);
                    var reg = operandKind == AsmOpKind.Register ? inx.GetOpRegister(j) : (Register?)null;
                    args[j] = new AsmOperandInfo(j, operandKind.ToString(), imm, reg?.ToString());
                }
                
                var offset = (ushort)(inx.IP - startAddress);
                var encoded = codespan.Slice(offset, inx.ByteLength).ToArray();
                var mnemonic = inx.Mnemonic.ToString().ToUpper();
                var opcode = inx.Code.ToString();
                var enckind = inx.Encoding == EncodingKind.Legacy ? string.Empty : inx.Encoding.ToString();
                inxs[i] = new AsmInstructionInfo(offset, inxsfmt[i], mnemonic, opcode, args, enckind, encoded);
            }

            return new AsmFuncSpec(startAddress, endAddress, src.MethodSig.Format(), inxs, code);            
        }

    }


}