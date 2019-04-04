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
    using static zcore;
    using Z0;


    partial class Structures
    {
        public interface Symbol<S,T> :  FreeMonoid<S>
            where S : Symbol<S,T>, new()
            where T : Nullary<T>, new()
        {
        }

    }
    /// <summary>
    /// Represents a symbol comprising a finite ordered sequence of atoms
    /// </summary>
    public readonly struct Symbol : Structures.Symbol<Symbol,Atom>
    {
        public static readonly Symbol Empty = new Symbol(string.Empty);

        [MethodImpl(Inline)]
        public static Symbol operator +(Symbol lhs, Symbol rhs)
            => lhs.append(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator ==(Symbol lhs, Symbol rhs)
            => lhs.atoms == rhs.atoms;

        [MethodImpl(Inline)]
        public static bool operator !=(Symbol lhs, Symbol rhs)
            => not(lhs == rhs);
            
        [MethodImpl(Inline)]
        public static implicit operator string(Symbol s)                
            => string.Concat(s.atoms.data.Select(x => x.data));

        [MethodImpl(Inline)]
        public Symbol(IEnumerable<Atom> data)
        {
            this.atoms = data.ToSlice();
        }

        [MethodImpl(Inline)]
        public Symbol(string data)
            => this.atoms = slice(new Atom(data));

        readonly Slice<Atom> atoms;

        public Symbol zero 
            => Empty;

        [MethodImpl(Inline)]
        public bool nonzero()
            => atoms.length != 0;

        public uint length 
            => atoms.length;

        public uint count 
            => length;

        public Atom this[int i] 
            => atoms[i];

        [MethodImpl(Inline)]
        public Symbol append(Symbol rhs)
            => new Symbol(atoms.data.Concat(rhs.atoms.data));

        [MethodImpl(Inline)]
        public Symbol concat(Symbol rhs)
            => new Symbol(this.atoms + rhs.atoms);

        [MethodImpl(Inline)]
        static Symbol concat(Symbol lhs, Symbol rhs)
            => lhs.concat(rhs);

        [MethodImpl(Inline)]
        public Symbol reverse()
            => new Symbol(atoms.Reverse());
                
        [MethodImpl(Inline)]
        public bool eq(Symbol rhs)
            => atoms.eq(rhs.atoms);

        [MethodImpl(Inline)]
        public bool neq(Symbol rhs)
            => atoms.neq(rhs.atoms);


        [MethodImpl(Inline)]
        public int hash()
            => atoms.GetHashCode();

    
        [MethodImpl(Inline)]
        public bool Equals(Symbol other)
            => this == other;

        [MethodImpl(Inline)]
        public string format()
            => string.Concat(apply(atoms, x => x.format()));

        public override string ToString() 
            => format();

        public override bool Equals(Object rhs)
            => rhs is Symbol ? eq((Symbol)rhs) : false;

        public override int GetHashCode() 
            => hash();

        public bool eq(Symbol lhs, Symbol rhs)
            => lhs.eq(rhs);

        public bool neq(Symbol lhs, Symbol rhs)
            => lhs.neq(rhs);
    }   
}