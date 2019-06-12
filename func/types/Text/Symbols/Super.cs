//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;

    /// <summary>
    /// Unicode superscript characters/sympbols
    /// </summary>
    public class Super
    {
        public const string Sup0 = "⁰";

        public const string Sup1 = "¹";

        public const string Sup2 = "²";

        public const string Sup3 = "³";

        public const string Sup4 = "⁴";

        public const string Sup5 = "⁵";

        public const string Sup6 = "⁶";

        public const string H = "ᴴ";

        public const string T = "ᵀ";

        public static string Digit(int n)
            => n switch {
            0 => Sup0,
            1 => Sup1,
            2 => Sup2,
            3 => Sup3,
            4 => Sup4,
            5 => Sup5,
            6 => Sup6,
            _  => "∅"
            };
    }
}