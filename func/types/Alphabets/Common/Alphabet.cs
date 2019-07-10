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

    public interface ISymbolic
    {
        string Format();
    }        
    public interface ISymbol<A> : ISymbolic
        where A : struct, IAlphabet<A>
    {
        ReadOnlySpan<char> Content {get;}
    }

    public interface IAlphabet<A> : ISymbolic
        where A : struct, IAlphabet<A>
    {
        /// <summary>
        /// Enumerates the symbols defined by an alphabet
        /// </summary>
        IEnumerable<Symbol<A>> Symbols {get;}    

    }

    public interface IWord<W,A> : IFreeMonoid<W>, ISymbolic
        where A : struct, IAlphabet<A>
        where W : struct, IWord<W,A>, IFreeMonoid<W>
    {
        ReadOnlySpan<char> Content {get;}
    }

}
