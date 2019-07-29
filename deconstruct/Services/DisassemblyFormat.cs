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
	using Iced.Intel;
    using System.IO;

    using static zfunc;
    
    public static class DisassemblyFormat
    {
        static readonly MasmFormatterOptions FormatOptions = new MasmFormatterOptions
        {
            DecimalDigitGroupSize = 4,
            BranchLeadingZeroes = false,
            HexDigitGroupSize = 4,
            UpperCaseRegisters = false, 
            LeadingZeroes = false,
            DisplInBrackets = true,
            
        };

        public static string FormatCil(this MethodDisassembly src)
        {
            var format = sbuild();
            format.AppendLine(src.MethodSig.Format());
            format.AppendLine(AsciSym.LBrace.ToString());
            format.AppendLine(src.CilBody.ToString());
            format.Append(AsciSym.RBrace.ToString());
            return format.ToString();
        }


        public static string Format(this MethodAsmBody src)
        {
            if(src.Instructions.Length == 0)
                return string.Empty;

            Span<byte> nativeData = src.NativeBlocks.Single().Data;

            var baseAddress = src.Instructions[0].IP;

            var formatter = new MasmFormatter(FormatOptions);
            var sb = sbuild();

            var writer = new StringWriter(sb);
            var output = new AsmFormatterOutput(writer, baseAddress);
            for(var j = 0; j< src.Instructions.Length; j++)
            {
                ref var i = ref src.Instructions[j];
                var startAddress = i.IP;
                var relAddress = (int)(startAddress - baseAddress);
                var relAddressFmt = relAddress.ToString("x4");            

                sb.Append($"{relAddressFmt}h  ");
                formatter.Format(ref i, output);

                var padding = "   ";
                var encoding = i.Encoding == EncodingKind.Legacy ? string.Empty : $" ({i.Encoding} encoded)";               
                var encoded = embrace(nativeData.Slice(relAddress, i.ByteLength).FormatHex(false, ','));
                sb.Append($"{padding}; opcode := {i.Code}{encoding} | encoded := {encoded} ({i.ByteLength} bytes)");
                
                if(j != src.Instructions.Length - 1)
                    sb.AppendLine();
            }
                
            return sb.ToString();
        }

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

        static string FormatNativeBlocks(this MethodDisassembly src)
        {
            var desc = sbuild();
            desc.Append("# encoding");
            desc.Append(AsciSym.Colon);
            desc.Append(AsciSym.Space);
            desc.Append(AsciSym.LBrace);

            var blocks = src.AsmBody.NativeBlocks;
            var blockcount = blocks.Length;
            for(var i=0; i<blockcount; i++)
            {
                var block = blocks[i];
                var blockParts = block.Data;
                var blocklen = blockParts.Length;
                for(var j=0; j< blocklen; j++)
                {
                    var part = blockParts[j];
                    desc.Append(part.FormatHex(true, true));
                    if(j != blocklen - 1)
                    {
                        desc.Append(AsciSym.Comma);
                        desc.Append(AsciSym.Space);
                    }
                }
            }
            
            desc.Append(AsciSym.RBrace);
            desc.AppendLine();                
            return desc.ToString();
        }        

        public static string FormatAsm(this MethodDisassembly src)
        {
            var format = sbuild();            
            format.AppendLine($"{src.NativeAddress.FormatHex(false,false,true)}h {src.MethodSig.Format()}"); 
            format.Append(src.FormatNativeBlocks());
            var startaddress = src.NativeBody.First().Address.FormatHex(false,false,true);
            var endaddress = src.NativeBody.Last().Address.FormatHex(false,false,true);
            format.AppendLine($"asm-body-begin {startaddress}h ".PadRight(120, '-'));                                    
            format.AppendLine(src.AsmBody.Format());
            format.AppendLine($"asm-body-end {endaddress}h ".PadRight(120, '-'));
            return format.ToString();
        }

        class AsmFormatterOutput : FormatterOutput
        {
            TextWriter Writer {get;}
            
            ulong BaseAddress {get;}

            public AsmFormatterOutput(TextWriter writer, ulong BaseAddress)
            {
                this.Writer = writer;
                this.BaseAddress = BaseAddress;
            }
            

            public override void Write(string text, FormatterOutputTextKind kind)
            {
                switch(kind)
                {
                    case FormatterOutputTextKind.LabelAddress:
                        var address = ulong.Parse($"{text.Substring(0, text.Length - 1)}", System.Globalization.NumberStyles.HexNumber);
                        var ra = (address - BaseAddress).ToString("x4");
                        var label = $"{ra}h";
                        Writer.Write(label);
                    break;
                    default:
                        Writer.Write(text);    
                    break;
                }
            }                
        }
    }
}