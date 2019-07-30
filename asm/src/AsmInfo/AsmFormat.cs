//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class AsmFormat
    {
        /// <summary>
        /// Formats an assembly function specifier
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="pad">The padding between each instruction and associated commentary</param>
        public static string Format(this AsmFuncSpec src, int? pad = null)
            => lines(src.FormatHeader(),  src.FormatInstructions(pad), src.FormatFooter());                

        /// <summary>
        /// Formats a single operand
        /// </summary>
        /// <param name="src">The source operand</param>
        public static string Format(this AsmOperand src)
        {
            var fmt = src.ImmInfo.Map(i => $"{i.Value.FormatHex(false,true,false,false)}:{i.Label}", () => string.Empty);
            fmt += src.Register.Map(r => r.RegisterName, () => string.Empty);
            fmt += src.Memory.Map(r => r.Format(), () => string.Empty);
            fmt += src.Branch.Map(b => b.Format(), () => string.Empty);
            if(string.IsNullOrWhiteSpace(fmt))
                fmt = src.Kind;
            return fmt;   
        }

        /// <summary>
        /// Formats the operands contained in an instruction
        /// </summary>
        /// <param name="src">The instruction description</param>
        /// <param name="sep">The operand separator</param>
        public static string FormatOperands(this AsmInstructionInfo src, char? sep = null)
        {
            var count = src.Operands.Length;
            if(count == 0)
                return string.Empty;

            var sb = sbuild();   
            for(var i=0; i<src.Operands.Length; i++)
            {
                sb.Append(src.Operands[i].Format());
                if(i != src.Operands.Length - 1)
                    sb.Append(sep ?? AsciSym.Comma);                            
            }
            return bracket(sb.ToString());
        }

        /// <summary>
        /// Formats a single instruction
        /// </summary>
        /// <param name="src">The source instruction</param>
        /// <param name="pad"></param>
        public static string Format(this AsmInstructionInfo src, int? pad = null)
        {
            var address = src.Offset.FormatHex(true,true,false,false);
            var content = src.Display.PadRight(pad ?? 24, AsciSym.Space);
            var encodingKind = !string.IsNullOrWhiteSpace(src.EncodingKind) ? $"{src.EncodingKind}, " : string.Empty;
            var encodingLen = concat(
                    src.Encoding.Length.ToString(), 
                    AsciSym.Space, 
                    src.Encoding.Length > 1 ?  "bytes" : "byte "
                    );
            var encoding = $" encoding({encodingKind}{encodingLen}) = " + src.Encoding.FormatHex(AsciSym.Space, true, false);
            var operands = src.FormatOperands();
            var title = concat(src.Mnemonic, AsciSym.LParen, src.OpCode, AsciSym.RParen);
            return (address + AsciSym.Space + content + "; " + title + " " + operands).PadRight(90, AsciSym.Space) + encoding;
        }

        const int IPad = 30;
        
        public static string FormatInstructions(this AsmFuncSpec src, int? pad = null)
        {
            var format = sbuild();            
            for(var i = 0; i< src.InstructionCount; i++)
            {
                var insx = src.Instructions[i];
                var fmt = insx.Format(pad ?? IPad);
                if(i != src.InstructionCount - 1)
                    format.AppendLine(fmt);
                else
                    format.Append(fmt);
            }
            return format.ToString();
        }    

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="pad"></param>
        public static string FormatHeader(this AsmFuncSpec src)
            => concat(
                   line(concat(BeginComment, $"function: {src.Signature}")),
                   concat(BeginComment, $"location: {src.StartAddress.GlobalHexRange(src.EndAddress)}" )
                   );

        /// <summary>
        /// Formats the function body encoding
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatEncoding(this AsmFuncSpec src)
            =>  embrace(src.Encoding.FormatHex(AsciSym.Comma, true, true, true));

        /// <summary>
        /// Formats the encoded bytes as a comment
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatFooter(this AsmFuncSpec src)
            => concat(BeginComment, $"code = new byte[{src.Encoding.Length}]", src.FormatEncoding(),AsciSym.Semicolon); 


        const string BeginComment = "; ";

        static string HexFormat(this ulong src)
            => src.FormatHex(false,true,true,false);


        static string GlobalHexRange(this ulong start, ulong end)
            => bracket(concat(start.HexFormat(),AsciSym.Comma, AsciSym.Space, end.HexFormat()));


        static string Format(this AsmBranch src)
        {
            var target = src.Near ? src.Target - src.Base : src.Target;
            return $"{target.HexFormat()}:{src.Label}";
        }

        static string Format(this AsmOperandMemory src)
        {
            var items = new List<(string value, string type)>();
            
            if(src.Address != 0)
                items.Add((src.Address.FormatHex(false,true, false, false),"address"));
            
            if(src.Size != string.Empty)
                items.Add((src.Size, string.Empty));

            src.BaseRegister.OnValue(value => items.Add((value.Format(),"br")));
            src.SegmentPrefix.OnValue(value => items.Add((value.Format(),"")));
            src.SegmentRegister.OnValue(value => items.Add((value.Format(), "sr")));

            var sb = sbuild();
            for(var i=0; i<items.Count; i++)
            {
                var item = items[i];
                if(item.type == string.Empty)
                    sb.Append(item.value);
                else
                    sb.Append($"{item.value}:{item.type}");
                if(i != items.Count - 1)
                    sb.Append(AsciSym.Comma);
            
            }
            return "mem" + paren(sb.ToString());

        }
    }
}