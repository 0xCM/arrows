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
    /// Represents an atomic value
    /// </summary>
    public readonly struct Symbol
    {
        public static readonly Symbol Empty = new Symbol(string.Empty);

        public static Symbol Define(string text)
            => new Symbol(text);
        
        [MethodImpl(Inline)]
        public static bool operator ==(Symbol lhs, Symbol rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator !=(Symbol lhs, Symbol rhs)
            => not(lhs == rhs);
            
        [MethodImpl(Inline)]
        public static implicit operator string(Symbol s)                
            => s.data;

        [MethodImpl(Inline)]
        public Symbol(string data)
            => this.data = data;

        readonly string data;


        [MethodImpl(Inline)]
        public bool Equals(Symbol rhs)
            => data.Equals(rhs.data);

        public override string ToString() 
            => data.ToString();

        public override bool Equals(Object rhs)
            => rhs is Symbol s ? Equals(s) : false;

        public override int GetHashCode() 
            => data.GetHashCode();
    }   

    /// <summary>
    /// Represents a symbol belonging to an alphabet A
    /// </summary>
    public readonly struct Symbol<A> : ISymbol<A>
        where A : struct, IAlphabet<A>
    {        
        readonly char c0;
        
        readonly char c1;

        /// <summary>
        /// Uses the unicode null symbol to represent an empty character
        /// </summary>
        const char EmptyChar = '\0';

        public static readonly Symbol<A> Empty = new Symbol<A>(string.Empty);
        
        public static Symbol<A> Define(string text)
            => new Symbol<A>(text);
        
        public static Symbol<A> Define(char c0, char? c1 = null)
            => new Symbol<A>(c0, c1);

        public static implicit operator Symbol<A>(char c0)
            => Define(c0);
                             
        /// <summary>
        /// Concatenates two symbols to form a word
        /// </summary>
        /// <param name="lhs">The left symbol, which will form the head of the new word</param>
        /// <param name="rhs">The right symbol, which will form the tail of the new word</param>
        [MethodImpl(Inline)]
        public static Word<A> operator +(Symbol<A> lhs, Symbol<A> rhs)
            => new Symbol<A>[]{lhs,rhs};

        [MethodImpl(Inline)]
        public static bool operator ==(Symbol<A> lhs, Symbol<A> rhs)
            => lhs.c0 == rhs.c0  && lhs.c1 == rhs.c1;

        [MethodImpl(Inline)]
        public static bool operator !=(Symbol<A> lhs, Symbol<A> rhs)
            => not(lhs == rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(Symbol<A> lhs, char rhs)
            => lhs.c0 == rhs && lhs.c1 == EmptyChar;

        [MethodImpl(Inline)]
        public static bool operator !=(Symbol<A> lhs, char rhs)
            => not(lhs == rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(char lhs, Symbol<A> rhs)
            => lhs == rhs.c0 && rhs.c1 == EmptyChar;

        [MethodImpl(Inline)]
        public static bool operator !=(char lhs, Symbol<A> rhs)
            =>not(lhs == rhs);

        [MethodImpl(Inline)]
        public Symbol(char c0, char? c1 = null)
        {
            this.c0 = c0;
            this.c1 = c1 ?? EmptyChar;
        }

        [MethodImpl(Inline)]
        public Symbol(string data)
        {
            if(data.Length == 1)
            {
                c0 = data[0];
                c1 = EmptyChar;
            }
            else if(data.Length == 2)
            {
                c0 = data[0];
                c1 = data[1];
            }
            else
                throw new ArgumentException($"Symbol data has length of either 1 or 2");        
        }

        public char this[int index]            
        {
            get
            {
                if(index == 0)
                    return c0;
                else if(index == 1)
                    return c1;
                else
                    throw new ArgumentException($"Symbol data is indexed by 0 and 1");
            }
        }

        [MethodImpl(Inline)]
        public bool Equals(Symbol<A> rhs)
            => this == rhs;
        
        public ReadOnlySpan<char> Content
            => c1 != EmptyChar ? new char[]{c0,c1} : new char[c0];

        public string Format()
            => c1 == EmptyChar ? c0.ToString() : $"{c0}{c1}";   
        
        public override string ToString() 
            => Format();

        public override bool Equals(object rhs)
            => rhs is Symbol<A> s ? Equals(s) : false;

        public override int GetHashCode() 
            =>  hash(c0,c1);

   }
}