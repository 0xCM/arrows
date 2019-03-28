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
    /// Represents a symbol
    /// </summary>
    public readonly struct Symbol : Traits.FreeMonoid<Symbol,Slice<Atom>>, IEquatable<Symbol>
    {
        public static readonly Symbol Empty = new Symbol(string.Empty);

        public static Symbol operator +(Symbol lhs, Symbol rhs)
            => lhs.append(rhs);
        
        public static bool operator ==(Symbol lhs, Symbol rhs)
            => lhs.data == rhs.data;

        public static bool operator !=(Symbol lhs, Symbol rhs)
            => not(lhs == rhs);
            
        public static implicit operator string(Symbol s)                
            => string.Concat(s.data.data.Select(x => x.data));

        public Symbol(IEnumerable<Atom> data)
        {
            this.data = data.ToSlice();
            this.description = string.Empty;
        }

        public Symbol(string data, string description = null)
        {
            this.data = slice(new Atom(data));
            this.description = description ?? string.Empty;
        }

        public string description {get;}


        public Slice<Atom> data {get;}

        public string name
            => this;

        public Symbol empty 
            => Empty;

        public bool eq(Symbol rhs)
            => name == rhs;

        public bool neq(Symbol rhs)
            => name != rhs;

        public Symbol append(Symbol rhs)
            => new Symbol(data.data.Concat(rhs.data.data));

        public override string ToString() 
            => name;

        public override int GetHashCode() 
            => data.GetHashCode();

        public bool Equals(Symbol other)
            => this == other;

        public override bool Equals(Object rhs)
            => rhs is Symbol ? Equals((Symbol)rhs) : false;

        public bool eq(Slice<Atom> lhs, Slice<Atom> rhs)
            => throw new NotImplementedException();

        bool Traits.Equatable<Symbol>.eq(Symbol lhs, Symbol rhs)
            => lhs.eq(rhs);
 
        bool Traits.Equatable<Symbol>.neq(Symbol lhs, Symbol rhs)
            => lhs.neq(rhs);

        Symbol Traits.Concatenable<Symbol>.concat(Symbol lhs, Symbol rhs)
            => lhs.append(rhs);

    }
   
}