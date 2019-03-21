//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Symbols
{
    using Core;

    using static corefunc;
    using static Latex;

    public static class Common
    {
                
        public static readonly Symbol alpha = symbol("α", cmd("alpha"));
        public static readonly Symbol Alpha = symbol("Α", cmd("Alpha"));
        public static readonly Symbol beta = symbol("β", cmd("beta"));
        public static readonly Symbol Beta = symbol("Β", cmd("Beta"));
        public static readonly Symbol gamma = symbol("γ", cmd("gamma"));
        public static readonly Symbol Gamma = symbol("Γ", cmd("Gamma"));        
        public static readonly Symbol rho = symbol("ρ", cmd("rho"));        
        public static readonly Symbol Rho = symbol("Ρ", cmd("Rho"));

        public static readonly Symbol inf = symbol("∞", "infty");
        public static readonly Symbol otimes = symbol("⊗",cmd("otimes"));        
        public static readonly Symbol oplus = symbol("⊕",cmd("oplus"));
        public static readonly Symbol wedge = symbol("∧",cmd("wedge"));
        public static readonly Symbol vee = symbol("∨",cmd("vee"));
        public static readonly Symbol partial = symbol("∂", cmd("partial"));
        public static readonly Symbol emptyset = symbol("∅", cmd("emptyset"));

        
    }

}