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
    using static zfunc;

    using static Operative;


    public readonly struct Text : IFreeMonoid<Text>, IComparable<String>, IReversible<Text>
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
            => lhs.Concat(rhs);
        
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

        public uint Length 
            => (uint)(content.Length);

        public Text zero 
            => Empty;

        [MethodImpl(Inline)]        
        public Text(string src)
            => this._content = src;

        [MethodImpl(Inline)]        
        public Text(char[] src)
            => this._content = new string(src);

        public char this[int i]
        {
            [MethodImpl(Inline)]        
            get => content[i];
        }

        [MethodImpl(Inline)]        
        public bool Equals(Text rhs)
            => content?.Equals(rhs.content) ?? false;

        [MethodImpl(Inline)]        
        public Text Concat(Text rhs)
            => new Text(rhs.content + rhs.content);

 
        public override int GetHashCode()
            => content.GetHashCode();
        
        public override string ToString() 
            => content.ToString();
    
        public override bool Equals(object rhs)
            => rhs is Text ? Equals((Text)rhs) : false;

        [MethodImpl(Inline)]        
        public int CompareTo(string rhs)
            => content.CompareTo(rhs);

        [MethodImpl(Inline)]        
        public char[] Chars()
            => content.ToCharArray();

        [MethodImpl(Inline)]        
        public Text Reverse()
            => Chars().Reverse();
    }

}