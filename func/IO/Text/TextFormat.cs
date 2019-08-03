//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    public readonly struct TextFormat
    {        
        public static readonly TextFormat Default = Define();

        public static TextFormat Define(bool HasHeader = true, char Delimiter = AsciSym.Pipe, char CommentPrefix = AsciSym.Hash)
            => new TextFormat(HasHeader, Delimiter, CommentPrefix);
        
        TextFormat(bool HasHeader, char Delimiter, char? CommentPrefix)
        {
            this.HasHeader = HasHeader;
            this.Delimiter = Delimiter;
            this.CommentPrefix = CommentPrefix;
        }

        /// <summary>
        /// Indicates whether the first line of the data is a header row
        /// </summary>
        public readonly bool HasHeader;
        
        /// <summary>
        /// The character used to delimit parts of a line
        /// </summary>
        public readonly char Delimiter;

        /// <summary>
        /// Indicates a character that begins a comment
        /// </summary>
        public readonly char? CommentPrefix;
    }


}