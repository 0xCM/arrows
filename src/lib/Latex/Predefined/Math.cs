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
        public static readonly Syntax longright = syntax("⟶", "longrightarrow");
        public static readonly Syntax times = syntax("×", "times");
    }

}