//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using static zfunc;
    
    public static class TextParser
    {
        /// <summary>
        /// Attempts to parse a text document and returns the result if successful
        /// </summary>
        /// <param name="src">The source document path</param>
        /// <param name="format">The document format</param>
        /// <param name="observer">An optional observer to witness intersting events</param>
        public static Option<TextDoc> ParseDocument(this FilePath src, TextFormat? format = null, Action<AppMsg> observer = null)
        {
            if(!src.Exists())
            {
                observer?.Invoke(ErrorMessages.FileDoesNotExist(src));
                return default;
            }
            
            var rows = new List<TextRow>();
            var counter = 1u;
            var fmt = format ?? TextFormat.Default;
            Option<TextHeader> header = default;
            
            try
            {
                using var reader = src.Reader();
                while(true)
                {
                    var text = reader.ParseLine(counter);
                    if(!text)
                        break;
                    
                    counter++;
                    
                    if(text.IsComment(fmt))
                        continue;

                    if(fmt.HasHeader && header.IsNone() && rows.Count == 0)
                        text.OnSome(line => line.ParseHeader(in fmt, observer)
                                                .OnSome(h => header = h));
                    else
                        text.OnSome(line => line.ParseRow(in fmt,observer)
                                            .OnSome(row => rows.Add(row)));
                }
            }
            catch(Exception e)
            {
                observer?.Invoke(errorMsg(e));
            }


            return new TextDoc(fmt, header, counter, rows.ToArray());
        }

        /// <summary>
        /// Parses a header row from a line of text
        /// </summary>
        /// <param name="src">The source line</param>
        /// <param name="spec">The text format</param>
        /// <param name="observer">An observer to witness interesting events</param>
        public static Option<TextHeader> ParseHeader(this TextLine src, in TextFormat spec, Action<AppMsg> observer = null)
            => new TextHeader(src.LineText.SplitLine(spec).Select(x => x.Trim()).Where(x => x != string.Empty).ToArray());
            
        public static TextLine[] ParseLines(string text)
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

        /// <summary>
        /// Parses a row from a line of text
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="spec">The text format spec</param>
        public static Option<TextRow> ParseRow(this TextLine src, in TextFormat spec, Action<AppMsg> observer = null)
        {            
            if(src.IsBlank || (spec.CommentPrefix != null && src[0] == spec.CommentPrefix))
                return default;
            else
            {            
                var parts = src.LineText.SplitLine(spec);
                var data = new TextCell[parts.Length];
                for(var i=0u; i<parts.Length; i++)
                    data[i] = new TextCell(src.LineNumber, i, parts[i].Trim());
                return new TextRow(data);
            }
        }

        /// <summary>
        /// Reads a file to produce a <see cref='TextDoc'/>
        /// </summary>
        /// <param name="src">The soruce file path</param>
        /// <param name="format">The file format</param>
        public static Option<TextDoc> ReadTextDoc(this FilePath src, TextFormat? format = null)
            => src.ParseDocument(format, message => print(message));

        static Option<TextLine> ParseLine(this StreamReader reader, uint lineNumber)
        {
            var result = reader.ReadLine();
            return result == null ? default : new TextLine(lineNumber, result.Trim());            
        }

        static bool IsComment(this Option<TextLine> line, TextFormat format)
            =>  line.Map(src => !src.IsBlank && src.LineText[0] == format.CommentPrefix, () => false);
    
        [MethodImpl(Inline)]
        static string[] SplitLine(this string src, in TextFormat spec)
            => src[0]  == spec.Delimiter 
                    ? src.Substring(1).Split(spec.Delimiter) 
                    : src.Split(spec.Delimiter);

    }

}