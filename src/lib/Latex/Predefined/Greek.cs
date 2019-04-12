//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using Z0;

    using static zcore;
    using static LatexCmd;

    public static class Greek
    {
                
        public static readonly Syntax alpha = syntax(GreekSym.alpha, "alpha");
        public static readonly Syntax Alpha = syntax(GreekSym.Alpha, "Alpha");
        public static readonly Syntax beta = syntax(GreekSym.beta, "beta");
        public static readonly Syntax Beta = syntax(GreekSym.Beta, "Beta");
        public static readonly Syntax gamma = syntax(GreekSym.gamma, "gamma");
        public static readonly Syntax Gamma = syntax(GreekSym.Gamma, "Gamma");        
        public static readonly Syntax rho = syntax(GreekSym.rho, "rho");        
        public static readonly Syntax Rho = syntax(GreekSym.Rho, "Rho");


        
    }

}