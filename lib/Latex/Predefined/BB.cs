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



    public static class BB
    {
        public static readonly Syntax Zero = syntax(BB.Zero,"Bbbzero");
        
        public static readonly Syntax One = syntax(BB.One,"Bbbone");
        
        public static readonly Syntax Two = syntax(BB.Two,"Bbbtwo");
        
        public static readonly Syntax Three = syntax(BB.Three,"Bbbthree");
        
        public static readonly Syntax A = syntax(BB.A,"BbbA");
        
        public static readonly Syntax T = syntax(BB.T, "BbbT");
        
        public static readonly Syntax Q = syntax(BB.Q,"BbbQ");
        
        public static readonly Syntax R = syntax(BB.R,"BbbR");            
    }

}