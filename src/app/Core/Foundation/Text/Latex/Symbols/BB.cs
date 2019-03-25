//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Expose
{
    using Z0;
    using static corefunc;
    using static Latex;


    public static class SU
    {
        public static readonly Symbol n = symbol("ⁿ",cmd("^n"));
    }


    public static class BB
    {
        public static readonly Symbol Zero = symbol("𝟘",cmd("Bbbzero"));
        public static readonly Symbol One = symbol("𝟙",cmd("Bbbone"));
        public static readonly Symbol Two = symbol("𝟚",cmd("Bbbtwo"));
        public static readonly Symbol Three = symbol("𝟛",cmd("Bbbthree"));
        public static readonly Symbol A = symbol("𝔸",cmd("BbbA"));
        public static readonly Symbol T = symbol("𝕋", cmd("BbbT"));
        public static readonly Symbol Q = symbol("ℚ",cmd("BbbQ"));
        public static readonly Symbol R = symbol("ℝ",cmd("BbbR"));            
    }

}