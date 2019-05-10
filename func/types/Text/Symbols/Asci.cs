//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using static zfunc;

    public static class Asci
    {
        public static readonly Atoms All = AsciSym.All + AsciDigits.All + AsciLower.All + AsciUpper.All;
    }


    public static class AsciEscape
    {
        public static readonly Atom EOL = new Atom("\r\n");
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