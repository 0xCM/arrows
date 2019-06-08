//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class SymbolAttribute : Attribute
    {
        public SymbolAttribute(params string[] symbols)
        {
            this.Symbols = symbols.Select(s => Z0.Symbol.Define(s)).ToArray();
            
        }

        public SymbolAttribute(string s1, char s2)
        {
            this.Symbols = items(s1, s2.ToString()).Select(s => Z0.Symbol.Define(s.ToString())).ToArray();
        }

        public SymbolAttribute(char s1, string s2)
        {
            this.Symbols = items(s1.ToString(), s2).Select(s => Z0.Symbol.Define(s.ToString())).ToArray();
        }

        public SymbolAttribute(params char[] symbols)
        {
            this.Symbols = symbols.Select(s => Z0.Symbol.Define(s.ToString())).ToArray();
            
        }

        public Symbol[] Symbols {get;}
        
    }


}