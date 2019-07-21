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

    public static class Formatting
    {
        public static string Format(this Instruction instruction)
            => instruction.ToString();            
        
        static string FormatAsm(this MethodAsmBody src)
        {
            var formatter = new AsmFormatter();
            return formatter.FormatBody(src);

        }

        public static string FormatCil(this MethodDisassembly src)
        {
            var format = sbuild();
            format.AppendLine(src.MethodSig.Format());
            format.AppendLine(AsciSym.LBrace.ToString());
            format.AppendLine(src.CilBody.ToString());
            format.Append(AsciSym.RBrace.ToString());
            return format.ToString();
        }

        public static string FormatNativeBlocks(this MethodDisassembly src)
        {
            var desc = sbuild();
            desc.Append(AsciSym.Semicolon);
            desc.Append(AsciSym.Semicolon);
            desc.Append(AsciSym.Space);
            foreach(var block in src.AsmBody.NativeBlocks)
            {
                foreach(var b in block.Data)
                {
                    desc.Append(b.ToHexString(true, false));
                    desc.Append(AsciSym.Space);
                }

                    
            }
            desc.AppendLine();                
            return desc.ToString();

        }        

        public static string FormatAsm(this MethodDisassembly src)
        {
            var format = sbuild();
            
            format.AppendLine($"{src.NativeAddress.ToHexString(false,false,true)}h: {src.MethodSig.Format()}"); 
            format.Append(src.FormatNativeBlocks());
            format.AppendLine("asm ".PadRight(80, '-'));                                    
            format.AppendLine(src.AsmBody.FormatAsm());
            format.AppendLine("end asm ".PadRight(80, '-'));
            return format.ToString();
        }

    }

    public class AsmFormatter
    {
        static readonly MasmFormatterOptions FormatOptions = new MasmFormatterOptions
        {
            DecimalDigitGroupSize = 4,
            BranchLeadingZeroes = false,
            HexDigitGroupSize = 4,
            UpperCaseRegisters = false, 
            LeadingZeroes = false,
        };

        public string FormatBody(MethodAsmBody src)
        {
            if(src.Instructions.Length == 0)
                return string.Empty;

            var baseAddress = src.Instructions[0].IP;

            var formatter = new MasmFormatter(FormatOptions);
            var sb = sbuild();

            var writer = new StringWriter(sb);
            var output = new AsmFormatterOutput(writer, baseAddress);
            for(var j = 0; j< src.Instructions.Length; j++)
            {
                ref var i = ref src.Instructions[j];
                var startAddress = i.IP;
                var ra = (startAddress - baseAddress).ToString("x4");

                sb.Append($"  {ra}h  ");
                formatter.Format(ref i, output);
                if(j != src.Instructions.Length - 1)
                    sb.AppendLine();
            }
                
            return sb.ToString();
        }
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
                    Writer.Write($"{ra}h");
                break;
                default:
                    Writer.Write(text);    
                break;
            }
        }
            

    }

}