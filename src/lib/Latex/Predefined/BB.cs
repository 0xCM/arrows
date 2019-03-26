//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using Z0;
    using static zcore;
    using static LatexCmd;



    public static class BB
    {
        public static readonly Syntax Zero = syntax("𝟘","Bbbzero");
        public static readonly Syntax One = syntax("𝟙","Bbbone");
        public static readonly Syntax Two = syntax("𝟚","Bbbtwo");
        public static readonly Syntax Three = syntax("𝟛","Bbbthree");
        public static readonly Syntax A = syntax("𝔸","BbbA");
        public static readonly Syntax T = syntax("𝕋", "BbbT");
        public static readonly Syntax Q = syntax("ℚ","BbbQ");
        public static readonly Syntax R = syntax("ℝ","BbbR");            
    }

}