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
    public readonly struct Atom :  INullary<Atom>
    {
        public static Atom Define(string text)
            => new Atom(text);
        public static readonly Atom Empty = new Atom(string.Empty);

        public static bool operator == (Atom lhs, Atom rhs)
            => lhs.data == rhs.data;

        public static bool operator != (Atom lhs, Atom rhs)
            => not(lhs == rhs);

        public static implicit operator string(Atom a)                
            => a.data;

        public static implicit operator Atom(string src)                
            => new Atom(src);

        public static implicit operator Atom(char src)                
            => new Atom(src);

        public string data {get;}

        public Atom zero 
            => Empty;

        [MethodImpl(Inline)]
        public Atom(string data)
            => this.data = data;

        [MethodImpl(Inline)]
        public Atom(char data)
            => this.data = data.ToString();

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


}