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
    using System.IO;

    using Z0.Cpu;


    using static zfunc;

    //-----------------------------------------------------------------------------
    // Several of these methods resulted from shuffling source from https://github.com/0xd4d/JitDasm 
    // See License.txt
    //-----------------------------------------------------------------------------
    public static class DeconstructorX
    {                    
        /// <summary>
        /// Disassembles reified methods declared by the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static MethodDisassembly[] Deconstruct(this Type src)
            => Deconstructor.Deconstruct(src.DeclaredMethods().NonGeneric().Concrete().ToArray()).ToArray();

        /// <summary>
        /// Disassembles the source methods
        /// </summary>
        /// <param name="src">The source methods</param>
        public static MethodDisassembly[] Deconstruct(this IEnumerable<MethodInfo> src)        
            => Deconstructor.Deconstruct(src.ToArray()).ToArray();

        /// <summary>
        /// Disassembles the assembly code for reified methods declared by the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static AsmFuncSpec[] ExtractAsm(this Type src)
        {
            var disassembly = src.Deconstruct();
            var dst = new AsmFuncSpec[disassembly.Length];
            for(var i=0; i<disassembly.Length; i++)   
                dst[i] = disassembly[i].DefineAsmSpec();
            return dst;
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

        public static void DumpAsm(this IEnumerable<MethodInfo> methods, string name)
            => methods.Deconstruct().DumpAsm(name);
        
        public static void DumpCil(this IEnumerable<MethodInfo> methods, string name)
            => methods.Deconstruct().DumpCil(name);

        public static void DumpDisassembly(this IEnumerable<MethodInfo> methods, string name)
        {
            var d = methods.Deconstruct();
            d.DumpAsm(name);
            d.DumpCil(name);            
        }
           
        static StreamWriter DumpWriter(string name, string extension, bool timestamped)
        {
            var dstFolder = FolderPath.Define(Settings.ProjectDir("deconstruct")) +  FolderName.Define(".dumps");
            var dstFileName = FileName.Define(name) + FileExtension.Define(extension);
            if(timestamped)
                dstFileName = FileName.Timestamped(dstFileName);
            var dstPath = dstFolder.CreateIfMissing() + dstFileName;
            return new StreamWriter(dstPath.ToString(),false);
        }
    }

}