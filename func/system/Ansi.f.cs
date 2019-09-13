//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Drawing;

    using static Ansi8;
    using static Ansi256;
    using static AnsiBright;
    using static AnsiGray;

    public static class ansi
    {
        public static void write(string encoded, bool eol = true)
        {
            var term = Terminal.Get();
            if(eol) 
                term.WriteLine(encoded);
            else
                term.Write(encoded);
        }            

        public static string color(string content, string code)
            => Z0.Ansi.Define(code, content);

        public static string green(string content, int level = 1)
        {
                var code = level switch {
                1 => Green1,
                2 => Green2,
                _ => Green0
            };
            return color(content, code);            
        }

        public static string pink(string content, int level = 1)        
        {
            var code = level switch {
                1 => DeepPink1,
                2 => DeepPink2,
                3 => DeepPink3,
                _ => DeepPink2
            };
            return color(content, code);
        }

        public static string equality<S,T>(S lhs, T rhs, Func<string,int,string> colorizer, int pad = 0, int level = 0)
        {
            var encoded = colorizer($"{rhs}", level);
            return 
                $"{lhs}".PadLeft(pad) 
               + " = " 
               + encoded;
        }
            
        public static string magenta(string content, int level = 1)        
        {
            var code = level switch {
                1 => Magenta1,
                2 => Magenta2,
                _ => Magenta0
            };
            return color(content, code);
        }

        public static string orchid(string content, int level = 2)        
        {
            var code = level switch {
                1 => Orchid1,
                2 => Orchid2,
                _ => Orchid0
            };
            return color(content, code);
        }

        public static string grey(string content, int level = 9, bool fg = true)
            => color(content, GrayCode(level,fg));

        public static Action<T> writer<T>(Func<string,int,string> colorizer, int level = 0)
        {
            void writeContent(T content)
            {
                write(colorizer($"{content}", level));
            }
            return writeContent;
        }

        public static Action<S,T> writer<S,T>(
            Func<string,int,string> leftColor, 
            Func<string,int,string> rightColor,  string separator,  int pad = 0, int level = 0)
        {
            void writeContent(S lhs, T rhs)
            {
                write(leftColor($"{lhs}".PadLeft(pad), level) + $" {separator} " + rightColor($"{rhs}", level));
            }
            return writeContent;
        }

    }

}