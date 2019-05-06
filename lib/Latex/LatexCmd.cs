//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0;
    using static zcore;
    using static zfunc;

    using static LatexCmd;


    public static class LatexCmd
    {
        public static string cmd(string name) 
            => append(AsciSym.BSlash,name);
        
        public static string begin(string tag) 
            => $"{cmd("begin")}{embrace(tag)}";
        
        public static string end(string tag) 
            => $"{cmd("end")}{embrace(tag)}";

        public static string begindoc() 
            => begin("document");

        public static string enddoc() 
            => end("document");
    
        /// <summary>
        /// Defines a symbol
        /// </summary>
        /// <param name="identifier">The name of the symbol</param>
        /// <param name="expression">Formal or informal description depending on context/needs</param>
        /// <returns></returns>
        [MethodImpl(Inline)]   
        public static Syntax syntax(Atom identifier, string expression)
            => new Syntax(identifier,cmd(expression), expression);

    }


}