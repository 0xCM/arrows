//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using Z0;
    using static zcore;
    using static LatexCmd;

    public static class Math
    {
        public static readonly Syntax longright = syntax(MathSym.LongRightArrow, "longrightarrow");
        public static readonly Syntax times = syntax(MathSym.Times, "times");

        public static readonly Syntax inf = syntax(MathSym.Infinity, "infty");

        public static readonly Syntax otimes = syntax(MathSym.OTimes,"otimes");        

        public static readonly Syntax oplus = syntax(MathSym.Oplus,"oplus");

        public static readonly Syntax wedge = syntax(MathSym.Wedge,"wedge");

        public static readonly Syntax vee = syntax(MathSym.Vee,"vee");

        public static readonly Syntax partial = syntax(MathSym.Partial, "partial");

        public static readonly Syntax emptyset = syntax(MathSym.EmptySet, "emptyset");

    }

}