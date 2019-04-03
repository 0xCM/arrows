//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Runtime.CompilerServices;
    using System.Linq;
    using static zcore;
    using Z0;

    /// <summary>
    /// Represents a symbol comprising a finite ordered sequence of symbols
    /// </summary>
    public readonly struct Word : Structures.FreeMonoid<Word>
    {
        public static readonly Word Empty = new Word();        

        [MethodImpl(Inline)]
        public static Word operator +(Word lhs, Word rhs)
            => lhs.append(rhs);
                    
        [MethodImpl(Inline)]
        public static implicit operator Slice<Symbol>(Word s)                
            => s.symbols;

        readonly Slice<Symbol> symbols;

        [MethodImpl(Inline)]
        public Word(params Symbol[] data)
            => this.symbols = data;

        [MethodImpl(Inline)]
        public Word(IEnumerable<Symbol> data)
            => this.symbols = data.Freeze();

        [MethodImpl(Inline)]
        public Word(string data)
            => this.symbols = slice(symbol(data));

        public Word zero 
            => Empty;

        public uint length 
            => symbols.length;

        [MethodImpl(Inline)]
        public bool eq(Word rhs)
            => symbols == rhs.symbols;

        [MethodImpl(Inline)]
        public bool neq(Word rhs)
            => symbols != rhs;

        [MethodImpl(Inline)]
        public Word append(Word rhs)
            => new Word(this.symbols.data.Concat(rhs.symbols.data));

        public Word concat(Word rhs)     
            => new Word(symbols + rhs.symbols);

        [MethodImpl(Inline)]
        public bool nonzero()
            => symbols.length != 0;

        [MethodImpl(Inline)]
        public bool eq(Word lhs, Word rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool neq(Word lhs, Word rhs)
            => lhs.neq(rhs);


        [MethodImpl(Inline)]
        public string format()
            => symbols.ToString();

        [MethodImpl(Inline)]
        public int hash()
            => symbols.hash();

        [MethodImpl(Inline)]
        public bool Equals(Word rhs)
            => eq(rhs);

        public override string ToString() 
            => symbols.ToString();

    }

}