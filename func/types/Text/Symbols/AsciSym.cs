//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using static zfunc;

    public class AsciSymK
    {
        public const string Pipe = "|";

        public const string Plus = "+";

        public const string Minus = "-";

        public const string Eq = "=";

       public const string Lt = "<";

        public const string Gt = ">";

        public const string Bang = "!";

        public const string At = "@";

        public const string Dollar = "$";

        public const string Percent = "%";

        public const string Caret = "^";

        public const string Amp = "&";

        public const string Star = "*";

        public const string LParen = "(";        

        public const string RParen = ")";        
        
        public const string LBrace = "{";

        public const string RBrace = "}";

        public const string LBracket = "[";

        public const string RBracket = "]";

        public const string BSlash = "\\";

        public const string FSlash = "/";

        public const string Colon = ":";

        public const string Comma = ",";

        public const string Semicolon = ";";

 
 
    }


    public class AsciSym
    {
        public static readonly Atoms All =  type<AsciSym>().DeclaredFields().Static().Values<Atom>().Contain();

        public static readonly Atom Pipe = AsciSymK.Pipe;

        public static readonly Atom Plus = AsciSymK.Plus;

        public static readonly Atom Minus = AsciSymK.Minus;

        public static readonly Atom Eq = AsciSymK.Eq;

        public static readonly Atom Lt = AsciSymK.Lt;

        public static readonly Atom Gt = AsciSymK.Gt;

        public static readonly Atom Bang = "!";

        public static readonly Atom At = "@";

        public static readonly Atom Dollar = "$";

        public static readonly Atom Percent = "%";

        public static readonly Atom Caret = "^";

        public static readonly Atom Amp = "&";

        public static readonly Atom Star = "*";

        public static readonly Atom LParen = "(";        

        public static readonly Atom RParen = ")";        
        
        public static readonly Atom LBrace = "{";

        public static readonly Atom RBrace = "}";

        public static readonly Atom LBracket = "[";

        public static readonly Atom RBracket = "]";

        public static readonly Atom BSlash = "\\";

        public static readonly Atom FSlash = "/";

        public static readonly Atom Colon = ":";

        public static readonly Atom Comma = ",";

        public static readonly Atom Semicolon = ";";

    }



}