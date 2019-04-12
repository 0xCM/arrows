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
        public static readonly Syntax longright = syntax(MathSym.longrightarrow, "longrightarrow");
        public static readonly Syntax times = syntax(MathSym.times, "times");

        public static readonly Syntax inf = syntax(MathSym.infinity, "infty");

        public static readonly Syntax otimes = syntax(MathSym.otimes,"otimes");        

        public static readonly Syntax oplus = syntax(MathSym.oplus,"oplus");

        public static readonly Syntax wedge = syntax(MathSym.wedge,"wedge");

        public static readonly Syntax vee = syntax(MathSym.vee,"vee");

        public static readonly Syntax partial = syntax(MathSym.partial, "partial");

        public static readonly Syntax emptyset = syntax(MathSym.emptyset, "emptyset");

    }

}