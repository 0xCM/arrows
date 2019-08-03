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
    using static zfunc;
    


    public static class TextParser
    {
        static Option<TextLine> ReadTextLine(this StreamReader reader, uint lineNumber)
        {
            var result = reader.ReadLine();
            return result == null ? default : new TextLine(lineNumber, result.Trim());            
        }

        static bool IsComment(this Option<TextLine> line, TextFormat format)
            =>  line.Map(src => !src.IsBlank && src.LineText[0] == format.CommentPrefix, () => false);

        public static Option<TextDoc> ParseDocument(this FilePath src, TextFormat? format = null, Action<AppMsg> observer = null)
        {
            if(!src.Exists())
            {
                observer?.Invoke(errorMsg($"The file {src} does not exist"));
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
                    var text = reader.ReadTextLine(counter);
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
                observer?.Invoke(errorMsg(e.Message));
            }


            return new TextDoc(fmt, header, counter, rows.ToArray());
        }

        public static Option<TextHeader> ParseHeader(this TextLine src, in TextFormat spec, Action<AppMsg> observer = null)
            => new TextHeader(src.LineText.SplitLine(spec).Select(x => x.Trim()).Where(x => x != string.Empty).ToArray());


        static string[] SplitLine(this string src, in TextFormat spec)
            => src[0] 
                    == spec.Delimiter 
                    ? src.Substring(1).Split(spec.Delimiter) 
                    : src.Split(spec.Delimiter);



        /// <summary>
        /// Parses a text row from a line of text
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="spec">The text format spec</param>
        public static Option<TextRow> ParseRow(this TextLine src, in TextFormat spec, Action<AppMsg> observer = null)
        {            
            if(spec.CommentPrefix != null && src[0] == spec.CommentPrefix)
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

    }

}