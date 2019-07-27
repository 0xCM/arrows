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
    using System.IO;

    using static zfunc;
    

    public static class AsmSpec
    {

        public static ReadOnlySpan<string> FormatInstructions(this MethodAsmBody src)
        {
            var inxcount = src.Instructions.Length;
            if(inxcount == 0)
                return ReadOnlySpan<string>.Empty;
            
            Span<string> dst = new string[inxcount];

            var formatter = new MasmFormatter(FormatOptions);
            var baseAddress = src.Instructions.First().IP;

            var sb = sbuild();
            var writer = new StringWriter(sb);
            var output = new AsmFormatterOutput(writer, baseAddress);
            for(var j = 0; j< src.Instructions.Length; j++)
            {
                ref var i = ref src.Instructions[j];
                formatter.Format(ref i, output);
                dst[j] = sb.ToString();
                sb.Clear();
            }

            return dst;
        }


        public static IEnumerable<AsmFuncSpec> SpecifyAsm(this IEnumerable<MethodDisassembly> src)
            => src.Select(DefineAsmSpec);

        public static AsmFuncSpec DefineAsmSpec(this MethodDisassembly src)
        {
            var asm = src.AsmBody;
            var inxcount = asm.Instructions.Length;
            var code = asm.NativeBlocks.Single().Data;
            Span<byte> codespan = code;
            var startAddress = asm.Instructions.First().IP;
            var endAddress = asm.Instructions.Last().IP - startAddress;
            var inxs = new AsmFuncInstruction[inxcount];
            var inxsfmt = asm.FormatInstructions();
            for(var i=0; i<asm.Instructions.Length; i++)
            {
                var inx = asm.Instructions[i];
                var offset = (ushort)(inx.IP - startAddress);
                var encoded = codespan.Slice(offset, inx.ByteLength).ToArray();
                var mnemonic = inx.Mnemonic.ToString();
                var opcode = inx.Code.ToString();
                var enckind = inx.Encoding == EncodingKind.Legacy ? string.Empty : inx.Encoding.ToString();
                inxs[i] = new AsmFuncInstruction(offset,inxsfmt[i], mnemonic, opcode, enckind, encoded);
            }

            return new AsmFuncSpec(startAddress, endAddress, src.MethodSig, inxs, code);            
        }

        static readonly MasmFormatterOptions FormatOptions = new MasmFormatterOptions
        {
            DecimalDigitGroupSize = 4,
            BranchLeadingZeroes = false,
            HexDigitGroupSize = 4,
            UpperCaseRegisters = false, 
            LeadingZeroes = false,
        };

    }


}