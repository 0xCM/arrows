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
    using A = BinaryAlphabet;

    /// <summary>
    /// Defines an alphabet constructed from exactly two symbols, zero and one
    /// </summary>
    public readonly struct BinaryAlphabet : IAlphabet<A>
    {   
        /// <summary>
        /// Retrieves the singleton instance of the alphabet
        /// </summary>
        public static BinaryAlphabet Get()
            => TheOnly;

        static readonly BinaryAlphabet TheOnly = new BinaryAlphabet('0', '1');
                      
        BinaryAlphabet(params Symbol<A>[] src)
            => Symbols = src.ToArray();
        
        public readonly Symbol<A>[] Symbols;

        /// <summary>
        /// Specifies the symbol for 0
        /// </summary>
        public Symbol<A> Zero => Symbols[0];

        /// <summary>
        /// Specifies the symbol for one
        /// </summary>
        public Symbol<A> One => Symbols[1];

        IEnumerable<Symbol<A>> IAlphabet<A>.Symbols 
              => Symbols;

        public string Format()
        {
            var fmt = sbuild();
            foreach(var s in Symbols)
                fmt.Append(s.Format());
            return fmt.ToString();
        }

        public Symbol<A> ParseSymbol(char c)
            => c == 0 ? Zero : One;
        
        public IEnumerable<Symbol<A>> ParseSymbols(IEnumerable<char> src)
        {
            foreach(var c in src)
                yield return ParseSymbol(c);
        }

        public Span<Symbol<A>> ParseSymbols(ReadOnlySpan<char> src)
        {
            var dst = span<Symbol<A>>();
            for(var i=0; i<src.Length; i++)
                dst[i] = ParseSymbol(src[i]);
            return dst;
        }
    }    
}