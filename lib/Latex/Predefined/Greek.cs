//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Latex
{
    using Z0;

    using static zcore;
    using static LatexCmd;
    using static Z0.MathSym;

    public static class Greek
    {
                
        public static readonly Syntax alpha = syntax(Greek.alpha, "alpha");
        public static readonly Syntax Alpha = syntax(Greek.Alpha, "Alpha");
        public static readonly Syntax beta = syntax(Greek.beta, "beta");
        public static readonly Syntax Beta = syntax(Greek.Beta, "Beta");
        public static readonly Syntax gamma = syntax(Greek.gamma, "gamma");
        public static readonly Syntax Gamma = syntax(Greek.Gamma, "Gamma");        
        public static readonly Syntax rho = syntax(Greek.rho, "rho");        
        public static readonly Syntax Rho = syntax(Greek.Rho, "Rho");
        public static readonly Syntax sigma = syntax(Greek.sigma, "sigma");
        public static readonly Syntax Sigma = syntax(Greek.Sigma, "Sigma");        


        
    }

}