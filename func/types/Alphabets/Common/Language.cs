//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static zfunc;

    public static class Language
    {

    }

    /// <summary>
    /// Encodes a language over a an alphabet A, where a language is understood
    /// to be a set of words over A
    /// </summary>
    /// <typeparam name="A">The alphabet over which the language is defined</typeparam>
    /// <remarks>A language is typically infinite, which we encode by an enumerable generator</remarks>
    public abstract class Language<L,A>
        where A : struct, IAlphabet<A>
        where L : Language<L,A>, new()
    {        
        public abstract IEnumerable<Word<A>> Words {get;}
    }

    public abstract class Language<L,A,W>
        where L : Language<L,A,W>, new()
        where A : struct, IAlphabet<A>
        where W : struct, IWord<W,A>
    {
        public abstract IEnumerable<W> Words(int len);
    }
}