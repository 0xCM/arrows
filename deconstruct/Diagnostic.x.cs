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

    using static zfunc;

    public static class DiagnosticX
    {                    
        public static string Format(this MethodAsmEntry instruction, bool trailingLineNumbers = true)
        {
            var offset = instruction.Offset.ToHexString(true,false);
            var text = instruction.Content;
            if(trailingLineNumbers)
                return $"    {text.PadRight(30)} ;{offset}";
            else
                return $"{offset}: {text}";
        }
        
        public static string Format(this MethodDisassembly src, bool braces = false, bool trailingLineNumbers = true, bool skipcil = true)
        {
            var format = sbuild();
            format.AppendLine(src.MethodSig.ToString());

            if(!skipcil)
            {
                format.AppendLine("cil ".PadRight(80, '-'));
                format.AppendLine(src.Cil.ToString());
                format.AppendLine("cil ".PadRight(80, '-'));
            }

            format.AppendLine("asm ".PadRight(80, '-'));

            if(braces)
                format.AppendLine(AsciSym.LBrace.ToString());
                                    
            foreach(var i in src.Asm.Instructions)
                format.AppendLine(i.Format(trailingLineNumbers));
                
            if(braces)
                format.Append(AsciSym.RBrace.ToString());

            format.AppendLine("end asm ".PadRight(80, '-'));

            return format.ToString();
        }

        [MethodImpl(Inline)]
        public static void JIT(this MethodInfo method)
        {
            RuntimeHelpers.PrepareMethod(method.MethodHandle);
        }

        public static void JIT(this IEnumerable<MethodInfo> methods)
        {
            foreach(var method in methods)
                RuntimeHelpers.PrepareMethod(method.MethodHandle);
        }

        
    }

}