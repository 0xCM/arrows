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

    /// <summary>
    /// Encodes a finite, ordered sequence of symbols over some alphabet A
    /// In the literature, a 'word' in this context is often referred to as a
    /// 'string' - the usage of which is avoided here, for obvious reasons.
    /// </summary>
    public readonly struct Word<A> : IWord<Word<A>,A>
        where A : struct, IAlphabet<A>
    {            
        /// <summary>
        /// Represents the empty word, with an invariant length of 0
        /// </summary>
        /// <typeparam name="A">The alphabet type</typeparam>
        public static readonly Word<A> Empty = new Word<A>(Symbol<A>.Empty);

        /// <summary>
        /// The symbols that comprise the word
        /// </summary>
        public readonly Symbol<A>[] Symbols;

        /// <summary>
        /// Determines whether two words are equivalent
        /// </summary>
        /// <param name="lhs">The first word</param>
        /// <param name="rhs">The second word</param>
        public static bool operator == (Word<A> lhs, Word<A> rhs)
            => lhs.Symbols == rhs.Symbols;

        /// <summary>
        /// Determines whether two words are unequal
        /// </summary>
        /// <param name="lhs">The first word</param>
        /// <param name="rhs">The second word</param>
        public static bool operator != (Word<A> lhs, Word<A> rhs)
            => not(lhs == rhs);

        /// <summary>
        /// Converts the word to a string via a canonical format
        /// </summary>
        /// <param name="src">The source word</param>
        public static implicit operator string(Word<A> src)
            => src.Format();

        /// <summary>
        /// Encloses an array of symbols by a word
        /// </summary>
        /// <param name="src">The source symbols</param>
        /// <typeparam name="A">The alphabet</typeparam>
        public static implicit operator Word<A>(Symbol<A>[] src)
            => new Word<A>(src);

        /// <summary>
        /// Converts a word to its equivalent symbolic representation
        /// </summary>
        /// <param name="src">The source word</param>
        public static implicit operator Symbol<A>[](Word<A> src)
            => src.Symbols;

        /// <summary>
        /// Concatenates a word *w* and a symbol *s* to form a new word w' := ws
        /// </summary>
        /// <param name="w">The left word, which will form the beginning of the new word</param>
        /// <param name="s">The right symbol, which will form the conclusing symbol of the new word</param>
        public static Word<A> operator +(Word<A> w, Symbol<A> s)
            => w.Concat(s);

        /// <summary>
        /// Concatenates a symbol *s* and a word *w* to form a new word w' := sw
        /// </summary>
        /// <param name="s">The symbol that will form the head of the new word</param>
        /// <param name="w">The word that will form the tail of the new word</param>
        public static Word<A> operator +(Symbol<A> s, Word<A> w)
            => s.Concat(w);

        /// <summary>
        /// Concatenates a word w1 with a word w2 to form a word w' = w1w2
        /// </summary>
        /// <param name="w1">The first word</param>
        /// <param name="w2">The second word</param>
        public static Word<A> operator +(Word<A> w1, Word<A> w2)
            => new Word<A>(w1,w2);

        /// <summary>
        /// The empty word containing no symbols
        /// </summary>
        public Word<A> Zero 
            => Empty;

        /// <summary>
        /// Specifies the number of symbols that comprise the word
        /// </summary>
        public uint Length
            => (uint)Symbols.Length;

        [MethodImpl(Inline)]
        public Word(params Word<A>[] Words)
        {
            
            var len = Words.Sum(s => s.Length);
            this.Symbols = new Symbol<A>[len];
            var symidx = 0;
            for(var i=0; i< Words.Length; i++)
            {
                var word = Words[i];
                for(var j = 0; j< word.Length; j++)
                    this.Symbols[symidx++] = word.Symbols[j];
            }
        }

        [MethodImpl(Inline)]
        public Word(params Symbol<A>[] Symbols)
        {            
            if(Symbols.Length == 1 && Symbols[0] == Symbol<A>.Empty)
                this.Symbols = new Symbol<A>[]{};
            else
                this.Symbols = Symbols;
        }

        public Symbol<A> this[int index]
        {
            [MethodImpl(Inline)]
            get => Symbols[index];
        }

        public bool IsEmpty
            => Symbols.Length == 0;

        public ReadOnlySpan<char> Content
            => string.Join(string.Empty, Symbols);

        /// <summary>
        /// Formats the word as a string
        /// </summary>
        public string Format()
            => string.Join(string.Empty, Symbols);

        [MethodImpl(Inline)]
        public bool Equals(Word<A> rhs)
        {
            if(Length != rhs.Length)
                return false;

            for(var i=0; i< rhs.Symbols.Length; i++)   
                if(!Symbols[i].Equals(rhs.Symbols[i]))
                    return false;
            return true;
        }

        public override int GetHashCode() 
            => Format().GetHashCode();

        public override string ToString() 
            => Format();

        public override bool Equals(Object rhs)
            => rhs is Word<A> ? Equals((Word<A>)rhs) : false;

        /// <summary>
        /// Concatenates this word w1 with another word w2 to form a new word w1w2
        /// </summary>
        /// <param name="w2">The word to concatenate with the current word</param>
        public Word<A> Concat(Word<A> w2)
            => new Word<A>(this,w2);
    }
}