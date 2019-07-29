//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;


    public static class AsmFormat
    {
        public static string Format(this AsmOperandInfo src)
        {
            var fmt = src.ImmInfo.Map(i => $"{i.Value.FormatHex(false,true,false,false)}:{i.Label}", () => string.Empty);
            fmt += src.Register.Map(r => r, () => string.Empty);
            if(string.IsNullOrWhiteSpace(fmt))
                fmt = src.Kind;
            return fmt;   
        }

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
            return (address + AsciSym.Space + content + "; " + title + " " + operands).PadRight(80, AsciSym.Space) + encoding;
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
        public static string FormatHeader(this AsmFuncSpec src, int? pad = null)
            => concat(
                   src.StartAddress.FormatHex(false,true,true,false), 
                   AsciSym.Space,
                   src.Signature
                   );

        /// <summary>
        /// Formats the function body encoding
        /// </summary>
        /// <param name="src">The source function</param>
        public static string FormatEncoding(this AsmFuncSpec src)
            =>  embrace(src.Encoding.FormatHex(AsciSym.Comma, true, true, true));

        public static string FormatFooter(this AsmFuncSpec src)
            => concat(
                src.EndAddress.FormatHex(false,true,true,false),
                AsciSym.Space,
                AsciSym.Semicolon, 
                src.FormatEncoding()
                ); 

        public static string Format(this AsmFuncSpec src, int? pad = null)
            => lines(src.FormatHeader(pad), 
                src.FormatInstructions(pad),
                src.FormatFooter());                
    }
}