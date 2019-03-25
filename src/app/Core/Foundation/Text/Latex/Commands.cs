//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Expose
{
    using Z0;
    using static corefunc;
    using static Latex;


    public static class Latex
    {
        public static string cmd(string name) => concat(AsciSym.BSlash,name);
        
        public static string begin(string tag) => $"{cmd("begin")}{embrace(tag)}";
        
        public static string end(string tag) => $"{cmd("end")}{embrace(tag)}";

        public static string begindoc() => begin("document");

        public static string enddoc() => end("document");
    }




}