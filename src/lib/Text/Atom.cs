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
    /// Represents a Atom
    /// </summary>
    public readonly struct Atom : IEquatable<Atom>, Structure.Equatable<Atom>, Operative.Equatable<Atom>
    {
        public static readonly Atom Empty = new Atom(string.Empty);

        // public static Slice<Atom> operator +(Atom lhs, Atom rhs)
        //     => slice(lhs,rhs);

        public static bool operator ==(Atom lhs, Atom rhs)
            => lhs.data == rhs.data;

        public static bool operator !=(Atom lhs, Atom rhs)
            => not(lhs == rhs);

        public static implicit operator string(Atom s)                
            => s.data;

        public static implicit operator Atom(string s)                
            => new Atom(s);

        public string data {get;}

        public Atom empty 
            => Empty;

        public Atom(string data)
            => this.data = data;

        public bool eq(Atom rhs)
            => data == rhs.data;

        public bool neq(Atom rhs)
            => data != rhs.data;

        public bool eq(Atom lhs, Atom rhs)
            => lhs.data == rhs.data;

        public bool neq(Atom lhs, Atom rhs)
            => not(eq(lhs,rhs));

        public override string ToString() 
            => data;

        public override bool Equals(Object rhs)
            => rhs is Atom ? Equals((Atom)rhs) : false;

        public override int GetHashCode() 
            => data.GetHashCode();


        public bool Equals(Atom rhs)
            => eq(this,rhs);
    }
   
}