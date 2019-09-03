//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;    


    class App : Context
    {

        public App()
            : base(null)
        {
            
        }

        void Describe(TextDoc doc)
        {
            inform($"Document contains {doc.DataLineCount} data lines, {doc.HeaderLineCount} header line and {doc.TotalLineCount} total file lines, including comments");
            var bins = new Dictionary<int,int>();
            foreach(var row in doc.Rows)
            {
                var count = row.Cells.Length;
                if(bins.TryGetValue(count, out int current))
                    bins[count] = ++current;
                else
                    bins.Add(count,0);
            }
            foreach(var bin in bins)
            {
                inform($"{bin.Value} rows have {bin.Key} cells");
            }

            doc.Header.OnSome(h => inform($"Header: {h}"));

            for(var i=0; i<15; i++)
            {
                inform(doc.Rows[i]);
            }
        }
        
        void ReadAsmCsv()
        {
            var path = FilePath.Define(@"J:\dev\projects\z0\asm\docs\instructions\tables\instructions.csv");
            var doc = path.ReadTextDoc();
            doc.OnSome(Describe);

        }

        void Run(params string[] args)
        {

            //ReadAsmCsv();            
            // var b256 = new Byte256();
            // print(b256.GenerateSourceInt8().Format());

            var code = InlineData.GenAccessor(Pow2.T15);
            print(code);

        }
            
        static void Main(params string[] args)
            => new App().Run();
    }
}