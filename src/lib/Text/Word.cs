//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;
    using static zcore;
    using Z0;

    /// <summary>
    /// Represents a Word
    /// </summary>
    public readonly struct Word : Structure.FreeMonoid<Word,Slice<Symbol>>, Structure.Equatable<Word>
    {
        public static readonly Word Empty = new Word();        

        public static Word operator +(Word lhs, Word rhs)
            => lhs.append(rhs);
                    
        public static implicit operator Slice<Symbol>(Word s)                
            => s.data;

        public Slice<Symbol> data {get;}

        public Word empty 
            => Empty;

        public Word(params Symbol[] data)
            => this.data = data;

        public Word(IEnumerable<Symbol> data)
            => this.data = data.ToSlice();

        public Word(string data)
            => this.data = slice(symbol(data));

        public override string ToString() 
            => data.ToString();

        public bool eq(Word rhs)
            => data == rhs.data;

        public bool neq(Word rhs)
            => data != rhs;

        public IEnumerable<Word> append(IEnumerable<Word> rhs)
            => items(this).Concat(rhs);

        public Word append(Word rhs)
            => new Word(this.data.data.Concat(rhs.data.data));

        public bool Equals(Word rhs)
            => eq(rhs);

        public Word concat(Word rhs)
            => new Word(data + rhs.data);
    }

}