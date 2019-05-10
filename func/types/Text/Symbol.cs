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

    public interface ISymbol<S,T> :  IFreeMonoid<S>
        where S : ISymbol<S,T>, new()
        where T : INullary<T>, new()
    {
    }

    /// <summary>
    /// Represents a symbol comprising a finite ordered sequence of atoms
    /// </summary>
    public readonly struct Symbol : ISymbol<Symbol,Atom>
    {
        public static readonly Symbol Empty = new Symbol(string.Empty);

        [MethodImpl(Inline)]
        public static Symbol operator +(Symbol lhs, Symbol rhs)
            => lhs.append(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator ==(Symbol lhs, Symbol rhs)
            => lhs.atom == rhs.atom;

        [MethodImpl(Inline)]
        public static bool operator !=(Symbol lhs, Symbol rhs)
            => not(lhs == rhs);
            
        [MethodImpl(Inline)]
        public static implicit operator string(Symbol s)                
            => s.atom.data;

        [MethodImpl(Inline)]
        public Symbol(string data)
            => this.atom = new Atom(data);

        readonly Atom atom;

        public Symbol zero 
            => Empty;

        public uint Length 
            => 1;

        [MethodImpl(Inline)]
        public Symbol append(Symbol rhs)
            => new Symbol(new Atom(atom.data + rhs.atom.data));

        [MethodImpl(Inline)]
        public Symbol concat(Symbol rhs)
            => append(rhs);

        [MethodImpl(Inline)]
        public bool Equals(Symbol rhs)
            => atom.Equals(rhs.atom);

        public override string ToString() 
            => atom.ToString();

        public override bool Equals(Object rhs)
            => rhs is Symbol s ? Equals(s) : false;

        public override int GetHashCode() 
            => atom.GetHashCode();
    }   
}