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
	using Iced.Intel;
    using System.IO;


    using static zfunc;

    //-----------------------------------------------------------------------------
    // Several of these methods resulted from shuffling source from https://github.com/0xd4d/JitDasm 
    // See License.txt
    //-----------------------------------------------------------------------------
    public static class DiagnosticX
    {                    
        /// <summary>
        /// Queries the runtime for the runtime method corresponding to a supplied <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="rt">The source runtime</param>
        /// <param name="src">The represented method</param>
        public static ClrMethod GetRuntimeMethod(this ClrRuntime rt, MethodBase src)
            =>  rt.GetMethodByAddress((ulong)src.MethodHandle.GetFunctionPointer());

        /// <summary>
        /// Creates a .net core runtime predicated on a  target
        /// </summary>
        /// <param name="target">The target relative type which the runtime abstraction will be created</param>
        public static ClrRuntime CoreRuntime(this DataTarget target)
            => target.ClrVersions.Single(x => x.Flavor == ClrFlavor.Core).CreateRuntime();

        static StreamWriter DumpWriter(string name, string extension, bool timestamped)
        {
            var dstFolder = FolderPath.Define(Settings.ProjectDir("deconstruct")) +  FolderName.Define(".dumps");
            var dstFileName = FileName.Define(name) + FileExtension.Define(extension);
            if(timestamped)
                dstFileName = FileName.Timestamped(dstFileName);
            var dstPath = dstFolder.CreateIfMissing() + dstFileName;
            return new StreamWriter(dstPath.ToString(),false);
        }
        
        public static void DumpAsm(this IEnumerable<MethodDisassembly> disassembly, string name, bool timestamped = false)
        {
            using var writer = DumpWriter(name, "asm", timestamped);
            writer.WriteLine($"# {now().ToLexicalString()}");
            foreach(var d in disassembly)
                writer.WriteLine(d.FormatAsm());
        }

        public static void DumpCil(this IEnumerable<MethodDisassembly> disassembly, string name, bool timestamped = false)
        {
            using var writer = DumpWriter(name, "il", timestamped);
            writer.WriteLine($"// {now().ToLexicalString()}");
            foreach(var d in disassembly)
                writer.WriteLine(d.FormatCil());
        }

        public static void Dump(this IEnumerable<MethodDisassembly> disassembly, string name, bool asm = true, bool cil = false)
        {
            if(asm)
                disassembly.DumpAsm(name); 
            
            if(cil)
                disassembly.DumpCil(name); 
        }

        public static void Dump(this AsmFuncSpec[] specs, string name)
        {
            using var writer = DumpWriter(name, "asm", false);
            writer.WriteLine($"# {now().ToLexicalString()}");
            for(var i=0; i< specs.Length; i++)
            {   
                var spec = specs[i];             
                writer.Write(spec.Format());
                if(i != i-1)
                    writer.WriteLine(new string('-',120));
            }
        }

        static MethodDisassembly[] Disassemble(this Type src)
            => Deconstructor.Disassemble(src.DeclaredMethods().NonGeneric().ToArray()).ToArray();
        
        public static MethodDisassembly[] Deconstruct(this Type src, bool dump = true)
        {
            var disassembly = src.Disassemble();
            if(dump)
                disassembly.Dump(src.DisplayName());
            return disassembly;
        }

        public static AsmFuncSpec[] ExtractAsm(this Type src)
        {
            var disassembly = src.Disassemble();
            var dst = new AsmFuncSpec[disassembly.Length];
            for(var i=0; i<disassembly.Length; i++)   
                dst[i] = disassembly[i].DefineAsmSpec();
            return dst;
        }

        public static MethodDisassembly[] Deconstruct(this IEnumerable<MethodInfo> src, string outname = null)
        {
            var disassembly = Deconstructor.Disassemble(src.ToArray()).ToArray();
            if(outname != null)
                disassembly.Dump(outname);
            return disassembly;

        }

    }

}