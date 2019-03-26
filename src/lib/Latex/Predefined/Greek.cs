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
                
        public static readonly Syntax alpha = syntax("α", "alpha");
        public static readonly Syntax Alpha = syntax("Α", "Alpha");
        public static readonly Syntax beta = syntax("β", "beta");
        public static readonly Syntax Beta = syntax("Β", "Beta");
        public static readonly Syntax gamma = syntax("γ", "gamma");
        public static readonly Syntax Gamma = syntax("Γ", "Gamma");        
        public static readonly Syntax rho = syntax("ρ", "rho");        
        public static readonly Syntax Rho = syntax("Ρ", "Rho");

        public static readonly Syntax inf = syntax("∞", "infty");
        public static readonly Syntax otimes = syntax("⊗","otimes");        
        public static readonly Syntax oplus = syntax("⊕","oplus");
        public static readonly Syntax wedge = syntax("∧","wedge");
        public static readonly Syntax vee = syntax("∨","vee");
        public static readonly Syntax partial = syntax("∂", "partial");
        public static readonly Syntax emptyset = syntax("∅", "emptyset");

        
    }

}