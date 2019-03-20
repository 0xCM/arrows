//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using static corefunc;

    using Root;

    /// <summary>
    /// Represents a symbol
    /// </summary>
    public readonly struct Symbol
    {
        public static Word operator +(Symbol a, Symbol b)                
            => new Word(a,b);
            
        public static implicit operator string(Symbol s)                
            => s.name;
            
        public string name {get;}

        public string description {get;}

        public Symbol(string name, string description = null)
        {
            this.name = name;
            this.description = description ?? string.Empty;
        }

        public override string ToString() => name;
    }

    /// <summary>
    /// Encapsulates a finite sequence of non-space symbols
    /// </summary>
    public readonly struct Word
    {
        Reify.Index<Symbol> symbols {get;}        

        public Word(params Symbol[] symbols)
            => this.symbols = list(symbols);

        public Word(IEnumerable<Symbol> symbols)
            => this.symbols = list(symbols);

        public override string ToString() 
            => concat(symbols);

    }

    
}