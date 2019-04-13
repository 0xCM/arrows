//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zcore;
 
    public static class Asci
    {
        public static readonly Atoms All = AsciSym.All + AsciDigits.All + AsciLower.All + AsciUpper.All;
    }

    public class AsciSym
    {
        public static readonly Atoms All =  type<AsciSym>().DeclaredFields().Static().Values<Atom>().Contain();

        public static readonly Atom Pipe = "|";

        public static readonly Atom Plus = "+";

        public static readonly Atom Minus = "-";

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

    public static class AsciEscape
    {
        public static readonly Atom EOL = new Atom("\r\n");
    }

    public class AsciLower
    {
        public static readonly Atoms All =  type<AsciLower>().DeclaredFields().Static().Values<Atom>().Contain();

        public static readonly Atom a = "a";
        public static readonly Atom b = "b";
        public static readonly Atom c = "c";
        public static readonly Atom d = "d";
        public static readonly Atom e = "e";
        public static readonly Atom f = "f";
        public static readonly Atom g = "g";
        public static readonly Atom h = "h";
        public static readonly Atom i = "i";
        public static readonly Atom j = "j";
        public static readonly Atom k = "k";
        public static readonly Atom l = "l";
        public static readonly Atom m = "m";
        public static readonly Atom n = "n";
        public static readonly Atom o = "o";
        public static readonly Atom p = "p";
        public static readonly Atom q = "q";
        public static readonly Atom r = "r";
        public static readonly Atom s = "s";
        public static readonly Atom t = "t";
        public static readonly Atom u = "u";
        public static readonly Atom v = "v";
        public static readonly Atom w = "w";
        public static readonly Atom x = "x";
        public static readonly Atom y = "y";
        public static readonly Atom z = "z";

    }

    public class AsciUpper
    {        
        public static readonly Atoms All =  type<AsciUpper>().DeclaredFields().Static().Values<Atom>().Contain();
        
        public static readonly Atom A = "A";
        public static readonly Atom B = "B";
        public static readonly Atom C = "C";
        public static readonly Atom D = "D";
        public static readonly Atom E = "E";
        public static readonly Atom F = "F";
        public static readonly Atom G = "G";
        public static readonly Atom H = "H";
        public static readonly Atom I = "I";
        public static readonly Atom J = "J";
        public static readonly Atom L = "L";
        public static readonly Atom M = "M";
        public static readonly Atom N = "N";
        public static readonly Atom O = "O";
        public static readonly Atom P = "P";
        public static readonly Atom Q = "Q";
        public static readonly Atom R = "R";
        public static readonly Atom S = "S";
        public static readonly Atom T = "T";
        public static readonly Atom U = "U";
        public static readonly Atom V = "V";
        public static readonly Atom W = "W";
        public static readonly Atom X = "X";
        public static readonly Atom Y = "Y";
        public static readonly Atom Z = "Z";


   }

    public class AsciDigits
    {
        public static readonly Atoms All =  type<AsciDigits>().DeclaredFields().Static().Values<Atom>().Contain();

        public static readonly Atom A0 = "1";
        public static readonly Atom A1 = "1";
        public static readonly Atom A2 = "2";
        public static readonly Atom A3 = "3";
        public static readonly Atom A4 = "4";
        public static readonly Atom A5 = "5";
        public static readonly Atom A6 = "6";
        public static readonly Atom A7 = "7";
        public static readonly Atom A8 = "8";
        public static readonly Atom A9 = "9";
    }
}