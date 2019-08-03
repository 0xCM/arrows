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
    
    /// <summary>
    /// Represents a line of text in the context of some document
    /// </summary>
    public sealed class TextLine 
    {
        
        
        public static TextLine[] ReadAll(string text)
        {
            var lines = new List<TextLine>();
            var lineNumber = 0u;
            using (var reader = new StringReader(text))
            {
                var next = reader.ReadLine();
                while (next != null)
                {
                    lines.Add(new TextLine(++lineNumber, next));
                }
            }
            return lines.ToArray();
        }

        public static explicit operator TextLine(string text) 
            =>  new TextLine(0, text);

        public static implicit operator string(TextLine line) 
            => line.LineText;

        public TextLine(uint LineNumber, string LineText)
        {
            this.LineNumber = LineNumber;
            this.LineText = LineText;
        }
        
        public uint LineNumber { get; }
        
        public string LineText {get;}

        public char? this[int charidx]
        {
            get => charidx + 1 <= LineText.Length ? LineText[charidx] : (char?)null;
        }

        public bool IsBlank
            => string.IsNullOrWhiteSpace(LineText);

        public override string ToString() 
            =>  $"{LineNumber.ToString().PadLeft(10, '0')}:{LineText}";

        public string this[int startpos, int endpos] 
            => LineText.Substring(startpos, endpos - startpos + 1);

    }
}