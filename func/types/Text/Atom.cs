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
    /// Defines an indivisible sequence of characters
    /// </summary>
    public readonly struct Atom : IEquatable<Atom>, INullary<Atom>
    {
        public static readonly Atom Empty = new Atom(string.Empty);

        public static bool operator == (Atom lhs, Atom rhs)
            => lhs.data == rhs.data;

        public static bool operator != (Atom lhs, Atom rhs)
            => not(lhs == rhs);

        public static implicit operator string(Atom s)                
            => s.data;

        public static implicit operator Atom(string s)                
            => new Atom(s);

        public string data {get;}


        public Atom zero 
            => Empty;

        [MethodImpl(Inline)]
        public Atom(string data)
            => this.data = data;

        [MethodImpl(Inline)]
        public bool eq(Atom rhs)
            => data == rhs.data;

        [MethodImpl(Inline)]
        public bool neq(Atom rhs)
            => data != rhs.data;

        [MethodImpl(Inline)]
        public bool eq(Atom lhs, Atom rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public bool neq(Atom lhs, Atom rhs)
            => not(eq(lhs,rhs));


        [MethodImpl(Inline)]
        public string format()
            => data;

        [MethodImpl(Inline)]
        public bool nonzero()
            =>data != string.Empty;

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(Atom rhs)
            => eq(this,rhs);

        public override int GetHashCode() 
            => hash();

        public override string ToString() 
            => data;

        public override bool Equals(Object rhs)
            => rhs is Atom ? Equals((Atom)rhs) : false;
    }

    /// <summary>
    /// Defines an atom sequence container
    /// </summary>
    public readonly struct Atoms : ISeq<Atoms, Atom>
    {
        public static Atoms contain(IEnumerable<Atom> src)
            => new Atoms(src);

        public static Atoms operator + (Atoms lhs, Atoms rhs)
            => lhs.Concat(rhs);
                
        public Atoms(IEnumerable<Atom> src)
            => Content = src;
        
        public IEnumerable<Atom> Content {get;}

        public Atoms Concat(Atoms rhs)
            => contain(Content.Concat(rhs.Content));
    }
}