//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;
    using System.Linq;

    /// <summary>
    /// Represents a collection of symbols from an alphabet
    /// </summary>
    /// <typeparam name="A"></typeparam>
    public abstract class SymbolSet<S,A,K>
        where A : struct, IAlphabet<A>
        where S : SymbolSet<S,A,K>, new()
    {
            
        /// <summary>
        /// Symbol set allocation that must be populated by the concrete subtype
        /// </summary>
        protected static Symbol<A>[] _Symbols;   

        /// <summary>
        /// Symbol accessor
        /// </summary>
        public static Symbol<A>[] Symbols 
            => _Symbols;
    }

    /// <summary>
    /// Represents a collection of symbols from an alphabet whose symbols can be reduced to a single charactger
    /// </summary>
    /// <typeparam name="A"></typeparam>
    public abstract class SymbolSet<S,A> : SymbolSet<S,A,char>
        where A : struct, IAlphabet<A>
        where S : SymbolSet<S,A>, new()
    {        
        public static Symbol<A> Find(char key)
            => SymbolIndex.Find(key);
        
        protected static readonly ILookup<char, Symbol<A>> SymbolIndex 
            = _Symbols.Select(s => (s[0],s)).ToLookup();        

        public Symbol<A> this[char key]
            => SymbolIndex.Find(key);        
    }
}