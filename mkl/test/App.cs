//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.IO;

    using Z0.Mkl;
    using static zfunc;

    static class MklListGenerator
    {
        static void WriteText(string text, FileName filename, [CallerFilePath] string caller = null)
        {
            var dir = FolderPath.Define(Path.GetDirectoryName(caller));
            var path = dir + filename;
            using var writer = path.Writer();
            writer.Write(text);

        }
        static void EmitNames()
        {
            var methods = typeof(LAPACK).DeclaredMethods().Select(x => x.Name).ToReadOnlyList();
            var sb = sbuild();
            methods.Iterate(m => sb.AppendLine(m));
                        
            WriteText(sb.ToString(), FileName.Define("lapacke.list"));
        }

    }

    public class App : TestApp<App>
    {            
        
        public static void Main(params string[] args)
            => Run(args);
    }
}