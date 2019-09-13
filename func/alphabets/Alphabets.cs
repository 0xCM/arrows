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

    public static class Alphabets
    {
        static readonly AsciAlphabet _Asci = AsciAlphabet.Get();
        
        /// <summary>
        /// Accessor for canonical asci alphabet
        /// </summary>
        public static AsciAlphabet Asci
            => _Asci;

        /// <summary>
        /// Constructs a new word by appending a symbol to an exising word
        /// </summary>
        /// <param name="w">The source word whose symbols will begin the new word</param>
        /// <param name="s">The symbols that will be appended to the source word</param>        
        public static Word<A> Concat<A>(this Word<A> w, params Symbol<A>[] s)
            where A : struct, IAlphabet<A>
        {
            var dst = array<Symbol<A>>(w.Length + s.Length);
            w.Symbols.CopyTo(dst, 0);
            s.CopyTo(dst, w.Length);
            return new Word<A>(dst);
        }

        /// <summary>
        /// Constructs a new word by appending a word to a symbol
        /// </summary>
        /// <param name="w">The source word whose symbols will begin the new word</param>
        /// <param name="s">The symbols that will be appended to the source word</param>        
        public static Word<A> Concat<A>(this Symbol<A> s, Word<A> w)
            where A : struct, IAlphabet<A>
        {
            var dst = array<Symbol<A>>(1 + w.Length);
            dst[0] = s;
            w.Symbols.CopyTo(dst, 1);
            return new Word<A>(dst);
        }

        /// <summary>
        /// Constructs a new word by appending a word to a sequence of symbols
        /// </summary>
        /// <param name="w">The source word whose symbols will begin the new word</param>
        /// <param name="s">The symbols that will be appended to the source word</param>        
        public static Word<A> Concat<A>(this Symbol<A>[] s, Word<A> w)
            where A : struct, IAlphabet<A>
        {
            var dst = array<Symbol<A>>(s.Length + w.Length);
            s.CopyTo(dst, 0);
            w.Symbols.CopyTo(dst, s.Length);
            return new Word<A>(dst);
        }
    }
}