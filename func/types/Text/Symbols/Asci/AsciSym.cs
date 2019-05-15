//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;


    public sealed class AsciSym
    {
        public static readonly Atoms All =  Atoms.FromType<AsciSym>();

        public const string Amp = "&";

        public const string At = "@";

        public const string Bang = "!";

        public const string BSlash = "\\";

        public const string Caret = "^";

        public const string Colon = ":";

        public const string Comma = ",";

        public const string Dollar = "$";

        public const string Eq = "=";

        public const string FSlash = "/";

        public const string LBrace = "{";

        public const string LBracket = "[";

        public const string LParen = "(";        

        public const string Lt = "<";

        public const string Gt = ">";

        public const string Pipe = "|";

        public const string Plus = "+";

        public const string Minus = "-";

        public const string Percent = "%";
 
        public const string RParen = ")";        
        
        public const string RBrace = "}";

        public const string RBracket = "]";

        public const string Semicolon = ";";

        public const string Star = "*";

        public const string Tilde = "~";

        public class Compound
        {
            public const string Eq = "==";

            public const string GtEq = ">=";

            public const string LtEq = "<=";

            public const string NEq = "!=";

            public const string Increment = "++";

            public const string Decrement = "--";

            public const string LShift = "<<";

            public const string RShift = ">>";

        }
    }
}