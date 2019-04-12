//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;
    using static Operative;


    public readonly struct Text : Structures.FreeMonoid<Text>, Formattable, IComparable<String>, Structures.Reversible<Text>
    {    
        public static readonly Text Empty = new Text(string.Empty);

        [MethodImpl(Inline)]        
        public static bool operator ==(Text lhs, Text rhs)
            => lhs.content == rhs.content;

        [MethodImpl(Inline)]        
        public static bool operator !=(Text lhs, Text rhs)
            => lhs.content != rhs.content;

        [MethodImpl(Inline)]        
        public static Text operator +(Text lhs, Text rhs)
            => lhs.concat(rhs);
        
        [MethodImpl(Inline)]        
        public static implicit operator string(Text src)
            => src.content;

        [MethodImpl(Inline)]        
        public static implicit operator Text(char[] src)
            => new Text(src);

        readonly string _content;

        string content
        {
            [MethodImpl(Inline)]
            get => _content ?? string.Empty;
        }

        public uint length 
            => (uint)(content.Length);

        public Text zero 
            => Empty;

        [MethodImpl(Inline)]        
        public Text(string src)
            => this._content = src;

        [MethodImpl(Inline)]        
        public Text(char[] src)
            => this._content = new string(src);

        [MethodImpl(Inline)]        
        public bool eq(Text rhs)
            => content?.Equals(rhs.content) ?? false;

        [MethodImpl(Inline)]        
        public bool neq(Text rhs)
            => not(eq(rhs));

        [MethodImpl(Inline)]        
        public int hash()
            => content.GetHashCode();

        public char this[int i]
        {
            [MethodImpl(Inline)]        
            get => content[i];
        }

        [MethodImpl(Inline)]        
        public bool Equals(Text rhs)
            => eq(rhs);

        [MethodImpl(Inline)]        
        public Text concat(Text rhs)
            => new Text(rhs.content + rhs.content);

        [MethodImpl(Inline)]        
        public string format()
            => content.ToString();
 
        public override int GetHashCode()
            => hash();
        
        public override string ToString() 
            => format();
    
        public override bool Equals(object rhs)
            => rhs is Text ? eq((Text)rhs) : false;

        [MethodImpl(Inline)]        
        public int CompareTo(string rhs)
            => content.CompareTo(rhs);

        [MethodImpl(Inline)]        
        public char[] chars()
            => content.ToCharArray();

        [MethodImpl(Inline)]        
        public Text reverse()
            => Arr.reverse(chars());

    }
    

}