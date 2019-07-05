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

        public static void Dump(this IEnumerable<MethodDisassembly> disassembly, string name)
        {
            disassembly.DumpAsm(name); 
            disassembly.DumpCil(name); 
        }

        public static MethodDisassembly[] Deconstruct(this Type src, bool dump = true)
        {
            var disassembly = Deconstructor.Disassemble(src.DeclaredMethods().ToArray()).ToArray();
            if(dump)
                disassembly.Dump(src.DisplayName());
            return disassembly;

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