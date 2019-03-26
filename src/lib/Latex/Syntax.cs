//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0;
    using static zcore;
    using static LatexCmd;


    /// <summary>
    /// Represents a Syntax
    /// </summary>
    public readonly struct Syntax : IEquatable<Syntax>
    {
        public static readonly Syntax Empty = new Syntax(string.Empty, string.Empty);

        public static Syntax operator +(Syntax lhs, Syntax rhs)
            => lhs.append(rhs);
        
        public static bool operator ==(Syntax lhs, Syntax rhs)
            => lhs.identity == rhs.identity;

        public static bool operator !=(Syntax lhs, Syntax rhs)
            => not(lhs == rhs);
            


        public Syntax(string identity, string expression, string alias = null)
        {
            this.identity = identity;
            this.expression = expression ?? string.Empty;
            this.alias = alias ?? string.Empty;
        }
        
        public string identity {get;}

        public string expression {get;}

        public string alias {get;}

        public Syntax empty 
            => Empty;

        public bool eq(Syntax rhs)
            => this == rhs;

        public bool neq(Syntax rhs)
            => this != rhs;

        public Syntax append(Syntax rhs)
            => new Syntax(
                    this.identity + rhs.identity, 
                    this.expression + rhs.expression,
                    this.alias + rhs.alias
                    );

        public override string ToString() 
            => identity;

        public override int GetHashCode() 
            => identity.GetHashCode();

        public bool Equals(Syntax other)
            => this == other;

        public override bool Equals(Object rhs)
            => rhs is Syntax ? Equals((Syntax)rhs) : false;

    }

}