//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Linq;

    using static zfunc;

    public sealed class AsciSym : SymbolSet<AsciSym, AsciAlphabet>
    {
        static AsciSym()
        {
            _Symbols = new Symbol<AsciAlphabet>[]
            {
                Amp, At, Bang, BSlash, Caret, Colon, Comma,Dollar, Dot, Eq,
                FSlash, Gt, LBrace, LBracket, LParen, Lt, Minus, Pipe, Plus,
                Percent, Quote, RParen, RBrace, RBracket, Semicolon, Space,
                SQuote, Star, Tilde,
            };            
        }

        public const char Amp = '&';

        public const char At = '@';

        public const char Bang = '!';

        public const char BSlash = '\\';

        public const char Caret = '^';

        public const char Colon = ':';

        public const char Comma = ',';

        public const char Dollar = '$';

        public const char Dot = '.';

        public const char Eq = '=';

        public const char FSlash = '/';

        public const char Gt = '>';

        public const char LBrace = '{';

        public const char LBracket = '[';

        public const char LParen = '(';        

        public const char Lt = '<';

        public const char Minus = '-';

        public const char Pipe = '|';

        public const char Plus = '+';

        public const char Percent = '%';

        /// <summary>
        /// Specifies '"', the double-quote symbol
        /// </summary>
        public const char Quote = '\"';

        public const char RParen = ')';        
        
        public const char RBrace = '}';

        public const char RBracket = ']';

        public const char Semicolon = ';';

        public const char Space = ' ';

        /// <summary>
        /// Specifies ''', the single-quote symbol
        /// </summary>
        public const char SQuote = '\'';

        public const char Star = '*';

        public const char Tilde = '~'; 
    }
}